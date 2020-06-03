using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLSBASE.CRM.DOCUMENTOS;
using CLSBASE.CRM.PERSONAS;
using CLSBASE.CRM.PRODUCTOS;
using System.Collections;
using ClsUtils.TICKETS;
using CLSBASE.CRM.RESERVAS;

namespace LFVBNewTPV.TPV
{
    public partial class FrmDocumento : SISTEMA.FrmBase
    {
        private Personas _pers;
        private Productos _prods;

        private Documento _doc;

        private Reserva _Reserva;

        public Reserva reserva
        {
            set
            {
                this._Reserva = value;
            }
            get
            {
                return this._Reserva;
            }
        }

        private bool CargaFrm;

        private void RellenaDatosDireccion(Int64 idpers)
        {
            this.doc.datos["ID_ELEM_PERS"] = idpers;
            Persona pers = this._pers.Buscar(idpers);
            this.LblIdCliente.Text = pers.datos["ID_ELEM"].ToString();
            this.LblNifCliente.Text = pers.datos["NIF_PERS"].ToString();
            this.LblNombreCliente.Text = pers.datos["NOMBRE_PERS"].ToString();
            this.LblDireccionCliente.Text = pers.datos["DIRE_PERS"].ToString();
            this.LblDireccion2Cliente.Text = "(" + pers.datos["CODPOSTAL_PERS"].ToString() + ") " + pers.datos["POBLACION_PERS"].ToString() + " " + pers.datos["PROVINCIA_PERS"].ToString();
        }

        public Documento doc
        {
            set
            {
                this._doc = value;
                try
                {
                    if (this._doc != null)
                    {
                        this._pers = Personas.ObtenInstancia();
                        this._prods = Productos.ObtenInstancia();
                        this.LblAnyoDocumento.Text = this._doc.datos["ANYO_CADO"].ToString().PadLeft(4, '0');
                        this.LblNumeroDocumento.Text = this._doc.datos["NUMERO_CADO"].ToString().PadLeft(10, '0');
                        this.LblTipoDocumento.Text = this._doc.datos["COD_TIDO"].ToString().PadLeft(2, ' ');
                        if (this._doc.datos["FECHA_ENTRADA_CADO"].ToString() != "")
                        {
                            this.LblFechaDocumento.Text = ((DateTime)this._doc.datos["FECHA_ENTRADA_CADO"]).ToLongDateString();
                        }
                        else
                        {
                            this.LblFechaDocumento.Text = DateTime.Now.ToLongDateString();
                        }
                        if (this._doc.datos["ID_ELEM_PERS"].ToString() != "")
                        {
                            this.RellenaDatosDireccion(Convert.ToInt64(this._doc.datos["ID_ELEM_PERS"].ToString()));
                        }
                        else
                        {
                            this._doc.datos["ID_ELEM_PERS"] = global::LFVBNewTPV.Properties.Settings.Default.CLIENTE_DEFECTO;
                            this.RellenaDatosDireccion(global::LFVBNewTPV.Properties.Settings.Default.CLIENTE_DEFECTO);
                        }
                        this.DGLineas.DataSource = this._doc.lineas;
                        Hashtable auxt = this._doc.ObtenTotalesDocumento();
                        double totalfact=0;
                        if(auxt.Count>=2) {
                            this.LblTotalBruto.Text = auxt["PVB"].ToString()+" €";
                            this.LblTotalDocu.Text = auxt["PVP"].ToString() + " €";
                            totalfact=Convert.ToDouble((auxt["PVP"].ToString()!=""?auxt["PVP"].ToString():"0"));
                        }
                        this.LblTotalPagado.Text = (this._doc.datos["PAGADO_CADO"].ToString()!=""?this._doc.datos["PAGADO_CADO"].ToString():"0.00") + " €";
                        if (global::LFVBNewTPV.Properties.Settings.Default.TPV_DOC_BLOQUEARANT && this._doc.datos["ID_ELEM"].ToString() != "")
                        {
                            this.BtnBuscarPersona.Enabled = false;
                            this.BtnGuardar.Enabled = false;
                            this.BtnGuardarLinea.Enabled = false;
                            this.BtnBuscarPersona.Enabled = false;
                            this.BtnBuscarProducto.Enabled = false;
                            this.BtnCobrar.Enabled = false;
                            this.TBoxRefProdIn.Enabled = false;
                            this.BtnEliminarLinea.Enabled = false;
                            this.btnSelectProds.Enabled = false;
                        }
                    }
                }
                catch (Exception err)
                {
                    SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                }
            }
            get
            {
                return this._doc;
            }
        }

