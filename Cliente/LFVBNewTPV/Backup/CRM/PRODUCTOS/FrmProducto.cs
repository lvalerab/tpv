using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLSBASE.CRM.PRODUCTOS;

namespace LFVBNewTPV.CRM.PRODUCTOS
{
    public partial class FrmProducto : SISTEMA.FrmBase
    {
        private Producto _Product;
        private IVA _AuxIva;
        private bool EditandoPSV;
        private bool EditandoPVP;
        private bool CargaDatos;

        public Producto Product
        {
            set
            {
                try
                {
                    this._Product = value;
                    //Rellenamos los campos
                    this.EditandoPSV = true;
                    this.EditandoPVP = true;
                    this.LblIdElem.Text = this._Product.datos["ID_ELEM"].ToString();
                    this.CmbFamilia.SelectedValue = this._Product.datos["COD_FAMI"].ToString();
                    this.CmbSubfamilia.SelectedValue = this._Product.datos["COD_SUFA"].ToString();
                    this.TBoxCodigoBarras.Text = this._Product.datos["COD_BARRAS"].ToString();
                    this.TBoxNombreProd.Text = this._Product.datos["NOMBRE_PROD"].ToString();
                    this.TBoxExistencias.Text = (this._Product.datos["EXISTENCIAS_PROD"].ToString() == "" ? "0" : this._Product.datos["EXISTENCIAS_PROD"].ToString());
                    this.TBoxPrecioCompra.Text = (this._Product.precio["PRECIO_COMPRA"].ToString() == "" ? "0.00" : this._Product.precio["PRECIO_COMPRA"].ToString());
                    if (this._Product.precio["COD_TIVA"].ToString() == "")
                    {
                        this.CmbPorIva.SelectedValue = global::LFVBNewTPV.Properties.Settings.Default.COD_IVA_DEF;
                    }
                    else
                    {
                        this.CmbPorIva.SelectedValue = this._Product.precio["COD_TIVA"].ToString();
                    }
                    string rImagen = this._Product.ObtenRutaImagen();
                    if (rImagen != null)
                    {
                        try
                        {
                            this.PBoxImagenProd.Load(rImagen);
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("No se ha podido cargar la imagen, causa: " + err.Message, "Error carga imagen", MessageBoxButtons.OK);
                        }
                    }
                    this.TBoxDescripcion.Text = this._Product.datos["DESCRIPCION_PROD"].ToString();
                    this.TBoxPrecioSinIva.Text = (this._Product.precio["PRECIO_BRUTO"].ToString() == "" ? "0.00" : this._Product.precio["PRECIO_BRUTO"].ToString());
                    this.TBoxPVP.Text = (this._Product.precio["PRECIO_VENTA"].ToString() == "" ? "0.00" : this._Product.precio["PRECIO_VENTA"].ToString());
                    this.DGDatosMovStock.DataSource = this._Product.MovStock;
                    this.EditandoPSV = false;
                    this.EditandoPVP = false;
                }
                catch (Exception err)
                {
                    SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                }
            }
            get
            {
                return this._Product;
            }
        }

        public void InicializarDesplegables()
        {

            Subfamilias aux2 = Subfamilias.ObtenInstancia();
            this.CmbSubfamilia.DataSource = aux2.Datos.Copy();
            this.CmbSubfamilia.DisplayMember = "NOMBRE_SUFA";
            this.CmbSubfamilia.ValueMember = "COD_SUFA";


            Familias aux = Familias.ObtenInstancia();
            this.CmbFamilia.DataSource = aux.Datos.Copy();
            this.CmbFamilia.DisplayMember = "NOMBRE_FAMI";
            this.CmbFamilia.ValueMember = "COD_FAMI";

            this._AuxIva = IVA.ObtenInstancia();
            this.CmbPorIva.DataSource = this._AuxIva.Datos;
            this.CmbPorIva.ValueMember = "COD_TIVA";
            this.CmbPorIva.DisplayMember = "DESCR_TIVA";
        }

        public FrmProducto(Producto p):base()
        {
            InitializeComponent();
            this.InicializarDesplegables();
            this.EditandoPSV = false;
            this.EditandoPVP = false;
            this.CargaDatos = true;
            this.Product = p;
            this.CargaDatos = false;
        }

        public FrmProducto(Producto p, string codbarras, string codfami, string codsufa, string Cantidad)
        {
            InitializeComponent();
            this.InicializarDesplegables();
            this.EditandoPSV = false;
            this.EditandoPVP = false;
            this.Product = p;
            this.TBoxCodigoBarras.Text = codbarras;
            this.CmbFamilia.SelectedValue = codfami;
            this.CmbSubfamilia.SelectedValue = codsufa;
            this.CmbPorIva.SelectedValue = global::LFVBNewTPV.Properties.Settings.Default.COD_IVA_DEF;
            this.TBoxExistencias.Text = Cantidad.ToString();
        }

