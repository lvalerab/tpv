using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLSBASE.INTERFACES;
using CLSBASE.CRM.PRODUCTOS;
using CLSBASE.CRM.DOCUMENTOS;
using CLSBASE.CRM.PERSONAS;
using CLSBASE.CRM.RESERVAS;


namespace LFVBNewTPV.MAE
{
    public partial class FrmMae : SISTEMA.FrmBase
    {
        private IMaestro _maestro;

        private void CargaDatosGrid()
        {
            switch (this._maestro.GetType().Name)
            {
                case "TipoDocumentos":
                    this.Text += " Tipos de documentos -Facturas, Tickets, abonos, etc...-";
                    this.DGDatos.DataSource = ((TipoDocumentos)this.maestro).Datos;
                    break;
                case "TipoPersonas":
                    this.Text += "Tipos de personas -Proveedores, Clientes, etc..";
                    this.DGDatos.DataSource=((TipoPersonas)this.maestro).Datos;
                    break;
                case "Familias":
                    this.Text += " Familias de productos";
                    this.DGDatos.DataSource = ((Familias)this.maestro).Datos;
                    break;
                case "Subfamilias":
                    this.Text += " Subfamilias de productos";
                    this.DGDatos.DataSource=((Subfamilias)this.maestro).Datos;
                    break;
                case "IVA":                    
                    this.Text += " Mantenimiento de tipos de I.V.A";
                    this.DGDatos.DataSource = ((IVA)this.maestro).Datos;
                    this.TSUtilsAplicaTipoIva.Visible = true;
                    break;
                case "EstadoReservas":
                    this.Text += " Mantenimiento de Estados de Reservas";
                    this.DGDatos.DataSource = ((EstadoReservas)this.maestro).Datos;
                    break;
            }
        }

        public void ConfiguraColumnasMae()
        {
            switch (this._maestro.GetType().Name)
            {
                case "TipoDocumentos":
                    this.cFamilias.Visible = false;
                    this.cPorIva.Visible = false;
                    this.cVigenteIva.Visible = false;
                    break;
                case "TipoPersonas":
                    this.cFamilias.Visible = false;
                    this.cPorIva.Visible = false;
                    this.cVigenteIva.Visible = false;
                    break;
                case "Familias":
                    this.cFamilias.Visible = false;
                    this.cPorIva.Visible = false;
                    this.cVigenteIva.Visible = false;
                    break;
                case "Subfamilias":
                    this.cFamilias.Visible = true;
                    this.cPorIva.Visible = false;
                    this.cVigenteIva.Visible = false;
                    Familias aux = Familias.ObtenInstancia();
                    this.cFamilias.DataSource = aux.Datos.Copy();
                    this.cFamilias.ValueMember = "COD_FAMI";
                    this.cFamilias.DisplayMember = "NOMBRE_FAMI";
                    this.cFamilias.DataPropertyName = "COD_FAMI";
                    break;
                case "IVA":
                    this.cFamilias.Visible = false;
                    this.cPorIva.Visible = true;
                    this.cVigenteIva.Visible = true;
                    break;
                case "EstadoReservas":
                    this.cFamilias.Visible = false;
                    this.cPorIva.Visible = false;
                    this.cVigenteIva.Visible = false;
                    break;
            }
        }

        public IMaestro maestro
        {
            set
            {
                this._maestro = value;
                if (this._maestro != null)
                {
                    this.ConfiguraColumnasMae();
                }
                this.CargaDatosGrid();
            }
            get
            {
                return this._maestro;
            }
        }

        public FrmMae(IMaestro mae):base()
        {
            InitializeComponent();
            this.TSUtilsAplicaTipoIva.Visible = false;
            this.maestro = mae;
        }

