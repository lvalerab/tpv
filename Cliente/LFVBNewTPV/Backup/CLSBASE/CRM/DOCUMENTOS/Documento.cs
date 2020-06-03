using System;
using System.Collections.Generic;
using System.Text;
using CLSBASE.INTERFACES;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;
using CLSBASE.CRM.PRODUCTOS;
using System.Threading;

namespace CLSBASE.CRM.DOCUMENTOS
{
/// <summary>
/// Clase para implementar la funcionalidad de generar un documento
/// </summary>
    public class Documento:Elemento,IElemento
    {
        private const string _SQL_LINEAS_CADO = "select * from lido_lineas_documento where ID_ELEM_CAB=[IDELEM]";

        private Documentos _parent;
        /// <summary>
        /// Identifica al objeto Documentos que ha generado este documento
        /// </summary>
        public Documentos parent
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
        /// <summary>
        /// DataRow con los datos de la cabecera del documento
        /// </summary>
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
        /// <summary>
        /// DataTable con las lineas que componen el documento
        /// </summary>
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

        /// <summary>
        /// Constructor del documento, al cual se le pasa el DataRow de la cabecera, y el padre <see cref="Documentos"/> que ha creado dicho documento
        /// </summary>
        /// <param name="d">DataRow con los datos del documento</param>
        /// <param name="p">Objeto documentos que ha generado este documento</param>
        internal Documento(ref DataRow d, Documentos p)
        {
            this.TIPO_ELEMENTO = "DOC";
            this.datos = d;
            this.parent = p;
            this.CargaDatosAux("LINEAS");
            this._lineas.RowChanged += new DataRowChangeEventHandler(_lineas_RowChanged);
        }

        void _lineas_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            //try
            //{
            //    e.Row["TOTAL_LIDO"] = Convert.ToDouble((e.Row["PVP_LIDO"].ToString() != "" ? e.Row["PVP_LIDO"].ToString() : "0")) * Convert.ToDouble((e.Row["CANTIDAD_LIDO"].ToString() != "" ? e.Row["CANTIDAD_LIDO"].ToString() : "0"));
            //}
            //catch (Exception err)
            //{
            //}
        }

        /// <summary>
        /// Constructor que crea un objeto documento vacio
        /// </summary>
        internal Documento()
        {
            this.TIPO_ELEMENTO = "DOC";
            this.datos = null;
            this.parent = null;
        }

        #region Miembros de IElemento
        /// <summary>
        /// Valida que el documento es correcto
        /// </summary>
        /// <param name="textoerr">Texto que devuelve en caso de encontrar algun error</param>
        /// <returns>Si es correcto true, si es incorrecto false</returns>
        public bool Validar(ref string textoerr)
        {
            textoerr = "";
            bool error = false;
            if (this._datos["COD_TIDO"].ToString().Trim() == "")
            {
                textoerr += "\nDebe de indicar un tipo de documento";
                error=true;
            }
            if (this._datos["ID_ELEM_PERS"].ToString().Trim() == "")
            {
                textoerr += "\nDebe de indicar un Cliente/Proveedor";
                error = true;
            }
            if (!error)
            {
                if (this._datos["FECHA_SYSTEMA_CADO"] == DBNull.Value)
                {
                    this._datos["FECHA_SYSTEMA_CADO"] = DateTime.Now;
                }
                if (this._datos["FECHA_ENTRADA_CADO"] == DBNull.Value)
                {
                    this._datos["FECHA_ENTRADA_CADO"] = DateTime.Now;
                    this._datos["ANYO_CADO"] = DateTime.Now.Year;
                }
            }
            return error;
        }