        private void CmbFamilia_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.CmbSubfamilia.DataSource != null && this.CmbFamilia.SelectedValue!=null) 
            {
                ((DataTable)this.CmbSubfamilia.DataSource).DefaultView.RowFilter="COD_FAMI='" + this.CmbFamilia.SelectedValue.ToString()+"'";
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardarProd_Click(object sender, EventArgs e)
        {
            try
            {
                this._Product.datos["COD_FAMI"] = this.CmbFamilia.SelectedValue;
                this._Product.datos["COD_SUFA"] = this.CmbSubfamilia.SelectedValue;
                this._Product.datos["COD_BARRAS"] = this.TBoxCodigoBarras.Text;
                this._Product.datos["NOMBRE_PROD"] = this.TBoxNombreProd.Text;
                this._Product.datos["EXISTENCIAS_PROD"] = (this.TBoxExistencias.Text == "" ? 0 : Convert.ToInt64(this.TBoxExistencias.Text));
                this._Product.precio["PRECIO_COMPRA"] = Math.Round(Convert.ToDouble((this.TBoxPrecioCompra.Text == "" ? "0" : this.TBoxPrecioCompra.Text)), 2, MidpointRounding.AwayFromZero);
                this._Product.precio["PRECIO_BRUTO"] = Math.Round(Convert.ToDouble((this.TBoxPrecioSinIva.Text == "" ? "0" : this.TBoxPrecioSinIva.Text)), 2, MidpointRounding.AwayFromZero);
                this._Product.precio["COD_TIVA"] = this.CmbPorIva.SelectedValue;
                this._Product.precio["PORC_IVA"] = this._AuxIva.ObtenPorcentajer(this.CmbPorIva.SelectedValue.ToString());
                this._Product.precio["PRECIO_VENTA"] = Math.Round(Convert.ToDouble((this.TBoxPVP.Text == "" ? "0" : this.TBoxPVP.Text)), 2, MidpointRounding.AwayFromZero);
                this._Product.datos["DESCRIPCION_PROD"] = this.TBoxDescripcion.Text;
                this._Product.Guardar();
                try
                {
                    this.Product = this.Product.parent.Buscar(Convert.ToInt64(this.Product.datos["ID_ELEM"].ToString()));
                }
                catch (Exception err)
                {
                    SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                }
            }
            catch (Exception err)
            {
                SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso(err.Message);
            }
        }

        private void TBoxPrecioSinIva_TextChanged(object sender, EventArgs e)
        {
            
            if (!this.EditandoPVP)
            {
                this.EditandoPSV = true;
                if (this.TBoxPrecioSinIva.Text.Trim() != "" && this.CmbPorIva.SelectedValue != null && this.CmbPorIva.SelectedValue != DBNull.Value)
                {
                    this.TBoxPVP.Text = this._AuxIva.AplicarIva(Convert.ToDouble(this.TBoxPrecioSinIva.Text), this.CmbPorIva.SelectedValue.ToString()).ToString();
                }
                this.EditandoPSV = false;
            }
        }

        private void TBoxPVP_TextChanged(object sender, EventArgs e)
        {
            if(!this.EditandoPSV) {
                this.EditandoPVP=true;
                try
                {
                    if (this.TBoxPVP.Text.Trim() != "" && this.CmbPorIva.SelectedValue != null && this.CmbPorIva.SelectedValue != DBNull.Value)
                    {
                        this.TBoxPrecioSinIva.Text = this._AuxIva.QuitaIva(Convert.ToDouble(this.TBoxPVP.Text), this.CmbPorIva.SelectedValue.ToString()).ToString();
                    }
                }
                catch (Exception err)
                {
                    this.TBoxPrecioSinIva.Text = "0,00";
                }
                this.EditandoPVP=false;
            }
        }

        private void CmbPorIva_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.CmbPorIva.SelectedValue != null)
            {
                try
                {
                    this.TBoxPorIva.Text = ((this._AuxIva.ObtenPorcentajer(this.CmbPorIva.SelectedValue.ToString()) - 1) * 100).ToString();
                    if (!this.CargaDatos)
                    {
                        this.TBoxPrecioSinIva.Text = this._AuxIva.QuitaIva(Convert.ToDouble(this.TBoxPVP.Text), this.CmbPorIva.SelectedValue.ToString()).ToString();
                    }
                }
                catch (Exception err)
                {
                    this.TBoxPrecioSinIva.Text = "0,00";
                }
            }
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            this.DlgAbrirImagen.FileOk += new CancelEventHandler(DlgAbrirImagen_FileOk);
            this.DlgAbrirImagen.ShowDialog();
        }

        void DlgAbrirImagen_FileOk(object sender, CancelEventArgs e)
        {
            if (this.DlgAbrirImagen.FileName != "")
            {
                this._Product.EstableceRutaImagen(this.DlgAbrirImagen.FileName);
                this.PBoxImagenProd.Load(this._Product.ObtenRutaImagen());
            }
        }
    }
}