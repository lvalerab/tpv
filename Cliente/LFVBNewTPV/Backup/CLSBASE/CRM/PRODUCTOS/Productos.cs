using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using CLSBASE.INTERFACES;

namespace CLSBASE.CRM.PRODUCTOS
{
    public class Productos:IElementos
    {
        private const string _SQL = "select * from prod_productos";
        
        private DataTable _datos;
        public DataTable Datos
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

        private static Productos _instancia;
        private Productos()
        {
            this.Refrescar();
        }

        public static Productos ObtenInstancia()
        {
            if (Productos._instancia == null)
            {
                Productos._instancia = new Productos();
            }
            else
            {
                Productos._instancia.Refrescar();
            }
            return Productos._instancia;
        }

        private void Cargar()
        {
            IGlobal.rellenar_datos(_SQL, ref this._datos);
            if (!this._datos.Columns.Contains("PVP_PROD"))
            {
                this._datos.Columns.Add(new DataColumn("PVP_PROD", System.Type.GetType("System.Double")));
            }
            for (Int32 i = 0; i < this._datos.Rows.Count; i++)
            {
                DataRow r = this._datos.Rows[i];
                Producto aux = new Producto(ref r, this);
                this._datos.Rows[i]["PVP_PROD"] = aux.precio["PRECIO_VENTA"];
            }
        }

        private void RellenarIdsNuevos(ref MySqlConnection cn, ref MySqlTransaction tr)
        {   
            DataRow[] reg=this._datos.Select("ID_ELEM is null");
            for(Int32 i=0;i<reg.Length;i++)
            {
                Producto aux = new Producto(ref reg[i], this);
                aux.GuardarReg(ref cn, ref tr);
            }
        }

        public void Guardar(ref MySqlConnection cn, ref MySqlTransaction tr)
        {
            this.RellenarIdsNuevos(ref cn, ref tr);
            IGlobal.guardar_datos(_SQL, ref this._datos, ref cn, ref tr);
        }

        public void Guardar()
        {
            MySqlConnection cn = null;
            MySqlTransaction tr = null;
            try
            {
                cn = new MySqlConnection(IGlobal.cad_conexion);
                cn.Open();
                tr = cn.BeginTransaction();
                this.Guardar(ref cn,ref tr);
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
                cn.Dispose();
            }
        }

        public void Refrescar()
        {
            if (this._datos != null)
            {
                this.Guardar();
            }
            this.Cargar();
        }

        public Producto Nuevo()
        {
            DataRow regnew = this._datos.NewRow();
            return new Producto(ref regnew, this);
        }

        public Producto Buscar(Int64 codigo)
        {
            DataRow[] resultado = this._datos.Select("ID_ELEM=" + codigo.ToString());
            if (resultado.Length > 0)
            {
                return new Producto(ref resultado[0], this);
            }
            else
            {
                return null;
            }
        }
    }
}