        /// <summary>
        /// Guarda un documento
        /// </summary>
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
                        this._datos["NUMERO_CADO"] = Documento.ObtenNumeroDoc(this._datos["COD_TIDO"].ToString(), DateTime.Now.Year, ref cn, ref tr);
                        this._parent.Datos.Rows.Add(this._datos);
                    }
                    this._parent.Guardar(ref cn, ref tr);
                    this.GuardaDatosAux(ref cn, ref tr);
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

        #endregion
        /// <summary>
        /// Carga los datos relacionados de un documento
        /// </summary>
        /// <param name="dato">String que puede ser:
        ///                         LINEAS -> Carga las lineas del documento
        /// </param>
        internal void CargaDatosAux(string dato)
        {
            string sql = "";
            switch (dato)
            {
                case "LINEAS":
                    sql = _SQL_LINEAS_CADO;
                    sql = sql.Replace("[IDELEM]", (this._datos["ID_ELEM"] != DBNull.Value ? this._datos["ID_ELEM"].ToString() : "0"));
                    IGlobal.rellenar_datos(sql, ref this._lineas);
                    break;
            }
        }
        /// <summary>
        /// Funcion que guarda los datos auxiliares del documento
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="tr"></param>
        internal void GuardaDatosAux(ref MySqlConnection cn, ref MySqlTransaction tr)
        {
            PRODUCTOS.Productos auxL = PRODUCTOS.Productos.ObtenInstancia();
            string sql = _SQL_LINEAS_CADO;
            sql = sql.Replace("[IDELEM]", (this._datos["ID_ELEM"] != DBNull.Value ? this._datos["ID_ELEM"].ToString() : "0"));
            foreach (DataRow d in this._lineas.Rows)
            {
                d["ID_ELEM_CAB"] = this._datos["ID_ELEM"];
                if (d["ID_ELEM"].ToString() == "")
                {
                    Elemento auxe = new Elemento();
                    auxe.TIPO_ELEMENTO = "LID";
                    d["ID_ELEM"] = auxe.ObtenIDNuevoElemento(ref cn, ref tr);
                    Thread.Sleep(10);
                    if (d["ID_ELEM_PROD"].ToString() != "")
                    {
                        try {
                            Int64 idelemprod = Convert.ToInt64(d["ID_ELEM_PROD"].ToString());
                            Producto auxp = auxL.Buscar(idelemprod);
                            if (auxp != null)
                            {
                                //auxp.datos["EXISTENCIAS_PROD"] = Convert.ToInt32((auxp.datos["EXISTENCIAS_PROD"].ToString() != "" ? auxp.datos["EXISTENCIAS_PROD"].ToString() : "0")) - Convert.ToInt32((d["CANTIDAD_LIDO"].ToString() != "" ? d["CANTIDAD_LIDO"].ToString() : "0"));
                                auxp.ActualizaStock((-1)*Convert.ToInt32((d["CANTIDAD_LIDO"].ToString() != "" ? d["CANTIDAD_LIDO"].ToString() : "0")));
                                auxp.Guardar();
                            }
                        } catch (Exception err) {
                        }
                    }
                }
            }
            auxL.Guardar(ref cn,ref tr);
            IGlobal.guardar_datos(sql, ref this._lineas, ref cn, ref tr);
        }

        /// <summary>
        /// Funcion que obtiene un número de documento (Contador)
        /// </summary>
        /// <param name="codtido">Tipo de documento</param>
        /// <param name="anyo">Año de emisión</param>
        /// <param name="cn">Conexion activa</param>
        /// <param name="tr">Transacion activa</param>
        /// <returns>Nº del contador</returns>
        public static Int32 ObtenNumeroDoc(string codtido, Int32 anyo, ref MySqlConnection cn, ref MySqlTransaction tr)
        {
            string sql = "select * from cntd_contador_tido where COD_TIDO='" + codtido + "' and ANYO_CNTD=" + anyo.ToString();
            DataTable aux=new DataTable();
            IGlobal.rellenar_datos(sql, ref aux);
            Int32 contador=0;
            if (aux.Rows.Count > 0)
            {
                contador = Convert.ToInt32(aux.Rows[0]["CONTADOR_CNTD"])+1;
                aux.Rows[0]["CONTADOR_CNTD"] = contador;
            }
            else
            {
                DataRow nreg = aux.NewRow();
                nreg["COD_TIDO"] = codtido;
                nreg["ANYO_CNTD"] = anyo;
                contador++;
                nreg["CONTADOR_CNTD"] = contador;
                aux.Rows.Add(nreg);
            }
            IGlobal.guardar_datos(sql, ref aux, ref cn, ref tr);
            return contador;
        }
        /// <summary>
        /// Funcion que obtiene un resumen de totales del documento
        /// </summary>
        /// <returns>Hashtable con:
        ///     PVB -> Precio total bruto (sin iva)
        ///     PVP -> Precio total con iva
        ///     PIM -> Importe total del iva
        /// </returns>
        public Hashtable ObtenTotalesDocumento()
        {
            Hashtable resultado = new Hashtable();
            Double PVB = 0;
            Double PVP = 0;
            Double PIM = 0;
            foreach (DataRow dr in this._lineas.Rows)
            {
                PVB += Convert.ToDouble((dr["PVB_LIDO"].ToString() != "" ? dr["PVB_LIDO"].ToString() : "0")) * Convert.ToInt32((dr["CANTIDAD_LIDO"].ToString() != "" ? dr["CANTIDAD_LIDO"].ToString() : "0"));
                Double piva=Convert.ToDouble(dr["PORC_IVA_LIDO"].ToString() != "" ? dr["PORC_IVA_LIDO"].ToString() : "0");
                //Cuidado, el iva viene en forma de coeficiente multiplicador para obtener el precio neto, es decir, si el iva es del 18%, nos vendrá como 1.18, con lo cual, simplemente tiene que multiplicarse por el bruto restandole la unidad
                if (piva != 0)
                {
                    PIM += Convert.ToDouble((dr["PVB_LIDO"].ToString() != "" ? dr["PVB_LIDO"].ToString() : "0")) * Convert.ToInt32((dr["CANTIDAD_LIDO"].ToString() != "" ? dr["CANTIDAD_LIDO"].ToString() : "0")) * (piva-1);
                }
                else if(Convert.ToDouble((dr["PVB_LIDO"].ToString() != "" ? dr["PVB_LIDO"].ToString() : "0"))==0 && Convert.ToDouble((dr["PVP_LIDO"].ToString() != "" ? dr["PVP_LIDO"].ToString() : "0"))>0)
                {
                    //En este caso, el importe no tiene aplicado iva, (una linea por defecto, con lo cual se le sumará al bruto
                    PVB += Convert.ToDouble((dr["PVP_LIDO"].ToString() != "" ? dr["PVP_LIDO"].ToString() : "0")) * Convert.ToInt32((dr["CANTIDAD_LIDO"].ToString() != "" ? dr["CANTIDAD_LIDO"].ToString() : "0"));
                }
                PVP += Convert.ToDouble((dr["PVP_LIDO"].ToString() != "" ? dr["PVP_LIDO"].ToString() : "0")) * Convert.ToInt32((dr["CANTIDAD_LIDO"].ToString() != "" ? dr["CANTIDAD_LIDO"].ToString() : "0"));
            }
            //Para cuadrar, sumamos la diferencia al iva, normalmente debe de descuadrar un centimo o menos, por los redondeos.
            Double diff = PVP - (PVB + PIM);
            PIM += diff;
            resultado.Add("PVB", PVB);
            resultado.Add("PIM", PIM);
            resultado.Add("PVP", PVP);
            return resultado;
        }
    }
}
