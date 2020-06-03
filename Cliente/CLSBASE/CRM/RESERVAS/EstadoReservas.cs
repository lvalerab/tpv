using System;
using System.Collections.Generic;
using System.Text;
using CLSBASE.INTERFACES;
using System.Data;

namespace CLSBASE.CRM.RESERVAS
{
    public class EstadoReservas:IMaestro
    {
        private const string _SQL = "select * from esre_estado_reservas";

        public EstadoReservas()
        {
            this.refrescar();
        }

        #region "Miembros de la clase singleton"
        private static EstadoReservas _instancia;
        /// <summary>
        /// Metódo estatico para obtener la instancia (singleton)
        /// </summary>
        /// <returns></returns>
        public static EstadoReservas ObtenInstancia()
        {
            if (EstadoReservas._instancia == null)
            {
                EstadoReservas._instancia = new EstadoReservas();
            }
            else
            {
                EstadoReservas._instancia.refrescar();
            }
            return EstadoReservas._instancia;
        }
        #endregion

        private DataTable _datos;
        /// <summary>
        /// DataTable con los tipos de documentos
        /// </summary>
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

        /// <summary>
        /// Guarda los tipos de documentos
        /// </summary>
        public void guardar()
        {
            IGlobal.guardar_datos(_SQL, ref this._datos);
        }

        /// <summary>
        /// Refresca los datos (guarda y carga)
        /// </summary>
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
