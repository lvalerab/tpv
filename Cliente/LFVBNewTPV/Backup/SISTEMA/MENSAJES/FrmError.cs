using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFVBNewTPV.SISTEMA.MENSAJES
{
    public partial class FrmError : FrmMensajeBase
    {
        private String mensaje;
        private String err;

        public FrmError(string Mensaje):base()
        {
            InitializeComponent();
        }

        public FrmError(Exception err):base()
        {
            InitializeComponent();
            this.TBoxDescripcion.Text = err.Message;
            if (global::LFVBNewTPV.Properties.Settings.Default.MODO_DEBUG)
            {
                this.LblStackTrace.Visible = true;
                this.TBoxStackTrace.Text = err.StackTrace;
                this.TBoxStackTrace.Visible = true;
            }
            else
            {
                this.LblStackTrace.Visible = false;
                this.TBoxStackTrace.Visible = false;
                this.Height = this.Height - 148;
            }
            this.ShowDialog();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            SISTEMA.CONFIGURACION.FrmConfiguracion FrmConf = new LFVBNewTPV.SISTEMA.CONFIGURACION.FrmConfiguracion();
            FrmConf.ShowDialog();
        }
    }
}