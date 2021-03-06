using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFVBRptTpvServer.FRM.PRODUCTOS.FRMAUX
{
    public partial class FrmFiltroStock: Form
    {
        private bool _seleccion;
        public bool Seleccion
        {
            get
            {
                return this._seleccion;
            }
            set
            {
                this._seleccion = value;
            }
        }
        public FrmFiltroStock()
        {
            InitializeComponent();
            this.InicializarDatos();
            this.Seleccion = false;
        }

        public void InicializarDatos()
        {
            DataTable familias = new DataTable();
            IGlobal.rellenar_datos("select * from fami_familias", ref familias);
            this.DGFamilias.DataSource = familias;
            this.TBoxStockMin.Text = "0";
            this.TBoxStockMax.Text = "999";
        }

        private void TSBtnAceptar_Click(object sender, EventArgs e)
        {
            this.Seleccion = true;
            this.Close();
        }

        private void TSBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Seleccion = false;
            this.Close();
        }
    }
}