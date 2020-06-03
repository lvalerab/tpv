using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CLSBASE.CRM.PERSONAS;

namespace LFVBNewTPV.CRM.PERSONAS
{
    public partial class FrmPersonas : SISTEMA.FrmBase
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

        private Personas _personas;
        public Personas MaePersonas
        {
            set
            {
                this._personas = value;                
            }
            get
            {
                return this._personas;
            }
        }

        public void InicializarDatos()
        {
            this.OEntrada = new ArrayList();
            this.MaePersonas = Personas.ObtenInstancia();
            this.DGDatos.DataSource = this.MaePersonas.Datos;
        }

        public FrmPersonas():base()
        {
            InitializeComponent();
            this.InicializarDatos();
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            bool exiteFichaAbierta = false;
            foreach (Form f in this.MdiParent.MdiChildren)
            {
                if (f.Text == "Ficha de la persona")
                {
                    exiteFichaAbierta = true;
                }
            }
            if (!exiteFichaAbierta)
            {
                try
                {
                    this.MaePersonas.Refrescar();
                }
                catch (Exception err)
                {
                    SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                }
            }
            else
            {
                SISTEMA.MENSAJES.FrmAviso FrmAvi = new LFVBNewTPV.SISTEMA.MENSAJES.FrmAviso("Debe de cerrar todas las fichas de persona abiertas");
            }
        }

        private void BtnNuevaPersona_Click(object sender, EventArgs e)
        {
            Persona aux = this.MaePersonas.Nuevo();
            FrmPersona FrmPers = new FrmPersona(aux);
            FrmPers.MdiParent = this.MdiParent;
            FrmPers.Show();
        }

        private void BtnFichaPersona_Click(object sender, EventArgs e)
        {
            if (this.DGDatos.CurrentRow != null)
            {
                try
                {
                    Persona aux = this.MaePersonas.Buscar(Convert.ToInt64(this.DGDatos.CurrentRow.Cells["cIdElem"].Value.ToString()));
                    if (aux != null)
                    {
                        FrmPersona FrmPers = new FrmPersona(aux);
                        FrmPers.MdiParent = this.MdiParent;
                        FrmPers.Show();
                    }
                }
                catch (Exception err)
                {
                    SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                }
            }
        }

        private void TBoxFiltroNif_TextChanged(object sender, EventArgs e)
        {
            string filtro="";
            if(this.TBoxFiltroNif.Text!="") 
            {
                filtro=" NIF_PERS like '%"+this.TBoxFiltroNif+"%'";
            } 
            if(this.TBoxFiltroNombre.Text!="") 
            {
                if(filtro.Trim()!="") {
                    filtro+=" AND ";
                }
                filtro+=" NOMBRE_PERS like '%"+this.TBoxFiltroNombre.Text+"%'";
            }
            this.MaePersonas.Datos.DefaultView.RowFilter = filtro;
        }

        private void FrmPersonas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MaePersonas.Datos.DefaultView.RowFilter = "";
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.OEntrada.Clear();
            if (this.DGDatos.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dvr in this.DGDatos.SelectedRows)
                {
                    Persona aux = this.MaePersonas.Buscar(Convert.ToInt64((dvr.Cells["cIdElem"].Value.ToString() != "" ? dvr.Cells["cIdElem"].Value.ToString() : "")));
                    this.OEntrada.Add(aux);
                }
            }
            this.Close();
        }
    }
}