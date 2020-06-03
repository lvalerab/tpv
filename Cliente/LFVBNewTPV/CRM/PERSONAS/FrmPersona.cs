using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLSBASE.CRM.PERSONAS;

namespace LFVBNewTPV.CRM.PERSONAS
{
    public partial class FrmPersona : SISTEMA.FrmBase
    {
        private Persona _pers;
        public Persona pers
        {
            set
            {
                try
                {
                    this._pers = value;
                    if (this._pers != null)
                    {
                        this.LblIdElemento.Text = this._pers.datos["ID_ELEM"].ToString();
                        this.TBoxNif.Text = this._pers.datos["NIF_PERS"].ToString();
                        this.TBoxNombre.Text = this._pers.datos["NOMBRE_PERS"].ToString();
                        this.TBoxDireccion.Text = this._pers.datos["DIRE_PERS"].ToString();
                        this.TBoxCodPostal.Text = this._pers.datos["CODPOSTAL_PERS"].ToString();
                        this.TBoxPoblacion.Text = this._pers.datos["POBLACION_PERS"].ToString();
                        this.TBoxProvincia.Text = this._pers.datos["PROVINCIA_PERS"].ToString();
                        this.TBoxEmail.Text = this._pers.datos["EMAIL_PERS"].ToString();
                    }
                }
                catch (Exception err)
                {
                    SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                }
            }
            get
            {
                return this._pers;
            }
        }

        public void InicializarDesplegables()
        {

        }

        public FrmPersona(Persona p):base()
        {
            InitializeComponent();
            this.InicializarDesplegables();
            this.pers = p;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                this._pers.datos["NIF_PERS"] = this._pers.NormalizaNif(this.TBoxNif.Text);                
                this._pers.datos["NOMBRE_PERS"] = this.TBoxNombre.Text;                
                this._pers.datos["DIRE_PERS"] = this.TBoxDireccion.Text;                
                this._pers.datos["CODPOSTAL_PERS"] = this.TBoxCodPostal.Text;                
                this._pers.datos["POBLACION_PERS"] = this.TBoxPoblacion.Text;                
                this._pers.datos["PROVINCIA_PERS"] = this.TBoxProvincia.Text;
                this._pers.datos["EMAIL_PERS"] = this.TBoxEmail.Text;
                this._pers.Guardar();
                try
                {
                    this.pers = this.pers.parent.Buscar(Convert.ToInt64(this.pers.datos["ID_ELEM"].ToString()));
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
    }
}