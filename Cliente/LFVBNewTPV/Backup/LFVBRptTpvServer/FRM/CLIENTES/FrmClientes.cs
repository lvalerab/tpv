using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFVBRptTpvServer.FRM.CLIENTES
{
    public partial class FrmClientes : CTCBASE.cFormBase
    {
        public FrmClientes():base()
        {
            InitializeComponent();
            this.RellenarDatos();
        }

        public void RellenarDatos()
        {
            DataTable pers = new DataTable();
            IGlobal.rellenar_datos("select * from pers_personas", ref pers);
            DataSet datos = new DataSet();
            pers.TableName = "PERS_PERSONAS";
            datos.Tables.Add(pers);

            RPT.CLIENTES.RptClientes rpt = new LFVBRptTpvServer.RPT.CLIENTES.RptClientes();
            rpt.SetDataSource(datos);
            this.CRViewer.ReportSource = rpt;
        }
    }
}