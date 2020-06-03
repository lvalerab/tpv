using System;
using System.Collections.Generic;
using System.Text;

namespace CLSBASE
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MySql.Data.MySqlClient;
    using System.Data;

    public class IGlobal
    {
        public const string _FORMATO_AUTOID = "yyyyMMddhhmmssfffff";
        public const string _FORMATO_FECH_MYSQL = "yyyy-MM-dd hh:mm:ss";
        #region "Propiedades publicas y estaticas para enlazar con la aplicacion"
        private static string _cad_conexion;

        public static string cad_conexion
        {
            set
            {
                _cad_conexion = value;
            }
            get
            {
                return _cad_conexion;
            }
        }

        private static string _RUTA_IMAG_PROD;
        public static string RUTA_IMAG_PROD
        {
            set
            {
                IGlobal._RUTA_IMAG_PROD = value.Replace("[APPBASE]", AppDomain.CurrentDomain.BaseDirectory);
            }
            get
            {
                return IGlobal._RUTA_IMAG_PROD;
            }
        }

        private static SISTEMA.USUARIOS.Usuario _user;

        public static SISTEMA.USUARIOS.Usuario user
        {
            set
            {
                IGlobal._user = value;
            }
            get
            {
                return IGlobal._user;
            }
        }

        //Ruta de las imagenes en el ftp
        #endregion

        public static void rellenar_datos(string sql, ref DataTable dt)
        {
            MySqlConnection cn = null;
            try
            {
                cn = new MySqlConnection(_cad_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cn);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception err)
            {
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
            }
        }

        public static void guardar_datos(string sql, ref DataTable dt, ref MySqlConnection cn, ref MySqlTransaction tr)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cn);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            da.SelectCommand.Transaction = tr;
            da.InsertCommand = cb.GetInsertCommand();
            da.InsertCommand.Transaction = tr;
            da.UpdateCommand = cb.GetUpdateCommand();
            da.UpdateCommand.Transaction = tr;
            da.DeleteCommand = cb.GetDeleteCommand();
            da.DeleteCommand.Transaction = tr;

            da.Update(dt);
        }

        public static void guardar_datos(string sql, ref DataTable dt)
        {
            MySqlConnection cn = null;
            MySqlTransaction tr = null;
            try
            {
                cn = new MySqlConnection(_cad_conexion);
                cn.Open();
                tr = cn.BeginTransaction();
                guardar_datos(sql, ref dt, ref cn, ref tr);
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

        public static void ejecutar_sql(string sql, ref MySqlConnection cn, ref  MySqlTransaction tr)
        {
            MySqlCommand cm = new MySqlCommand(sql, cn, tr);
            cm.ExecuteNonQuery();
        }

        public static void ejectuar_sql(string sql)
        {
            MySqlConnection cn = null;
            MySqlTransaction tr = null;
            try
            {
                cn = new MySqlConnection(_cad_conexion);
                cn.Open();
                tr = cn.BeginTransaction();
                ejecutar_sql(sql, ref cn, ref tr);
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
            }
        }
    }
}
