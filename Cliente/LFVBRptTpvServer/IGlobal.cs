using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace LFVBRptTpvServer
{
    public class IGlobal
    {
        private static string _cad_conexion;

        public static string cad_conexion
        {
            get
            {
                return (IGlobal._cad_conexion==null?global::LFVBRptTpvServer.Properties.Settings.Default.CAD_CONEXION:IGlobal._cad_conexion);
            }
            set
            {
                IGlobal._cad_conexion = value;
                global::LFVBRptTpvServer.Properties.Settings.Default.CAD_CONEXION = IGlobal._cad_conexion;
            }
        }

        public static void rellenar_datos(string sql, ref DataTable dt)
        {
            MySqlConnection cn = null;
            try
            {
                cn = new MySqlConnection(IGlobal.cad_conexion);
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
                cn = new MySqlConnection(IGlobal.cad_conexion);
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
                cn = new MySqlConnection(IGlobal.cad_conexion);
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
