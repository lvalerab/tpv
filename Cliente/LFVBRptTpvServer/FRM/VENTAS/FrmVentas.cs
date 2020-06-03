using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFVBRptTpvServer.FRM.VENTAS
{
    public partial class FrmVentas : CTCBASE.cFormBase
    {
        public FrmVentas():base()
        {
            InitializeComponent();
        }

        private void TSBtnLstVentas_Click(object sender, EventArgs e)
        {
            FRMAUX.FrmFiltroVentas FrmFiltro = new LFVBRptTpvServer.FRM.VENTAS.FRMAUX.FrmFiltroVentas();
            FrmFiltro.ShowDialog();
            if (FrmFiltro.aceptado)
            {
                string sql = "select cado.ID_ELEM, cado.COD_TIDO, (select DESCR_TIDO from tido_tipo_documento tido where tido.COD_TIDO=cado.COD_TIDO) as DESCR_TIDO, NUMERO_CADO, ANYO_CADO, FECHA_ENTRADA_CADO, pers.NIF_PERS as NIF_CLIENTE, pers.NOMBRE_PERS as NOMBRE_CLIENTE, (select sum(TOTAL_LIDO) from lido_lineas_documento lido where lido.ID_ELEM_CAB=cado.ID_ELEM) as IMPORTE_CADO, PAGADO_CADO from cado_cabecera_documento cado inner join pers_personas pers on cado.ID_ELEM_PERS=pers.ID_ELEM";
                string where = "";
                string tido = "";
                foreach (DataGridViewRow dgvr in FrmFiltro.DGTiposDocus.SelectedRows)
                {
                    tido += (tido == "" ? "" : ",") + "'" + dgvr.Cells["cCodTido"].Value.ToString() + "'";
                }
                if (tido != "")
                {
                    where += (where == "" ? " where " : " and ") + " COD_TIDO in (" + tido + ")";
                }
                if (FrmFiltro.ChkFiltroFechas.Checked)
                {
                    where += (where == "" ? " where " : " and ") + " FECHA_ENTRADA_CADO BETWEEN '" + FrmFiltro.TPFechaDesde.Value.ToString("yyyy-MM-dd") + "' and '" + FrmFiltro.TPFechaHasta.Value.ToString("yyyy-MM-dd") + "'";
                }
                sql += where;
                sql += " order by FECHA_ENTRADA_CADO desc";
                DataTable cado=new DataTable();
                IGlobal.rellenar_datos(sql, ref cado);
                cado.TableName = "CADO_CABECERA_DOCUMENTO";
                DataSet dt = new DataSet();
                dt.Tables.Add(cado);
                RPT.VENTAS.RptVentas RptV = new LFVBRptTpvServer.RPT.VENTAS.RptVentas();
                RptV.SetDataSource(dt);
                this.CRViewer.ReportSource = RptV;
            }           
        }

        private void TSBtnLstIva_Click(object sender, EventArgs e)
        {
            FRMAUX.FrmFiltroVentas FrmFiltro = new LFVBRptTpvServer.FRM.VENTAS.FRMAUX.FrmFiltroVentas();
            FrmFiltro.ShowDialog();
            if (FrmFiltro.aceptado)
            {
                string sql = "select cado.ID_ELEM, cado.COD_TIDO, (select DESCR_TIDO from tido_tipo_documento tido where tido.COD_TIDO=cado.COD_TIDO) as DESCR_TIDO, NUMERO_CADO, ANYO_CADO, FECHA_ENTRADA_CADO, pers.NIF_PERS as NIF_CLIENTE, pers.NOMBRE_PERS as NOMBRE_CLIENTE, (select sum(TOTAL_LIDO) from lido_lineas_documento lido where lido.ID_ELEM_CAB=cado.ID_ELEM) as IMPORTE_CADO, PAGADO_CADO from cado_cabecera_documento cado inner join pers_personas pers on cado.ID_ELEM_PERS=pers.ID_ELEM";
                string where = "";
                string tido = "";
                foreach (DataGridViewRow dgvr in FrmFiltro.DGTiposDocus.SelectedRows)
                {
                    tido += (tido == "" ? "" : ",") + "'" + dgvr.Cells["cCodTido"].Value.ToString() + "'";
                }
                if (tido != "")
                {
                    where += (where == "" ? " where " : " and ") + " cado.COD_TIDO in (" + tido + ")";
                }
                if (FrmFiltro.ChkFiltroFechas.Checked)
                {
                    where += (where == "" ? " where " : " and ") + " cado.FECHA_ENTRADA_CADO BETWEEN '" + FrmFiltro.TPFechaDesde.Value.ToString("yyyy-MM-dd") + "' and '" + FrmFiltro.TPFechaHasta.Value.ToString("yyyy-MM-dd") + "'";
                }
                sql += where;
                sql += " order by FECHA_ENTRADA_CADO desc";
                DataTable cado = new DataTable();
                IGlobal.rellenar_datos(sql, ref cado);
                cado.TableName = "CADO_CABECERA_DOCUMENTO";

                sql = "select cado.COD_TIDO, cado.NUMERO_CADO, cado.ANYO_CADO, lido.* from lido_lineas_documento lido inner join cado_cabecera_documento cado on lido.ID_ELEM_CAB=cado.ID_ELEM " + where+" order by lido.ID_ELEM, cado.ID_ELEM";
                DataTable lido = new DataTable();
                IGlobal.rellenar_datos(sql, ref lido);
                lido.TableName = "LIDO_LINEAS_DOCUMENTO";
                DataSet dt = new DataSet();
                //dt.Tables.Add(cado);
                dt.Tables.Add(lido);
                RPT.VENTAS.RptIva RIva = new LFVBRptTpvServer.RPT.VENTAS.RptIva();
                RIva.SetDataSource(dt);
                this.CRViewer.ReportSource = RIva;
            }
        }
    }
}