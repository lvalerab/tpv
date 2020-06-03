using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CLSBASE.INTERFACES;

namespace CLSBASE.CRM.PRODUCTOS
{
    public class Familias:IMaestro
    {
        private const string _SQL = "select * from fami_familias";

        private Familias()
        {
            this.refrescar();
        }

        #region "Miembros clase singleton"
        private static Familias _instancia;

        public static Familias ObtenInstancia()
        {
            if (Familias._instancia == null)
            {
                Familias._instancia = new Familias();
            }
            else
            {
                Familias._instancia.refrescar();
            }
            return Familias._instancia;
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
