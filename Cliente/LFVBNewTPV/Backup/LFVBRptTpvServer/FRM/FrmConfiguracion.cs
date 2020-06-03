using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFVBRptTpvServer.FRM
{
    public partial class FrmConfiguracion : CTCBASE.cFormBase
    {
        public FrmConfiguracion():base()
        {
            InitializeComponent();
            this.CargaDatos();
        }

        private void CargaDatos()
        {
            this.TboxCadConexion.Text = global::LFVBRptTpvServer.Properties.Settings.Default.CAD_CONEXION;
        }

        private void TSGuardar_Click(object sender, EventArgs e)
        {
            global::LFVBRptTpvServer.Properties.Settings.Default.CAD_CONEXION = this.TboxCadConexion.Text;
            global::LFVBRptTpvServer.Properties.Settings.Default.Save();
            Application.Restart();
        }
    }
}