using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using CLSBASE.INTERFACES;

namespace CLSBASE.CRM.PRODUCTOS
{
    public class Producto:Elemento,IElemento

    {
        private const string _SQL_PRPR_PRECIOS_PRODUCTO = "select * from prpr_precios_producto where ID_ELEM_PROD=[IDELEM]";
        private const string _SQL_MSPR_MOV_STOCK_PROD = "select * from mspr_mov_stock_prod where ID_ELEM_PROD=[IDELEM]";
        private DataRow _datos;
        private Productos _parent;
        private DataTable _DTPrecios;
        private DataRow _precio;
        private DataTable _DTMovStock;
        private DataRow _stock;

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
        public Productos parent
        {
            get
            {
                return this._parent;
            }
        }
        public DataTable precios
        {
            get
            {
                return this._DTPrecios;
            }
            set
            {
                this._DTPrecios = value;
            }
        }
        public DataRow precio
        {
            set
            {
                this._precio = value;
            }
            get
            {
                return this._precio;
            }
        }
        public DataTable MovStock
        {
            get
            {
                return this._DTMovStock;
            }
            set
            {
                this._DTMovStock = value;
            }
        }

        internal Producto(ref DataRow datos, Productos parent)
        {
            this.TIPO_ELEMENTO = "PR";
            this._datos = datos;
            this._parent = parent;
            this.CargaDatosAux("PRECIO");
            this.CargaDatosAux("MSTOCK");
            this.ObtenDatosPrecio();
        }

        public Producto()
        {
            this.TIPO_ELEMENTO = "PR";
            this._datos = null;
            this._parent = null;
        }

        public bool Validar(ref string textoerr)
        {
            bool error = false;
            textoerr = "";
            if (this._datos["COD_FAMI"].ToString() == "")
            {
                textoerr += "Debe de indicar una familia para dicho producto";
                error=true;
            }
            if (this._datos["COD_SUFA"].ToString() == "")
            {
                textoerr += "Debe de indicar una subfamilia para dicho producto";
                error = true;
            }
            return error;
        }

        internal void CargaDatosAux(string dato)
        {
            string sql = "";
            switch (dato)
            {
                case "PRECIO":
                    sql = _SQL_PRPR_PRECIOS_PRODUCTO;
                    sql = sql.Replace("[IDELEM]", (this._datos["ID_ELEM"] != DBNull.Value ? this._datos["ID_ELEM"].ToString() : "0"));
                    IGlobal.rellenar_datos(sql, ref this._DTPrecios);
                    break;
                case "MSTOCK":
                    sql = _SQL_MSPR_MOV_STOCK_PROD;
                    sql = sql.Replace("[IDELEM]", (this._datos["ID_ELEM"] != DBNull.Value ? this._datos["ID_ELEM"].ToString() : "0"));
                    IGlobal.rellenar_datos(sql, ref this._DTMovStock);
                    break;
            }
        }

        public void Guardar()
        {
            string mensaje="";
            if (!this.Validar(ref mensaje))
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
                    this._datos["EXISTENCIAS_PROD"] = this.ObtenStock();
                    this._parent.Guardar(ref cn, ref tr);
                    this.GuardaDatosPrecio(ref cn, ref tr);
                    this.GuardarDatosMovStock(ref cn, ref tr);
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
                throw new Exception(mensaje);
            }
        }

        internal void GuardarReg(ref MySqlConnection cn, ref MySqlTransaction tr)
        {
            if (this._datos.RowState == DataRowState.Detached)
            {
                this._datos["ID_ELEM"] = this.ObtenIDNuevoElemento(ref cn, ref tr);
                this._parent.Datos.Rows.Add(this._datos);
            }
        }

        private void ObtenDatosPrecio()
        {

            DataRow[] dr = this._DTPrecios.Select("VIGENTE_PRECIO='S'");
            if (dr.Length <= 0)
            {
                this._precio = this._DTPrecios.NewRow();
            }
            else
            {
                this._precio = dr[0];
            }
        }

