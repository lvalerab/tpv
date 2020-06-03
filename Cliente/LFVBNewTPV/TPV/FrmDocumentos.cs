using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLSBASE.CRM.DOCUMENTOS;
using System.Collections;

namespace LFVBNewTPV.TPV
{
    public partial class FrmDocumentos : SISTEMA.FrmBase
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

        private Documentos _documentos;
        public Documentos documentos
        {
            set
            {
                this._documentos = value;
            }
            get
            {
                return this._documentos;
            }
        }

        public void InicializarDatos()
        {
            this.documentos = Documentos.ObtenInstancia();
            this.DGDatos.DataSource = this.documentos.Datos;
            
        }

        public FrmDocumentos():base()
        {
            InitializeComponent();
            this.InicializarDatos();
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            bool exiteFichaAbierta = false;
            foreach (Form f in this.MdiParent.MdiChildren)
            {
                if (f.Text == "TPV")
                {
                    exiteFichaAbierta = true;
                }
            }
            if (!exiteFichaAbierta)
            {
                try
                {
                    this.documentos.Refrescar();
                }
                catch (Exception err)
                {
                    SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                }
            }
            else
            {
                SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso("Debe de cerrar todas las fichas de documento abiertas");
            }
        }

        private void TBoxTipoDocFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = "";
            if (this.TBoxTipoDocFiltro.Text.Trim() != "")
            {
                filtro = "COD_TIDO='" + this.TBoxTipoDocFiltro.Text + "'";
            }
            if (this.TBoxNumeroDocFiltro.Text.Trim() != "" && this.TBoxNumeroDocFiltro.Text.Trim() != "0")
            {
                if (filtro.Trim() != "")
                {
                    filtro += " AND ";
                }
                filtro += " NUMERO_CADO=" + this.TBoxNumeroDocFiltro.Text.ToString();
            }

            if (this.TBoxAnyoDocFiltro.Text.Trim() != "" && this.TBoxAnyoDocFiltro.Text.Trim() != "0")
            {
                if (filtro.Trim() != "")
                {
                    filtro += " AND ";
                }
                filtro += " ANYO_CADO=" + this.TBoxAnyoDocFiltro.Text.Trim();

            }
            if (this.TBoxNombreClienteFiltro.Text.Trim() != "")
            {
                if (filtro.Trim() != "")
                {
                    filtro += " AND ";
                }
                filtro += " NOMBRE_PERS_CADO like '%" + this.TBoxNombreClienteFiltro.Text.Trim() + "%'";
            }
            this.documentos.Datos.DefaultView.RowFilter = filtro;

        }

        private void FrmDocumentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.documentos.Datos.DefaultView.RowFilter = "";
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmAuxiliares.FrmTipoDocumento FrmTipDoc = new LFVBNewTPV.TPV.FrmAuxiliares.FrmTipoDocumento();
            FrmTipDoc.ShowDialog();
            if (FrmTipDoc.TipoSel.Trim() != "")
            {
                Documento nuevo = this.documentos.Nuevo();
                FrmDocumento FrmDocu = new FrmDocumento(nuevo, FrmTipDoc.TipoSel.Trim());
                FrmDocu.MdiParent = this.MdiParent;
                FrmDocu.FormClosing += new FormClosingEventHandler(FrmDocu_FormClosing);
                FrmDocu.Show();
            }
        }

        private void FrmDocu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.InicializarDatos();
        }

        private void BtnFicha_Click(object sender, EventArgs e)
        {
            if (this.DGDatos.CurrentRow != null)
            {
                try
                {
                    Documento aux = this.documentos.Buscar(Convert.ToInt64(this.DGDatos.CurrentRow.Cells["cIdElem"].Value.ToString()));
                    if (aux != null)
                    {
                        FrmDocumento FrmDocu = new FrmDocumento(aux);
                        FrmDocu.MdiParent = this.MdiParent;
                        FrmDocu.FormClosing += new FormClosingEventHandler(FrmDocu_FormClosing);
                        FrmDocu.Show();
                    }
                }
                catch (Exception err)
                {
                    SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                }
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}