        private void DGDatos_DataSourceChanged(object sender, EventArgs e)
        {
            switch (this.maestro.GetType().Name)
            {
                case "TipoDocumentos":                    
                    foreach (DataGridViewColumn c in this.DGDatos.Columns)
                    {
                        switch (c.DataPropertyName)
                        {
                            case "COD_TIDO":
                                c.HeaderText = "Código";
                                ((DataGridViewTextBoxColumn)c).MaxInputLength = 3;
                                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                break;
                            case "DESCR_TIDO":
                                c.HeaderText = "Descripción";
                                ((DataGridViewTextBoxColumn)c).MaxInputLength = 60;
                                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                break;
                        }
                    }
                    break;
                case "TipoPersonas":
                    foreach (DataGridViewColumn c in this.DGDatos.Columns)
                    {
                        switch (c.DataPropertyName)
                        {
                            case "COD_TIPE":
                                c.HeaderText = "Código";
                                ((DataGridViewTextBoxColumn)c).MaxInputLength = 2;
                                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                break;
                            case "DESC_TIPE":
                                c.HeaderText = "Descripción";
                                ((DataGridViewTextBoxColumn)c).MaxInputLength = 60;
                                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                break;
                        }
                    }
                    break;
                case "Familias":
                    foreach (DataGridViewColumn c in this.DGDatos.Columns)
                    {
                        switch (c.DataPropertyName)
                        {
                            case "COD_FAMI":
                                c.HeaderText = "Código";
                                ((DataGridViewTextBoxColumn)c).MaxInputLength = 5;
                                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                break;
                            case "NOMBRE_FAMI":
                                c.HeaderText = "Nombre";
                                ((DataGridViewTextBoxColumn)c).MaxInputLength = 60;
                                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                break;
                        }
                    }
                    break;
                case "Subfamilias":
                    foreach (DataGridViewColumn c in this.DGDatos.Columns)
                    {
                        switch (c.DataPropertyName)
                        {
                            case "COD_SUFA":
                                c.HeaderText = "Código";
                                ((DataGridViewTextBoxColumn)c).MaxInputLength = 5;
                                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                break;
                            case "NOMBRE_SUFA":
                                c.HeaderText = "Nombre";
                                ((DataGridViewTextBoxColumn)c).MaxInputLength = 60;
                                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                break;
                        }
                    }
                    break;
                case "IVA":
                    foreach (DataGridViewColumn c in this.DGDatos.Columns)
                    {
                        switch (c.DataPropertyName)
                        {
                            case "COD_TIVA":
                                c.HeaderText = "Código";
                                ((DataGridViewTextBoxColumn)c).MaxInputLength = 3;
                                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                break;
                            case "DESCR_TIVA":
                                c.HeaderText = "Nombre";
                                ((DataGridViewTextBoxColumn)c).MaxInputLength = 60;
                                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                break;
                            case "DEFECTO_TIVA":
                                c.Visible = false;
                                break;
                                
                        }
                    }
                    break;
                case "EstadoReservas":
                    foreach (DataGridViewColumn c in this.DGDatos.Columns)
                    {
                        switch (c.DataPropertyName)
                        {
                            case "COD_ESRE":
                                c.HeaderText = "Código";
                                ((DataGridViewTextBoxColumn)c).MaxInputLength = 3;
                                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                break;
                            case "DESCR_ESRE":
                                c.HeaderText = "Estado";
                                ((DataGridViewTextBoxColumn)c).MaxInputLength = 60;
                                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                break;
                            case "DESCARGABLE":
                                c.Visible = false;
                                break;

                        }
                    }
                    break;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.maestro.refrescar();
            }
            catch (Exception err)
            {
                SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
            }
        }

        private void TSUtilsAplicaTipoIva_Click(object sender, EventArgs e)
        {
            UTILIDADES.FrmAplicarTipoIvaNuevo FrmAplicaIva = new LFVBNewTPV.MAE.UTILIDADES.FrmAplicarTipoIvaNuevo();
            FrmAplicaIva.ShowDialog();
        }
    }
}