using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFVBNewTPV.SISTEMA.CONFIGURACION
{
    public partial class FrmConfiguracion : FrmBase
    {
        public FrmConfiguracion():base()
        {
            InitializeComponent();
            this.CargaLblConfTicket();
            this.CargarConfiguracion();
        }

        private void CargarConfiguracion()
        {
            this.TBoxCadenaConexion.Text = global::LFVBNewTPV.Properties.Settings.Default.CADENA_CONEXION;
            this.TBoxTecladoVirtual.Text = global::LFVBNewTPV.Properties.Settings.Default.PROGRAMA_TECLADO;
            this.ChkMetodoWin7.Checked = global::LFVBNewTPV.Properties.Settings.Default.WIN7_METODO_TECLADO;
            this.TBoxPorIvaDef.Text = global::LFVBNewTPV.Properties.Settings.Default.COD_IVA_DEF;
            this.ChkModoDebug.Checked = global::LFVBNewTPV.Properties.Settings.Default.MODO_DEBUG;
            this.ChkActivarBarraBusq.Checked = global::LFVBNewTPV.Properties.Settings.Default.ACTIVAR_BARRA_BUSQ_RAP;
            this.TBoxTPVIdenClienteDef.Text = global::LFVBNewTPV.Properties.Settings.Default.CLIENTE_DEFECTO.ToString();
            this.ChkTPVDespuesGuardarND.Checked=global::LFVBNewTPV.Properties.Settings.Default.TPV_NUEVO_DESPUES_GUARDAR;
            this.TBoxImpresoraDef.Text = global::LFVBNewTPV.Properties.Settings.Default.TICKET_IMP_DEF;
            this.ChkPistLinAuto.Checked = global::LFVBNewTPV.Properties.Settings.Default.TPV_PIST_LINEA_AUTO;
            this.ChkTpvLinAgrupar.Checked = global::LFVBNewTPV.Properties.Settings.Default.TPV_LIN_AGRUPAR_LINEAS;
            this.TBoxTipoDocNuevo.Text = global::LFVBNewTPV.Properties.Settings.Default.TPV_TIPO_DOC_NUEVO_DEF;
            this.ChkTpvCobrarImpTkc.Checked = global::LFVBNewTPV.Properties.Settings.Default.TPV_TICK_IMPRCOBR;
            this.ChkTpvCobrGuaDoc.Checked= global::LFVBNewTPV.Properties.Settings.Default.TPV_DOC_GUARDARCOBR;
            this.ChkTpvDocuGuaSinLiq.Checked = global::LFVBNewTPV.Properties.Settings.Default.TPV_DOC_GUARDASINLIQ;
            this.ChkTpvBloquearDocuMod.Checked = global::LFVBNewTPV.Properties.Settings.Default.TPV_DOC_BLOQUEARANT;
            this.ChkPermitirProductosSinExistencias.Checked = global::LFVBNewTPV.Properties.Settings.Default.TPV_PROD_PERMITIR_SIN_EXISTENCIAS;
            this.ChkBoxMostrarBtnProductosTPV.Checked = global::LFVBNewTPV.Properties.Settings.Default.TPV_USO_TECLAS_RAPIDAS;
            this.TBoxRutaImagenProd.Text = global::LFVBNewTPV.Properties.Settings.Default.PROD_RUTA_IMAGENES;
            this.TBoxRutaMysqlDump.Text = global::LFVBNewTPV.Properties.Settings.Default.MYSQDUMP_RUTA;
            this.CargaPlantImpresora();
        }

        private void GuardaConfiguracion()
        {
            try
            {
                global::LFVBNewTPV.Properties.Settings.Default.CADENA_CONEXION = this.TBoxCadenaConexion.Text;
                global::LFVBNewTPV.Properties.Settings.Default.PROGRAMA_TECLADO = this.TBoxTecladoVirtual.Text;
                global::LFVBNewTPV.Properties.Settings.Default.WIN7_METODO_TECLADO=this.ChkMetodoWin7.Checked;
                global::LFVBNewTPV.Properties.Settings.Default.MODO_DEBUG = this.ChkModoDebug.Checked;
                global::LFVBNewTPV.Properties.Settings.Default.COD_IVA_DEF = this.TBoxPorIvaDef.Text;
                global::LFVBNewTPV.Properties.Settings.Default.ACTIVAR_BARRA_BUSQ_RAP = this.ChkActivarBarraBusq.Checked;
                global::LFVBNewTPV.Properties.Settings.Default.CLIENTE_DEFECTO = Convert.ToInt64(this.TBoxTPVIdenClienteDef.Text);
                global::LFVBNewTPV.Properties.Settings.Default.TPV_NUEVO_DESPUES_GUARDAR = this.ChkTPVDespuesGuardarND.Checked;
                global::LFVBNewTPV.Properties.Settings.Default.TICKET_IMP_DEF = this.TBoxImpresoraDef.Text;
                global::LFVBNewTPV.Properties.Settings.Default.TPV_PIST_LINEA_AUTO = this.ChkPistLinAuto.Checked;
                global::LFVBNewTPV.Properties.Settings.Default.TPV_LIN_AGRUPAR_LINEAS = this.ChkTpvLinAgrupar.Checked;
                global::LFVBNewTPV.Properties.Settings.Default.TPV_TICK_IMPRCOBR = this.ChkTpvCobrarImpTkc.Checked;
                global::LFVBNewTPV.Properties.Settings.Default.TPV_DOC_GUARDARCOBR=this.ChkTpvCobrGuaDoc.Checked;
                global::LFVBNewTPV.Properties.Settings.Default.TPV_DOC_GUARDASINLIQ = this.ChkTpvDocuGuaSinLiq.Checked;
                global::LFVBNewTPV.Properties.Settings.Default.TPV_DOC_BLOQUEARANT = this.ChkTpvBloquearDocuMod.Checked;
                global::LFVBNewTPV.Properties.Settings.Default.TPV_PROD_PERMITIR_SIN_EXISTENCIAS = this.ChkPermitirProductosSinExistencias.Checked;
                global::LFVBNewTPV.Properties.Settings.Default.TPV_TIPO_DOC_NUEVO_DEF = this.TBoxTipoDocNuevo.Text;
                global::LFVBNewTPV.Properties.Settings.Default.TPV_USO_TECLAS_RAPIDAS = this.ChkBoxMostrarBtnProductosTPV.Checked;
                global::LFVBNewTPV.Properties.Settings.Default.PROD_RUTA_IMAGENES = this.TBoxRutaImagenProd.Text;
                global::LFVBNewTPV.Properties.Settings.Default.MYSQDUMP_RUTA = this.TBoxRutaMysqlDump.Text;
                this.GuardaPlantImpresora();
                global::LFVBNewTPV.Properties.Settings.Default.Save();
                Program.CargaConfiguracionLibrerias();
                SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso("Configuración guardada con éxito");
                
            }
            catch (Exception err)
            {
                SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
            }
        }

        private void CargaLblConfTicket()
        {
            this.LblTicketCamposCabecera.Text = "Campos disponibles para la cabecera:\n";
            this.LblTicketCamposCabecera.Text += "{NUM_DOC} - Número de Ticket\n";
            this.LblTicketCamposCabecera.Text += "{FECHA_DOC}- Fecha de la factura*\n";

            this.LblTicketCamposPie.Text = "Campos disponibles para el pie total\n";
            this.LblTicketCamposPie.Text = "Nota: El formato es una linea para el literal y otra para el campo\n";
            this.LblTicketCamposPie.Text += "{TOTAL_BRUTO}  - Subtotal";
            this.LblTicketCamposPie.Text += "{TOTAL_IVA}  -Importe del IVA";
            this.LblTicketCamposPie.Text += "{IMPORTE_TOTAL} -Total Importe";
        }

        private void GuardaPlantImpresora()
        {
            if (this.RTBoxPieTotalesTicket.Lines.Length % 2 != 0)
            {
                throw new Exception("El número de lineas del pie de total tiene que ser par");
            }
            ClsUtils.TICKETS.ImpresionTicket.PlantCab = this.RTBoxCabeceraTicket.Lines;
            ClsUtils.TICKETS.ImpresionTicket.PlantTot = this.RTBoxPieTotalesTicket.Lines;
            ClsUtils.TICKETS.ImpresionTicket.PlantPie = this.RTBoxPieTicket.Lines;
            ClsUtils.TICKETS.ImpresionTicket.GuardaPlantilla(ClsUtils.TICKETS.TIPO_PLANTILLAS_TICKET.TICKET);
            ClsUtils.TICKETS.ImpresionTicket.PlantCab = this.RTBoxCabeceraReserva.Lines;
            ClsUtils.TICKETS.ImpresionTicket.PlantTot = this.RTBoxPieTotalesReserva.Lines;
            ClsUtils.TICKETS.ImpresionTicket.PlantPie = this.RTBoxPieReserva.Lines;
            ClsUtils.TICKETS.ImpresionTicket.GuardaPlantilla(ClsUtils.TICKETS.TIPO_PLANTILLAS_TICKET.RESERVA);
        }

        private void CargaPlantImpresora()
        {
            ClsUtils.TICKETS.ImpresionTicket.CargaPlantilla(ClsUtils.TICKETS.TIPO_PLANTILLAS_TICKET.TICKET);
            this.RTBoxCabeceraTicket.Lines = ClsUtils.TICKETS.ImpresionTicket.PlantCab;
            this.RTBoxPieTotalesTicket.Lines = ClsUtils.TICKETS.ImpresionTicket.PlantTot;
            this.RTBoxPieTicket.Lines = ClsUtils.TICKETS.ImpresionTicket.PlantPie;
            ClsUtils.TICKETS.ImpresionTicket.CargaPlantilla(ClsUtils.TICKETS.TIPO_PLANTILLAS_TICKET.RESERVA);
            this.RTBoxCabeceraReserva.Lines = ClsUtils.TICKETS.ImpresionTicket.PlantCab;
            this.RTBoxPieTotalesReserva.Lines = ClsUtils.TICKETS.ImpresionTicket.PlantTot;
            this.RTBoxPieReserva.Lines = ClsUtils.TICKETS.ImpresionTicket.PlantPie;
        }

        private void BtnCerrarConf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardarConf_Click(object sender, EventArgs e)
        {
            this.GuardaConfiguracion();
        }

        private void BtnSeleccionImpresora_Click(object sender, EventArgs e)
        {
            this.DlgImpresora.ShowDialog();
            this.TBoxImpresoraDef.Text = this.DlgImpresora.PrinterSettings.PrinterName;
        }

        private void BtnBuscarRutaProductos_Click(object sender, EventArgs e)
        {
            this.DlgBuscarCarpeta.ShowDialog();
            this.TBoxRutaImagenProd.Text = this.DlgBuscarCarpeta.SelectedPath;
        }
    }
}