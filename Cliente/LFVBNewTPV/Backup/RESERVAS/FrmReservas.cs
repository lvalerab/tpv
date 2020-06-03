using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CLSBASE.CRM.RESERVAS;

namespace LFVBNewTPV.RESERVAS
{
    public partial class FrmReservas : SISTEMA.FrmBase
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

        private CLSBASE.CRM.RESERVAS.Reservas _reservas;
        public CLSBASE.CRM.RESERVAS.Reservas reservas
        {
            set
            {
                this._reservas = value;
            }
            get
            {
                return this._reservas;
            }
        }
        public FrmReservas():base()
        {
            InitializeComponent();
            this.InicializarDatos();
        }

        private string _filtro;

        public void InicializarDatos()
        {
            this._filtro = "";
            CLSBASE.CRM.RESERVAS.EstadoReservas MaeEstReservas = CLSBASE.CRM.RESERVAS.EstadoReservas.ObtenInstancia();
            DataTable auxMaeEst = MaeEstReservas.Datos.Copy();
            DataRow nreg = auxMaeEst.NewRow();
            nreg["COD_ESRE"] = "*";
            nreg["DESCR_ESRE"] = "Todos los estados";
            auxMaeEst.Rows.Add(nreg);
            this.cCodEsre.DataSource = auxMaeEst;
            this.cCodEsre.ValueMember = "COD_ESRE";
            this.cCodEsre.DisplayMember = "DESCR_ESRE";
            this.cCodEsre.DataPropertyName = "COD_ESRE";
            this.reservas = CLSBASE.CRM.RESERVAS.Reservas.ObtenInstancia();
            this.DGDatos.DataSource = this.reservas.Datos;
            this.EstableceFiltro();
            this.CmbFiltroEstado.DataSource = auxMaeEst;
            this.CmbFiltroEstado.ValueMember = "COD_ESRE";
            this.CmbFiltroEstado.DisplayMember = "DESCR_ESRE";
            this.CmbFiltroEstado.SelectedValue = "*";
        }

        private void EstableceFiltro()
        {
            this.reservas.Datos.DefaultView.RowFilter = this._filtro;
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            bool ExisteFichaAbierta = false;
            foreach (Form f in this.MdiParent.MdiChildren)
            {
                if (f.GetType().ToString().Trim() == "FrmReserva")
                {
                    ExisteFichaAbierta = true;
                }
            }
            if (!ExisteFichaAbierta)
            {
                try
                {
                    this.reservas.Refrescar();
                }
                catch (Exception err)
                {
                    SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                }
            }
            else
            {
                SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso("Debe de cerrar todas las fichas de reservas abiertas");
            }
        }

        private void TBoxFiltroCliente_TextChanged(object sender, EventArgs e)
        {
            this._filtro = "";
            if (this.TBoxFiltroCliente.Text.Trim() != "")
            {
                this._filtro = "NOMBRE_PERS_CARE like '%" + this.TBoxFiltroCliente.Text.Trim() + "%'";
            }
            if (this.CmbFiltroEstado.SelectedValue != "*")
            {
                this._filtro += (this._filtro != "" ? " and " : "") + " COD_ESRE='" + this.CmbFiltroEstado.SelectedValue.ToString() + "'";
            }
            this.EstableceFiltro();
        }

        private void CmbFiltroEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            this._filtro = "";
            if (this.TBoxFiltroCliente.Text.Trim() != "")
            {
                this._filtro = "NOMBRE_PERS_CARE like '%" + this.TBoxFiltroCliente.Text.Trim() + "%'";
            }
            if (this.CmbFiltroEstado.SelectedValue != "*")
            {
                this._filtro += (this._filtro != "" ? " and " : "") + " COD_ESRE='" + this.CmbFiltroEstado.SelectedValue.ToString() + "'";
            }
            this.EstableceFiltro();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Reserva nuevo = this.reservas.Nuevo();
            FrmReserva FrmRese = new FrmReserva(nuevo);
            FrmRese.MdiParent = this.MdiParent;
            FrmRese.FormClosing += new FormClosingEventHandler(FrmRese_FormClosing);
            FrmRese.Show();
        }

        private void FrmRese_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.InicializarDatos();
        }

        private void BtnFicha_Click(object sender, EventArgs e)
        {
            if (this.DGDatos.CurrentRow != null)
            {
                try
                {
                    Reserva aux = this.reservas.Buscar(Convert.ToInt64(this.DGDatos.CurrentRow.Cells["cIdElem"].Value.ToString()));
                    if (aux != null)
                    {
                        FrmReserva FrmRese = new FrmReserva(aux);
                        FrmRese.MdiParent = this.MdiParent;
                        FrmRese.FormClosing+=new FormClosingEventHandler(FrmRese_FormClosing);
                        FrmRese.Show();
                    }
                }
                catch (Exception err)
                {
                    SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}