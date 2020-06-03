using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;
using ReplicacionTPVWeb.CLASES.LOGS;
using System.IO;
using CLSBASE.CRM.RESERVAS;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ReplicacionTPVWeb
{

    public partial class ReplicacionTPVWeb : ServiceBase
    {
        private Thread HiloPrincipal;
        private EstadoHilo _EstadoHiloPrincipal;

        public EstadoHilo EstadoHiloPrincipal
        {
            set
            {
                this.FL.EscribeLinea("[ESTABLECIENTO ESTADO HILO] "+DateTime.Now.ToString("HH:mm:ss:ffff") + value.ToString());
                this._EstadoHiloPrincipal = value;
            }
            get
            {
                return this._EstadoHiloPrincipal;
            }
        }
        private CLASES.LOGS.FileLog FL;
        

        public ReplicacionTPVWeb()
        {

            FL = new CLASES.LOGS.FileLog();
            FL.cab_fichero = "MAIN";
            try
            {
                InitializeComponent();
                HiloPrincipal = new Thread(new ThreadStart(this.BucleDaemon));
                this.EstadoHiloPrincipal = new EstadoHilo();
                IGlobal.ObtenConfiguracion();
                IGlobal.ImprimeConfCargada(this.FL);
            }
            catch (Exception err)
            {
                FL.EscribeLinea("[CONSTRUCTOR] "+DateTime.Now.ToString("HH:mm:ss:fffff")+" > "+err.Message);
            }
        }

        protected override void OnStart(string[] args)
        {
            // TODO: agregar código aquí para iniciar el servicio.
            this.HiloPrincipal.Start();
        }

        protected override void OnPause()
        {
            base.OnPause();
            this.EstadoHiloPrincipal.Accion = ACCION_HILO.PAUSAR;
        }

        protected override void OnContinue()
        {
            base.OnContinue();
            this.EstadoHiloPrincipal.Accion = ACCION_HILO.REANUDAR;
        }
        
        protected override void OnStop()
        {
            this.EstadoHiloPrincipal.Accion = ACCION_HILO.FINALIZAR;
        }

        private void MantenimientoTiel()
        {
            MySqlConnection cnTPV=null;
            MySqlTransaction trTPV=null;
            MySqlConnection cnWEB=null;
            MySqlTransaction trWEB=null;
            Int32 nuevos = 0;
            Int32 actualizados = 0;
            try
            {
                cnTPV = new MySqlConnection(CLSBASE.IGlobal.cad_conexion);
                cnTPV.Open();
                trTPV = cnTPV.BeginTransaction();
                cnWEB = new MySqlConnection(IGlobal.CADENA_CONEX_WEB);
                cnWEB.Open();
                trWEB = cnWEB.BeginTransaction();
                //Obtengo los datos
                string sql = "select * from tiel_tipo_elemento";
                DataTable datosTPV = new DataTable();
                DataTable datosWEB = new DataTable();
                IGlobal.ObtenDatosSQL(sql, ref datosTPV, ref cnTPV, ref trTPV);
                IGlobal.ObtenDatosSQL(sql, ref datosWEB, ref cnWEB, ref trWEB);
                foreach (DataRow drTPV in datosTPV.Rows)
                {
                    DataRow[] drWEB = datosWEB.Select("COD_TIEL='" + drTPV["COD_TIEL"].ToString() + "'");
                    if (drWEB.Length > 0)
                    {
                        if (drWEB[0]["DESCR_TIEL"].ToString() != drTPV["DESCR_TIEL"].ToString())
                        {
                            drWEB[0]["DESCR_TIEL"] = drTPV["DESCR_TIEL"];
                            actualizados++;
                        }
                    }
                    else
                    {
                        DataRow drWEBn = datosWEB.NewRow();
                        drWEBn["COD_TIEL"] = drTPV["COD_TIEL"].ToString();
                        drWEBn["DESCR_TIEL"] = drTPV["DESCR_TIEL"];
                        datosWEB.Rows.Add(drWEBn);
                        nuevos++;
                    }
                }
                //Solo es de sentido web, asi que guardamos solo los datos de la web
                IGlobal.GuardaDatosSql(sql, ref datosWEB, ref cnWEB, ref trWEB);
                this.FL.EscribeLinea("Total actualizados: " + actualizados);
                this.FL.EscribeLinea("Total nuevos: " + nuevos);
                trTPV.Commit();
                this.FL.EscribeLinea("Conexión TPV Commit Si");
                trWEB.Commit();
                this.FL.EscribeLinea("Conexión WEB Commit Si");
            }
            catch (Exception err)
            {
                this.FL.EscribeLinea("[ERROR ACT TIEL] " + DateTime.Now.ToString("HH:mm:ss:fffff") + " " + err.Message);                
                try
                {
                    if (trTPV != null)
                    {
                        trTPV.Rollback();
                        this.FL.EscribeLinea("Conexión TPV Rollback Si");
                    }
                }
                catch (Exception err2)
                {
                    this.FL.EscribeLinea("Conexión TPV Rollback No: "+err2.Message);
                }
                try
                {
                    if (trWEB != null)
                    {
                        trWEB.Rollback();
                        this.FL.EscribeLinea("Conexión WEB Rollback Si");
                    }
                }
                catch (Exception err2)
                {
                    this.FL.EscribeLinea("Conexión WEB Rollback No: "+err2.Message);
                }

            }
            finally
            {
                if (cnTPV != null)
                {
                    cnTPV.Close();
                    cnTPV.Dispose();
                    cnTPV = null;
                }
                if (cnWEB != null)
                {
                    cnWEB.Close();
                    cnWEB.Dispose();
                    cnWEB = null;
                }
                GC.Collect();
            }
        }

        private void MantenimientoEsre()
        {
            MySqlConnection cnTPV = null;
            MySqlTransaction trTPV = null;
            MySqlConnection cnWEB = null;
            MySqlTransaction trWEB = null;
            Int32 nuevos = 0;
            Int32 actualizados = 0;
            try
            {
                cnTPV = new MySqlConnection(CLSBASE.IGlobal.cad_conexion);
                cnTPV.Open();
                trTPV = cnTPV.BeginTransaction();
                cnWEB = new MySqlConnection(IGlobal.CADENA_CONEX_WEB);
                cnWEB.Open();
                trWEB = cnWEB.BeginTransaction();
                //Obtengo los datos
                string sql = "select * from esre_estado_reservas";
                DataTable datosTPV = new DataTable();
                DataTable datosWEB = new DataTable();
                IGlobal.ObtenDatosSQL(sql, ref datosTPV, ref cnTPV, ref trTPV);
                IGlobal.ObtenDatosSQL(sql, ref datosWEB, ref cnWEB, ref trWEB);
                foreach (DataRow drTPV in datosTPV.Rows)
                {
                    DataRow[] drWEB = datosWEB.Select("COD_ESRE='" + drTPV["COD_ESRE"].ToString() + "'");
                    if (drWEB.Length > 0)
                    {
                        if (drWEB[0]["DESCR_ESRE"].ToString() != drTPV["DESCR_ESRE"].ToString())
                        {
                            drWEB[0]["DESCR_ESRE"] = drTPV["DESCR_ESRE"];
                            actualizados++;
                        }
                    }
                    else
                    {
                        DataRow drWEBn = datosWEB.NewRow();
                        drWEBn["COD_ESRE"] = drTPV["COD_ESRE"].ToString();
                        drWEBn["DESCR_ESRE"] = drTPV["DESCR_ESRE"];
                        datosWEB.Rows.Add(drWEBn);
                        nuevos++;
                    }
                }
                //Solo es de sentido web, asi que guardamos solo los datos de la web
                IGlobal.GuardaDatosSql(sql, ref datosWEB, ref cnWEB, ref trWEB);
                this.FL.EscribeLinea("Total actualizados: " + actualizados);
                this.FL.EscribeLinea("Total nuevos: " + nuevos);
                trTPV.Commit();
                this.FL.EscribeLinea("Conexión TPV Commit Si");
                trWEB.Commit();
                this.FL.EscribeLinea("Conexión WEB Commit Si");
            }
            catch (Exception err)
            {
                this.FL.EscribeLinea("[ERROR ACT ESRE] " + DateTime.Now.ToString("HH:mm:ss:fffff") + " " + err.Message);
                try
                {
                    if (trTPV != null)
                    {
                        trTPV.Rollback();
                        this.FL.EscribeLinea("Conexión TPV Rollback Si");
                    }
                }
                catch (Exception err2)
                {
                    this.FL.EscribeLinea("Conexión TPV Rollback No: " + err2.Message);
                }
                try
                {
                    if (trWEB != null)
                    {
                        trWEB.Rollback();
                        this.FL.EscribeLinea("Conexión WEB Rollback Si");
                    }
                }
                catch (Exception err2)
                {
                    this.FL.EscribeLinea("Conexión WEB Rollback No: " + err2.Message);
                }

            }
            finally
            {
                if (cnTPV != null)
                {
                    cnTPV.Close();
                    cnTPV.Dispose();
                    cnTPV = null;
                }
                if (cnWEB != null)
                {
                    cnWEB.Close();
                    cnWEB.Dispose();
                    cnWEB = null;
                }
                GC.Collect();
            }
        }

        private void MantenimientoFamilias()
        {
            MySqlConnection cnTPV = null;
            MySqlTransaction trTPV = null;
            MySqlConnection cnWEB = null;
            MySqlTransaction trWEB = null;
            Int32 nuevos = 0;
            Int32 actualizados = 0;
            try
            {
                cnTPV = new MySqlConnection(CLSBASE.IGlobal.cad_conexion);
                cnTPV.Open();
                trTPV = cnTPV.BeginTransaction();
                cnWEB = new MySqlConnection(IGlobal.CADENA_CONEX_WEB);
                cnWEB.Open();
                trWEB = cnWEB.BeginTransaction();
                //Obtengo los datos
                string sql = "select * from fami_familias";
                DataTable datosTPV = new DataTable();
                DataTable datosWEB = new DataTable();
                IGlobal.ObtenDatosSQL(sql, ref datosTPV, ref cnTPV, ref trTPV);
                IGlobal.ObtenDatosSQL(sql, ref datosWEB, ref cnWEB, ref trWEB);
                foreach (DataRow drTPV in datosTPV.Rows)
                {
                    DataRow[] drWEB = datosWEB.Select("COD_FAMI='" + drTPV["COD_FAMI"].ToString() + "'");
                    if (drWEB.Length > 0)
                    {
                        if (drWEB[0]["NOMBRE_FAMI"].ToString() != drTPV["NOMBRE_FAMI"].ToString())
                        {
                            drWEB[0]["NOMBRE_FAMI"] = drTPV["NOMBRE_FAMI"];
                            actualizados++;
                        }
                    }
                    else
                    {
                        DataRow drWEBn = datosWEB.NewRow();
                        drWEBn["COD_FAMI"] = drTPV["COD_FAMI"].ToString();
                        drWEBn["NOMBRE_FAMI"] = drTPV["NOMBRE_FAMI"];
                        datosWEB.Rows.Add(drWEBn);
                        nuevos++;
                    }
                }
                //Solo es de sentido web, asi que guardamos solo los datos de la web
                IGlobal.GuardaDatosSql(sql, ref datosWEB, ref cnWEB, ref trWEB);
                this.FL.EscribeLinea("Total actualizados: " + actualizados);
                this.FL.EscribeLinea("Total nuevos: " + nuevos);
                trTPV.Commit();
                this.FL.EscribeLinea("Conexión TPV Commit Si");
                trWEB.Commit();
                this.FL.EscribeLinea("Conexión WEB Commit Si");
            }
            catch (Exception err)
            {
                this.FL.EscribeLinea("[ERROR ACT FAMI] " + DateTime.Now.ToString("HH:mm:ss:fffff") + " " + err.Message);
                this.FL.EscribeLinea(err.StackTrace);
                try
                {
                    if (trTPV != null)
                    {
                        trTPV.Rollback();
                        this.FL.EscribeLinea("Conexión TPV Rollback Si");
                    }
                }
                catch (Exception err2)
                {
                    this.FL.EscribeLinea("Conexión TPV Rollback No: " + err2.Message);
                }
                try
                {
                    if (trWEB != null)
                    {
                        trWEB.Rollback();
                        this.FL.EscribeLinea("Conexión WEB Rollback Si");
                    }
                }
                catch (Exception err2)
                {
                    this.FL.EscribeLinea("Conexión WEB Rollback No: " + err2.Message);
                }

            }
            finally
            {
                if (cnTPV != null)
                {
                    cnTPV.Close();
                    cnTPV.Dispose();
                    cnTPV = null;
                }
                if (cnWEB != null)
                {
                    cnWEB.Close();
                    cnWEB.Dispose();
                    cnWEB = null;
                }
                GC.Collect();
            }
        }

        private void MantenimientoSubFamilias()
        {
            MySqlConnection cnTPV = null;
            MySqlTransaction trTPV = null;
            MySqlConnection cnWEB = null;
            MySqlTransaction trWEB = null;
            Int32 nuevos = 0;
            Int32 actualizados = 0;
            try
            {
                cnTPV = new MySqlConnection(CLSBASE.IGlobal.cad_conexion);
                cnTPV.Open();
                trTPV = cnTPV.BeginTransaction();
                cnWEB = new MySqlConnection(IGlobal.CADENA_CONEX_WEB);
                cnWEB.Open();
                trWEB = cnWEB.BeginTransaction();
                //Obtengo los datos
                string sql = "select * from sufa_sub_familias";
                DataTable datosTPV = new DataTable();
                DataTable datosWEB = new DataTable();
                IGlobal.ObtenDatosSQL(sql, ref datosTPV, ref cnTPV, ref trTPV);
                IGlobal.ObtenDatosSQL(sql, ref datosWEB, ref cnWEB, ref trWEB);
                foreach (DataRow drTPV in datosTPV.Rows)
                {
                    DataRow[] drWEB = datosWEB.Select("COD_FAMI='" + drTPV["COD_FAMI"].ToString() + "' and COD_SUFA='"+drTPV["COD_SUFA"].ToString()+"'");
                    if (drWEB.Length > 0)
                    {
                        if (drWEB[0]["NOMBRE_SUFA"].ToString() != drTPV["NOMBRE_SUFA"].ToString())
                        {
                            drWEB[0]["NOMBRE_SUFA"] = drTPV["NOMBRE_SUFA"];
                            actualizados++;
                        }
                    }
                    else
                    {
                        DataRow drWEBn = datosWEB.NewRow();
                        drWEBn["COD_FAMI"] = drTPV["COD_FAMI"].ToString();
                        drWEBn["COD_SUFA"] = drTPV["COD_SUFA"].ToString();
                        drWEBn["NOMBRE_SUFA"] = drTPV["NOMBRE_SUFA"];
                        datosWEB.Rows.Add(drWEBn);
                        nuevos++;
                    }
                }
                //Solo es de sentido web, asi que guardamos solo los datos de la web
                IGlobal.GuardaDatosSql(sql, ref datosWEB, ref cnWEB, ref trWEB);
                this.FL.EscribeLinea("Total actualizados: " + actualizados);
                this.FL.EscribeLinea("Total nuevos: " + nuevos);
                trTPV.Commit();
                this.FL.EscribeLinea("Conexión TPV Commit Si");
                trWEB.Commit();
                this.FL.EscribeLinea("Conexión WEB Commit Si");
            }
            catch (Exception err)
            {
                this.FL.EscribeLinea("[ERROR ACT SUFA] " + DateTime.Now.ToString("HH:mm:ss:fffff") + " " + err.Message);
                this.FL.EscribeLinea(err.StackTrace);
                try
                {
                    if (trTPV != null)
                    {
                        trTPV.Rollback();
                        this.FL.EscribeLinea("Conexión TPV Rollback Si");
                    }
                }
                catch (Exception err2)
                {
                    this.FL.EscribeLinea("Conexión TPV Rollback No: " + err2.Message);
                }
                try
                {
                    if (trWEB != null)
                    {
                        trWEB.Rollback();
                        this.FL.EscribeLinea("Conexión WEB Rollback Si");
                    }
                }
                catch (Exception err2)
                {
                    this.FL.EscribeLinea("Conexión WEB Rollback No: " + err2.Message);
                }

            }
            finally
            {
                if (cnTPV != null)
                {
                    cnTPV.Close();
                    cnTPV.Dispose();
                    cnTPV = null;
                }
                if (cnWEB != null)
                {
                    cnWEB.Close();
                    cnWEB.Dispose();
                    cnWEB = null;
                }
                GC.Collect();
            }
        }

        private DataTable CreaHashImagenes()
        {
            DataTable tabla = new DataTable("hashimag");
            tabla.Columns.Add(new DataColumn("FICHERO", System.Type.GetType("System.String")));
            tabla.Columns.Add(new DataColumn("INTENTOS", System.Type.GetType("System.Int32")));
            tabla.Columns.Add(new DataColumn("ERROR", System.Type.GetType("System.String")));
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\hashimag.xml"))
            {
                try
                {
                    this.FL.EscribeLinea("Cargando hash con imagenes erroneneas");
                    DataTable auxt = new DataTable();
                    auxt.ReadXml(AppDomain.CurrentDomain.BaseDirectory+ @"\hashimag.xml");
                    foreach (DataRow dr in auxt.Rows)
                    {
                        DataRow nreg = tabla.NewRow();
                        nreg["FICHERO"] = dr["FICHERO"].ToString();
                        nreg["INTENTOS"] = 0;
                        nreg["ERROR"] = "";
                        tabla.Rows.Add(nreg);
                    }
                    this.FL.EscribeLinea("Nº de imagenes " + tabla.Rows.Count.ToString());
                }
                catch (Exception err)
                {
                    this.FL.EscribeLinea("Imposible cargar el fichero de imagenes erronesas, causa: " + err.Message);
                }
            }
            else
            {
                this.FL.EscribeLinea("No hay fichero de imagenes erroneas");
            }
            return tabla;
        }

        private void MantenimientoClientes()
        {
            MySqlConnection cnTPV = null;
            MySqlTransaction trTPV = null;
            MySqlConnection cnWEB = null;
            MySqlTransaction trWEB = null;
            Int32 nuevos = 0;
            Int32 actualizados = 0;
            try
            {
                cnTPV = new MySqlConnection(CLSBASE.IGlobal.cad_conexion);
                cnTPV.Open();
                trTPV = cnTPV.BeginTransaction();
                cnWEB = new MySqlConnection(IGlobal.CADENA_CONEX_WEB);
                cnWEB.Open();
                trWEB = cnWEB.BeginTransaction();
                //Obtengo los datos
                string sql = "select * from pers_personas";
                DataTable datosTPV = new DataTable();
                DataTable datosWEB = new DataTable();
                IGlobal.ObtenDatosSQL(sql, ref datosTPV, ref cnTPV, ref trTPV);
                IGlobal.ObtenDatosSQL(sql, ref datosWEB, ref cnWEB, ref trWEB);
                foreach (DataRow drWEB in datosWEB.Rows)
                {
                    DataRow[] drTPV = datosTPV.Select("ID_ELEM='" + drWEB["ID_ELEM"].ToString() + "'");
                    if (drTPV.Length > 0)
                    {
                        if (drTPV[0]["NIF_PERS"].ToString() != drWEB["NIF_PERS"].ToString() ||
                            drTPV[0]["NOMBRE_PERS"].ToString() != drWEB["NOMBRE_PERS"].ToString() ||
                            drTPV[0]["DIRE_PERS"].ToString() != drWEB["DIRE_PERS"].ToString() ||
                            drTPV[0]["CODPOSTAL_PERS"].ToString() != drWEB["CODPOSTAL_PERS"].ToString() ||
                            drTPV[0]["POBLACION_PERS"].ToString() != drWEB["POBLACION_PERS"].ToString() ||
                            drTPV[0]["PROVINCIA_PERS"].ToString() != drWEB["PROVINCIA_PERS"].ToString() ||
                            drTPV[0]["EMAIL_PERS"].ToString() != drWEB["EMAIL_PERS"].ToString()
                            )
                        {
                            drTPV[0]["NIF_PERS"] = drWEB["NIF_PERS"].ToString();
                            drTPV[0]["NOMBRE_PERS"]= drWEB["NOMBRE_PERS"].ToString();
                            drTPV[0]["DIRE_PERS"]= drWEB["DIRE_PERS"].ToString();
                            drTPV[0]["CODPOSTAL_PERS"]= drWEB["CODPOSTAL_PERS"].ToString();
                            drTPV[0]["POBLACION_PERS"]= drWEB["POBLACION_PERS"].ToString();
                            drTPV[0]["PROVINCIA_PERS"]= drWEB["PROVINCIA_PERS"].ToString();
                            drTPV[0]["EMAIL_PERS"] = drWEB["EMAIL_PERS"].ToString();
                            actualizados++;
                        }
                    }
                    else
                    {
                        IGlobal.EjecutaSql("insert into elem_elementos (ID_ELEMENTO, COD_TIEL) values ("+drWEB["ID_ELEM"].ToString()+",'PER')",ref cnTPV, ref trTPV);
                        DataRow drTPVn = datosTPV.NewRow();
                        drTPVn["ID_ELEM"] = drWEB["ID_ELEM"].ToString();
                        drTPVn["NIF_PERS"] = drWEB["NIF_PERS"].ToString();
                        drTPVn["NOMBRE_PERS"] = drWEB["NOMBRE_PERS"].ToString();
                        drTPVn["DIRE_PERS"] = drWEB["DIRE_PERS"].ToString();
                        drTPVn["CODPOSTAL_PERS"] = drWEB["CODPOSTAL_PERS"].ToString();
                        drTPVn["POBLACION_PERS"] = drWEB["POBLACION_PERS"].ToString();
                        drTPVn["PROVINCIA_PERS"] = drWEB["PROVINCIA_PERS"].ToString();
                        drTPVn["EMAIL_PERS"] = drWEB["EMAIL_PERS"].ToString();
                        datosTPV.Rows.Add(drTPVn);
                        nuevos++;
                    }
                }
                //Solo es de sentido web, asi que guardamos solo los datos de la web
                IGlobal.GuardaDatosSql(sql, ref datosTPV, ref cnTPV, ref trTPV);
                this.FL.EscribeLinea("Total actualizados: " + actualizados);
                this.FL.EscribeLinea("Total nuevos: " + nuevos);
                trTPV.Commit();
                this.FL.EscribeLinea("Conexión TPV Commit Si");
                trWEB.Commit();
                this.FL.EscribeLinea("Conexión WEB Commit Si");
            }
            catch (Exception err)
            {
                this.FL.EscribeLinea("[ERROR ACT CLIENTES] " + DateTime.Now.ToString("HH:mm:ss:fffff") + " " + err.Message);
                this.FL.EscribeLinea(err.StackTrace);
                try
                {
                    if (trTPV != null)
                    {
                        trTPV.Rollback();
                        this.FL.EscribeLinea("Conexión TPV Rollback Si");
                    }
                }
                catch (Exception err2)
                {
                    this.FL.EscribeLinea("Conexión TPV Rollback No: " + err2.Message);
                }
                try
                {
                    if (trWEB != null)
                    {
                        trWEB.Rollback();
                        this.FL.EscribeLinea("Conexión WEB Rollback Si");
                    }
                }
                catch (Exception err2)
                {
                    this.FL.EscribeLinea("Conexión WEB Rollback No: " + err2.Message);
                }

            }
            finally
            {
                if (cnTPV != null)
                {
                    cnTPV.Close();
                    cnTPV.Dispose();
                    cnTPV = null;
                }
                if (cnWEB != null)
                {
                    cnWEB.Close();
                    cnWEB.Dispose();
                    cnWEB = null;
                }
                GC.Collect();
            }
        }

        private void AltaTPVLinReservas(Int64 idelem, ref MySqlConnection cnTPV, ref MySqlConnection cnWEB, ref MySqlTransaction trTPV, ref MySqlTransaction trWEB)
        {
            string sql = "select * from lire_lin_reservas where ID_ELEM_CARE="+idelem.ToString();
            DataTable datosTPV = new DataTable();
            DataTable datosWEB = new DataTable();
            IGlobal.ObtenDatosSQL(sql, ref datosTPV, ref cnTPV, ref trTPV);
            IGlobal.ObtenDatosSQL(sql, ref datosWEB, ref cnWEB, ref trWEB);
            foreach (DataRow drWeb in datosWEB.Rows)
            {
                IGlobal.EjecutaSql("insert into elem_elementos (ID_ELEMENTO, COD_TIEL) values (" + drWeb["ID_ELEM"].ToString() + ",'LRS')", ref cnTPV, ref trTPV);
                DataRow drTPVn = datosTPV.NewRow();
                drTPVn["ID_ELEM"]=drWeb["ID_ELEM"];
                drTPVn["ID_ELEM_CARE"] = drWeb["ID_ELEM_CARE"];
                drTPVn["ID_ELEM_PROD"] = drWeb["ID_ELEM_PROD"];
                drTPVn["DESCRIPCION_PROD"] = drWeb["DESCRIPCION_PROD"];
                drTPVn["CANTIDAD_PROD"] = drWeb["CANTIDAD_PROD"];
                drTPVn["PVB_LIRE"] = drWeb["PVB_LIRE"];
                drTPVn["PORC_IVA_LIRE"] = drWeb["PORC_IVA_LIRE"];
                drTPVn["PVP_LIRE"] = drWeb["PVP_LIRE"];
                drTPVn["TOTAL_LIRE"] = drWeb["TOTAL_LIRE"];
                datosTPV.Rows.Add(drTPVn);
            }
            IGlobal.GuardaDatosSql("select * from lire_lin_reservas", ref datosTPV, ref cnTPV, ref trTPV);
        }

        private void AltaTPVReservas()
        {
            MySqlConnection cnTPV = null;
            MySqlTransaction trTPV = null;
            MySqlConnection cnWEB = null;
            MySqlTransaction trWEB = null;
            Int32 nuevos = 0;
            Int32 actualizados = 0;
            ArrayList idcade = new ArrayList();
            try
            {
                cnTPV = new MySqlConnection(CLSBASE.IGlobal.cad_conexion);
                cnTPV.Open();
                trTPV = cnTPV.BeginTransaction();
                cnWEB = new MySqlConnection(IGlobal.CADENA_CONEX_WEB);
                cnWEB.Open();
                trWEB = cnWEB.BeginTransaction();
                //Obtengo los datos
                string sql = "select * from care_cab_reservas";
                DataTable datosTPV = new DataTable();
                DataTable datosWEB = new DataTable();
                IGlobal.ObtenDatosSQL(sql, ref datosTPV, ref cnTPV, ref trTPV);
                IGlobal.ObtenDatosSQL(sql, ref datosWEB, ref cnWEB, ref trWEB);
                foreach (DataRow drWEB in datosWEB.Rows)
                {
                    DataRow[] drTPV = datosTPV.Select("ID_ELEM='" + drWEB["ID_ELEM"].ToString() + "'");
                    if (drTPV.Length > 0)
                    {
                           if(drWEB["COD_ESRE"].ToString()!=drTPV[0]["COD_ESRE"].ToString()) {
                                drWEB["COD_ESRE"]=drTPV[0]["COD_ESRE"].ToString();
                                drWEB["FECHA_ESRE"]=(DateTime)drTPV[0]["FECHA_ESRE"];
                                drWEB["NUMERO_CADO"] = drTPV[0]["NUMERO_CADO"].ToString();
                                actualizados++;
                           }
                    }
                    else
                    {
                        IGlobal.EjecutaSql("insert into elem_elementos (ID_ELEMENTO, COD_TIEL) values (" + drWEB["ID_ELEM"].ToString() + ",'RES')", ref cnTPV, ref trTPV);
                        DataRow drTPVn = datosTPV.NewRow();
                        drTPVn["ID_ELEM"] = (Int64)drWEB["ID_ELEM"];
                        drTPVn["ID_ELEM_PERS"] = (Int64)drWEB["ID_ELEM_PERS"];
                        drTPVn["COD_ESRE"] = drWEB["COD_ESRE"].ToString();
                        drTPVn["FECHA_GRABACION_CARE"] =DateTime.Now;
                        drTPVn["FECHA_ESRE"] = DateTime.Now;
                        datosTPV.Rows.Add(drTPVn);
                        idcade.Add((Int64)drWEB["ID_ELEM"]);                        
                        nuevos++;
                    }
                } 
                //Solo es de sentido web, asi que guardamos solo los datos de la web
                IGlobal.GuardaDatosSql(sql, ref datosTPV, ref cnTPV, ref trTPV);
                IGlobal.GuardaDatosSql(sql, ref datosWEB, ref cnWEB, ref trWEB);
                //Guardo las lineas
                foreach (Int64 idcab in idcade)
                {
                    this.AltaTPVLinReservas(idcab, ref cnTPV, ref cnWEB, ref trTPV, ref trWEB);
                }
                this.FL.EscribeLinea("Total actualizados: " + actualizados);
                this.FL.EscribeLinea("Total nuevos: " + nuevos);
                trTPV.Commit();
                this.FL.EscribeLinea("Conexión TPV Commit Si");
                trWEB.Commit();
                this.FL.EscribeLinea("Conexión WEB Commit Si");
            }
            catch (Exception err)
            {
                this.FL.EscribeLinea("[ERROR SINCRONIZACION RESERVAS] " + DateTime.Now.ToString("HH:mm:ss:fffff") + " " + err.Message);
                this.FL.EscribeLinea(err.StackTrace);
                try
                {
                    if (trTPV != null)
                    {
                        trTPV.Rollback();
                        this.FL.EscribeLinea("Conexión TPV Rollback Si");
                    }
                }
                catch (Exception err2)
                {
                    this.FL.EscribeLinea("Conexión TPV Rollback No: " + err2.Message);
                }
                try
                {
                    if (trWEB != null)
                    {
                        trWEB.Rollback();
                        this.FL.EscribeLinea("Conexión WEB Rollback Si");
                    }
                }
                catch (Exception err2)
                {
                    this.FL.EscribeLinea("Conexión WEB Rollback No: " + err2.Message);
                }

            }
            finally
            {
                if (cnTPV != null)
                {
                    cnTPV.Close();
                    cnTPV.Dispose();
                    cnTPV = null;
                }
                if (cnWEB != null)
                {
                    cnWEB.Close();
                    cnWEB.Dispose();
                    cnWEB = null;
                }
                GC.Collect();
            }
        }

      /*  private void ActualizaWEBReservas()
        {
            MySqlConnection cnTPV = null;
            MySqlTransaction trTPV = null;
            MySqlConnection cnWEB = null;
            MySqlTransaction trWEB = null;
            Int32 actualizados = 0;
            try
            {
                cnTPV = new MySqlConnection(CLSBASE.IGlobal.cad_conexion);
                cnTPV.Open();
                trTPV = cnTPV.BeginTransaction();
                cnWEB = new MySqlConnection(IGlobal.CADENA_CONEX_WEB);
                cnWEB.Open();
                trWEB = cnWEB.BeginTransaction();
                //Obtengo los datos
                string sql = "select * from care_cab_reservas";
                DataTable datosTPV = new DataTable();
                DataTable datosWEB = new DataTable();
                IGlobal.ObtenDatosSQL(sql, ref datosTPV, ref cnTPV, ref trTPV);
                IGlobal.ObtenDatosSQL(sql+" where COD_ESRE not in ('EFC','FAC') ", ref datosWEB, ref cnWEB, ref trWEB);
                foreach (DataRow drTPV in datosTPV.Rows)
                {
                    DataRow[] drWEB = datosWEB.Select("ID_ELEM_CARE_TPV=" + drTPV["ID_ELEM"].ToString());
                    if (drWEB.Length > 0)
                    {
                        if (drWEB[0]["COD_ESRE"].ToString() != drTPV["COD_ESRE"].ToString())
                        {
                            drWEB[0]["COD_ESRE"] = drTPV["COD_ESRE"];
                            drWEB[0]["FECHA_ESRE"] = drTPV["FECHA_ESRE"];
                            if (drTPV["NUMERO_CADO"].ToString() != drWEB[0]["NUMERO_CADO"].ToString())
                            {
                                drWEB[0]["NUMERO_CADO"] = drTPV["NUMERO_CADO"];
                            }
                            actualizados++;
                        }
                    }
                }
                //Solo es de sentido web, asi que guardamos solo los datos de la web
                IGlobal.GuardaDatosSql(sql, ref datosWEB, ref cnWEB, ref trWEB);
                this.FL.EscribeLinea("Total actualizados: " + actualizados);
                trTPV.Commit();
                this.FL.EscribeLinea("Conexión TPV Commit Si");
                trWEB.Commit();
                this.FL.EscribeLinea("Conexión WEB Commit Si");
            }
            catch (Exception err)
            {
                this.FL.EscribeLinea("[ERROR ACT CARE] " + DateTime.Now.ToString("HH:mm:ss:fffff") + " " + err.Message+" ST "+err.StackTrace);
                this.FL.EscribeLinea(err.StackTrace);
                try
                {
                    if (trTPV != null)
                    {
                        trTPV.Rollback();
                        this.FL.EscribeLinea("Conexión TPV Rollback Si");
                    }
                }
                catch (Exception err2)
                {
                    this.FL.EscribeLinea("Conexión TPV Rollback No: " + err2.Message);
                }
                try
                {
                    if (trWEB != null)
                    {
                        trWEB.Rollback();
                        this.FL.EscribeLinea("Conexión WEB Rollback Si");
                    }
                }
                catch (Exception err2)
                {
                    this.FL.EscribeLinea("Conexión WEB Rollback No: " + err2.Message);
                }

            }
            finally
            {
                if (cnTPV != null)
                {
                    cnTPV.Close();
                    cnTPV.Dispose();
                    cnTPV = null;
                }
                if (cnWEB != null)
                {
                    cnWEB.Close();
                    cnWEB.Dispose();
                    cnWEB = null;
                }
                GC.Collect();
            }
        }
        */
        private void MantenimientoProductos(ref DataTable imagenes)
        {
            MySqlConnection cnWEB = null;
            MySqlTransaction trWEB = null;
            Int32 nuevos = 0;
            Int32 actualizados = 0;
            try
            {
                CLSBASE.CRM.PRODUCTOS.Productos datosTPV = CLSBASE.CRM.PRODUCTOS.Productos.ObtenInstancia();
                cnWEB = new MySqlConnection(IGlobal.CADENA_CONEX_WEB);
                cnWEB.Open();
                trWEB = cnWEB.BeginTransaction();
                //Obtengo los datos
                string sql = "select * from prod_productos";
                DataTable datosWEB = new DataTable();
                IGlobal.ObtenDatosSQL(sql, ref datosWEB, ref cnWEB, ref trWEB);
                foreach (DataRow drTPV in datosTPV.Datos.Rows)
                {
                    DataRow[] drWEB = datosWEB.Select("ID_ELEM=" + drTPV["ID_ELEM"].ToString());
                    long codigo = 0;
                    long.TryParse(drTPV["ID_ELEM"].ToString(), out codigo);
                    CLSBASE.CRM.PRODUCTOS.Producto prod = datosTPV.Buscar(codigo);
                    if (prod != null)
                    {
                        if (drWEB.Length > 0)
                        {
                            if (drWEB[0]["IMAGEN_PROD"].ToString() != drTPV["IMAGEN_PROD"].ToString())
                            {
                                drWEB[0]["IMAGEN_PROD"] = drTPV["IMAGEN_PROD"].ToString();
                                if (imagenes.Select("FICHERO='" + drWEB[0]["IMAGEN_PROD"].ToString() + "'").Length <= 0)
                                {
                                    DataRow drHashImag = imagenes.NewRow();
                                    drHashImag["FICHERO"] = drTPV["IMAGEN_PROD"].ToString();
                                    drHashImag["INTENTOS"] = 0;
                                    drHashImag["ERROR"] = "";
                                    imagenes.Rows.Add(drHashImag);
                                }
                            }
                            drWEB[0]["COD_FAMI"] = drTPV["COD_FAMI"].ToString();
                            drWEB[0]["COD_SUFA"] = drTPV["COD_SUFA"].ToString();
                            drWEB[0]["NOMBRE_PROD"] = drTPV["NOMBRE_PROD"].ToString();
                            drWEB[0]["PRECIO_BRUTO_PROD"] = (double)prod.precio["PRECIO_BRUTO"];
                            drWEB[0]["PORC_IVA"] = (double)prod.precio["PORC_IVA"];
                            drWEB[0]["PRECIO_VENTA_PROD"] = (double)prod.precio["PRECIO_VENTA"];
                            drWEB[0]["DESCRIPCION_PROD"] = prod.datos["DESCRIPCION_PROD"].ToString();
                            actualizados++;
                       
                        }
                        else
                        {
                            DataRow drWEBn = datosWEB.NewRow();
                            MySqlCommand cm = new MySqlCommand("insert into elem_elementos (ID_ELEM) values (" + drTPV["ID_ELEM"].ToString() + ")", cnWEB, trWEB);
                            cm.ExecuteNonQuery();
                            //Siempre agregamos el hash (mientras que no sea nulo
                            if (drTPV["IMAGEN_PROD"].ToString() != "" && imagenes.Select("FICHERO='"+drTPV["IMAGEN_PROD"].ToString()+"'").Length<=0)
                            {
                                DataRow drHashImag = imagenes.NewRow();
                                drHashImag["FICHERO"] = drTPV["IMAGEN_PROD"].ToString();
                                drHashImag["INTENTOS"] = 0;
                                drHashImag["ERROR"] = "";
                                imagenes.Rows.Add(drHashImag);
                            }

                            drWEBn["ID_ELEM"] = drTPV["ID_ELEM"];
                            drWEBn["COD_FAMI"] = drTPV["COD_FAMI"].ToString();
                            drWEBn["COD_SUFA"] = drTPV["COD_SUFA"].ToString();
                            drWEBn["NOMBRE_PROD"] = drTPV["NOMBRE_PROD"].ToString();
                            drWEBn["IMAGEN_PROD"] = drTPV["IMAGEN_PROD"].ToString();
                            drWEBn["PRECIO_BRUTO_PROD"] = (double)prod.precio["PRECIO_BRUTO"];
                            drWEBn["PORC_IVA"] = (double)prod.precio["PORC_IVA"];
                            drWEBn["PRECIO_VENTA_PROD"] = (double)prod.precio["PRECIO_VENTA"];
                            drWEBn["DESCRIPCION_PROD"] = prod.datos["DESCRIPCION_PROD"].ToString();
                            datosWEB.Rows.Add(drWEBn);
                            nuevos++;
                        }
                    }
                }
                //Solo es de sentido web, asi que guardamos solo los datos de la web
                IGlobal.GuardaDatosSql(sql, ref datosWEB, ref cnWEB, ref trWEB);
                this.FL.EscribeLinea("Total actualizados: " + actualizados);
                this.FL.EscribeLinea("Total nuevos: " + nuevos);
                trWEB.Commit();
                this.FL.EscribeLinea("Conexión WEB Commit Si");
            }
            catch (Exception err)
            {
                this.FL.EscribeLinea("[ERROR ACT PROD] " + DateTime.Now.ToString("HH:mm:ss:fffff") + " " + err.Message);
                this.FL.EscribeLinea(err.StackTrace);
                try
                {
                    if (trWEB != null)
                    {
                        trWEB.Rollback();
                        this.FL.EscribeLinea("Conexión WEB Rollback Si");
                    }
                }
                catch (Exception err2)
                {
                    this.FL.EscribeLinea("Conexión WEB Rollback No: " + err2.Message);
                }

            }
            finally
            {
                if (cnWEB != null)
                {
                    cnWEB.Close();
                    cnWEB.Dispose();
                    cnWEB = null;
                }
                GC.Collect();
            }
        }

        private string ImagenesReducc(string ruta)
        {
            string rutaTemp="";
            try {
                rutaTemp=IGlobal.RUTA_IMAGENES_TPV + @"\TMPIMG";
                if (!Directory.Exists(rutaTemp))
                {
                    Directory.CreateDirectory(rutaTemp);
                }
                //Cargo la imagen
                string ImgTmp=ruta.Replace(IGlobal.RUTA_IMAGENES_TPV+@"\","").Trim(new char[] {' ','\\'});
                Image imgOrig=Image.FromFile(ruta);
                Int32 imgX=imgOrig.Size.Width;
                Int32 imgY=imgOrig.Size.Height;
                if (!(imgX <= IGlobal.ResImgX || imgY < IGlobal.ResImgY))
                {
                    bool apaisada = (imgY <= imgX ? true : false);
                    float relXY = (float)imgX / imgY;
                    float nimgX = 0;
                    float nimgY = 0;
                    if (apaisada)
                    {
                        //Si esta apaisada, nos fijamos en el ancho
                        nimgX = IGlobal.ResImgX;
                        nimgY = nimgX * (1 / (relXY));
                    }
                    else
                    {
                        //si no esta apaisada, nos fijamos en el alto
                        nimgY = IGlobal.ResImgY;
                        nimgX = nimgY * relXY;
                    }
                    Bitmap b = new Bitmap(Convert.ToInt16(nimgX), Convert.ToInt16(nimgY));
                    Graphics g = Graphics.FromImage(b);
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.DrawImage(imgOrig, new Rectangle(0, 0,Convert.ToInt16(nimgX), Convert.ToInt16(nimgY)), new Rectangle(0, 0, imgOrig.Width, imgOrig.Height), GraphicsUnit.Pixel);
                    b.Save(rutaTemp + @"\" + ImgTmp);
                    g.Dispose();
                    b.Dispose();
                    rutaTemp = rutaTemp + @"\" + ImgTmp;
                }
                else
                {
                    rutaTemp = ruta;
                }
            } catch (Exception err) {
                this.FL.EscribeLinea("Imagen ["+ruta+"] no convertida, causa: "+err.Message);
                rutaTemp= ruta;
            } finally {
                GC.Collect();
            }
            return rutaTemp;
        }

        private void MantenimientoImagenes(ref DataTable imagenes)
        {
            FileLog FLFtp = new FileLog();
            FLFtp.cab_fichero = "FTP" + DateTime.Now.ToString("HHmmss");
            this.FL.EscribeLinea("[MANTENIMIENTO DE IMAGENES] Creado fichero log " + FLFtp.cab_fichero);
            DataRow[] ipendientes = imagenes.Select("INTENTOS<=" + IGlobal.NUM_INTENTOS_FTP.ToString());
            Int32 bucles = 0;
            while (bucles <= IGlobal.NUM_INTENTOS_FTP && ipendientes.Length > 0)
            {
                for(Int32 j=0;j<ipendientes.Length;j++) {
                    FtpLibrary.ClienteFtp cFtp = null;
                    try
                    {
                         cFtp=new FtpLibrary.ClienteFtp(IGlobal.URL_FTP, IGlobal.USER_FTP, IGlobal.PASS_FTP);
                         FLFtp.EscribeLinea("Fichero origen " + IGlobal.RUTA_IMAGENES_TPV + @"\" + ipendientes[j]["FICHERO"].ToString());
                         FLFtp.EscribeLinea("Fichero destino "+IGlobal.RUTA_FTP + ipendientes[j]["FICHERO"].ToString());
                         cFtp.Upload(this.ImagenesReducc(IGlobal.RUTA_IMAGENES_TPV + @"\" + ipendientes[j]["FICHERO"].ToString()), IGlobal.RUTA_FTP + ipendientes[j]["FICHERO"].ToString());
                         FLFtp.EscribeLinea(DateTime.Now.ToString("HH:mm:ss.fffff")+"[" + ipendientes[j]["FICHERO"].ToString() + "] Subido");
                         imagenes.Rows.Remove(ipendientes[j]);
                    }
                    catch (Exception err)
                    {
                        FLFtp.EscribeLinea(DateTime.Now.ToString("HH:mm:ss.fffff") + "[" + ipendientes[j]["FICHERO"].ToString() + "] <"+bucles+"> Error: "+err.Message);
                        ipendientes[j]["INTENTOS"] = Convert.ToInt16(ipendientes[j]["INTENTOS"].ToString()) + 1;
                        ipendientes[j]["ERROR"] = err.Message;
                    }
                    finally
                    {
                        if (cFtp != null)
                        {
                            cFtp = null;
                        }
                        GC.Collect();
                    }
                    ipendientes = imagenes.Select("INTENTOS<=" + IGlobal.NUM_INTENTOS_FTP.ToString());
                    bucles++;
                }
            }
            if (imagenes.Rows.Count > 0)
            {
                try
                {
                    this.FL.EscribeLinea("Guardando Hash con " + imagenes.Rows.Count + " ficheros erroneos");
                    imagenes.WriteXml(AppDomain.CurrentDomain.BaseDirectory + @"\hashimag.xml", XmlWriteMode.WriteSchema, true);
                }
                catch (Exception errx)
                {
                    this.FL.EscribeLinea("No se ha podido guardar el hash, cuasa: " + errx);
                }
                finally
                {
                    imagenes = null;
                }
            }
            else
            {
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\hashimag.xml"))
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\hashimag.xml");
                }
            }
        }

        protected void BucleDaemon()
        {
            bool salir = false;
            while (!salir)
            {
                lock (this.EstadoHiloPrincipal)
                {
                    this.FL.EscribeLinea("[HILO] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Iniciando bucle");
                    switch (this.EstadoHiloPrincipal.Accion)
                    {
                        case ACCION_HILO.CONTINUAR:
                        case ACCION_HILO.REANUDAR:
                            try
                            {
                                this.FL.EscribeLinea("[HILO] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Ejecutando bucle");
                                Thread.BeginCriticalRegion();
                                this.FL.EscribeLinea("[REPLICACION TIPOS ELEMENTOS] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Inicio de proceso");
                                this.MantenimientoTiel();
                                this.FL.EscribeLinea("[REPLICACION TIPOS ELEMENTOS] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Fin de proceso");
                                this.FL.EscribeLinea("[REPLICACION ESTADO RESERVAS] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Inicio de proceso");
                                this.MantenimientoEsre();
                                this.FL.EscribeLinea("[REPLICACION ESTADO RESERVAS] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Fin de proceso");
                                this.FL.EscribeLinea("[REPLICACION FAMILIAS] "+DateTime.Now.ToString("HH:mm:ss:ffff") + " Inicio de proceso");
                                this.MantenimientoFamilias();
                                this.FL.EscribeLinea("[REPLICACION FAMILIAS] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Fin de proceso");
                                this.FL.EscribeLinea("[REPLICACION SUBFAMILIAS] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Inicio de proceso");
                                this.MantenimientoSubFamilias();
                                this.FL.EscribeLinea("[REPLICACION SUBFAMILIAS] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Fin de proceso");
                                this.FL.EscribeLinea("[HASH IMAGENES] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Inicio de proceso");
                                DataTable hashimag = this.CreaHashImagenes();
                                this.FL.EscribeLinea("[HASH IMAGENES] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Fin de proceso");
                                this.FL.EscribeLinea("[REPLICACION PRODUCTOS] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Inicio de proceso");
                                this.MantenimientoProductos(ref hashimag);
                                this.FL.EscribeLinea("[REPLICACION PRODUCTOS] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Fin de proceso");
                                this.FL.EscribeLinea("[SUBIDA FICHEROS] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Inicio de proceso");
                                this.MantenimientoImagenes(ref hashimag);
                                this.FL.EscribeLinea("[SUBIDA FICHEROS] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Fin de proceso");
                                this.FL.EscribeLinea("[CLIENTES WEB > CLIENTES TPV] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Inicio de proceso");
                                this.MantenimientoClientes();
                                this.FL.EscribeLinea("[CLIENTES WEB > CLIENTES TPV] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Inicio de proceso");
                                this.FL.EscribeLinea("[ALTA DE RESERVAS EN EL TPV] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Inicio de proceso");
                                this.AltaTPVReservas();
                                this.FL.EscribeLinea("[ALTA DE RESERVAS EN EL TPV] " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Fin de proceso");
                            }
                            catch (ThreadAbortException tae)
                            {
                                salir = true;
                            }
                            catch (Exception err)
                            {
                                this.FL.EscribeLinea("[ERROR HILO] " + DateTime.Now.ToString("HH:mm:ss:fffff") + " " + err.Message);
                                this.FL.EscribeLinea(err.StackTrace);
                                try
                                {
                                    CLASES.LOGS.MailLog ml = new global::ReplicacionTPVWeb.CLASES.LOGS.MailLog("Error en el hilo", "Adjunto log");
                                    ml.AnadeAdjunto(this.FL.Fichero);
                                    ml.Enviar();
                                }
                                catch (Exception err2)
                                {
                                    this.FL.EscribeLinea("[ERROR ENVIO LOG MAIL] " + DateTime.Now.ToString("HH:mm:ss:fffff") + " " + err2.Message);
                                    this.FL.EscribeLinea(err2.StackTrace);
                                }
                            }
                            finally
                            {
                                try
                                {
                                    Thread.EndCriticalRegion();
                                }
                                catch (Exception e)
                                {
                                }
                                GC.Collect();
                            }
                            break;
                        case ACCION_HILO.FINALIZAR:
                            this.FL.EscribeLinea("[HILO] " + DateTime.Now.ToString("HH:mm:ss:ffff") + "Parando bucle");
                            salir = true;
                            break;
                        case ACCION_HILO.PAUSAR:
                            this.FL.EscribeLinea("[HILO] " + DateTime.Now.ToString("HH:mm:ss:ffff") + "Pausando bucle");
                            break;
                    }
                    if (!salir)
                    {
                        this.FL.EscribeLinea("[HILO] " + DateTime.Now.ToString("HH:mm:ss:ffff") + "Inicio espera bucle");
                        Thread.Sleep(new TimeSpan(0, (Int32)IGlobal.TIEMPO_ESPERA_BUCLE, 0));
                        this.FL.EscribeLinea("[HILO] " + DateTime.Now.ToString("HH:mm:ss:ffff") + "Fin espera bucle");
                    }
                }
            }
        }
    }

    public enum ACCION_HILO
    {
        CONTINUAR,
        PAUSAR,
        REANUDAR,
        FINALIZAR
    }

    public class EstadoHilo
    {
        private ACCION_HILO _AccionActual;

        public ACCION_HILO Accion
        {
            set
            {
                this._AccionActual = value;
            }
            get
            {
                return this._AccionActual;
            }
        }

        public EstadoHilo()
        {
            this.Accion = ACCION_HILO.CONTINUAR;
        }
    }
}