        public void CargaCompOpcs()
        {
            this.BtnGuardar.Visible = global::LFVBNewTPV.Properties.Settings.Default.TPV_DOC_GUARDASINLIQ;
            this.btnSelectProds.Visible = global::LFVBNewTPV.Properties.Settings.Default.TPV_USO_TECLAS_RAPIDAS;
        }

        public FrmDocumento(Documento p):base()
        {
            InitializeComponent();
            this.CargaCompOpcs();
            this.CargaFrm = false;
            this.doc = p;
        }

        public FrmDocumento(Documento p, string tipo)
            : base()
        {
            InitializeComponent();
            this.CargaCompOpcs();
            this.CargaFrm = false;
            this.doc = p;
            this.LblTipoDocumento.Text = tipo;
            this.doc.datos["COD_TIDO"] = tipo;
        }

        private void GuardarDatosReserva()
        {
            if (this.reserva != null)
            {
                this.reserva.datos["ID_ELEM_CADO"] = this.doc.datos["ID_ELEM"];
                this.reserva.datos["NUMERO_CADO"] = this.doc.datos["COD_TIDO"].ToString().PadLeft(2, ' ') + "/" + this.doc.datos["NUMERO_CADO"].ToString().PadLeft(10, '0') + "/" + this.doc.datos["ANYO_CADO"].ToString().PadLeft(4, '0');
                this.reserva.datos["COD_ESRE"] = "FAC";
                this.reserva.datos["FECHA_ESRE"] = DateTime.Now;
                this.reserva.Guardar();
            }
        }

        #region "Trato de lineas"
        private void CargaDatosLineaProd(Int64 idprod)
        {
            Producto aux = this._prods.Buscar(idprod);
            if (aux != null)
            {
                this.TBoxRefProdIn.Text = aux.datos["COD_BARRAS"].ToString();
                this.TBoxIdProd.Text = idprod.ToString();
                this.TBoxTextoLinIn.Text = aux.datos["NOMBRE_PROD"].ToString();
                this.LblPrecioBrutoIn.Text = aux.precio["PRECIO_BRUTO"].ToString();
                this.LblPorIvaIn.Text = aux.precio["PORC_IVA"].ToString();
                if (this.TBoxCantidadIn.Text != "1" && this.TBoxCantidadIn.Text != "-1")
                {
                    this.TBoxCantidadIn.Text = "1";
                }
                this.TBoxPrecioVentaIn.Text = aux.precio["PRECIO_VENTA"].ToString();
            }
            else
            {
                this.TBoxRefProdIn.Text = "";
                this.TBoxIdProd.Text = "";
                this.TBoxTextoLinIn.Text = "";
                this.LblPrecioBrutoIn.Text = "0.00";
                this.LblPorIvaIn.Text = "0.00";
                this.TBoxPrecioVentaIn.Text = "0.00";
            }
            this.TBoxCantidadIn.Focus();
        }
        
