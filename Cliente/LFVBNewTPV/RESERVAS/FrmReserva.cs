using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLSBASE.CRM.PERSONAS;
using CLSBASE.CRM.PRODUCTOS;
using CLSBASE.CRM.RESERVAS;
using CLSBASE.CRM.DOCUMENTOS;
using ClsUtils.TICKETS;

namespace LFVBNewTPV.RESERVAS
{
    public partial class FrmReserva : SISTEMA.FrmBase
    {
        private Personas _pers;
        private Productos _prods;

        private Reserva _res;

        public Reserva reserva
        {
            set
            {
                this._res = value;
                try
                {
                    if (this._res != null)
                    {
                        this._pers = Personas.ObtenInstancia();
                        this._prods = Productos.ObtenInstancia();
                        this.LblIdentificadorCare.Text = this._res.datos["ID_ELEM"].ToString();
                        if (this._res.datos["FECHA_GRABACION_CARE"] != DBNull.Value)
                        {
                            this.LblFechaGrabacion.Text = ((DateTime)this._res.datos["FECHA_GRABACION_CARE"]).ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            this.LblFechaGrabacion.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        }
                        if (this._res.datos["ID_ELEM_CADO"] != DBNull.Value)
                        {
                            this.TBoxIdCado.Text = this._res.datos["ID_ELEM_CADO"].ToString();
                            this.LblIdentFactura.Text = this._res.datos["NUMERO_CADO"].ToString();
                            this.BtnFacturar.Enabled = false;
                        }
                        else
                        {
                            this.TBoxIdCado.Text = "";
                            this.LblIdentFactura.Text = "Pend. Facturar";
                            this.BtnFacturar.Enabled = true;
                        }
                        this.CmbCodEsre.SelectedValue = this._res.datos["COD_ESRE"].ToString();
                        if (this._res.datos["ID_ELEM_PERS"].ToString() != "")
                        {
                            this.RellenaDatosDireccion(Convert.ToInt64(this._res.datos["ID_ELEM_PERS"].ToString()));
                        }
                        else
                        {
                            this._res.datos["ID_ELEM_PERS"] = global::LFVBNewTPV.Properties.Settings.Default.CLIENTE_DEFECTO;
                            this.RellenaDatosDireccion(global::LFVBNewTPV.Properties.Settings.Default.CLIENTE_DEFECTO);
                        }
                        this.DGLineas.DataSource = this._res.lineas;
                        switch (this._res.datos["COD_ESRE"].ToString())
                        {
                            case "EFC":
                            case "FAC":
                                this.BtnBuscarArticulo.Enabled = false;
                                this.BtnBuscarPersona.Enabled = false;
                                this.BtnFacturar.Enabled = false;
                                this.BtnGuardarReserva.Enabled = false;
                                break;
                            default:
                                this.BtnBuscarArticulo.Enabled = true;
                                this.BtnBuscarPersona.Enabled = true;
                                this.BtnFacturar.Enabled = true;
                                this.BtnGuardarReserva.Enabled = true;
                                break;
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
                return this._res;
            }
        }

        private bool CargaFrm;

        private void RellenaDatosDireccion(Int64 idpers)
        {
            this.reserva.datos["ID_ELEM_PERS"] = idpers;
            Persona pers = this._pers.Buscar(idpers);
            this.LblIdCliente.Text = pers.datos["ID_ELEM"].ToString();
            this.LblNifCliente.Text = pers.datos["NIF_PERS"].ToString();
            this.LblNombreCliente.Text = pers.datos["NOMBRE_PERS"].ToString();
            this.LblDireccionCliente.Text = pers.datos["DIRE_PERS"].ToString();
            this.LblDireccion2Cliente.Text = "(" + pers.datos["CODPOSTAL_PERS"].ToString() + ") " + pers.datos["POBLACION_PERS"].ToString() + " " + pers.datos["PROVINCIA_PERS"].ToString();
        }

        private void CargaDesplegables()
        {
            CLSBASE.CRM.RESERVAS.EstadoReservas MaeEstReservas = CLSBASE.CRM.RESERVAS.EstadoReservas.ObtenInstancia();
            DataTable auxMaeEst = MaeEstReservas.Datos.Copy();
            this.CmbCodEsre.DataSource = auxMaeEst;
            this.CmbCodEsre.ValueMember = "COD_ESRE";
            this.CmbCodEsre.DisplayMember = "DESCR_ESRE";
        }

        public FrmReserva(Reserva r)
            : base()
        {
            InitializeComponent();
            this.CargaDesplegables();
            this.CargaFrm = false;
            this.reserva = r;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

            DataRow[] dr = this.reserva.lineas.Select("ID_ELEM_PROD=" + (this.TBoxIdProd.Text.Trim() != "" ? this.TBoxIdProd.Text.Trim() : "0"));
            if (dr.Length > 0 && global::LFVBNewTPV.Properties.Settings.Default.TPV_LIN_AGRUPAR_LINEAS)
            {
                dr[0]["CANTIDAD_PROD"] = Convert.ToInt32(dr[0]["CANTIDAD_PROD"]) + Convert.ToInt32(this.TBoxCantidadIn.Text);
                dr[0]["TOTAL_LIRE"] = Convert.ToInt32(dr[0]["CANTIDAD_PROD"]) * Convert.ToDouble(dr[0]["PVP_LIRE"]);
                /*Hashtable auxt = this._doc.ObtenTotalesDocumento();
                if (auxt.Count >= 2)
                {
                    this.LblTotalBruto.Text = auxt["PVB"].ToString() + " €";
                    this.LblTotalDocu.Text = auxt["PVP"].ToString() + " €";
                }*/
            }
            else
            {
                DataRow nreg = this.reserva.lineas.NewRow();
                if (this.TBoxIdProd.Text.Trim() != "")
                {
                    nreg["ID_ELEM_PROD"] = Convert.ToInt64(this.TBoxIdProd.Text);
                }
                else
                {
                    nreg["ID_ELEM_PROD"] = DBNull.Value;
                }
                nreg["DESCRIPCION_PROD"] = this.TBoxTextoLinIn.Text;
                nreg["CANTIDAD_PROD"] = Convert.ToInt32(this.TBoxCantidadIn.Text);
                nreg["PVB_LIRE"] = Convert.ToDouble(this.LblPrecioBrutoIn.Text);
                nreg["PORC_IVA_LIRE"] = Convert.ToDouble(this.LblPorIvaIn.Text);
                nreg["PVP_LIRE"] = Convert.ToDouble(this.TBoxPrecioVentaIn.Text);
                nreg["TOTAL_LIRE"] = Convert.ToDouble(this.TBoxPrecioVentaIn.Text) * Convert.ToInt32(this.TBoxCantidadIn.Text);
                this.reserva.lineas.Rows.Add(nreg);
                //Hashtable auxt = this._doc.ObtenTotalesDocumento();
                //if (auxt.Count >= 2)
                //{
                //    this.LblTotalBruto.Text = auxt["PVB"].ToString() + " €";
                //    this.LblTotalDocu.Text = auxt["PVP"].ToString() + " €";
                //}
                this.CargaDatosLineaProd(0);
                this.TBoxRefProdIn.Focus();
            }
        }
        #endregion

        #region "Eventos"
        private string ValidarReserva()
        {
            string msgerror = "";
            if (this.TBoxIdCado.Text.Trim() == "")
            {
                if (this.CmbCodEsre.SelectedValue != null && (this.CmbCodEsre.SelectedValue.ToString() == "EFC" || this.CmbCodEsre.SelectedValue.ToString() == "FAC"))
                {
                    msgerror += "\nNo se puede seleccionar el estado 'Facturada' o 'Enviada y Facturada' cuando no tiene documento de pago";
                }
            }
            else
            {
                if (this.CmbCodEsre.SelectedValue != null && (this.CmbCodEsre.SelectedValue.ToString() != "EFC" && this.CmbCodEsre.SelectedValue.ToString() != "FAC"))
                {
                      msgerror += "\nNo se puede seleccionar el estado diferente a 'Facturada' o 'Enviada y Facturada' cuando se tiene documento de pago";
                }                
            }
            if (this.reserva.lineas.Rows.Count <= 0)
            {
                msgerror += "\nNo se puede guardar una reserva sin nada que reservar";
            }
            Int64 idpers = 0;
            Int64.TryParse(this.reserva.datos["ID_ELEM_PERS"].ToString(), out idpers);
            if (idpers == global::LFVBNewTPV.Properties.Settings.Default.CLIENTE_DEFECTO || idpers == 0)
            {
                msgerror += "\nNo se puede guardar una reserva, sin indicar el cliente o siendo este el cliente por defecto";
            }
            return msgerror;
        }

        private void BtnGuardarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = this.ValidarReserva();
                if (msg != "")
                {
                    SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso(msg);
                }
                else
                {
                    //Guardamos los datos sensibles
                    if (this.CmbCodEsre.SelectedValue != null && this.CmbCodEsre.SelectedValue.ToString() != this.reserva.datos["COD_ESRE"].ToString())
                    {
                        this.reserva.datos["COD_ESRE"] = this.CmbCodEsre.SelectedValue.ToString();
                        this.reserva.datos["FECHA_ESRE"] = DateTime.Now;
                    }
                    else if (this.CmbCodEsre.SelectedValue==null)
                    {
                        this.reserva.datos["COD_ESRE"] = "GRB";
                        this.reserva.datos["FECHA_ESRE"] = DateTime.Now;
                    }
                    this.reserva.Guardar();
                    this.reserva = this.reserva.parent.Buscar(Convert.ToInt64(this.reserva.datos["ID_ELEM"].ToString()));
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
                Persona aux = (Persona)FrmBusqPers.OEntrada[0];
                this.RellenaDatosDireccion(Convert.ToInt64((aux.datos["ID_ELEM"].ToString() != "" ? aux.datos["ID_ELEM"].ToString() : global::LFVBNewTPV.Properties.Settings.Default.CLIENTE_DEFECTO.ToString())));
            }
        }

        private void BtnBuscarArticulo_Click(object sender, EventArgs e)
        {
            this.CargaFrm = true;
            CRM.PRODUCTOS.FrmProductos FrmBusqProd = new LFVBNewTPV.CRM.PRODUCTOS.FrmProductos();
            FrmBusqProd.ShowDialog();
            if (FrmBusqProd.OEntrada.Count > 0)
            {
                Producto aux = (Producto)FrmBusqProd.OEntrada[0];
                this.CargaDatosLineaProd(Convert.ToInt64((aux.datos["ID_ELEM"].ToString() != "" ? aux.datos["ID_ELEM"].ToString() : "0")));
            }
            this.CargaFrm = false;
        }

        private void BtnGuardarLinea_Click(object sender, EventArgs e)
        {
            this.GuardaLinea();
        }

        private void TBoxRefProdIn_Validating(object sender, CancelEventArgs e)
        {
            if (!this.CargaFrm && this.TBoxRefProdIn.Text.Trim() != "")
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

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = this.ValidarReserva();
                if (msg != "")
                {
                    SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso(msg);
                }
                else
                {
                    //Guardamos los datos sensibles
                    if (this.CmbCodEsre.SelectedValue != null && this.CmbCodEsre.SelectedValue.ToString() != this.reserva.datos["COD_ESRE"].ToString())
                    {
                        this.reserva.datos["COD_ESRE"] = this.CmbCodEsre.SelectedValue.ToString();
                        this.reserva.datos["FECHA_ESRE"] = DateTime.Now;
                    }
                    else if (this.CmbCodEsre.SelectedValue == null)
                    {
                        this.reserva.datos["COD_ESRE"] = "GRB";
                        this.reserva.datos["FECHA_ESRE"] = DateTime.Now;
                    }                   
                    bool ExistenExistencias = true;
                    Productos lstp = Productos.ObtenInstancia();
                    foreach (DataRow d in this.reserva.lineas.Rows)
                    {
                        Int64 idprod;
                        Int64.TryParse(d["ID_ELEM_PROD"].ToString(), out idprod);
                        if (idprod > 0)
                        {
                            Producto p = lstp.Buscar(idprod);
                            if (p != null)
                            {
                                double existencias = p.ObtenStock();
                                double pedidas = 0;
                                Double.TryParse(d["CANTIDAD_PROD"].ToString(), out pedidas);
                                if (pedidas > existencias)
                                {
                                    ExistenExistencias = false;
                                }
                            }
                        }
                    }
                    if (ExistenExistencias)
                    {
                        //Puedo facturar
                        TPV.FrmAuxiliares.FrmTipoDocumento FrmTipo = new TPV.FrmAuxiliares.FrmTipoDocumento();
                        FrmTipo.ShowDialog();
                        if (FrmTipo.TipoSel.Trim() != "")
                        {
                            Documentos auxdocs = Documentos.ObtenInstancia();
                            Documento nuevo = auxdocs.Nuevo();
                            //Relleno los datos del nuevo documento
                            nuevo.datos["ID_ELEM_PERS"] = this.reserva.datos["ID_ELEM_PERS"];
                            foreach (DataRow d in this.reserva.lineas.Rows)
                            {
                                DataRow l = nuevo.lineas.NewRow();
                                l["ID_ELEM_PROD"] = d["ID_ELEM_PROD"];
                                l["CANTIDAD_LIDO"] = d["CANTIDAD_PROD"];
                                l["TEXTO_LIDO"] = d["DESCRIPCION_PROD"];
                                l["PVB_LIDO"] = d["PVB_LIRE"];
                                l["PORC_IVA_LIDO"] = d["PORC_IVA_LIRE"];
                                l["PVP_LIDO"] = d["PVP_LIRE"];
                                double cant = 0;
                                double pvp = 0;
                                double.TryParse(l["CANTIDAD_LIDO"].ToString(), out cant);
                                double.TryParse(l["PVP_LIDO"].ToString(), out pvp);
                                l["TOTAL_LIDO"] = cant * pvp;
                                nuevo.lineas.Rows.Add(l);
                            }
                            DataRow ln = nuevo.lineas.NewRow();
                            ln["ID_ELEM_PROD"] = DBNull.Value;
                            ln["CANTIDAD_LIDO"] = 0;
                            ln["TEXTO_LIDO"] = "Reserva nº " + this.reserva.datos["ID_ELEM"].ToString();
                            ln["PVB_LIDO"] = 0;
                            ln["PORC_IVA_LIDO"] = 0;
                            ln["PVP_LIDO"] = 0;
                            ln["TOTAL_LIDO"] = 0;
                            nuevo.lineas.Rows.Add(ln);
                            TPV.FrmDocumento FrmDocu = new TPV.FrmDocumento(nuevo, FrmTipo.TipoSel.Trim());
                            FrmDocu.reserva = this.reserva;
                            FrmDocu.ShowDialog();
                            this.reserva = this.reserva.parent.Buscar(Convert.ToInt64(this.reserva.datos["ID_ELEM"].ToString()));
                        }
                    }
                    else
                    {
                        //No puedo facturar al faltar algun producto
                        this.CmbCodEsre.SelectedValue = "PST";
                        SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso("Existen productos sin stock suficiente para ser servidos");
                    }
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

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
                this.Imprimir();
        }

        #endregion

        #region Impresion del ticket
        public void Imprimir()
        {
            try
            {
                ImpresionTicket.CargaPlantilla(TIPO_PLANTILLAS_TICKET.RESERVA);
                Persona p = null;
                if (Convert.ToInt64(this.reserva.datos["ID_ELEM_PERS"]) != global::LFVBNewTPV.Properties.Settings.Default.CLIENTE_DEFECTO)
                {
                    Personas lsp = Personas.ObtenInstancia();
                    p = lsp.Buscar(Convert.ToInt64(this.reserva.datos["ID_ELEM_PERS"].ToString()));
                }
                ImpresionTicket.ImprimirReserva(global::LFVBNewTPV.Properties.Settings.Default.TICKET_IMP_DEF, this.reserva, p);
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
        #endregion

    }
}