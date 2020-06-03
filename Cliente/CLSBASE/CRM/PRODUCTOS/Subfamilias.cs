using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CLSBASE.INTERFACES;

namespace CLSBASE.CRM.PRODUCTOS
{
    public class Subfamilias:IMaestro
    {
        private const string _SQL = "select * from sufa_sub_familias";

        public Subfamilias()
        {
            this.refrescar();
        }

        #region "Miembros de la clase singleton"
        private static Subfamilias _instancia;
        public static Subfamilias ObtenInstancia()
        {
            if (Subfamilias._instancia == null)
            {
                Subfamilias._instancia = new Subfamilias();
            }
            else
            {
                Subfamilias._instancia.refrescar();
            }
            return Subfamilias._instancia;
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
