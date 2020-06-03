using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CLSBASE.SISTEMA.USUARIOS
{
    public class Usuario
    {
        private bool _valido;
        public bool valido
        {
            get
            {
                return _valido;
            }
        }
        private DataTable _datos;
        //Por ahora solo de lectura. la gestión de usuarios lo hare yo.
        public DataTable datos
        {
            get
            {
                return _datos;
            }
        }
        //public DataTable permisos;
        //public DataTable controles;


        private static Usuario _instancia;
        private Usuario()
        {
            this._datos = null;
            this._valido = false;
        }

        public static Usuario Validar(string tinusua, string tinpass)
        {
            if (_instancia == null)
            {
                _instancia = new Usuario();
            }
            string sql = "select * from usua_usuarios  u where u.USUA_USUA='" + tinusua + "' and u.PASS_USUA='" + tinusua + "'";
            IGlobal.rellenar_datos(sql, ref _instancia._datos);
            if (_instancia._datos.Rows.Count >= 1)
            {
                _instancia._valido = true;
                //_instancia.CargaPermisos();
            }
            else
            {
                _instancia._valido = false;
                _instancia._datos = null;
            }
            return _instancia;
        }

        public void Log(string texto)
        {
            string sql = "insert into lgus_logs_usuarios (ID_LOG, ID_USUA, FECHA_LOG, TEXTO_LOG) values (" + DateTime.Now.ToString(IGlobal._FORMATO_AUTOID) + ", " + this._datos.Rows[0]["ID_USUA"].ToString() + ", '" + DateTime.Now.ToString(IGlobal._FORMATO_FECH_MYSQL) + "', '" + texto + "')";
            IGlobal.ejectuar_sql(sql);
        }

        //public void CargaPermisos()
        //{
        //    string sql = "select distinct perm.COD_CTRL, perm.EDITABLE from USGR_USUA_GRUP usgr inner join GRUP_GRUPOS grup on usgr.ID_GRUP=grup.ID_GRUP inner join PERM_PERMISOS perm on perm.ID_GRUP=grup.ID_GRUP where usgr.ID_USUA=" + this._datos.Rows[0]["ID_USUA"].ToString();
        //    try
        //    {
        //        this.permisos = new DataTable();
        //        IGlobal.rellenar_datos(sql, ref this.permisos);
        //        this.controles = new DataTable();
        //        IGlobal.rellenar_datos("select * from CTRL_CONTROLES ctrl", ref this.controles);
        //    }
        //    catch (Exception err)
        //    {
        //        this.Log("Error al cargar los permisos, causa: " + err.Message + " Stack: " + err.StackTrace);
        //    }
        //}

        //public PERM_VISIBILIDAD PermisoObj(string nombre)
        //{
        //    PERM_VISIBILIDAD per = PERM_VISIBILIDAD.invisible;
        //    try
        //    {
        //        DataRow[] perm = this.permisos.Select("COD_CTRL='" + nombre + "'");
        //        if (perm.Length <= 0)
        //        {
        //            DataRow[] ExistePerm = this.controles.Select("COD_CTRL='" + nombre + "'");

        //            if (ExistePerm.Length > 0)
        //            {
        //                per = PERM_VISIBILIDAD.invisible;
        //            }
        //            else
        //            {
        //                per = PERM_VISIBILIDAD.visible;
        //            }
        //        }
        //        else
        //        {
        //            DataRow[] visibles = this.permisos.Select("COD_CTRL='" + nombre + "' and EDITABLE='S'");
        //            if (visibles.Length > 0)
        //            {
        //                per = PERM_VISIBILIDAD.visible;
        //            }
        //            else
        //            {
        //                per = PERM_VISIBILIDAD.protegido;
        //            }
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        this.Log(err.Message + " " + err.StackTrace);
        //        per = PERM_VISIBILIDAD.invisible;
        //    }
        //    return per;
        //}
    }
}
