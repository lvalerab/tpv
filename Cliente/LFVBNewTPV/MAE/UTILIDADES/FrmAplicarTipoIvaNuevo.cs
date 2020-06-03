using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLSBASE.CRM.PRODUCTOS;

namespace LFVBNewTPV.MAE.UTILIDADES
{
    public partial class FrmAplicarTipoIvaNuevo : CTCBASE.cFormBase
    {
        public FrmAplicarTipoIvaNuevo():base()
        {
            InitializeComponent();
            IVA lstiva = IVA.ObtenInstancia();
            this.CmbTipoOrigen.DataSource = lstiva.Datos.Copy();
            this.CmbTipoOrigen.DisplayMember = "DESCR_TIVA";
            this.CmbTipoOrigen.ValueMember = "COD_TIVA";
            this.CmbTipoDestino.DataSource = lstiva.Datos.Copy();
            this.CmbTipoDestino.DisplayMember = "DESCR_TIVA";
            this.CmbTipoDestino.ValueMember = "COD_TIVA";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cambiar el tipo de iva a los productos seleccionados?", "Cambio de tipo de IVA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes
                && (this.CmbTipoDestino.SelectedValue.ToString() != this.CmbTipoOrigen.SelectedValue.ToString()))
            {
                MessageBox.Show("Se han cambiado " + IVA.AplicaTipoIvaProds(this.CmbTipoOrigen.SelectedValue.ToString(), this.CmbTipoDestino.SelectedValue.ToString(), this.ChkAplicarPVP.Checked));
            }
            this.Close();
        }
    }
}