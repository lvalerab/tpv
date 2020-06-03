using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLSBASE.CRM.DOCUMENTOS;

namespace LFVBNewTPV.TPV.FrmAuxiliares
{
    public partial class FrmTipoDocumento : SISTEMA.FrmBase
    {
        private string _TipoSel;
        public string TipoSel
        {
            set
            {
                this._TipoSel = value;
            }
            get
            {
                return this._TipoSel;
            }
        }

        private void InicializarDesplegables()
        {
            TipoDocumentos TipDocu = TipoDocumentos.ObtenInstancia();
            this.CmbTiposDocumento.DataSource = TipDocu.Datos.Copy();
            this.CmbTiposDocumento.ValueMember = "COD_TIDO";
            this.CmbTiposDocumento.DisplayMember = "DESCR_TIDO";
            this.CmbTiposDocumento.SelectedValue = global::LFVBNewTPV.Properties.Settings.Default.TPV_TIPO_DOC_NUEVO_DEF;
        }

        public FrmTipoDocumento()
        {
            InitializeComponent();
            this.InicializarDesplegables();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.TipoSel = "";
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.TipoSel = this.CmbTiposDocumento.SelectedValue.ToString();
            this.Close();
        }
    }
}