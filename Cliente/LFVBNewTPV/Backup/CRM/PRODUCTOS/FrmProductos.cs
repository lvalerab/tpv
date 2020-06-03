using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CLSBASE.CRM.PRODUCTOS;

namespace LFVBNewTPV.CRM.PRODUCTOS
{
    public partial class FrmProductos : SISTEMA.FrmBase
    {
        private ArrayList _OEntrada;

        public ArrayList OEntrada
        {
            set
            {
                this._OEntrada = value;
            }
            get
            {
                return this._OEntrada;
            }
        }

        private CLSBASE.CRM.PRODUCTOS.Productos _LstProductos;

        public CLSBASE.CRM.PRODUCTOS.Productos LstProductos
        {
            set
            {
                this._LstProductos = value;
            }
            get
            {
                return this._LstProductos;
            }
        }

        public void InicializarDatos()
        {
            this.OEntrada = new ArrayList();
            try
            {
                this.LstProductos = Productos.ObtenInstancia();
                Familias MaeFam = Familias.ObtenInstancia();
                this.CCodFamilia.DataSource = MaeFam.Datos.Copy();
                this.CCodFamilia.ValueMember = "COD_FAMI";
                this.CCodFamilia.DisplayMember = "NOMBRE_FAMI";
                Subfamilias MaeSufa = Subfamilias.ObtenInstancia();
                this.cCodSufa.DataSource = MaeSufa.Datos.Copy();
                this.cCodSufa.ValueMember = "COD_SUFA";
                this.cCodSufa.DisplayMember = "NOMBRE_SUFA";
                this.DGDatos.DataSource = this.LstProductos.Datos;
            }
            catch (Exception err)
            {
                SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
            }
        }

        public FrmProductos():base()
        {
            InitializeComponent();
            this.InicializarDatos();
        }

        private void TSNuevoProd_Click(object sender, EventArgs e)
        {
            Producto aux = this.LstProductos.Nuevo();
            FrmProducto Ficha = new FrmProducto(aux);
            Ficha.MdiParent = this.MdiParent;
            Ficha.Show();
        }

        private void TSFichaProd_Click(object sender, EventArgs e)
        {
            if (this.DGDatos.CurrentRow != null)
            {
                try
                {
                    Producto aux = this.LstProductos.Buscar(Convert.ToInt64(this.DGDatos.CurrentRow.Cells["CIdElem"].Value.ToString()));
                    if (aux != null)
                    {
                        FrmProducto ficha = new FrmProducto(aux);
                        ficha.MdiParent = this.MdiParent;
                        ficha.Show();
                    }
                }
                catch (Exception err)
                {
                    SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                }
            }
        }

        private void TSSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSAceptar_Click(object sender, EventArgs e)
        {
            this.OEntrada.Clear();
            if (this.DGDatos.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dvr in this.DGDatos.SelectedRows)
                {
                    Producto aux = this.LstProductos.Buscar(Convert.ToInt64((dvr.Cells["cIdElem"].Value.ToString() != "" ? dvr.Cells["cIdElem"].Value.ToString() : "")));
                    this.OEntrada.Add(aux);
                }
            }
            this.Close();
        }

        private void TSRefrescar_Click(object sender, EventArgs e)
        {
            bool exiteFichaAbierta = false;
            foreach (Form f in this.MdiParent.MdiChildren)
            {
                if (f.Text == "Ficha del producto")
                {
                    exiteFichaAbierta = true;
                }
            }
            if (!exiteFichaAbierta)
            {
                try
                {
                    this.LstProductos.Refrescar();
                }
                catch (Exception err)
                {
                    SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                }
            }
            else
            {
                SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso("Debe de cerrar todas las fichas de producto abiertas");
            }
        }

        private void TBoxFiltroCodBarras_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "";
                if (this.TBoxFiltroCodBarras.Text.Trim() != "")
                {
                    filtro="COD_BARRAS='" + this.TBoxFiltroCodBarras.Text + "'";
                }
                if(this.TBoxFiltroDescripcion.Text.Trim()!="") {
                    if(filtro.Trim()!="") {
                        filtro+=" AND ";
                    }
                    filtro="NOMBRE_PROD like '%"+this.TBoxFiltroDescripcion.Text+"%'";
                }
                this.LstProductos.Datos.DefaultView.RowFilter = filtro;
            }
            catch (Exception err)
            {
                SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso("No es posible filtrar por el código de barras indicado, causa: " + err.Message);
            }

        }

        private void FrmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.LstProductos.Datos.DefaultView.RowFilter = "";
            }
            catch (Exception err)
            {
            }
        }


    }
}