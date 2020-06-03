using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CLSRPT.VISOR
{
    public partial class FrmVisorBase : CTCBASE.cFormBase
    {
        public FrmVisorBase(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt):base()
        {
            InitializeComponent();
            this.RptViewer.ReportSource = rpt;
        }
    }
}