        private void GuardaLinea()
        {

            DataRow[] dr = this.doc.lineas.Select("ID_ELEM_PROD=" + (this.TBoxIdProd.Text.Trim() != "" ? this.TBoxIdProd.Text.Trim() : "0"));
            Productos lstp = Productos.ObtenInstancia();
            DataRow[] encontrado = lstp.Datos.Select("ID_ELEM='" + (this.TBoxIdProd.Text.Trim() != "" ? this.TBoxIdProd.Text.Trim() : "0") + "'");
            if ((this.TBoxIdProd.Text.Trim() != "" ? this.TBoxIdProd.Text.Trim() : "0")!="0" && dr.Length > 0 && global::LFVBNewTPV.Properties.Settings.Default.TPV_LIN_AGRUPAR_LINEAS)
            {
                double existencias=0;
                double.TryParse(encontrado[0]["EXISTENCIAS_PROD"].ToString(),out existencias);
                if (!global::LFVBNewTPV.Properties.Settings.Default.TPV_PROD_PERMITIR_SIN_EXISTENCIAS && (existencias- (Convert.ToInt32(dr[0]["CANTIDAD_LIDO"]) + Convert.ToInt32(this.TBoxCantidadIn.Text))) < 0)
                {
                    SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso("El producto no tiene existencias");
                }
                else
                {
                    dr[0]["CANTIDAD_LIDO"] = Convert.ToInt32(dr[0]["CANTIDAD_LIDO"]) + Convert.ToInt32(this.TBoxCantidadIn.Text);
                    dr[0]["TOTAL_LIDO"] = Convert.ToInt32(dr[0]["CANTIDAD_LIDO"]) * Convert.ToDouble(dr[0]["PVP_LIDO"]);
                    Hashtable auxt = this._doc.ObtenTotalesDocumento();
                    if (auxt.Count >= 2)
                    {
                        this.LblTotalBruto.Text = auxt["PVB"].ToString() + " €";
                        this.LblTotalDocu.Text = auxt["PVP"].ToString() + " €";
                    }
                    this.LblTotalPagado.Text = (this._doc.datos["PAGADO_CADO"].ToString() != "" ? this._doc.datos["PAGADO_CADO"].ToString() : "0.00") + " €";
                }
            }
            else
            {
                bool ConExistencias=true;             
                if(this.TBoxIdProd.Text.Trim()!="" && encontrado.Length>0) {
                    double existencias=0;
                    double.TryParse(encontrado[0]["EXISTENCIAS_PROD"].ToString(),out existencias);   
                    if (!global::LFVBNewTPV.Properties.Settings.Default.TPV_PROD_PERMITIR_SIN_EXISTENCIAS && (existencias- Convert.ToInt32(this.TBoxCantidadIn.Text)) < 0)
                    {
                        SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso("El producto no tiene existencias");
                        ConExistencias=false;
                    } else {
                        ConExistencias=true;
                    }
                } else {
                    ConExistencias=true;
                }
                if(ConExistencias) {
                    DataRow nreg = this.doc.lineas.NewRow();
                    if (this.TBoxIdProd.Text.Trim() != "")                {

                        nreg["ID_ELEM_PROD"] = Convert.ToInt64(this.TBoxIdProd.Text);
                    }
                    else
                    {
                        nreg["ID_ELEM_PROD"] = DBNull.Value;
                    }
                    nreg["TEXTO_LIDO"] = this.TBoxTextoLinIn.Text;
                    nreg["CANTIDAD_LIDO"] = Convert.ToInt32(this.TBoxCantidadIn.Text);
                    nreg["PVB_LIDO"] = Convert.ToDouble(this.LblPrecioBrutoIn.Text);
                    nreg["PORC_IVA_LIDO"] = Convert.ToDouble(this.LblPorIvaIn.Text);
                    nreg["PVP_LIDO"] = Convert.ToDouble(this.TBoxPrecioVentaIn.Text);
                    nreg["TOTAL_LIDO"] = Convert.ToDouble(this.TBoxPrecioVentaIn.Text) * Convert.ToInt32(this.TBoxCantidadIn.Text);
                    this.doc.lineas.Rows.Add(nreg);
                    Hashtable auxt = this._doc.ObtenTotalesDocumento();
                    if (auxt.Count >= 2)
                    {
                        this.LblTotalBruto.Text = ((double)auxt["PVB"]).ToString("F2") + " €";
                        this.LblTotalDocu.Text = ((double)auxt["PVP"]).ToString("F2") + " €";
                    }
                    this.LblTotalPagado.Text = (this._doc.datos["PAGADO_CADO"].ToString() != "" ? ((double)this._doc.datos["PAGADO_CADO"]).ToString("F2") : "0.00") + " €";
                }
                this.CargaDatosLineaProd(0);
                this.TBoxRefProdIn.Focus();
            }
        }

        private void BtnEliminarLinea_Click(object sender, EventArgs e)
        {
            if (this.DGLineas.CurrentRow != null && MessageBox.Show("¿Desea eliminar la linea seleccionada?", "Eliminar linea de documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DGLineas.Rows.Remove(this.DGLineas.CurrentRow);                
            }
        }

        private void DGLineas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Hashtable auxt = this._doc.ObtenTotalesDocumento();
            if (auxt.Count >= 2)
            {
                this.LblTotalBruto.Text = ((double)auxt["PVB"]).ToString("F2") + " €";
                this.LblTotalDocu.Text = ((double)auxt["PVP"]).ToString("F2") + " €";
            }
            this.LblTotalPagado.Text = (this._doc.datos["PAGADO_CADO"].ToString() != "" ? ((double)this._doc.datos["PAGADO_CADO"]).ToString("F2") : "0.00") + " €";
        }
        #endregion

