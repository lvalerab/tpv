using System;
using System.Collections.Generic;
using System.Text;
using CLSBASE.INTERFACES;
using System.Data;
using MySql.Data.MySqlClient;

namespace CLSBASE.CRM.RESERVAS
{
    public class Reservas:IElementos
    {
        private const string _SQL = "select * from care_cab_reservas";

        private DataTable _datos;

        /// <summary>
        /// DataTable con todas las cabeceras de reservas disponibles
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

        private Reservas()
        {
            this.Refrescar();
        }

        private static Reservas _instancia;

        /// <summary>
        /// Metodo que obtiene la instancia de las Reservas (singleton)
        /// </summary>
        /// <returns>Reservas</returns>
        public static Reservas ObtenInstancia()
        {
            if (Reservas._instancia == null)
            {
                Reservas._instancia = new Reservas();
            }
            else
            {
                Reservas._instancia.Refrescar();
            }
            return Reservas._instancia;
        }

        /// <summary>
        /// Carga los datos al datatable
        /// </summary>
        private void Cargar()
        {
            IGlobal.rellenar_datos(_SQL, ref this._datos);
            this.CargarDatosAux();
            this._datos.DefaultView.Sort = "ID_ELEM desc";
        }

        private void CargarDatosAux()
        {
            PERSONAS.Personas auxP = PERSONAS.Personas.ObtenInstancia();
            if (!this._datos.Columns.Contains("NOMBRE_PERS_CARE"))
            {
                this._datos.Columns.Add(new DataColumn("NOMBRE_PERS_CARE",System.Type.GetType("System.String")));
            }
            foreach (DataRow d in this._datos.Rows)
            {
                PERSONAS.Persona aux = auxP.Buscar(Convert.ToInt64(d["ID_ELEM_PERS"]));
                d["NOMBRE_PERS_CARE"] = aux.datos["NOMBRE_PERS"].ToString();
            }
        }

        #region Miembros de IElementos

        public void Guardar(ref MySql.Data.MySqlClient.MySqlConnection cn, ref MySql.Data.MySqlClient.MySqlTransaction tr)
        {
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
                this.Guardar(ref cn, ref tr);
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

        #endregion
        /// <summary>
        /// Crea una nueva Reseerva
        /// <see cref="Documento"/>
        /// </summary>
        /// <returns>Reserva nueva</returns>
        public Reserva Nuevo()
        {
            DataRow regnew = this._datos.NewRow();
            return new Reserva(ref regnew, this);
        }

        /// <summary>
        /// Busca una reserva dada
        /// <see cref="Documento"/>
        /// </summary>
        /// <param name="codigo">ID de la reserva</param>
        /// <returns>Reserva encontrada o null si no encuentra nada</returns>
        public Reserva Buscar(Int64 codigo)
        {
            DataRow[] resultado = this._datos.Select("ID_ELEM=" + codigo.ToString());
            if (resultado.Length > 0)
            {
                return new Reserva(ref resultado[0], this);
            }
            else
            {
                return null;
            }
        }
    
    }
}
