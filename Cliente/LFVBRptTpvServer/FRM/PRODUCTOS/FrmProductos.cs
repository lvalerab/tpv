using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LFVBRptTpvServer.DATASETS.PRODUCTOS;

namespace LFVBRptTpvServer.FRM.PRODUCTOS
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }


        private void TSStocks_Click(object sender, EventArgs e)
        {
            try {
                FRMAUX.FrmFiltroStock FrmFiltro = new LFVBRptTpvServer.FRM.PRODUCTOS.FRMAUX.FrmFiltroStock();
                FrmFiltro.ShowDialog();
                DTProductos dtSetProductos = new DTProductos();
                string sqlFami = "select * from fami_familias";
                string wFami = "";
                foreach (DataGridViewRow dgvr in FrmFiltro.DGFamilias.SelectedRows)
                {
                    wFami += (wFami == "" ? "" : ",") + "'" + dgvr.Cells["cCodFami"].Value.ToString() + "'";
                }
                sqlFami+=(wFami==""?"":" where COD_FAMI in ("+wFami+")");
                DataSet datos = new DataSet();
                DataTable fami = new DataTable("FAMI_FAMILIAS");
                IGlobal.rellenar_datos(sqlFami,ref fami);
                fami.TableName = "FAMI_FAMILIAS";
                datos.Tables.Add(fami);
                

                string sqlSufa="select * from sufa_sub_familias"+(wFami==""?"":" where COD_FAMI in ("+wFami+")");
                DataTable sufa = new DataTable("SUFA_SUB_FAMILIAS");
                IGlobal.rellenar_datos(sqlSufa,ref sufa);
                sufa.TableName = "SUFA_SUB_FAMILIAS";
                datos.Tables.Add(sufa);

                DataTable prods = new DataTable("PROD_PRODUCTOS");
                string sqlProd="select * from prod_productos"+(wFami==""?"":" where COD_FAMI in ("+wFami+")")+" and EXISTENCIAS_PROD between "+FrmFiltro.TBoxStockMin.Text+" and "+FrmFiltro.TBoxStockMax.Text;
                IGlobal.rellenar_datos(sqlProd,ref prods);
                prods.TableName = "PROD_PRODUCTOS";
                datos.Tables.Add(prods);

                RPT.PRODUCTOS.RptProductosStock Rpt=new LFVBRptTpvServer.RPT.PRODUCTOS.RptProductosStock();
                Rpt.SetDataSource(datos);
                this.CRViewer.ReportSource=Rpt;
            } catch (Exception err) {
                MessageBox.Show("Error al cargar el reporte, causa: "+err.Message,"Error en carga del reporte");
            }
        }

        private void TSPrecios_Click(object sender, EventArgs e)
        {
            FRMAUX.FrmFiltroPrecios FrmFiltro = new LFVBRptTpvServer.FRM.PRODUCTOS.FRMAUX.FrmFiltroPrecios();
            FrmFiltro.ShowDialog();
            DTProductos dtSetProductos = new DTProductos();
            string sqlFami = "select * from fami_familias";
            string wFami = "";
            foreach (DataGridViewRow dgvr in FrmFiltro.DGFamilias.SelectedRows)
            {
                wFami += (wFami == "" ? "" : ",") + "'" + dgvr.Cells["cCodFami"].Value.ToString() + "'";
            }
            sqlFami += (wFami == "" ? "" : " where COD_FAMI in (" + wFami + ")");
            DataSet datos = new DataSet();
            DataTable fami = new DataTable("FAMI_FAMILIAS");
            IGlobal.rellenar_datos(sqlFami, ref fami);
            fami.TableName = "FAMI_FAMILIAS";
            datos.Tables.Add(fami);


            string sqlSufa = "select * from sufa_sub_familias" + (wFami == "" ? "" : " where COD_FAMI in (" + wFami + ")");
            DataTable sufa = new DataTable("SUFA_SUB_FAMILIAS");
            IGlobal.rellenar_datos(sqlSufa, ref sufa);
            sufa.TableName = "SUFA_SUB_FAMILIAS";
            datos.Tables.Add(sufa);

            DataTable prods = new DataTable("PROD_PRODUCTOS");
            string sqlProd = "select prod.*, prpr.PRECIO_VENTA as PVP_PROD, (prpr.PORC_IVA-1)*100 as IVA_PROD from prod_productos prod inner join PRPR_PRECIOS_PRODUCTO prpr on prod.ID_ELEM=prpr.ID_ELEM_PROD and prpr.vigente_precio='S' " + (wFami == "" ? "" : " where COD_FAMI in (" + wFami + ")");
            IGlobal.rellenar_datos(sqlProd, ref prods);
            prods.TableName = "PROD_PRODUCTOS";
            datos.Tables.Add(prods);

            RPT.PRODUCTOS.RptProductosPrecios Rpt = new LFVBRptTpvServer.RPT.PRODUCTOS.RptProductosPrecios();
            Rpt.SetDataSource(datos);
            this.CRViewer.ReportSource = Rpt;
        }
    }
}