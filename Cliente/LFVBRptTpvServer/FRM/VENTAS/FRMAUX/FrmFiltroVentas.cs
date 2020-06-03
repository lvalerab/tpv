using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFVBRptTpvServer.FRM.VENTAS.FRMAUX
{
    public partial class FrmFiltroVentas : CTCBASE.cFormBase
    {
        private bool _aceptado;

        public bool aceptado
        {
            get
            {
                return this._aceptado;
            }
            set
            {
                this._aceptado = value;
            }
        }

        public FrmFiltroVentas():base()
        {
            InitializeComponent();
            this.RellenaDatos();
            this.aceptado = false;
        }

        public void RellenaDatos()
        {
            DataTable tido = new DataTable();
            IGlobal.rellenar_datos("select * from tido_tipo_documento", ref tido);
            this.DGTiposDocus.DataSource = tido;
            this.TPFechaDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.TPFechaHasta.Value = DateTime.Now;
        }

        private void TSAceptar_Click(object sender, EventArgs e)
        {
            this.aceptado = true;
            this.Close();
        }

        private void TSCancelar_Click(object sender, EventArgs e)
        {
            this.aceptado = false;
            this.Close();
        }
    }
}