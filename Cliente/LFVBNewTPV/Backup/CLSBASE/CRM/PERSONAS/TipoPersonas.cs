using System;
using System.Collections.Generic;
using System.Text;
using CLSBASE.INTERFACES;
using System.Data;

namespace CLSBASE.CRM.PERSONAS
{
    public class TipoPersonas:IMaestro
    {
        private const string _SQL = "select * from tipe_tipo_personas";

        private TipoPersonas()
        {
            this.refrescar();
        }

        #region "Miembros clase singleton"
        private static TipoPersonas _instancia;

        public static TipoPersonas ObtenInstancia()
        {
            if (TipoPersonas._instancia == null)
            {
                TipoPersonas._instancia = new TipoPersonas();
            }
            else
            {
                TipoPersonas._instancia.refrescar();
            }
            return TipoPersonas._instancia;
        }
        #endregion

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

        public void guardar()
        {
            IGlobal.guardar_datos(_SQL, ref this._datos);
        }

        public void refrescar()
        {
            if (this._datos != null)
            {
                this.guardar();
            }
            IGlobal.rellenar_datos(_SQL, ref this._datos);
        }
    }
}
