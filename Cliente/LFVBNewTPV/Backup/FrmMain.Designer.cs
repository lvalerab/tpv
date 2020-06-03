namespace LFVBNewTPV
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BarrHerramientas = new CTCBASE.cBarraHerramientas();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.BarrEstado = new CTCBASE.cBarraHerramientas();
            this.CronometroSistema = new System.Windows.Forms.Timer(this.components);
            this.BarrPistola = new CTCBASE.cBarraHerramientas();
            this.LblFamiliaDef = new System.Windows.Forms.ToolStripLabel();
            this.CmbFamiliaDef = new System.Windows.Forms.ToolStripComboBox();
            this.LblSubFamiliaDef = new System.Windows.Forms.ToolStripLabel();
            this.CmbSubFamiliaDef = new System.Windows.Forms.ToolStripComboBox();
            this.LblNumItem = new System.Windows.Forms.ToolStripLabel();
            this.TBoxNumeroItemsEnt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TBoxlecturaCodigo = new System.Windows.Forms.ToolStripTextBox();
            this.BtnModoAlmacen = new System.Windows.Forms.ToolStripButton();
            this.BtnModoBusqueda = new System.Windows.Forms.ToolStripButton();
            this.LblUsuario = new System.Windows.Forms.ToolStripLabel();
            this.LblCaja = new System.Windows.Forms.ToolStripLabel();
            this.LblReloj = new System.Windows.Forms.ToolStripLabel();
            this.BtnTPV = new System.Windows.Forms.ToolStripButton();
            this.BtnCRM = new System.Windows.Forms.ToolStripDropDownButton();
            this.BtnClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnCambiarUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.BtnMaeDocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnTipoDocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnMaeFamiSubfami = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnMaeFamilias = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnMaeSubfamilias = new System.Windows.Forms.ToolStripMenuItem();
            this.tIPOSDEIVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnMaeCajas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnTipoPersonasMae = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEstadosReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnConfiguracion = new System.Windows.Forms.ToolStripButton();
            this.BtnTeclado = new System.Windows.Forms.ToolStripButton();
            this.BtnReservas = new System.Windows.Forms.ToolStripButton();
            this.BarrHerramientas.SuspendLayout();
            this.BarrEstado.SuspendLayout();
            this.BarrPistola.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarrHerramientas
            // 
            this.BarrHerramientas.AutoSize = false;
            this.BarrHerramientas.color_final = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BarrHerramientas.color_inicial = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BarrHerramientas.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarrHerramientas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BarrHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.BtnTPV,
            this.toolStripSeparator4,
            this.BtnCRM,
            this.BtnCerrar,
            this.toolStripSeparator1,
            this.BtnCambiarUsuario,
            this.toolStripSeparator2,
            this.toolStripSeparator5,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripSeparator6,
            this.BtnConfiguracion,
            this.toolStripSeparator7,
            this.BtnTeclado,
            this.toolStripSeparator8,
            this.BtnReservas});
            this.BarrHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarrHerramientas.Name = "BarrHerramientas";
            this.BarrHerramientas.Size = new System.Drawing.Size(97, 534);
            this.BarrHerramientas.TabIndex = 1;
            this.BarrHerramientas.Text = "cBarraHerramientas1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(95, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(95, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(95, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(95, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(95, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(95, 6);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(95, 6);
            // 
            // BarrEstado
            // 
            this.BarrEstado.color_final = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BarrEstado.color_inicial = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BarrEstado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BarrEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblUsuario,
            this.LblCaja,
            this.LblReloj});
            this.BarrEstado.Location = new System.Drawing.Point(97, 0);
            this.BarrEstado.Name = "BarrEstado";
            this.BarrEstado.Size = new System.Drawing.Size(959, 25);
            this.BarrEstado.TabIndex = 2;
            this.BarrEstado.Text = "cBarraHerramientas1";
            // 
            // CronometroSistema
            // 
            this.CronometroSistema.Enabled = true;
            this.CronometroSistema.Interval = 980;
            this.CronometroSistema.Tick += new System.EventHandler(this.CronometroSistema_Tick);
            // 
            // BarrPistola
            // 
            this.BarrPistola.AutoSize = false;
            this.BarrPistola.color_final = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BarrPistola.color_inicial = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BarrPistola.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BarrPistola.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnModoAlmacen,
            this.BtnModoBusqueda,
            this.LblFamiliaDef,
            this.CmbFamiliaDef,
            this.LblSubFamiliaDef,
            this.CmbSubFamiliaDef,
            this.LblNumItem,
            this.TBoxNumeroItemsEnt,
            this.toolStripLabel1,
            this.TBoxlecturaCodigo});
            this.BarrPistola.Location = new System.Drawing.Point(97, 25);
            this.BarrPistola.Name = "BarrPistola";
            this.BarrPistola.Size = new System.Drawing.Size(959, 29);
            this.BarrPistola.TabIndex = 3;
            this.BarrPistola.Text = "cBarraHerramientas1";
            // 
            // LblFamiliaDef
            // 
            this.LblFamiliaDef.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFamiliaDef.Name = "LblFamiliaDef";
            this.LblFamiliaDef.Size = new System.Drawing.Size(99, 26);
            this.LblFamiliaDef.Text = "Familia por Defecto";
            // 
            // CmbFamiliaDef
            // 
            this.CmbFamiliaDef.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFamiliaDef.Name = "CmbFamiliaDef";
            this.CmbFamiliaDef.Size = new System.Drawing.Size(121, 29);
            this.CmbFamiliaDef.SelectedIndexChanged += new System.EventHandler(this.CmbFamiliaDef_SelectedIndexChanged);
            // 
            // LblSubFamiliaDef
            // 
            this.LblSubFamiliaDef.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubFamiliaDef.Name = "LblSubFamiliaDef";
            this.LblSubFamiliaDef.Size = new System.Drawing.Size(114, 26);
            this.LblSubFamiliaDef.Text = "Subfamilia por defecto";
            // 
            // CmbSubFamiliaDef
            // 
            this.CmbSubFamiliaDef.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSubFamiliaDef.Name = "CmbSubFamiliaDef";
            this.CmbSubFamiliaDef.Size = new System.Drawing.Size(121, 29);
            // 
            // LblNumItem
            // 
            this.LblNumItem.Name = "LblNumItem";
            this.LblNumItem.Size = new System.Drawing.Size(21, 26);
            this.LblNumItem.Text = "Nº";
            // 
            // TBoxNumeroItemsEnt
            // 
            this.TBoxNumeroItemsEnt.MaxLength = 3;
            this.TBoxNumeroItemsEnt.Name = "TBoxNumeroItemsEnt";
            this.TBoxNumeroItemsEnt.Size = new System.Drawing.Size(35, 29);
            this.TBoxNumeroItemsEnt.Text = "1";
            this.TBoxNumeroItemsEnt.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxNumeroItemsEnt.TextChanged += new System.EventHandler(this.TBoxNumeroItemsEnt_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(224, 26);
            this.toolStripLabel1.Text = "Busqueda rapida producto, código de barras:";
            // 
            // TBoxlecturaCodigo
            // 
            this.TBoxlecturaCodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxlecturaCodigo.MaxLength = 40;
            this.TBoxlecturaCodigo.Name = "TBoxlecturaCodigo";
            this.TBoxlecturaCodigo.Size = new System.Drawing.Size(100, 29);
            this.TBoxlecturaCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBoxlecturaCodigo_KeyDown);
            this.TBoxlecturaCodigo.Enter += new System.EventHandler(this.TBoxlecturaCodigo_Enter);
            // 
            // BtnModoAlmacen
            // 
            this.BtnModoAlmacen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnModoAlmacen.Image = global::LFVBNewTPV.Properties.Resources.factory;
            this.BtnModoAlmacen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnModoAlmacen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModoAlmacen.Name = "BtnModoAlmacen";
            this.BtnModoAlmacen.Size = new System.Drawing.Size(28, 26);
            this.BtnModoAlmacen.Text = "Modo Almacen";
            this.BtnModoAlmacen.Click += new System.EventHandler(this.BtnModoAlmacen_Click);
            // 
            // BtnModoBusqueda
            // 
            this.BtnModoBusqueda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnModoBusqueda.Image = global::LFVBNewTPV.Properties.Resources.find;
            this.BtnModoBusqueda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnModoBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModoBusqueda.Name = "BtnModoBusqueda";
            this.BtnModoBusqueda.Size = new System.Drawing.Size(28, 26);
            this.BtnModoBusqueda.Text = "Modo Busqueda";
            this.BtnModoBusqueda.Click += new System.EventHandler(this.BtnModoBusqueda_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.Image = global::LFVBNewTPV.Properties.Resources.businessman;
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(66, 22);
            this.LblUsuario.Text = "Usuario:";
            // 
            // LblCaja
            // 
            this.LblCaja.Image = global::LFVBNewTPV.Properties.Resources.money2;
            this.LblCaja.Name = "LblCaja";
            this.LblCaja.Size = new System.Drawing.Size(86, 22);
            this.LblCaja.Text = "Caja Actual:";
            this.LblCaja.Visible = false;
            // 
            // LblReloj
            // 
            this.LblReloj.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LblReloj.Image = global::LFVBNewTPV.Properties.Resources.clock;
            this.LblReloj.Name = "LblReloj";
            this.LblReloj.Size = new System.Drawing.Size(16, 22);
            // 
            // BtnTPV
            // 
            this.BtnTPV.AutoSize = false;
            this.BtnTPV.Image = global::LFVBNewTPV.Properties.Resources.cashier;
            this.BtnTPV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnTPV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnTPV.Name = "BtnTPV";
            this.BtnTPV.Size = new System.Drawing.Size(78, 65);
            this.BtnTPV.Text = "T.P.V";
            this.BtnTPV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnTPV.ToolTipText = "Terminal Punto Venta";
            this.BtnTPV.Click += new System.EventHandler(this.BtnTPV_Click);
            // 
            // BtnCRM
            // 
            this.BtnCRM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnClientes,
            this.BtnProveedores,
            this.BtnProductos});
            this.BtnCRM.Image = global::LFVBNewTPV.Properties.Resources.user1_earth;
            this.BtnCRM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCRM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCRM.Name = "BtnCRM";
            this.BtnCRM.Size = new System.Drawing.Size(95, 67);
            this.BtnCRM.Text = "CRM";
            this.BtnCRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCRM.ToolTipText = "Clientes - Proveedores - Productos";
            // 
            // BtnClientes
            // 
            this.BtnClientes.Image = global::LFVBNewTPV.Properties.Resources.businessman1;
            this.BtnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(184, 54);
            this.BtnClientes.Text = "CLIENTES";
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.Image = global::LFVBNewTPV.Properties.Resources.businessmen;
            this.BtnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(184, 54);
            this.BtnProveedores.Text = "PROVEEDORES";
            this.BtnProveedores.Visible = false;
            // 
            // BtnProductos
            // 
            this.BtnProductos.Image = global::LFVBNewTPV.Properties.Resources.box;
            this.BtnProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(184, 54);
            this.BtnProductos.Text = "PRODUCTOS";
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrar.Image = global::LFVBNewTPV.Properties.Resources.error;
            this.BtnCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(95, 67);
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnCambiarUsuario
            // 
            this.BtnCambiarUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCambiarUsuario.Image = global::LFVBNewTPV.Properties.Resources.user1_back;
            this.BtnCambiarUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCambiarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCambiarUsuario.Name = "BtnCambiarUsuario";
            this.BtnCambiarUsuario.Size = new System.Drawing.Size(95, 67);
            this.BtnCambiarUsuario.Text = "Cerrar Session";
            this.BtnCambiarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCambiarUsuario.Click += new System.EventHandler(this.BtnCambiarUsuario_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = global::LFVBNewTPV.Properties.Resources.data_disk;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(95, 67);
            this.toolStripButton2.Text = "Copia Seg.";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMaeDocumentos,
            this.BtnMaeFamiSubfami,
            this.tIPOSDEIVAToolStripMenuItem,
            this.BtnMaeCajas,
            this.BtnTipoPersonasMae,
            this.BtnEstadosReservas});
            this.toolStripButton1.Image = global::LFVBNewTPV.Properties.Resources.data_edit;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(95, 67);
            this.toolStripButton1.Text = "Tablas Maestras";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // BtnMaeDocumentos
            // 
            this.BtnMaeDocumentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnTipoDocumentos});
            this.BtnMaeDocumentos.Image = global::LFVBNewTPV.Properties.Resources.address_book;
            this.BtnMaeDocumentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnMaeDocumentos.Name = "BtnMaeDocumentos";
            this.BtnMaeDocumentos.Size = new System.Drawing.Size(242, 54);
            this.BtnMaeDocumentos.Text = "DOCUMENTOS";
            // 
            // BtnTipoDocumentos
            // 
            this.BtnTipoDocumentos.Image = global::LFVBNewTPV.Properties.Resources.document_dirty;
            this.BtnTipoDocumentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnTipoDocumentos.Name = "BtnTipoDocumentos";
            this.BtnTipoDocumentos.Size = new System.Drawing.Size(329, 54);
            this.BtnTipoDocumentos.Text = "TIPOS DE DOCUMENTOS Y CONTADORES";
            this.BtnTipoDocumentos.Click += new System.EventHandler(this.BtnTipoDocumentos_Click);
            // 
            // BtnMaeFamiSubfami
            // 
            this.BtnMaeFamiSubfami.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMaeFamilias,
            this.BtnMaeSubfamilias});
            this.BtnMaeFamiSubfami.Image = global::LFVBNewTPV.Properties.Resources.index;
            this.BtnMaeFamiSubfami.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnMaeFamiSubfami.Name = "BtnMaeFamiSubfami";
            this.BtnMaeFamiSubfami.Size = new System.Drawing.Size(242, 54);
            this.BtnMaeFamiSubfami.Text = "FAMILIAS Y SUBFAMILIAS";
            // 
            // BtnMaeFamilias
            // 
            this.BtnMaeFamilias.Image = global::LFVBNewTPV.Properties.Resources.box;
            this.BtnMaeFamilias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnMaeFamilias.Name = "BtnMaeFamilias";
            this.BtnMaeFamilias.Size = new System.Drawing.Size(178, 54);
            this.BtnMaeFamilias.Text = "FAMILIAS";
            this.BtnMaeFamilias.Click += new System.EventHandler(this.BtnMaeFamilias_Click);
            // 
            // BtnMaeSubfamilias
            // 
            this.BtnMaeSubfamilias.Image = global::LFVBNewTPV.Properties.Resources.box;
            this.BtnMaeSubfamilias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnMaeSubfamilias.Name = "BtnMaeSubfamilias";
            this.BtnMaeSubfamilias.Size = new System.Drawing.Size(178, 54);
            this.BtnMaeSubfamilias.Text = "SUBFAMILIAS";
            this.BtnMaeSubfamilias.Click += new System.EventHandler(this.BtnMaeSubfamilias_Click);
            // 
            // tIPOSDEIVAToolStripMenuItem
            // 
            this.tIPOSDEIVAToolStripMenuItem.Image = global::LFVBNewTPV.Properties.Resources.money21;
            this.tIPOSDEIVAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tIPOSDEIVAToolStripMenuItem.Name = "tIPOSDEIVAToolStripMenuItem";
            this.tIPOSDEIVAToolStripMenuItem.Size = new System.Drawing.Size(242, 54);
            this.tIPOSDEIVAToolStripMenuItem.Text = "TIPOS DE IVA";
            this.tIPOSDEIVAToolStripMenuItem.Click += new System.EventHandler(this.tIPOSDEIVAToolStripMenuItem_Click);
            // 
            // BtnMaeCajas
            // 
            this.BtnMaeCajas.Image = global::LFVBNewTPV.Properties.Resources.cashier;
            this.BtnMaeCajas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnMaeCajas.Name = "BtnMaeCajas";
            this.BtnMaeCajas.Size = new System.Drawing.Size(242, 54);
            this.BtnMaeCajas.Text = "CAJAS";
            this.BtnMaeCajas.Visible = false;
            // 
            // BtnTipoPersonasMae
            // 
            this.BtnTipoPersonasMae.Image = global::LFVBNewTPV.Properties.Resources.businessmen;
            this.BtnTipoPersonasMae.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnTipoPersonasMae.Name = "BtnTipoPersonasMae";
            this.BtnTipoPersonasMae.Size = new System.Drawing.Size(242, 54);
            this.BtnTipoPersonasMae.Text = "PERSONAS";
            this.BtnTipoPersonasMae.Visible = false;
            this.BtnTipoPersonasMae.Click += new System.EventHandler(this.BtnTipoPersonasMae_Click);
            // 
            // BtnEstadosReservas
            // 
            this.BtnEstadosReservas.Image = global::LFVBNewTPV.Properties.Resources.index;
            this.BtnEstadosReservas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnEstadosReservas.Name = "BtnEstadosReservas";
            this.BtnEstadosReservas.Size = new System.Drawing.Size(242, 54);
            this.BtnEstadosReservas.Text = "ESTADOS RESERVAS";
            this.BtnEstadosReservas.Click += new System.EventHandler(this.BtnEstadosReservas_Click);
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnConfiguracion.Image = global::LFVBNewTPV.Properties.Resources.gear_warning;
            this.BtnConfiguracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnConfiguracion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Size = new System.Drawing.Size(87, 67);
            this.BtnConfiguracion.Text = "Configuración";
            this.BtnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnConfiguracion.ToolTipText = "Configuración";
            this.BtnConfiguracion.Click += new System.EventHandler(this.BtnConfiguracion_Click);
            // 
            // BtnTeclado
            // 
            this.BtnTeclado.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnTeclado.Image = global::LFVBNewTPV.Properties.Resources.keyboard1;
            this.BtnTeclado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnTeclado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnTeclado.Name = "BtnTeclado";
            this.BtnTeclado.Size = new System.Drawing.Size(90, 67);
            this.BtnTeclado.Text = "Teclado Virtual";
            this.BtnTeclado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnTeclado.Click += new System.EventHandler(this.BtnTeclado_Click);
            // 
            // BtnReservas
            // 
            this.BtnReservas.Image = global::LFVBNewTPV.Properties.Resources.document_dirty;
            this.BtnReservas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnReservas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnReservas.Name = "BtnReservas";
            this.BtnReservas.Size = new System.Drawing.Size(56, 67);
            this.BtnReservas.Text = "Reservas";
            this.BtnReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnReservas.Click += new System.EventHandler(this.BtnReservas_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 534);
            this.Controls.Add(this.BarrPistola);
            this.Controls.Add(this.BarrEstado);
            this.Controls.Add(this.BarrHerramientas);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmMain";
            this.Text = "TPV version";
            this.Controls.SetChildIndex(this.BarrHerramientas, 0);
            this.Controls.SetChildIndex(this.BarrEstado, 0);
            this.Controls.SetChildIndex(this.BarrPistola, 0);
            this.BarrHerramientas.ResumeLayout(false);
            this.BarrHerramientas.PerformLayout();
            this.BarrEstado.ResumeLayout(false);
            this.BarrEstado.PerformLayout();
            this.BarrPistola.ResumeLayout(false);
            this.BarrPistola.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTCBASE.cBarraHerramientas BarrHerramientas;
        private System.Windows.Forms.ToolStripButton BtnTPV;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnCambiarUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private CTCBASE.cBarraHerramientas BarrEstado;
        private System.Windows.Forms.ToolStripLabel LblUsuario;
        private System.Windows.Forms.ToolStripLabel LblCaja;
        private System.Windows.Forms.ToolStripLabel LblReloj;
        private System.Windows.Forms.Timer CronometroSistema;
        private System.Windows.Forms.ToolStripButton BtnConfiguracion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton BtnTeclado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private CTCBASE.cBarraHerramientas BarrPistola;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TBoxlecturaCodigo;
        private System.Windows.Forms.ToolStripLabel LblFamiliaDef;
        private System.Windows.Forms.ToolStripComboBox CmbFamiliaDef;
        private System.Windows.Forms.ToolStripLabel LblSubFamiliaDef;
        private System.Windows.Forms.ToolStripComboBox CmbSubFamiliaDef;
        private System.Windows.Forms.ToolStripButton BtnModoAlmacen;
        private System.Windows.Forms.ToolStripButton BtnModoBusqueda;
        private System.Windows.Forms.ToolStripLabel LblNumItem;
        private System.Windows.Forms.ToolStripTextBox TBoxNumeroItemsEnt;
        private System.Windows.Forms.ToolStripDropDownButton BtnCRM;
        private System.Windows.Forms.ToolStripMenuItem BtnClientes;
        private System.Windows.Forms.ToolStripMenuItem BtnProveedores;
        private System.Windows.Forms.ToolStripMenuItem BtnProductos;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem BtnMaeDocumentos;
        private System.Windows.Forms.ToolStripMenuItem BtnTipoDocumentos;
        private System.Windows.Forms.ToolStripMenuItem BtnMaeFamiSubfami;
        private System.Windows.Forms.ToolStripMenuItem BtnMaeFamilias;
        private System.Windows.Forms.ToolStripMenuItem BtnMaeSubfamilias;
        private System.Windows.Forms.ToolStripMenuItem tIPOSDEIVAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnMaeCajas;
        private System.Windows.Forms.ToolStripMenuItem BtnTipoPersonasMae;
        private System.Windows.Forms.ToolStripButton BtnReservas;
        private System.Windows.Forms.ToolStripMenuItem BtnEstadosReservas;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}