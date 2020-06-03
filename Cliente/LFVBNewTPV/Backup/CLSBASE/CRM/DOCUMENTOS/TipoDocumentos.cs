using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using CLSBASE.INTERFACES;

namespace CLSBASE.CRM.DOCUMENTOS
{
    /// <summary>
    /// Clase maestra para obtener los tipos de documento
    /// </summary>
    public class TipoDocumentos:IMaestro
    {
        private const string _SQL = "select * from tido_tipo_documento";

        /// <summary>
        /// Constructor simple
        /// </summary>
        public TipoDocumentos()
        {
            this.refrescar();
        }

        #region "Miembros de la clase singleton"
        private static TipoDocumentos _instancia;
        /// <summary>
        /// Metódo estatico para obtener la instancia (singleton)
        /// </summary>
        /// <returns></returns>
        public static TipoDocumentos ObtenInstancia()
        {
            if (TipoDocumentos._instancia == null)
            {
                TipoDocumentos._instancia = new TipoDocumentos();
            }
            else
            {
                TipoDocumentos._instancia.refrescar();
            }
            return TipoDocumentos._instancia;
        }
        #endregion

        private DataTable _datos;
        /// <summary>
        /// DataTable con los tipos de documentos
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

        /// <summary>
        /// Guarda los tipos de documentos
        /// </summary>
        public void guardar()
        {
            IGlobal.guardar_datos(_SQL, ref this._datos);
        }

        /// <summary>
        /// Refresca los datos (guarda y carga)
        /// </summary>
        public void refrescar()
        {
            if (this._datos != null)
            {
                this.guardar();
            }
            IGlobal.rellenar_datos(_SQL, ref this._datos);
        }

        /// <summary>
        /// Obtiene las tablas de contadores por tipos
        /// </summary>
        /// <param name="codtido"> Cod. Tipo</param>
        /// <returns></returns>
        public DataTable ObtenerTablaContadores(string codtido)
        {
            string sql = "select * from CNTD_CONTADOR_TIDO where cod_tido='" + codtido + "'";
            DataTable retorno = null;
            IGlobal.rellenar_datos(sql, ref retorno);
            return retorno;
        }

        /// <summary>
        /// guarda la tabla de contadores por tipos
        /// </summary>
        /// <param name="codtido">Codigo Tipo</param>
        /// <param name="datos">DataTable de con los contadores</param>
        public void GuardarTablaContadores(string codtido, ref DataTable datos)
        {
            string sql = "select * from CNTD_CONTADOR_TIDO where cod_tido='" + codtido + "'";
            IGlobal.guardar_datos(sql, ref datos);
        }

        /// <summary>
        /// Obtiene un contador de un tipo determinado
        /// </summary>
        /// <param name="codtido">Cod. Tipo</param>
        /// <param name="anyo">Año emision</param>
        /// <param name="cn">Conexion Activa</param>
        /// <param name="tr">Transacion Activa</param>
        /// <returns>Contador</returns>
        public Int32 ObtenContador(string codtido, Int16 anyo, ref MySqlConnection cn, ref MySqlTransaction tr)
        {
            string sql = "select cod_tido, anyo_cntd, CONTADOR_CNTD from CNTD_CONTADOR_TIDO where cod_tido='" + codtido + "' and anyo_cntd=" + anyo.ToString();
            DataTable tblcontador = null;
            IGlobal.rellenar_datos(sql, ref tblcontador);
            Int32 contador = 0;
            if (tblcontador.Rows.Count > 0)
            {
                if (!Int32.TryParse(tblcontador.Rows[0]["CONTADOR_CNTD"].ToString(), out contador))
                {
                    contador = -1;
                }
                else
                {
                    contador++;
                    tblcontador.Rows[0]["CONTADOR_CNTD"] = contador;
                };
            }
            else
            {
                contador = 1;
                DataRow dr = tblcontador.NewRow();
                dr["cod_tido"] = codtido;
                dr["anyo_cntd"] = anyo;
                dr["contador_cntd"] = contador;
                tblcontador.Rows.Add(dr);
            }
            IGlobal.guardar_datos(sql, ref tblcontador, ref cn, ref tr);
            return contador;
        }
    }
}
