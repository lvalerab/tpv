using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLSBASE.CRM.PRODUCTOS;
using CLSBASE.CRM.DOCUMENTOS;
using CLSBASE.CRM.PERSONAS;

namespace LFVBNewTPV
{
    public enum MODO_BARRA_BUSQ
    {
        BUSQUEDA,
        ALMACEN
    }

    public partial class FrmMain : CTCBASE.cMdiFormBase
    {
        private MODO_BARRA_BUSQ _modobarra;

        public MODO_BARRA_BUSQ ModoBarra
        {
            set
            {
                this._modobarra = value;
                switch (this._modobarra)
                {
                    case MODO_BARRA_BUSQ.ALMACEN:
                        this.BtnModoBusqueda.Visible = true;
                        this.BtnModoAlmacen.Visible = false;
                        this.LblFamiliaDef.Visible = true;
                        this.CmbFamiliaDef.Visible = true;
                        this.LblSubFamiliaDef.Visible = true;
                        this.CmbSubFamiliaDef.Visible = true;
                        this.LblNumItem.Visible = true;
                        this.TBoxNumeroItemsEnt.Visible = true;
                        break;
                    case MODO_BARRA_BUSQ.BUSQUEDA:
                        this.BtnModoBusqueda.Visible = false;
                        this.BtnModoAlmacen.Visible = true;
                        this.LblFamiliaDef.Visible = false;
                        this.CmbFamiliaDef.Visible = false;
                        this.LblSubFamiliaDef.Visible = false;
                        this.CmbSubFamiliaDef.Visible = false;
                        this.LblNumItem.Visible = false;
                        this.TBoxNumeroItemsEnt.Visible = false;
                        break;
                }
            }
            get
            {
                return this._modobarra;
            }
        }

        private Productos listadoGenProd;

        private void InicializarBarraBusqueda()
        {
            this.listadoGenProd = Productos.ObtenInstancia();

            Subfamilias auxSF = Subfamilias.ObtenInstancia();
            this.CmbSubFamiliaDef.ComboBox.DataSource = auxSF.Datos.Copy();
            this.CmbSubFamiliaDef.ComboBox.DisplayMember = "NOMBRE_SUFA";
            this.CmbSubFamiliaDef.ComboBox.ValueMember = "COD_FAMI";
            
            Familias auxF = Familias.ObtenInstancia();
            this.CmbFamiliaDef.ComboBox.DataSource = auxF.Datos.Copy();
            this.CmbFamiliaDef.ComboBox.DisplayMember = "NOMBRE_FAMI";
            this.CmbFamiliaDef.ComboBox.ValueMember = "COD_FAMI";
            if (this.CmbFamiliaDef.ComboBox.SelectedValue != null)
            {
                ((DataTable)this.CmbSubFamiliaDef.ComboBox.DataSource).DefaultView.RowFilter = "COD_FAMI='" + this.CmbFamiliaDef.ComboBox.SelectedValue.ToString() + "'";
            }
        }

        private void CmbFamiliaDef_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((DataTable)this.CmbSubFamiliaDef.ComboBox.DataSource).DefaultView.RowFilter = "COD_FAMI='" + this.CmbFamiliaDef.ComboBox.SelectedValue.ToString() + "'";
        }

        private void BtnModoAlmacen_Click(object sender, EventArgs e)
        {
            this.ModoBarra = MODO_BARRA_BUSQ.ALMACEN;
        }

        private void TBoxNumeroItemsEnt_TextChanged(object sender, EventArgs e)
        {
            if (this.TBoxNumeroItemsEnt.Text.Trim() != "")
            {
                try
                {
                    Int32 aux = Convert.ToInt32(this.TBoxNumeroItemsEnt.Text);
                }
                catch (Exception err)
                {
                    this.TBoxNumeroItemsEnt.Text = "1";
                }
            }
            else
            {
                this.TBoxNumeroItemsEnt.Text = "1";
            }
        }

        private void BtnModoBusqueda_Click(object sender, EventArgs e)
        {
            this.ModoBarra = MODO_BARRA_BUSQ.BUSQUEDA;
        }

