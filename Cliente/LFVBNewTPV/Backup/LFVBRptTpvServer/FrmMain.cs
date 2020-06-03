using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFVBRptTpvServer
{
    public partial class FrmMain : CTCBASE.cFormBase
    {


        public FrmMain():base()
        {
            InitializeComponent();
            
        }

        private void BtnReportesProductos_Click(object sender, EventArgs e)
        {
            FRM.PRODUCTOS.FrmProductos FrmProdMain = new LFVBRptTpvServer.FRM.PRODUCTOS.FrmProductos();
            FrmProdMain.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReportesClientess_Click(object sender, EventArgs e)
        {
            FRM.CLIENTES.FrmClientes FrmClie = new LFVBRptTpvServer.FRM.CLIENTES.FrmClientes();
            FrmClie.Show();
        }

        private void BtnReportesFacturacion_Click(object sender, EventArgs e)
        {
            FRM.VENTAS.FrmVentas FrmVen = new LFVBRptTpvServer.FRM.VENTAS.FrmVentas();
            FrmVen.Show();
        }

        private void cBoton1_Click(object sender, EventArgs e)
        {
            FRM.FrmConfiguracion FrmConf = new LFVBRptTpvServer.FRM.FrmConfiguracion();
            FrmConf.Show();
        }
    }
}