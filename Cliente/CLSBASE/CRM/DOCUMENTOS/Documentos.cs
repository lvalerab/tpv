using System;
using System.Collections.Generic;
using System.Text;
using CLSBASE.INTERFACES;
using MySql.Data.MySqlClient;
using System.Data;
using CLSBASE.CRM.PERSONAS;

namespace CLSBASE.CRM.DOCUMENTOS
{
    /// <summary>
    /// Clase que obtiene todos los documentos dados de alta en el sistema
    /// <seealso cref="Documento"/>
    /// </summary>
    public class Documentos:IElementos
    {
        private const string _SQL = "select * from cado_cabecera_documento";

        private DataTable _datos;
        /// <summary>
        /// DataTable con todas las cabeceras de los documentos
        /// </summary>
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

        private static Documentos _instancia;
        private Documentos()
        {
            this.Refrescar();
        }

        /// <summary>
        /// Método para obtener una instancia de la clase documentos (singleton)
        /// </summary>
        /// <returns>Listado de documentos</returns>
        public static Documentos ObtenInstancia()
        {
            if (Documentos._instancia == null)
            {
                Documentos._instancia = new Documentos();
            }
            else
            {
                Documentos._instancia.Refrescar();
            }
            return Documentos._instancia;
        }

        /// <summary>
        /// Carga los datos de la base de datos en memoria 
        /// <see cref="DataTable"/>
        /// </summary>
        private void Cargar()
        {   
            IGlobal.rellenar_datos(_SQL, ref this._datos);
            this.CargaDatosAux();
            this._datos.DefaultView.Sort = "FECHA_ENTRADA_CADO desc, NUM_DOC_FORM desc";
        }

        /// <summary>
        /// Rellena los datos auxiliares del documento
        /// </summary>
        private void CargaDatosAux()
        {
            Personas auxP = Personas.ObtenInstancia();
            if (!this._datos.Columns.Contains("NUM_DOC_FORM"))
            {
                this._datos.Columns.Add(new DataColumn("NUM_DOC_FORM", System.Type.GetType("System.String")));
            }
            if (!this._datos.Columns.Contains("NOMBRE_PERS_CADO"))
            {
                this._datos.Columns.Add(new DataColumn("NOMBRE_PERS_CADO", System.Type.GetType("System.String")));
            }
            foreach (DataRow d in this._datos.Rows)
            {
                d["NUM_DOC_FORM"] = Documentos.ObtenerNumeroDocumento(d["COD_TIDO"].ToString(), d["NUMERO_CADO"].ToString(), d["ANYO_CADO"].ToString());
                Persona aux = auxP.Buscar(Convert.ToInt64((d["ID_ELEM_PERS"].ToString() != "" ? d["ID_ELEM_PERS"].ToString() : "0")));
                d["NOMBRE_PERS_CADO"] = aux.datos["NOMBRE_PERS"].ToString();
            }
        }

        /// <summary>
        /// Rellena los ID de los documentos nuevos
        /// <![CDATA[En desuso]]>
        /// </summary>
        /// <param name="cn">Conexion Activa</param>
        /// <param name="tr">Transacion Activa</param>
        //private void RellenarIdsNuevos(ref MySqlConnection cn, ref MySqlTransaction tr)
        //{   
        //    DataRow[] reg=this._datos.Select("ID_ELEM is null");
        //    for(Int32 i=0;i<reg.Length;i++)
        //    {
                
        //    }
        //}

        /// <summary>
        /// Guarda los datos de los documentos
        /// </summary>
        /// <param name="cn">Conexión Activa</param>
        /// <param name="tr">Transación Activa</param>
        public void Guardar(ref MySqlConnection cn, ref MySqlTransaction tr)
        {
           // this.RellenarIdsNuevos(ref cn, ref tr);
            IGlobal.guardar_datos(_SQL, ref this._datos, ref cn, ref tr);
        }

        /// <summary>
        /// Guarda los datos del documento en una transacion propia
        /// </summary>
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

        /// <summary>
        /// Recarga los datos,  (guarda y vuelve a cargar)
        /// </summary>
        public void Refrescar()
        {
            if (this._datos != null)
            {
                this.Guardar();
            }
            this.Cargar();
            this.CargaDatosAux();
        }

        /// <summary>
        /// Crea una nuevo documento
        /// <see cref="Documento"/>
        /// </summary>
        /// <returns>Documento nuevo</returns>
        public Documento Nuevo()
        {
            DataRow regnew = this._datos.NewRow();
            return new Documento(ref regnew, this);
        }

        /// <summary>
        /// Busca un documento dado
        /// <see cref="Documento"/>
        /// </summary>
        /// <param name="codigo">ID del documento</param>
        /// <returns>Documento encontrado o null si no encuentra nada</returns>
        public Documento Buscar(Int64 codigo)
        {
            DataRow[] resultado = this._datos.Select("ID_ELEM=" + codigo.ToString());
            if (resultado.Length > 0)
            {
                return new Documento(ref resultado[0], this);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Obtiene un numero de documento formateado
        /// </summary>
        /// <param name="tipo">Tipo de documento</param>
        /// <param name="numero">Número del documento</param>
        /// <param name="Anyo">Año de emisión del documento</param>
        /// <returns></returns>
        public static string ObtenerNumeroDocumento(string tipo, string numero, string Anyo)
        {
            return tipo.PadLeft(2, ' ') + "/" + numero.ToString().PadLeft(10, '0') + "/" + Anyo.ToString().PadLeft(4, '0');
        }
        
    }
}