        #region Impresion del ticket
        public void Imprimir()
        {
            ImpresionTicket.CargaPlantilla(TIPO_PLANTILLAS_TICKET.TICKET);
            Persona p=null;
            if (Convert.ToInt64(this.doc.datos["ID_ELEM_PERS"]) != global::LFVBNewTPV.Properties.Settings.Default.CLIENTE_DEFECTO)
            {
                Personas lsp = Personas.ObtenInstancia();
                p = lsp.Buscar(Convert.ToInt64(this.doc.datos["ID_ELEM_PERS"].ToString()));
            }
            ImpresionTicket.ImprimirTicket(global::LFVBNewTPV.Properties.Settings.Default.TICKET_IMP_DEF, this.doc, p);
        }
        #endregion

        #region "Eventos"

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Hashtable auxt = this._doc.ObtenTotalesDocumento();
                double totalfact = 0;
                if (auxt.Count >= 2)
                {
                    totalfact = Convert.ToDouble((auxt["PVP"].ToString() != "" ? auxt["PVP"].ToString() : "0"));
                }
                this.doc.datos["TOTAL_CADO"] = totalfact;
                this.doc.Guardar();
                this.GuardarDatosReserva();
                if (global::LFVBNewTPV.Properties.Settings.Default.TPV_TICK_IMPRCOBR)
                {
                    try
                    {
                        this.Imprimir();
                    }
                    catch (Exception err2)
                    {
                        SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso("Error al imprimir "+err2.Message);
                    }
                }
                if (global::LFVBNewTPV.Properties.Settings.Default.TPV_NUEVO_DESPUES_GUARDAR && this.reserva==null)
                {
                    FrmAuxiliares.FrmTipoDocumento FrmTipo = new FrmAuxiliares.FrmTipoDocumento();
                    FrmTipo.ShowDialog();
                    if (FrmTipo.TipoSel.Trim() != "")
                    {
                        this.doc = this.doc.parent.Nuevo();
                        this.doc.datos["COD_TIDO"] = FrmTipo.TipoSel;
                        this.LblTipoDocumento.Text = FrmTipo.TipoSel;
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else if (this.reserva == null)
                {
                    try
                    {
                        this.doc = this.doc.parent.Buscar(Convert.ToInt64(this.doc.datos["ID_ELEM"].ToString()));
                    }
                    catch (Exception err)
                    {
                        SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                    }
                }
                else
                {                    
                    this.Close();
                }
            }
            catch (Exception err)
            {
                if (global::LFVBNewTPV.Properties.Settings.Default.MODO_DEBUG)
                {
                    SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                }
                else
                {
                    SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso(err.Message);
                }
            }
        }

        private void BtnBuscarPersona_Click(object sender, EventArgs e)
        {
            CRM.PERSONAS.FrmPersonas FrmBusqPers = new LFVBNewTPV.CRM.PERSONAS.FrmPersonas();
            FrmBusqPers.ShowDialog();
            if (FrmBusqPers.OEntrada.Count > 0)
            {
                Persona aux=(Persona)FrmBusqPers.OEntrada[0];
                this.RellenaDatosDireccion(Convert.ToInt64((aux.datos["ID_ELEM"].ToString()!=""?aux.datos["ID_ELEM"].ToString():global::LFVBNewTPV.Properties.Settings.Default.CLIENTE_DEFECTO.ToString())));
            }
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            this.CargaFrm = true;
            CRM.PRODUCTOS.FrmProductos FrmBusqProd = new LFVBNewTPV.CRM.PRODUCTOS.FrmProductos();
            FrmBusqProd.ShowDialog();
            if (FrmBusqProd.OEntrada.Count > 0)
            {
                Producto aux=(Producto)FrmBusqProd.OEntrada[0];
                this.CargaDatosLineaProd(Convert.ToInt64((aux.datos["ID_ELEM"].ToString() != "" ? aux.datos["ID_ELEM"].ToString() : "0")));
            }
            this.CargaFrm = false;
        }