        private void GuardaDatosPrecio(ref MySqlConnection cn, ref MySqlTransaction tr)
        {
            foreach (DataRow dr in this._DTPrecios.Rows)
            {
                dr["VIGENTE_PRECIO"] = "N";
            }
            Elemento aux = new Elemento();
            aux.TIPO_ELEMENTO = "PRE";
            DataRow nprecio = this._DTPrecios.NewRow();
            nprecio["ID_ELEM_PROD"] = this._datos["ID_ELEM"];
            nprecio["ID_ELEM"] = aux.ObtenIDNuevoElemento(ref cn, ref tr);
            nprecio["VIGENTE_PRECIO"] = "S";
            nprecio["PRECIO_COMPRA"] = this._precio["PRECIO_COMPRA"];
            nprecio["PRECIO_BRUTO"] = this._precio["PRECIO_BRUTO"];
            nprecio["COD_TIVA"] = this._precio["COD_TIVA"];
            nprecio["PORC_IVA"] = this._precio["PORC_IVA"];
            nprecio["PRECIO_VENTA"] = this._precio["PRECIO_VENTA"];
            this._DTPrecios.Rows.Add(nprecio);
            IGlobal.guardar_datos(_SQL_PRPR_PRECIOS_PRODUCTO.Replace("[IDELEM]", this._datos["ID_ELEM"].ToString()), ref this._DTPrecios, ref cn, ref tr);
        }
        #region "Metodos para el manejo de stocks"
        private void GuardarDatosMovStock(ref MySqlConnection cn, ref MySqlTransaction tr)
        {   
            foreach (DataRow dr in this._DTMovStock.Rows)
            {
                if (dr.RowState == DataRowState.Added)
                {
                    Elemento aux = new Elemento();
                    aux.TIPO_ELEMENTO = "MSP";
                    dr["ID_ELEM"] = aux.ObtenIDNuevoElemento(ref cn, ref tr);
                    dr["ID_ELEM_PROD"] = this._datos["ID_ELEM"];
                }
            }
            IGlobal.guardar_datos(_SQL_MSPR_MOV_STOCK_PROD.Replace("[IDELEM]", this._datos["ID_ELEM"].ToString()), ref this._DTMovStock,ref cn, ref tr);
        }

        public void ActualizaStock(double cantidad, DOCUMENTOS.Documento e)
        {
            DataRow[] dr = null;
            if (e == null)
            {
                dr = this._DTMovStock.Select("FECHA_MOVIMIENTO_MSPR='" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
            }
            else
            {
                dr = this._DTMovStock.Select("FECHA_MOVIMIENTO_MSPR='" + DateTime.Now.ToString("yyyy-MM-dd") + "' and ID_ELEM_LIDO="+e.datos["ID_ELEM"].ToString());
            }
            double entrada = (cantidad > 0 ? cantidad : 0);
            double salida = (cantidad < 0 ? (-1) * cantidad : 0);
            if (dr.Length > 0)
            {
                double taux=0;
                Double.TryParse(dr[0]["ENTRADA_MSPR"].ToString(), out taux);
                dr[0]["ENTRADA_MSPR"] = taux + entrada;
                Double.TryParse(dr[0]["SALIDA_MSPR"].ToString(), out taux);
                dr[0]["SALIDA_MSPR"] = taux + salida;
            }
            else
            {
                DataRow drn = this._DTMovStock.NewRow();
                drn["FECHA_MOVIMIENTO_MSPR"] = DateTime.Now;
                drn["ENTRADA_MSPR"] = entrada;
                drn["SALIDA_MSPR"] = salida;
                if (e != null)
                {
                    drn["ID_ELEM_OPER"] = e.datos["ID_ELEM"];
                }
                this._DTMovStock.Rows.Add(drn);
            }
        }

        public void ActualizaStock(double cantidad)
        {
            this.ActualizaStock(cantidad, null);
        }

        public double ObtenStock(DateTime fechaTope)
        {
            double ent = 0;
            double sal = 0;
            Double.TryParse(this._DTMovStock.Compute("sum(ENTRADA_MSPR)", "FECHA_MOVIMIENTO_MSPR<=#" + fechaTope.ToString("yyyy/MM/dd HH:mm:ss") + "#").ToString(), out ent);
            Double.TryParse(this._DTMovStock.Compute("sum(SALIDA_MSPR)", "FECHA_MOVIMIENTO_MSPR<=#" + fechaTope.ToString("yyyy/MM/dd HH:mm:ss") + "#").ToString(), out sal);
            return ent-sal;
        }

        /**
         * Usar esta para actualizar en el acto
         * */
        public double ObtenStock()
        {
            double ent = 0;
            double sal = 0;
            Double.TryParse(this._DTMovStock.Compute("sum(ENTRADA_MSPR)","").ToString(), out ent);
            Double.TryParse(this._DTMovStock.Compute("sum(SALIDA_MSPR)","").ToString(), out sal);
            return ent - sal;
        }
        #endregion
        #region "Metodo para obtener las imagenes"
        public string ObtenRutaImagen()
        {
            if (this.datos["IMAGEN_PROD"] != DBNull.Value)
            {
                return IGlobal.RUTA_IMAG_PROD + @"\" + this.datos["IMAGEN_PROD"].ToString();
            }
            else
            {
                return null;
            }
        }

        public void EstableceRutaImagen(string ruta)
        {
            if(!System.IO.Directory.Exists(IGlobal.RUTA_IMAG_PROD)) 
            {
                System.IO.Directory.CreateDirectory(IGlobal.RUTA_IMAG_PROD);
            }
            string[] ext=ruta.Split(new char[] {'.'});
            string NFich=DateTime.Now.ToString("yyyyMMddHHmmssffff")+"."+ext[ext.Length-1];
            System.IO.File.Copy(ruta,IGlobal.RUTA_IMAG_PROD+@"\"+NFich);
            this.datos["IMAGEN_PROD"] = NFich;
        }
        #endregion
    }
}
