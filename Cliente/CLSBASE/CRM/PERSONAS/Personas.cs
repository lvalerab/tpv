using System;
using System.Collections.Generic;
using System.Text;
using CLSBASE.INTERFACES;
using System.Data;
using MySql.Data.MySqlClient;

namespace CLSBASE.CRM.PERSONAS
{
    public class Personas:IElementos
    {
        private const string _SQL = "select * from pers_personas";
        
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

        private static Personas _instancia;
        private Personas()
        {
            this.Refrescar();
        }

        public static Personas ObtenInstancia()
        {
            if (Personas._instancia == null)
            {
                Personas._instancia = new Personas();
            }
            else
            {
                Personas._instancia.Refrescar();
            }
            return Personas._instancia;
        }

        private void Cargar()
        {
            IGlobal.rellenar_datos(_SQL, ref this._datos);            
        }

        private void RellenarIdsNuevos(ref MySqlConnection cn, ref MySqlTransaction tr)
        {   
            DataRow[] reg=this._datos.Select("ID_ELEM is null");
            for(Int32 i=0;i<reg.Length;i++)
            {
                DataRow d = reg[i];
                Persona aux = new Persona(ref d,this);
                d["ID_ELEM"] = aux.ObtenIDNuevoElemento(ref cn, ref tr);
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

        public Persona Nuevo()
        {
            DataRow regnew = this._datos.NewRow();
            return new Persona(ref regnew, this);
        }

        public Persona Buscar(Int64 codigo)
        {
            DataRow[] resultado = this._datos.Select("ID_ELEM=" + codigo.ToString());
            if (resultado.Length > 0)
            {
                return new Persona(ref resultado[0], this);
            }
            else
            {
                return null;
            }
        }
    }
}