        private void BtnGuardarLinea_Click(object sender, EventArgs e)
        {
            this.GuardaLinea();
        }

        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            FrmAuxiliares.FrmCobrarDocu FrmCobro = new LFVBNewTPV.TPV.FrmAuxiliares.FrmCobrarDocu(this.doc);
            FrmCobro.MdiParent = this.MdiParent;
            FrmCobro.FormClosing += new FormClosingEventHandler(FrmCobro_FormClosing);
            FrmCobro.Show();
        }

        void FrmCobro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hashtable auxt = this._doc.ObtenTotalesDocumento();
            double TDoc = 0;
            double TPag = 0;
            if (auxt.Count >= 2)
            {
                this.LblTotalBruto.Text = auxt["PVB"].ToString() + " €";
                this.LblTotalDocu.Text = auxt["PVP"].ToString() + " €";
                TDoc = Convert.ToDouble(auxt["PVP"].ToString() != "" ? auxt["PVP"].ToString() : "0");
            }
            this.LblTotalPagado.Text = (this._doc.datos["PAGADO_CADO"].ToString() != "" ? this._doc.datos["PAGADO_CADO"].ToString() : "0.00") + " €";
            TPag = Convert.ToDouble(this._doc.datos["PAGADO_CADO"].ToString() != "" ? this._doc.datos["PAGADO_CADO"].ToString() : "0.00");
            if (TPag >= TDoc && global::LFVBNewTPV.Properties.Settings.Default.TPV_DOC_GUARDARCOBR)
            {
                this.BtnGuardar_Click(sender, e);
            }
        }

        private void TBoxRefProdIn_Validating(object sender, CancelEventArgs e)
        {
            if (!this.CargaFrm && this.TBoxRefProdIn.Text.Trim()!="")
            {
                Productos lstp = Productos.ObtenInstancia();
                DataRow[] encontrado = lstp.Datos.Select("COD_BARRAS='" + this.TBoxRefProdIn.Text.Trim() + "'");
                if (encontrado.Length > 0)
                {
                    this.CargaDatosLineaProd(Convert.ToInt64((encontrado[0]["ID_ELEM"].ToString() != "" ? encontrado[0]["ID_ELEM"].ToString() : "0")));
                    if (global::LFVBNewTPV.Properties.Settings.Default.TPV_PIST_LINEA_AUTO)
                    {
                        this.GuardaLinea();
                        this.CargaDatosLineaProd(0);
                    }
                }
                else
                {
                    SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso("No se ha encontrado el producto");
                    this.CargaDatosLineaProd(0);
                }
            }
        }

        private void TBoxCantidadIn_Enter(object sender, EventArgs e)
        {
            if (global::LFVBNewTPV.Properties.Settings.Default.TPV_PIST_LINEA_AUTO)
            {
                this.TBoxRefProdIn.Focus();
            }
        }

        private void BtnImprimirDoc_Click(object sender, EventArgs e)
        {
            try
            {
                this.Imprimir();
            }
            catch (Exception err)
            {
                if (global::LFVBNewTPV.Properties.Settings.Default.MODO_DEBUG)
                {
                    SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                }
                else
                {
                    SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso(err.Message);
                }
            }
        }

        private void BtnMasCantidad_Click(object sender, EventArgs e)
        {
            Int32 aux = 0;
            Int32.TryParse(this.TBoxCantidadIn.Text, out aux);
            this.TBoxCantidadIn.Text = ((Int32)(aux + 1)).ToString();
        }

        private void BtnMenosCantidad_Click(object sender, EventArgs e)
        {
            Int32 aux = 0;
            Int32.TryParse(this.TBoxCantidadIn.Text, out aux);
            this.TBoxCantidadIn.Text = ((Int32)(aux - 1)).ToString();
        }

        private void TBoxRefProdIn_Enter(object sender, EventArgs e)
        {
            this.TBoxRefProdIn.SelectAll();
        }

        private void btnSelectProds_OnSelectProducto(Control c)
        {
            try
            {
                this.CargaDatosLineaProd(Convert.ToInt64(c.Tag.ToString()));
                if (global::LFVBNewTPV.Properties.Settings.Default.TPV_PIST_LINEA_AUTO)
                {
                    this.GuardaLinea();
                    this.CargaDatosLineaProd(0);
                }
            }
            catch (Exception err)
            {
            }
        }
        #endregion









    }
}