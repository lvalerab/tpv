using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFVBNewTPV.SISTEMA.VALIDACION
{
    public partial class FrmValidarUsuario : FrmBase
    {
        internal DialogResult resultado;

        public FrmValidarUsuario():base()
        {
            InitializeComponent();
            this.resultado = DialogResult.No;
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            this.resultado = DialogResult.Yes;
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.resultado = DialogResult.Cancel;
            this.Close();
        }

        private void BtnTeclado_Click(object sender, EventArgs e)
        {
            ClsUtils.IGlobal.teclado.Lanzar();
        }

    }
}