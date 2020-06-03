using System;
using System.Collections.Generic;
using System.Text;
using CLSBASE.INTERFACES;
using System.Data;
using MySql.Data.MySqlClient;

namespace CLSBASE.CRM.PERSONAS
{
    public class Persona:Elemento,IElemento
    {
        private Personas _parent;
        public Personas parent
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

        internal Persona(ref DataRow d, Personas p)
        {
            this.TIPO_ELEMENTO = "PER";
            this.datos = d;
            this.parent = p;
        }

        internal Persona()
        {
            this.TIPO_ELEMENTO = "PER";
            this.datos = null;
            this.parent = null;
        }

        #region Miembros de IElemento

        public bool Validar(ref string textoerr)
        {
            bool error = false;
            textoerr = "";
            return error;
        }

        public void Guardar()
        {
            string msgerr="";
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
                        this._parent.Datos.Rows.Add(this._datos);
                    }
                    this._parent.Guardar(ref cn, ref tr);                    
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

        public string NormalizaNif(string nif)
        {
            return nif;
        }
    }
}
