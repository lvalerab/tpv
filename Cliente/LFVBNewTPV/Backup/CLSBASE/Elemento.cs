using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Threading;
using System.Data;

namespace CLSBASE
{
    public class Elemento
    {
        public string TIPO_ELEMENTO;
        private DataTable _DatoWeb;
        /// <summary>
        /// Obtiene un nuevo ID de elemento, esta funcion se usa cuando se crea el elemento en cuestion
        /// </summary>
        /// <param name="cn"> Conexion activa</param>
        /// <param name="tr">Transacion activa</param>
        /// <returns>Int64 con el nuevo ID de elemento</returns>
        public Int64 ObtenIDNuevoElemento(ref MySqlConnection cn, ref MySqlTransaction tr)
        {
            Int64 id = Convert.ToInt64(DateTime.Now.ToString(IGlobal._FORMATO_AUTOID));
            Thread.Sleep(10);
            Application.DoEvents();
            string sql="insert into elem_elementos (ID_ELEMENTO, COD_TIEL) values ("+id.ToString()+", '"+this.TIPO_ELEMENTO+"')";
            MySqlCommand cm = new MySqlCommand(sql, cn, tr);
            cm.ExecuteNonQuery();
            return id;
        }
        /// <summary>
        /// Obtiene las opciones WEB de un elemento dado
        /// </summary>
        /// <param name="id">ID del elemento en cuestion</param>
        /// <param name="cn">Conexion activa</param>
        /// <param name="tr">Transacion Activa</param>
        public void ObtenOpcionesWeb(Int64 id, ref MySqlConnection cn, ref MySqlTransaction tr)
        {
            string sql = "select * from WEEL_WEB_ESTADO_ELEMENTO where ID_ELEMENTO="+id.ToString();
            IGlobal.rellenar_datos(sql, ref this._DatoWeb);
        }

        public void GuardaOpcionesWeb(Int64 id, ref MySqlConnection cn, ref MySqlTransaction tr)
        {
            if (this._DatoWeb != null)
            {
                string sql = "select * from WEEL_WEB_ESTADO_ELEMENTO where ID_ELEMENTO=" + id.ToString();
                IGlobal.guardar_datos(sql, ref this._DatoWeb, ref cn, ref tr);
            }
        }
    }
}
