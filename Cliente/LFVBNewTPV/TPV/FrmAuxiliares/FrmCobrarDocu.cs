using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLSBASE.CRM.DOCUMENTOS;
using System.Collections;

namespace LFVBNewTPV.TPV.FrmAuxiliares
{
    public partial class FrmCobrarDocu : SISTEMA.FrmBase
    {
        private Documento doc;
        private double TotPagado;
        private double TotDocu;
        public FrmCobrarDocu(Documento doc):base()
        {
            InitializeComponent();            
            this.doc = doc;
            this.RefrescaPrecios();
        }

        public void RefrescaPrecios()
        {
            Hashtable aux = this.doc.ObtenTotalesDocumento();
            Double pendiente = 0;
            if(aux.Count>=2) {
                this.LblImporteTotal.Text = aux["PVP"].ToString()+" €";
                this.TotDocu = Convert.ToDouble(aux["PVP"].ToString() != "" ? aux["PVP"].ToString() : "0");
                pendiente = Convert.ToDouble((aux["PVP"].ToString() != "" ? aux["PVP"].ToString() : "0"));
                this.LblPagadoAnteriormente.Text = (this.doc.datos["PAGADO_CADO"].ToString() != "" ? this.doc.datos["PAGADO_CADO"].ToString() : "0") + " €";
                pendiente-=Convert.ToDouble((this.doc.datos["PAGADO_CADO"].ToString() != "" ? this.doc.datos["PAGADO_CADO"].ToString() : "0"));
                this.LblTotalPendiente.Text=pendiente.ToString()+" €";
                double pagado = 0;
                double.TryParse(this.TBoxEntregado.Text.Trim(),out pagado);                
                if(pagado>pendiente) 
                {
                    this.LblDevolver.Text=(pagado-pendiente).ToString()+" €";
                    this.TotPagado=Convert.ToDouble((aux["PVP"].ToString() != "" ? aux["PVP"].ToString() : "0"));
                } else {
                    this.LblDevolver.Text="0 €";
                    this.TotPagado = pagado + Convert.ToDouble((this.doc.datos["PAGADO_CADO"].ToString() != "" ? this.doc.datos["PAGADO_CADO"].ToString() : "0"));
                }
            }
        }

        private void TBoxEntregado_TextChanged(object sender, EventArgs e)
        {
            this.RefrescaPrecios();
        }

        private void BtnCobrar_Click(object sender, EventArgs e)
        {   
            bool correcto=true;
            if (!global::LFVBNewTPV.Properties.Settings.Default.TPV_COBR_COBROSCUENTE && this.TotPagado < this.TotDocu)
            {
                correcto = false;
            }
            if (correcto)
            {
                this.doc.datos["PAGADO_CADO"] = this.TotPagado;
                this.Close();
            }
            else
            {
                SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso("Debe de coincidir lo cobrado con el total de la factura");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}