        private void TBoxlecturaCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && this.TBoxlecturaCodigo.Text != "")
            {
                DataRow[] prod = this.listadoGenProd.Datos.Select("COD_BARRAS='" + this.TBoxlecturaCodigo.Text + "'");
                if (prod.Length > 0)
                {
                    if (prod.Length == 1)
                    {
                        Producto aux = this.listadoGenProd.Buscar(Convert.ToInt64(prod[0]["ID_ELEM"]));
                        switch (this.ModoBarra)
                        {
                            case MODO_BARRA_BUSQ.BUSQUEDA:
                                if (aux != null)
                                {
                                    CRM.PRODUCTOS.FrmProducto FrmFichaProd = new LFVBNewTPV.CRM.PRODUCTOS.FrmProducto(aux);
                                    FrmFichaProd.MdiParent = this;
                                    FrmFichaProd.Show();
                                }
                                break;
                            case MODO_BARRA_BUSQ.ALMACEN:
                                //prod[0]["EXISTENCIAS_PROD"] = Convert.ToInt64((prod[0]["EXISTENCIAS_PROD"].ToString() != "" ? prod[0]["EXISTENCIAS_PROD"].ToString() : "0")) + Convert.ToInt32((this.TBoxNumeroItemsEnt.Text.Trim()!=""?this.TBoxNumeroItemsEnt.Text:"1"));
                                if (aux != null)
                                {
                                    aux.ActualizaStock(Convert.ToInt32((this.TBoxNumeroItemsEnt.Text.Trim()!=""?this.TBoxNumeroItemsEnt.Text:"1")));
                                    aux.Guardar();
                                }
                                this.listadoGenProd.Refrescar();
                                break;
                        }
                    }
                    else
                    {
                        CRM.PRODUCTOS.FrmProductos FrmListado = new LFVBNewTPV.CRM.PRODUCTOS.FrmProductos();
                        FrmListado.MdiParent = this;
                        FrmListado.Show();
                        FrmListado.TBoxFiltroCodBarras.Text = this.TBoxlecturaCodigo.Text;
                    }
                }
                else
                {
                    if (MessageBox.Show("El producto no existe, ¿Desea crearlo?", "Producto inexistente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Producto aux = this.listadoGenProd.Nuevo();
                        string codfami=(this.CmbFamiliaDef.ComboBox.SelectedValue != null ? this.CmbFamiliaDef.ComboBox.SelectedValue.ToString() : "");
                        string codsufa = (this.CmbSubFamiliaDef.ComboBox.SelectedValue != null ? this.CmbSubFamiliaDef.ComboBox.SelectedValue.ToString() : "");
                        CRM.PRODUCTOS.FrmProducto FrmFichaProd = new LFVBNewTPV.CRM.PRODUCTOS.FrmProducto(aux, this.TBoxlecturaCodigo.Text,codfami ,codsufa ,this.TBoxNumeroItemsEnt.Text);
                        FrmFichaProd.MdiParent = this;
                        FrmFichaProd.Show();
                    }
                }
            }
        }

        private void PonHoraReloj()
        {
            this.LblReloj.Text=DateTime.Now.ToLongDateString()+" - "+DateTime.Now.ToLongTimeString();
        }

        private void CargaDatosUsuario()
        {
            this.LblUsuario.Text = CLSBASE.IGlobal.user.datos.Rows[0]["NOMBRE_USUA"].ToString();
        }

        private void MuestraBarraCodigoBarras()
        {
            if (this.MdiChildren.Length <= 0 && this.BarrPistola.Visible==false && global::LFVBNewTPV.Properties.Settings.Default.ACTIVAR_BARRA_BUSQ_RAP)
            {
                this.BarrPistola.Visible = true;
                this.TBoxlecturaCodigo.Focus();
            }
            else
            {
                if(this.MdiChildren.Length>0) 
                    this.BarrPistola.Visible = false;
            }
        }
         
        private void CronometroSistema_Tick(object sender, EventArgs e)
        {
            this.PonHoraReloj();
            this.MuestraBarraCodigoBarras();
        }

        public FrmMain()
        {
            InitializeComponent();
            this.InicializarBarraBusqueda();
            this.Text = "TPV version " + Application.ProductVersion;
            this.PonHoraReloj();
            this.CargaDatosUsuario();
            this.ModoBarra = MODO_BARRA_BUSQ.BUSQUEDA;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicacion?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.MdiChildren.Length > 0)
                {
                    if (MessageBox.Show("¿Desea cerrar todas las ventanas?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (Form f in this.MdiChildren)
                        {
                            f.Close();
                        }
                        Application.Exit();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            SISTEMA.CONFIGURACION.FrmConfiguracion FrmConf = new LFVBNewTPV.SISTEMA.CONFIGURACION.FrmConfiguracion();
            FrmConf.MdiParent = this;
            FrmConf.Show();
        }

        private void BtnCambiarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar su sesion actual?", "Cerrar Session", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool continuar = true;
                if (this.MdiChildren.Length > 0)
                {
                    if (MessageBox.Show("Se cerraran todas las ventanas abiertas, ¿Desea continuar?", "Cierre de ventanas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (Int32 i = this.MdiChildren.Length-1; i >=0 ; i--)
                        {
                            this.MdiChildren[i].Close();
                        }
                    }
                    else
                    {
                        continuar = false;
                    }
                }
                if (continuar)
                {
                    this.BarrHerramientas.Enabled = false;
                    Int32 contador = 0;
                    SISTEMA.VALIDACION.FrmValidarUsuario FrmVal = new LFVBNewTPV.SISTEMA.VALIDACION.FrmValidarUsuario();
                    CLSBASE.IGlobal.user = CLSBASE.SISTEMA.USUARIOS.Usuario.Validar("", "");
                    while (contador < 3 && !CLSBASE.IGlobal.user.valido)
                    {
                        FrmVal.ShowDialog();
                        if (FrmVal.resultado == DialogResult.Cancel)
                        {
                            contador = 3;
                        }
                        else
                        {
                            CLSBASE.IGlobal.user = CLSBASE.SISTEMA.USUARIOS.Usuario.Validar(FrmVal.TBoxUsuario.Text, FrmVal.TBoxPassword.Text);
                            if (CLSBASE.IGlobal.user.valido)
                            {
                                contador = 3;
                            }
                            else
                            {
                                contador++;
                            }
                        }
                    }
                    if (!CLSBASE.IGlobal.user.valido)
                    {
                        MessageBox.Show("Ha superado el máximo de veces que se puede validar, la aplicación se cerrará", "Máximo número de intentos de validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        this.BarrHerramientas.Enabled = true;
                        this.CargaDatosUsuario();
                    }
                }
            }
            
        }

        private void BtnTeclado_Click(object sender, EventArgs e)
        {
            ClsUtils.IGlobal.teclado.Lanzar();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            try
            {
                CRM.PRODUCTOS.FrmProductos FrmProds = new CRM.PRODUCTOS.FrmProductos();
                FrmProds.MdiParent = this;
                FrmProds.Show();
            }
            catch (Exception err)
            {
                SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
            }
        }

        private void BtnTipoDocumentos_Click(object sender, EventArgs e)
        {
            TipoDocumentos TipoDoc=TipoDocumentos.ObtenInstancia();
            MAE.FrmMae FrmConfMae = new LFVBNewTPV.MAE.FrmMae(TipoDoc);
            FrmConfMae.MdiParent = this;
            FrmConfMae.Show();
        }

        private void BtnMaeFamilias_Click(object sender, EventArgs e)
        {
            Familias Fami = Familias.ObtenInstancia();
            MAE.FrmMae FrmConfMae = new LFVBNewTPV.MAE.FrmMae(Fami);
            FrmConfMae.MdiParent = this;
            FrmConfMae.Show();
        }

        private void BtnMaeSubfamilias_Click(object sender, EventArgs e)
        {
            Subfamilias SubFami = Subfamilias.ObtenInstancia();
            MAE.FrmMae FrmConfMae = new LFVBNewTPV.MAE.FrmMae(SubFami);
            FrmConfMae.MdiParent = this;
            FrmConfMae.Show();
        }

        private void tIPOSDEIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IVA MaeIva = IVA.ObtenInstancia();
            MAE.FrmMae FrmConfMae = new LFVBNewTPV.MAE.FrmMae(MaeIva);
            FrmConfMae.MdiParent = this;
            FrmConfMae.Show();
        }

        private void BtnTipoPersonasMae_Click(object sender, EventArgs e)
        {
            TipoPersonas TipPersonas = TipoPersonas.ObtenInstancia();
            MAE.FrmMae FrmConfMae = new LFVBNewTPV.MAE.FrmMae(TipPersonas);
            FrmConfMae.MdiParent = this;
            FrmConfMae.Show();
        }

        private void BtnEstadosReservas_Click(object sender, EventArgs e)
        {
            CLSBASE.CRM.RESERVAS.EstadoReservas EstReservas = CLSBASE.CRM.RESERVAS.EstadoReservas.ObtenInstancia();
            MAE.FrmMae FrmConfMae = new LFVBNewTPV.MAE.FrmMae(EstReservas);
            FrmConfMae.MdiParent = this;
            FrmConfMae.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {   
            CRM.PERSONAS.FrmPersonas FrmLstPers = new LFVBNewTPV.CRM.PERSONAS.FrmPersonas();
            FrmLstPers.MdiParent = this;
            FrmLstPers.Show();
        }

        private void BtnTPV_Click(object sender, EventArgs e)
        {
            TPV.FrmDocumentos FrmLstDocu = new LFVBNewTPV.TPV.FrmDocumentos();
            FrmLstDocu.MdiParent = this;
            FrmLstDocu.Show();
        }

        private void BtnReservas_Click(object sender, EventArgs e)
        {
            RESERVAS.FrmReservas FrmLstRes = new LFVBNewTPV.RESERVAS.FrmReservas();
            FrmLstRes.MdiParent = this;
            FrmLstRes.Show();
        }

        private void TBoxlecturaCodigo_Enter(object sender, EventArgs e)
        {
            this.TBoxlecturaCodigo.SelectAll();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SISTEMA.UTILES.FrmCopiaSeguridad FrmCopia = new LFVBNewTPV.SISTEMA.UTILES.FrmCopiaSeguridad();
            FrmCopia.ShowDialog();
        }


    }
}