using System;
using System.Collections.Generic;
using System.Text;
using CLSBASE.INTERFACES;
using System.Data;
using MySql.Data.MySqlClient;
using System.Threading;

namespace CLSBASE.CRM.RESERVAS
{
    public class Reserva:Elemento,IElemento
    {
        private const string _SQL_LINEAS_CARE = "select * from lire_lin_reservas lire where lire.ID_ELEM_CARE=[IDELEM]";

        private Reservas _parent;

        public Reservas parent
        {
            set
            {
                this._parent = value;
            }
            get
            {
                return this._parent;
            }
        }

        private DataRow _datos;

        public DataRow datos
        {
            set
            {
                this._datos = value;
            }
            get
            {
                return this._datos;
            }
        }

        private DataTable _lineas;

        public DataTable lineas
        {
            set
            {
                this._lineas = value;
            }
            get
            {
                return this._lineas;
            }
        }

        internal Reserva(ref DataRow d, Reservas r)
        {
            this.TIPO_ELEMENTO = "RES";
            this.datos = d;
            this.parent = r;
            this.CargaDatosAux("LINEAS");
        }

        internal Reserva()
        {
            this.TIPO_ELEMENTO = "RES";
            this.datos = null;
            this.parent = null;
        }

        #region Miembros de IElemento

        public bool Validar(ref string textoerr)
        {
            bool error=false;
            if (this.datos["COD_ESRE"].ToString().Trim() == "")
            {
                textoerr += "\nDebe indicar un estado en el que se encuentra la reserva";
                error=true;
            }
            if (this.datos["ID_ELEM_PERS"].ToString().Trim() == "")
            {
                textoerr += "\nDebe indicar la persona que ha realizado la reserva";
                error=true;
            }
            if (!error)
            {
                if (this.datos["FECHA_GRABACION_CARE"] == DBNull.Value)
                {
                    this.datos["FECHA_GRABACION_CARE"] = DateTime.Now;
                }
            }
            return error;
        }

        public void Guardar()
        {
            string msgerr = "";
                if (!this.Validar(ref msgerr))
                {
                    MySqlConnection cn = null;
                    MySqlTransaction tr = null;
                    try
                    {
                        cn = new MySqlConnection(IGlobal.cad_conexion);
                        cn.Open();
                        tr = cn.BeginTransaction();
                        if (this._datos.RowState == DataRowState.Detached)
                        {
                            this._datos["ID_ELEM"] = this.ObtenIDNuevoElemento(ref cn, ref tr);                            
                            this._parent.Datos.Rows.Add(this._datos);
                        }
                        this._parent.Guardar(ref cn, ref tr);
                        this.GuardarDatosAux(ref cn, ref tr);
                        tr.Commit();
                    }
                    catch (Exception err)
                    {
                        if (tr != null)
                        {
                            tr.Rollback();
                        }
                        throw err;
                    }
                    finally
                    {
                        if (cn != null)
                        {
                            cn.Close();
                            cn.Dispose();
                            cn = null;
                        }
                        GC.Collect();
                    }
                }
                else
                {
                    throw new Exception(msgerr);
                }
        }

        public void Guardar(ref MySqlConnection cn, ref MySqlTransaction tr)
        {
            string msgerr = "";
            if (!this.Validar(ref msgerr))
            {
                    if (this._datos.RowState == DataRowState.Detached)
                    {
                        this._datos["ID_ELEM"] = this.ObtenIDNuevoElemento(ref cn, ref tr);
                        this._parent.Datos.Rows.Add(this._datos);
                    }
                    this._parent.Guardar(ref cn, ref tr);
                    this.GuardarDatosAux(ref cn, ref tr);
            }
            else
            {
                throw new Exception(msgerr);
            }

        }

        #endregion

        internal void CargaDatosAux(string dato)
        {
            string sql = "";
            switch (dato)
            {
                case "LINEAS":
                    sql = _SQL_LINEAS_CARE;
                    sql = sql.Replace("[IDELEM]", (this._datos["ID_ELEM"] != DBNull.Value ? this._datos["ID_ELEM"].ToString() : "0"));
                    IGlobal.rellenar_datos(sql, ref this._lineas);
                    break;
            }
        }

        internal void GuardarDatosAux(ref MySqlConnection cn, ref MySqlTransaction tr)
        {
            PRODUCTOS.Productos auxL = PRODUCTOS.Productos.ObtenInstancia();
            string sql = _SQL_LINEAS_CARE;
            sql = sql.Replace("[IDELEM]", (this._datos["ID_ELEM"] != DBNull.Value ? this._datos["ID_ELEM"].ToString() : "0"));
            foreach (DataRow d in this._lineas.Rows)
            {
                d["ID_ELEM_CARE"] = this._datos["ID_ELEM"];
                if (d["ID_ELEM"].ToString() == "")
                {
                    Elemento auxe = new Elemento();
                    auxe.TIPO_ELEMENTO = "LRS";
                    d["ID_ELEM"] = auxe.ObtenIDNuevoElemento(ref cn, ref tr);
                    Thread.Sleep(10);
                }
            }
            IGlobal.guardar_datos(sql, ref this._lineas, ref cn, ref tr);
        }
    }
}
