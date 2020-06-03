using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFVBNewTPV.SISTEMA.MENSAJES
{
    public partial class FrmAviso : FrmMensajeBase
    {
        public FrmAviso(string texto):base()
        {
            InitializeComponent();
            this.LblMensaje.Text = texto;
            this.ShowDialog();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}