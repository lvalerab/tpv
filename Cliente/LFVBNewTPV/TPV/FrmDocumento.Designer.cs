namespace LFVBNewTPV.TPV
{
    partial class FrmDocumento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGLineas = new CTGRIDBASE.GRID.DataGridViewBase();
            this.CIdElemCab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIdelem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdElemProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTextoLido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantidad = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.CPrecioBruto = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.CPorIva = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.cPVP = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.cTotalLinea = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.cLabelBase1 = new CTCBASE.cLabelBase();
            this.cLabelBase2 = new CTCBASE.cLabelBase();
            this.cLabelBase3 = new CTCBASE.cLabelBase();
            this.LblNombreCliente = new CTCBASE.cLabelBase();
            this.cLabelBase4 = new CTCBASE.cLabelBase();
            this.LblIdCliente = new CTCBASE.cLabelBase();
            this.LblNifCliente = new CTCBASE.cLabelBase();
            this.LblDireccionCliente = new CTCBASE.cLabelBase();
            this.LblDireccion2Cliente = new CTCBASE.cLabelBase();
            this.HerramientasTPV = new CTCBASE.cBarraHerramientas();
            this.BtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnBuscarPersona = new System.Windows.Forms.ToolStripButton();
            this.BtnBuscarProducto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCobrar = new System.Windows.Forms.ToolStripButton();
            this.BtnSalir = new System.Windows.Forms.ToolStripButton();
            this.BtnImprimirDoc = new System.Windows.Forms.ToolStripButton();
            this.cLabelBase5 = new CTCBASE.cLabelBase();
            this.cLabelBase6 = new CTCBASE.cLabelBase();
            this.cLabelBase7 = new CTCBASE.cLabelBase();
            this.LblAnyoDocumento = new CTCBASE.cLabelBase();
            this.LblNumeroDocumento = new CTCBASE.cLabelBase();
            this.LblTipoDocumento = new CTCBASE.cLabelBase();
            this.cLabelBase11 = new CTCBASE.cLabelBase();
            this.LblFechaDocumento = new CTCBASE.cLabelBase();
            this.cLabelBase8 = new CTCBASE.cLabelBase();
            this.cLabelBase9 = new CTCBASE.cLabelBase();
            this.cLabelBase10 = new CTCBASE.cLabelBase();
            this.cLabelBase12 = new CTCBASE.cLabelBase();
            this.cLabelBase13 = new CTCBASE.cLabelBase();
            this.cLabelBase14 = new CTCBASE.cLabelBase();
            this.TBoxRefProdIn = new CTCBASE.cTextBoxBase();
            this.TBoxTextoLinIn = new CTCBASE.cTextBoxBase();
            this.LblPrecioBrutoIn = new CTCBASE.cLabelBase();
            this.TBoxCantidadIn = new CTCBASE.cNumericBoxBase();
            this.LblPorIvaIn = new CTCBASE.cLabelBase();
            this.TBoxPrecioVentaIn = new CTCBASE.cNumericBoxBase();
            this.cLabelBase15 = new CTCBASE.cLabelBase();
            this.LblTotalBruto = new CTCBASE.cLabelBase();
            this.LblTotalDocu = new CTCBASE.cLabelBase();
            this.cLabelBase17 = new CTCBASE.cLabelBase();
            this.LblTotalPagado = new CTCBASE.cLabelBase();
            this.cLabelBase19 = new CTCBASE.cLabelBase();
            this.TBoxIdProd = new CTCBASE.cNumericBoxBase();
            this.cLabelBase16 = new CTCBASE.cLabelBase();
            this.cLabelBase18 = new CTCBASE.cLabelBase();
            this.BtnGuardarLinea = new CTCBASE.cBoton();
            this.BtnMenosCantidad = new CTCBASE.cBoton();
            this.BtnMasCantidad = new CTCBASE.cBoton();
            this.BtnEliminarLinea = new CTCBASE.cBoton();
            this.btnSelectProds = new LFVBNewTPV.COMP.BtnSelectProds();
            ((System.ComponentModel.ISupportInitialize)(this.DGLineas)).BeginInit();
            this.HerramientasTPV.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGLineas
            // 
            this.DGLineas.AllowUserToAddRows = false;
            this.DGLineas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGLineas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGLineas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGLineas.ColorOrdenAscendente = System.Drawing.Color.Empty;
            this.DGLineas.ColorOrdenDescendente = System.Drawing.Color.Empty;
            this.DGLineas.ColumnasFijadasSalto = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGLineas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGLineas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdElemCab,
            this.CIdelem,
            this.cIdElemProd,
            this.cTextoLido,
            this.cCantidad,
            this.CPrecioBruto,
            this.CPorIva,
            this.cPVP,
            this.cTotalLinea});
            this.DGLineas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGLineas.EnableHeadersVisualStyles = false;
            this.DGLineas.FormularioPadreMdi = null;
            this.DGLineas.Location = new System.Drawing.Point(12, 62);
            this.DGLineas.MostrarMenuContextualDefecto = false;
            this.DGLineas.Name = "DGLineas";
            this.DGLineas.OpcionesMenuContextualUsuario = null;
            this.DGLineas.OrigenDatos = null;
            this.DGLineas.PuedeUsuarioFiltrar = false;
            this.DGLineas.RowHeadersWidth = 25;
            this.DGLineas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGLineas.Size = new System.Drawing.Size(529, 231);
            this.DGLineas.TabIndex = 0;
            this.DGLineas.TransaparenciaDialogosGris = ((short)(100));
            this.DGLineas.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGLineas_RowsRemoved);
            // 
            // CIdElemCab
            // 
            this.CIdElemCab.DataPropertyName = "ID_ELEM_CAB";
            this.CIdElemCab.HeaderText = "IdElemCab";
            this.CIdElemCab.Name = "CIdElemCab";
            this.CIdElemCab.Visible = false;
            // 
            // CIdelem
            // 
            this.CIdelem.DataPropertyName = "ID_ELEM";
            this.CIdelem.HeaderText = "ID_ELEM";
            this.CIdelem.Name = "CIdelem";
            this.CIdelem.Visible = false;
            // 
            // cIdElemProd
            // 
            this.cIdElemProd.DataPropertyName = "ID_ELEM_PROD";
            this.cIdElemProd.HeaderText = "ID_ELEM_PROD";
            this.cIdElemProd.Name = "cIdElemProd";
            this.cIdElemProd.Visible = false;
            // 
            // cTextoLido
            // 
            this.cTextoLido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTextoLido.DataPropertyName = "TEXTO_LIDO";
            this.cTextoLido.HeaderText = "Texto";
            this.cTextoLido.Name = "cTextoLido";
            this.cTextoLido.ReadOnly = true;
            // 
            // cCantidad
            // 
            this.cCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cCantidad.ColorNegativos = System.Drawing.Color.Red;
            this.cCantidad.ColorPositivos = System.Drawing.Color.Green;
            this.cCantidad.DataPropertyName = "CANTIDAD_LIDO";
            this.cCantidad.HeaderText = "Cantidad";
            this.cCantidad.MarcarNegativos = true;
            this.cCantidad.MarcarPositivos = true;
            this.cCantidad.Name = "cCantidad";
            this.cCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cCantidad.Width = 74;
            // 
            // CPrecioBruto
            // 
            this.CPrecioBruto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CPrecioBruto.ColorNegativos = System.Drawing.Color.Empty;
            this.CPrecioBruto.ColorPositivos = System.Drawing.Color.Empty;
            this.CPrecioBruto.DataPropertyName = "PVB_LIDO";
            this.CPrecioBruto.HeaderText = "Precio bruto";
            this.CPrecioBruto.MarcarNegativos = false;
            this.CPrecioBruto.MarcarPositivos = false;
            this.CPrecioBruto.Name = "CPrecioBruto";
            this.CPrecioBruto.ReadOnly = true;
            this.CPrecioBruto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CPrecioBruto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CPrecioBruto.Width = 89;
            // 
            // CPorIva
            // 
            this.CPorIva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CPorIva.ColorNegativos = System.Drawing.Color.Empty;
            this.CPorIva.ColorPositivos = System.Drawing.Color.Empty;
            this.CPorIva.DataPropertyName = "PORC_IVA_LIDO";
            this.CPorIva.HeaderText = "% IVA";
            this.CPorIva.MarcarNegativos = false;
            this.CPorIva.MarcarPositivos = false;
            this.CPorIva.Name = "CPorIva";
            this.CPorIva.ReadOnly = true;
            this.CPorIva.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CPorIva.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CPorIva.Width = 60;
            // 
            // cPVP
            // 
            this.cPVP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cPVP.ColorNegativos = System.Drawing.Color.Red;
            this.cPVP.ColorPositivos = System.Drawing.Color.Green;
            this.cPVP.DataPropertyName = "PVP_LIDO";
            this.cPVP.HeaderText = "PVP";
            this.cPVP.MarcarNegativos = true;
            this.cPVP.MarcarPositivos = true;
            this.cPVP.Name = "cPVP";
            this.cPVP.ReadOnly = true;
            this.cPVP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cPVP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cPVP.Width = 53;
            // 
            // cTotalLinea
            // 
            this.cTotalLinea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cTotalLinea.ColorNegativos = System.Drawing.Color.Red;
            this.cTotalLinea.ColorPositivos = System.Drawing.Color.Green;
            this.cTotalLinea.DataPropertyName = "TOTAL_LIDO";
            this.cTotalLinea.HeaderText = "Total";
            this.cTotalLinea.MarcarNegativos = true;
            this.cTotalLinea.MarcarPositivos = true;
            this.cTotalLinea.Name = "cTotalLinea";
            this.cTotalLinea.ReadOnly = true;
            this.cTotalLinea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cTotalLinea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cTotalLinea.Width = 56;
            // 
            // cLabelBase1
            // 
            this.cLabelBase1.AutoSize = true;
            this.cLabelBase1.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase1.Location = new System.Drawing.Point(548, 89);
            this.cLabelBase1.Name = "cLabelBase1";
            this.cLabelBase1.Size = new System.Drawing.Size(54, 13);
            this.cLabelBase1.TabIndex = 1;
            this.cLabelBase1.Text = "Id. Cliente";
            // 
            // cLabelBase2
            // 
            this.cLabelBase2.AutoSize = true;
            this.cLabelBase2.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase2.Location = new System.Drawing.Point(694, 89);
            this.cLabelBase2.Name = "cLabelBase2";
            this.cLabelBase2.Size = new System.Drawing.Size(65, 13);
            this.cLabelBase2.TabIndex = 3;
            this.cLabelBase2.Text = "N.I.F Cliente";
            // 
            // cLabelBase3
            // 
            this.cLabelBase3.AutoSize = true;
            this.cLabelBase3.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase3.Location = new System.Drawing.Point(547, 138);
            this.cLabelBase3.Name = "cLabelBase3";
            this.cLabelBase3.Size = new System.Drawing.Size(79, 13);
            this.cLabelBase3.TabIndex = 5;
            this.cLabelBase3.Text = "Nombre Cliente";
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreCliente.Location = new System.Drawing.Point(548, 162);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(79, 13);
            this.LblNombreCliente.TabIndex = 6;
            this.LblNombreCliente.Text = "Nombre Cliente";
            // 
            // cLabelBase4
            // 
            this.cLabelBase4.AutoSize = true;
            this.cLabelBase4.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase4.Location = new System.Drawing.Point(548, 191);
            this.cLabelBase4.Name = "cLabelBase4";
            this.cLabelBase4.Size = new System.Drawing.Size(87, 13);
            this.cLabelBase4.TabIndex = 7;
            this.cLabelBase4.Text = "Dirección Cliente";
            // 
            // LblIdCliente
            // 
            this.LblIdCliente.AutoSize = true;
            this.LblIdCliente.BackColor = System.Drawing.Color.Transparent;
            this.LblIdCliente.Location = new System.Drawing.Point(548, 113);
            this.LblIdCliente.Name = "LblIdCliente";
            this.LblIdCliente.Size = new System.Drawing.Size(54, 13);
            this.LblIdCliente.TabIndex = 8;
            this.LblIdCliente.Text = "Id. Cliente";
            // 
            // LblNifCliente
            // 
            this.LblNifCliente.AutoSize = true;
            this.LblNifCliente.BackColor = System.Drawing.Color.Transparent;
            this.LblNifCliente.Location = new System.Drawing.Point(694, 113);
            this.LblNifCliente.Name = "LblNifCliente";
            this.LblNifCliente.Size = new System.Drawing.Size(54, 13);
            this.LblNifCliente.TabIndex = 9;
            this.LblNifCliente.Text = "Id. Cliente";
            // 
            // LblDireccionCliente
            // 
            this.LblDireccionCliente.AutoSize = true;
            this.LblDireccionCliente.BackColor = System.Drawing.Color.Transparent;
            this.LblDireccionCliente.Location = new System.Drawing.Point(548, 220);
            this.LblDireccionCliente.Name = "LblDireccionCliente";
            this.LblDireccionCliente.Size = new System.Drawing.Size(87, 13);
            this.LblDireccionCliente.TabIndex = 10;
            this.LblDireccionCliente.Text = "Direccion Cliente";
            // 
            // LblDireccion2Cliente
            // 
            this.LblDireccion2Cliente.AutoSize = true;
            this.LblDireccion2Cliente.BackColor = System.Drawing.Color.Transparent;
            this.LblDireccion2Cliente.Location = new System.Drawing.Point(548, 247);
            this.LblDireccion2Cliente.Name = "LblDireccion2Cliente";
            this.LblDireccion2Cliente.Size = new System.Drawing.Size(96, 13);
            this.LblDireccion2Cliente.TabIndex = 11;
            this.LblDireccion2Cliente.Text = "Direccion 2 Cliente";
            // 
            // HerramientasTPV
            // 
            this.HerramientasTPV.AutoSize = false;
            this.HerramientasTPV.color_final = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HerramientasTPV.color_inicial = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HerramientasTPV.Dock = System.Windows.Forms.DockStyle.Right;
            this.HerramientasTPV.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.HerramientasTPV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGuardar,
            this.toolStripSeparator1,
            this.BtnBuscarPersona,
            this.BtnBuscarProducto,
            this.toolStripSeparator2,
            this.BtnCobrar,
            this.BtnSalir,
            this.BtnImprimirDoc});
            this.HerramientasTPV.Location = new System.Drawing.Point(915, 0);
            this.HerramientasTPV.Name = "HerramientasTPV";
            this.HerramientasTPV.Size = new System.Drawing.Size(102, 617);
            this.HerramientasTPV.TabIndex = 12;
            this.HerramientasTPV.Text = "cBarraHerramientas1";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = global::LFVBNewTPV.Properties.Resources.disk_blue;
            this.BtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 67);
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // BtnBuscarPersona
            // 
            this.BtnBuscarPersona.Image = global::LFVBNewTPV.Properties.Resources.businessman1;
            this.BtnBuscarPersona.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnBuscarPersona.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBuscarPersona.Name = "BtnBuscarPersona";
            this.BtnBuscarPersona.Size = new System.Drawing.Size(100, 67);
            this.BtnBuscarPersona.Text = "Buscar &Persona";
            this.BtnBuscarPersona.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnBuscarPersona.Click += new System.EventHandler(this.BtnBuscarPersona_Click);
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.Image = global::LFVBNewTPV.Properties.Resources.box;
            this.BtnBuscarProducto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnBuscarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Size = new System.Drawing.Size(100, 67);
            this.BtnBuscarProducto.Text = "Buscar &Articulo";
            this.BtnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // BtnCobrar
            // 
            this.BtnCobrar.Image = global::LFVBNewTPV.Properties.Resources.cashier;
            this.BtnCobrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCobrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCobrar.Name = "BtnCobrar";
            this.BtnCobrar.Size = new System.Drawing.Size(100, 67);
            this.BtnCobrar.Text = "&Cobrar";
            this.BtnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCobrar.Click += new System.EventHandler(this.BtnCobrar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnSalir.Image = global::LFVBNewTPV.Properties.Resources.delete2;
            this.BtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 67);
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnImprimirDoc
            // 
            this.BtnImprimirDoc.Image = global::LFVBNewTPV.Properties.Resources.printer2;
            this.BtnImprimirDoc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnImprimirDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnImprimirDoc.Name = "BtnImprimirDoc";
            this.BtnImprimirDoc.Size = new System.Drawing.Size(100, 67);
            this.BtnImprimirDoc.Text = "&Imprimir";
            this.BtnImprimirDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnImprimirDoc.Click += new System.EventHandler(this.BtnImprimirDoc_Click);
            // 
            // cLabelBase5
            // 
            this.cLabelBase5.AutoSize = true;
            this.cLabelBase5.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase5.Location = new System.Drawing.Point(8, 10);
            this.cLabelBase5.Name = "cLabelBase5";
            this.cLabelBase5.Size = new System.Drawing.Size(151, 24);
            this.cLabelBase5.TabIndex = 13;
            this.cLabelBase5.Text = "Tipo Documento";
            // 
            // cLabelBase6
            // 
            this.cLabelBase6.AutoSize = true;
            this.cLabelBase6.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase6.Location = new System.Drawing.Point(167, 9);
            this.cLabelBase6.Name = "cLabelBase6";
            this.cLabelBase6.Size = new System.Drawing.Size(180, 24);
            this.cLabelBase6.TabIndex = 14;
            this.cLabelBase6.Text = "Número documento";
            // 
            // cLabelBase7
            // 
            this.cLabelBase7.AutoSize = true;
            this.cLabelBase7.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase7.Location = new System.Drawing.Point(360, 10);
            this.cLabelBase7.Name = "cLabelBase7";
            this.cLabelBase7.Size = new System.Drawing.Size(148, 24);
            this.cLabelBase7.TabIndex = 15;
            this.cLabelBase7.Text = "Año Documento";
            // 
            // LblAnyoDocumento
            // 
            this.LblAnyoDocumento.AutoSize = true;
            this.LblAnyoDocumento.BackColor = System.Drawing.Color.Transparent;
            this.LblAnyoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnyoDocumento.Location = new System.Drawing.Point(409, 34);
            this.LblAnyoDocumento.Name = "LblAnyoDocumento";
            this.LblAnyoDocumento.Size = new System.Drawing.Size(50, 24);
            this.LblAnyoDocumento.TabIndex = 18;
            this.LblAnyoDocumento.Text = "0000";
            // 
            // LblNumeroDocumento
            // 
            this.LblNumeroDocumento.AutoSize = true;
            this.LblNumeroDocumento.BackColor = System.Drawing.Color.Transparent;
            this.LblNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroDocumento.Location = new System.Drawing.Point(202, 34);
            this.LblNumeroDocumento.Name = "LblNumeroDocumento";
            this.LblNumeroDocumento.Size = new System.Drawing.Size(110, 24);
            this.LblNumeroDocumento.TabIndex = 17;
            this.LblNumeroDocumento.Text = "0000000000";
            // 
            // LblTipoDocumento
            // 
            this.LblTipoDocumento.AutoSize = true;
            this.LblTipoDocumento.BackColor = System.Drawing.Color.Transparent;
            this.LblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoDocumento.Location = new System.Drawing.Point(64, 35);
            this.LblTipoDocumento.Name = "LblTipoDocumento";
            this.LblTipoDocumento.Size = new System.Drawing.Size(38, 24);
            this.LblTipoDocumento.TabIndex = 16;
            this.LblTipoDocumento.Text = "XX";
            // 
            // cLabelBase11
            // 
            this.cLabelBase11.AutoSize = true;
            this.cLabelBase11.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase11.Location = new System.Drawing.Point(543, 9);
            this.cLabelBase11.Name = "cLabelBase11";
            this.cLabelBase11.Size = new System.Drawing.Size(167, 24);
            this.cLabelBase11.TabIndex = 19;
            this.cLabelBase11.Text = "Fecha Documento";
            // 
            // LblFechaDocumento
            // 
            this.LblFechaDocumento.AutoSize = true;
            this.LblFechaDocumento.BackColor = System.Drawing.Color.Transparent;
            this.LblFechaDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaDocumento.Location = new System.Drawing.Point(543, 34);
            this.LblFechaDocumento.Name = "LblFechaDocumento";
            this.LblFechaDocumento.Size = new System.Drawing.Size(167, 24);
            this.LblFechaDocumento.TabIndex = 20;
            this.LblFechaDocumento.Text = "Fecha Documento";
            // 
            // cLabelBase8
            // 
            this.cLabelBase8.AutoSize = true;
            this.cLabelBase8.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase8.Location = new System.Drawing.Point(8, 329);
            this.cLabelBase8.Name = "cLabelBase8";
            this.cLabelBase8.Size = new System.Drawing.Size(110, 20);
            this.cLabelBase8.TabIndex = 21;
            this.cLabelBase8.Text = "Código Barras";
            // 
            // cLabelBase9
            // 
            this.cLabelBase9.AutoSize = true;
            this.cLabelBase9.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase9.Location = new System.Drawing.Point(169, 329);
            this.cLabelBase9.Name = "cLabelBase9";
            this.cLabelBase9.Size = new System.Drawing.Size(91, 20);
            this.cLabelBase9.TabIndex = 22;
            this.cLabelBase9.Text = "Texto Linea";
            // 
            // cLabelBase10
            // 
            this.cLabelBase10.AutoSize = true;
            this.cLabelBase10.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase10.Location = new System.Drawing.Point(710, 329);
            this.cLabelBase10.Name = "cLabelBase10";
            this.cLabelBase10.Size = new System.Drawing.Size(100, 20);
            this.cLabelBase10.TabIndex = 23;
            this.cLabelBase10.Text = "Precio Venta";
            // 
            // cLabelBase12
            // 
            this.cLabelBase12.AutoSize = true;
            this.cLabelBase12.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase12.Location = new System.Drawing.Point(425, 329);
            this.cLabelBase12.Name = "cLabelBase12";
            this.cLabelBase12.Size = new System.Drawing.Size(96, 20);
            this.cLabelBase12.TabIndex = 24;
            this.cLabelBase12.Text = "Precio Bruto";
            // 
            // cLabelBase13
            // 
            this.cLabelBase13.AutoSize = true;
            this.cLabelBase13.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase13.Location = new System.Drawing.Point(543, 329);
            this.cLabelBase13.Name = "cLabelBase13";
            this.cLabelBase13.Size = new System.Drawing.Size(73, 20);
            this.cLabelBase13.TabIndex = 25;
            this.cLabelBase13.Text = "Cantidad";
            // 
            // cLabelBase14
            // 
            this.cLabelBase14.AutoSize = true;
            this.cLabelBase14.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase14.Location = new System.Drawing.Point(633, 329);
            this.cLabelBase14.Name = "cLabelBase14";
            this.cLabelBase14.Size = new System.Drawing.Size(54, 20);
            this.cLabelBase14.TabIndex = 26;
            this.cLabelBase14.Text = "% IVA";
            // 
            // TBoxRefProdIn
            // 
            this.TBoxRefProdIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxRefProdIn.Location = new System.Drawing.Point(12, 352);
            this.TBoxRefProdIn.Name = "TBoxRefProdIn";
            this.TBoxRefProdIn.Size = new System.Drawing.Size(147, 20);
            this.TBoxRefProdIn.TabIndex = 27;
            this.TBoxRefProdIn.Enter += new System.EventHandler(this.TBoxRefProdIn_Enter);
            this.TBoxRefProdIn.Validating += new System.ComponentModel.CancelEventHandler(this.TBoxRefProdIn_Validating);
            // 
            // TBoxTextoLinIn
            // 
            this.TBoxTextoLinIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxTextoLinIn.Location = new System.Drawing.Point(171, 352);
            this.TBoxTextoLinIn.Name = "TBoxTextoLinIn";
            this.TBoxTextoLinIn.Size = new System.Drawing.Size(237, 20);
            this.TBoxTextoLinIn.TabIndex = 28;
            // 
            // LblPrecioBrutoIn
            // 
            this.LblPrecioBrutoIn.AutoSize = true;
            this.LblPrecioBrutoIn.BackColor = System.Drawing.Color.Transparent;
            this.LblPrecioBrutoIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioBrutoIn.Location = new System.Drawing.Point(481, 352);
            this.LblPrecioBrutoIn.Name = "LblPrecioBrutoIn";
            this.LblPrecioBrutoIn.Size = new System.Drawing.Size(40, 20);
            this.LblPrecioBrutoIn.TabIndex = 29;
            this.LblPrecioBrutoIn.Text = "0.00";
            this.LblPrecioBrutoIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBoxCantidadIn
            // 
            this.TBoxCantidadIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxCantidadIn.ColorNegativos = System.Drawing.Color.Empty;
            this.TBoxCantidadIn.ColorPositivos = System.Drawing.Color.Empty;
            this.TBoxCantidadIn.Decimales = ((short)(0));
            this.TBoxCantidadIn.Location = new System.Drawing.Point(547, 352);
            this.TBoxCantidadIn.MarcarNegativos = false;
            this.TBoxCantidadIn.MarcarPositivos = false;
            this.TBoxCantidadIn.Name = "TBoxCantidadIn";
            this.TBoxCantidadIn.PonerValorDefecto = false;
            this.TBoxCantidadIn.Size = new System.Drawing.Size(69, 20);
            this.TBoxCantidadIn.TabIndex = 30;
            this.TBoxCantidadIn.Text = "0";
            this.TBoxCantidadIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxCantidadIn.ValorDefecto = 0;
            this.TBoxCantidadIn.Enter += new System.EventHandler(this.TBoxCantidadIn_Enter);
            // 
            // LblPorIvaIn
            // 
            this.LblPorIvaIn.AutoSize = true;
            this.LblPorIvaIn.BackColor = System.Drawing.Color.Transparent;
            this.LblPorIvaIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPorIvaIn.Location = new System.Drawing.Point(647, 349);
            this.LblPorIvaIn.Name = "LblPorIvaIn";
            this.LblPorIvaIn.Size = new System.Drawing.Size(40, 20);
            this.LblPorIvaIn.TabIndex = 31;
            this.LblPorIvaIn.Text = "0.00";
            // 
            // TBoxPrecioVentaIn
            // 
            this.TBoxPrecioVentaIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxPrecioVentaIn.ColorNegativos = System.Drawing.Color.Empty;
            this.TBoxPrecioVentaIn.ColorPositivos = System.Drawing.Color.Empty;
            this.TBoxPrecioVentaIn.Decimales = ((short)(0));
            this.TBoxPrecioVentaIn.Location = new System.Drawing.Point(714, 349);
            this.TBoxPrecioVentaIn.MarcarNegativos = false;
            this.TBoxPrecioVentaIn.MarcarPositivos = false;
            this.TBoxPrecioVentaIn.Name = "TBoxPrecioVentaIn";
            this.TBoxPrecioVentaIn.PonerValorDefecto = false;
            this.TBoxPrecioVentaIn.Size = new System.Drawing.Size(96, 20);
            this.TBoxPrecioVentaIn.TabIndex = 32;
            this.TBoxPrecioVentaIn.Text = "0";
            this.TBoxPrecioVentaIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxPrecioVentaIn.ValorDefecto = 0;
            // 
            // cLabelBase15
            // 
            this.cLabelBase15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cLabelBase15.AutoSize = true;
            this.cLabelBase15.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase15.Location = new System.Drawing.Point(580, 516);
            this.cLabelBase15.Name = "cLabelBase15";
            this.cLabelBase15.Size = new System.Drawing.Size(135, 20);
            this.cLabelBase15.TabIndex = 34;
            this.cLabelBase15.Text = "Precio Total Bruto";
            // 
            // LblTotalBruto
            // 
            this.LblTotalBruto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalBruto.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalBruto.Location = new System.Drawing.Point(765, 516);
            this.LblTotalBruto.Name = "LblTotalBruto";
            this.LblTotalBruto.Size = new System.Drawing.Size(135, 20);
            this.LblTotalBruto.TabIndex = 35;
            this.LblTotalBruto.Text = "0.00 €";
            this.LblTotalBruto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTotalDocu
            // 
            this.LblTotalDocu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalDocu.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalDocu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalDocu.Location = new System.Drawing.Point(765, 536);
            this.LblTotalDocu.Name = "LblTotalDocu";
            this.LblTotalDocu.Size = new System.Drawing.Size(135, 20);
            this.LblTotalDocu.TabIndex = 37;
            this.LblTotalDocu.Text = "0.00 €";
            this.LblTotalDocu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabelBase17
            // 
            this.cLabelBase17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cLabelBase17.AutoSize = true;
            this.cLabelBase17.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase17.Location = new System.Drawing.Point(580, 536);
            this.cLabelBase17.Name = "cLabelBase17";
            this.cLabelBase17.Size = new System.Drawing.Size(179, 20);
            this.cLabelBase17.TabIndex = 36;
            this.cLabelBase17.Text = "Precio Total Documento";
            // 
            // LblTotalPagado
            // 
            this.LblTotalPagado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalPagado.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPagado.Location = new System.Drawing.Point(765, 556);
            this.LblTotalPagado.Name = "LblTotalPagado";
            this.LblTotalPagado.Size = new System.Drawing.Size(135, 20);
            this.LblTotalPagado.TabIndex = 39;
            this.LblTotalPagado.Text = "0.00 €";
            this.LblTotalPagado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabelBase19
            // 
            this.cLabelBase19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cLabelBase19.AutoSize = true;
            this.cLabelBase19.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase19.Location = new System.Drawing.Point(580, 556);
            this.cLabelBase19.Name = "cLabelBase19";
            this.cLabelBase19.Size = new System.Drawing.Size(64, 20);
            this.cLabelBase19.TabIndex = 38;
            this.cLabelBase19.Text = "Pagado";
            // 
            // TBoxIdProd
            // 
            this.TBoxIdProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxIdProd.ColorNegativos = System.Drawing.Color.Empty;
            this.TBoxIdProd.ColorPositivos = System.Drawing.Color.Empty;
            this.TBoxIdProd.Decimales = ((short)(0));
            this.TBoxIdProd.Location = new System.Drawing.Point(12, 402);
            this.TBoxIdProd.MarcarNegativos = false;
            this.TBoxIdProd.MarcarPositivos = false;
            this.TBoxIdProd.Name = "TBoxIdProd";
            this.TBoxIdProd.PonerValorDefecto = false;
            this.TBoxIdProd.Size = new System.Drawing.Size(100, 20);
            this.TBoxIdProd.TabIndex = 40;
            this.TBoxIdProd.Text = "0";
            this.TBoxIdProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxIdProd.ValorDefecto = 0;
            this.TBoxIdProd.Visible = false;
            // 
            // cLabelBase16
            // 
            this.cLabelBase16.AutoSize = true;
            this.cLabelBase16.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase16.Location = new System.Drawing.Point(12, 379);
            this.cLabelBase16.Name = "cLabelBase16";
            this.cLabelBase16.Size = new System.Drawing.Size(76, 20);
            this.cLabelBase16.TabIndex = 41;
            this.cLabelBase16.Text = "ID PROD";
            this.cLabelBase16.Visible = false;
            // 
            // cLabelBase18
            // 
            this.cLabelBase18.AutoSize = true;
            this.cLabelBase18.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase18.Location = new System.Drawing.Point(547, 62);
            this.cLabelBase18.Name = "cLabelBase18";
            this.cLabelBase18.Size = new System.Drawing.Size(148, 24);
            this.cLabelBase18.TabIndex = 43;
            this.cLabelBase18.Text = "Datos del cliente";
            // 
            // BtnGuardarLinea
            // 
            this.BtnGuardarLinea.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardarLinea.Image = global::LFVBNewTPV.Properties.Resources.disk_blue2;
            this.BtnGuardarLinea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarLinea.Location = new System.Drawing.Point(816, 339);
            this.BtnGuardarLinea.Name = "BtnGuardarLinea";
            this.BtnGuardarLinea.Size = new System.Drawing.Size(35, 36);
            this.BtnGuardarLinea.TabIndex = 42;
            this.BtnGuardarLinea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGuardarLinea.UseVisualStyleBackColor = true;
            this.BtnGuardarLinea.Click += new System.EventHandler(this.BtnGuardarLinea_Click);
            // 
            // BtnMenosCantidad
            // 
            this.BtnMenosCantidad.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenosCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMenosCantidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenosCantidad.Location = new System.Drawing.Point(547, 376);
            this.BtnMenosCantidad.Name = "BtnMenosCantidad";
            this.BtnMenosCantidad.Size = new System.Drawing.Size(32, 23);
            this.BtnMenosCantidad.TabIndex = 44;
            this.BtnMenosCantidad.Text = "-";
            this.BtnMenosCantidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnMenosCantidad.UseVisualStyleBackColor = true;
            this.BtnMenosCantidad.Click += new System.EventHandler(this.BtnMenosCantidad_Click);
            // 
            // BtnMasCantidad
            // 
            this.BtnMasCantidad.BackColor = System.Drawing.Color.Transparent;
            this.BtnMasCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMasCantidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMasCantidad.Location = new System.Drawing.Point(584, 376);
            this.BtnMasCantidad.Name = "BtnMasCantidad";
            this.BtnMasCantidad.Size = new System.Drawing.Size(32, 23);
            this.BtnMasCantidad.TabIndex = 45;
            this.BtnMasCantidad.Text = "+";
            this.BtnMasCantidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnMasCantidad.UseVisualStyleBackColor = true;
            this.BtnMasCantidad.Click += new System.EventHandler(this.BtnMasCantidad_Click);
            // 
            // BtnEliminarLinea
            // 
            this.BtnEliminarLinea.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarLinea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarLinea.Location = new System.Drawing.Point(12, 299);
            this.BtnEliminarLinea.Name = "BtnEliminarLinea";
            this.BtnEliminarLinea.Size = new System.Drawing.Size(147, 23);
            this.BtnEliminarLinea.TabIndex = 46;
            this.BtnEliminarLinea.Text = "Eliminar Linea";
            this.BtnEliminarLinea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEliminarLinea.UseVisualStyleBackColor = true;
            this.BtnEliminarLinea.Visible = false;
            this.BtnEliminarLinea.Click += new System.EventHandler(this.BtnEliminarLinea_Click);
            // 
            // btnSelectProds
            // 
            this.btnSelectProds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectProds.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectProds.Location = new System.Drawing.Point(12, 402);
            this.btnSelectProds.Name = "btnSelectProds";
            this.btnSelectProds.Size = new System.Drawing.Size(562, 211);
            this.btnSelectProds.TabIndex = 47;
            this.btnSelectProds.OnSelectProducto += new LFVBNewTPV.COMP.SelectProducto(this.btnSelectProds_OnSelectProducto);
            // 
            // FrmDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 617);
            this.Controls.Add(this.btnSelectProds);
            this.Controls.Add(this.BtnEliminarLinea);
            this.Controls.Add(this.BtnMasCantidad);
            this.Controls.Add(this.BtnMenosCantidad);
            this.Controls.Add(this.cLabelBase18);
            this.Controls.Add(this.BtnGuardarLinea);
            this.Controls.Add(this.cLabelBase16);
            this.Controls.Add(this.TBoxIdProd);
            this.Controls.Add(this.LblTotalPagado);
            this.Controls.Add(this.cLabelBase19);
            this.Controls.Add(this.LblTotalDocu);
            this.Controls.Add(this.cLabelBase17);
            this.Controls.Add(this.LblTotalBruto);
            this.Controls.Add(this.cLabelBase15);
            this.Controls.Add(this.HerramientasTPV);
            this.Controls.Add(this.LblFechaDocumento);
            this.Controls.Add(this.cLabelBase11);
            this.Controls.Add(this.LblAnyoDocumento);
            this.Controls.Add(this.LblNumeroDocumento);
            this.Controls.Add(this.LblTipoDocumento);
            this.Controls.Add(this.cLabelBase7);
            this.Controls.Add(this.cLabelBase6);
            this.Controls.Add(this.cLabelBase5);
            this.Controls.Add(this.LblDireccion2Cliente);
            this.Controls.Add(this.LblDireccionCliente);
            this.Controls.Add(this.LblNifCliente);
            this.Controls.Add(this.LblIdCliente);
            this.Controls.Add(this.cLabelBase4);
            this.Controls.Add(this.LblNombreCliente);
            this.Controls.Add(this.cLabelBase3);
            this.Controls.Add(this.cLabelBase2);
            this.Controls.Add(this.cLabelBase1);
            this.Controls.Add(this.DGLineas);
            this.Controls.Add(this.TBoxPrecioVentaIn);
            this.Controls.Add(this.LblPorIvaIn);
            this.Controls.Add(this.TBoxCantidadIn);
            this.Controls.Add(this.LblPrecioBrutoIn);
            this.Controls.Add(this.TBoxTextoLinIn);
            this.Controls.Add(this.TBoxRefProdIn);
            this.Controls.Add(this.cLabelBase14);
            this.Controls.Add(this.cLabelBase13);
            this.Controls.Add(this.cLabelBase12);
            this.Controls.Add(this.cLabelBase10);
            this.Controls.Add(this.cLabelBase9);
            this.Controls.Add(this.cLabelBase8);
            this.Name = "FrmDocumento";
            this.Text = "TPV";
            ((System.ComponentModel.ISupportInitialize)(this.DGLineas)).EndInit();
            this.HerramientasTPV.ResumeLayout(false);
            this.HerramientasTPV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTGRIDBASE.GRID.DataGridViewBase DGLineas;
        private CTCBASE.cLabelBase cLabelBase1;
        private CTCBASE.cLabelBase cLabelBase2;
        private CTCBASE.cLabelBase cLabelBase3;
        private CTCBASE.cLabelBase LblNombreCliente;
        private CTCBASE.cLabelBase cLabelBase4;
        private CTCBASE.cLabelBase LblIdCliente;
        private CTCBASE.cLabelBase LblNifCliente;
        private CTCBASE.cLabelBase LblDireccionCliente;
        private CTCBASE.cLabelBase LblDireccion2Cliente;
        private CTCBASE.cBarraHerramientas HerramientasTPV;
        private CTCBASE.cLabelBase cLabelBase5;
        private CTCBASE.cLabelBase cLabelBase6;
        private CTCBASE.cLabelBase cLabelBase7;
        private CTCBASE.cLabelBase LblAnyoDocumento;
        private CTCBASE.cLabelBase LblNumeroDocumento;
        private CTCBASE.cLabelBase LblTipoDocumento;
        private CTCBASE.cLabelBase cLabelBase11;
        private CTCBASE.cLabelBase LblFechaDocumento;
        private CTCBASE.cLabelBase cLabelBase8;
        private CTCBASE.cLabelBase cLabelBase9;
        private CTCBASE.cLabelBase cLabelBase10;
        private CTCBASE.cLabelBase cLabelBase12;
        private CTCBASE.cLabelBase cLabelBase13;
        private CTCBASE.cLabelBase cLabelBase14;
        private CTCBASE.cTextBoxBase TBoxRefProdIn;
        private CTCBASE.cTextBoxBase TBoxTextoLinIn;
        private CTCBASE.cLabelBase LblPrecioBrutoIn;
        private CTCBASE.cNumericBoxBase TBoxCantidadIn;
        private CTCBASE.cLabelBase LblPorIvaIn;
        private CTCBASE.cNumericBoxBase TBoxPrecioVentaIn;
        private CTCBASE.cLabelBase cLabelBase15;
        private CTCBASE.cLabelBase LblTotalBruto;
        private CTCBASE.cLabelBase LblTotalDocu;
        private CTCBASE.cLabelBase cLabelBase17;
        private System.Windows.Forms.ToolStripButton BtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnBuscarPersona;
        private System.Windows.Forms.ToolStripButton BtnBuscarProducto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnCobrar;
        private CTCBASE.cLabelBase LblTotalPagado;
        private CTCBASE.cLabelBase cLabelBase19;
        private System.Windows.Forms.ToolStripButton BtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdElemCab;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdelem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdElemProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTextoLido;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn cCantidad;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn CPrecioBruto;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn CPorIva;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn cPVP;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn cTotalLinea;
        private CTCBASE.cNumericBoxBase TBoxIdProd;
        private CTCBASE.cLabelBase cLabelBase16;
        private CTCBASE.cBoton BtnGuardarLinea;
        private CTCBASE.cLabelBase cLabelBase18;
        private System.Windows.Forms.ToolStripButton BtnImprimirDoc;
        private CTCBASE.cBoton BtnMenosCantidad;
        private CTCBASE.cBoton BtnMasCantidad;
        private CTCBASE.cBoton BtnEliminarLinea;
        private LFVBNewTPV.COMP.BtnSelectProds btnSelectProds;
    }
}