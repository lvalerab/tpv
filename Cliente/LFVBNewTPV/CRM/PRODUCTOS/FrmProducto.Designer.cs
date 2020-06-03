namespace LFVBNewTPV.CRM.PRODUCTOS
{
    partial class FrmProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HerramientasProd = new CTCBASE.cBarraHerramientas();
            this.BtnGuardarProd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSalir = new System.Windows.Forms.ToolStripButton();
            this.cLabelBase1 = new CTCBASE.cLabelBase();
            this.LblIdElem = new CTCBASE.cLabelBase();
            this.cLabelBase2 = new CTCBASE.cLabelBase();
            this.TBoxCodigoBarras = new CTCBASE.cTextBoxBase();
            this.cLabelBase3 = new CTCBASE.cLabelBase();
            this.CmbFamilia = new CTCBASE.cComboBoxBase();
            this.cLabelBase4 = new CTCBASE.cLabelBase();
            this.CmbSubfamilia = new CTCBASE.cComboBoxBase();
            this.cLabelBase5 = new CTCBASE.cLabelBase();
            this.TBoxNombreProd = new CTCBASE.cTextBoxBase();
            this.cLabelBase6 = new CTCBASE.cLabelBase();
            this.TBoxExistencias = new CTCBASE.cNumericBoxBase();
            this.TBoxPrecioCompra = new CTCBASE.cNumericBoxBase();
            this.cLabelBase7 = new CTCBASE.cLabelBase();
            this.TBoxPrecioSinIva = new CTCBASE.cNumericBoxBase();
            this.cLabelBase8 = new CTCBASE.cLabelBase();
            this.cLabelBase9 = new CTCBASE.cLabelBase();
            this.CmbPorIva = new CTCBASE.cComboBoxBase();
            this.TBoxPVP = new CTCBASE.cNumericBoxBase();
            this.cLabelBase10 = new CTCBASE.cLabelBase();
            this.cLabelBase11 = new CTCBASE.cLabelBase();
            this.TBoxPorIva = new CTCBASE.cNumericBoxBase();
            this.TCDatosProducto = new System.Windows.Forms.TabControl();
            this.TPMovStock = new System.Windows.Forms.TabPage();
            this.DGDatosMovStock = new CTGRIDBASE.GRID.DataGridViewBase();
            this.cIdelemMspr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdElemProdMspr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFechaMovi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEntradaMspr = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.cSalisaMspr = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.cIdElemOper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TPImagen = new System.Windows.Forms.TabPage();
            this.PBoxImagenProd = new CTCBASE.cImagen();
            this.BtnCargarImagen = new CTCBASE.cBoton();
            this.TPWeb = new System.Windows.Forms.TabPage();
            this.DlgAbrirImagen = new System.Windows.Forms.OpenFileDialog();
            this.cLabelBase12 = new CTCBASE.cLabelBase();
            this.TBoxDescripcion = new CTCBASE.cRitchTextBox();
            this.HerramientasProd.SuspendLayout();
            this.TCDatosProducto.SuspendLayout();
            this.TPMovStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDatosMovStock)).BeginInit();
            this.TPImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImagenProd)).BeginInit();
            this.TPWeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // HerramientasProd
            // 
            this.HerramientasProd.AutoSize = false;
            this.HerramientasProd.color_final = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HerramientasProd.color_inicial = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HerramientasProd.Dock = System.Windows.Forms.DockStyle.Right;
            this.HerramientasProd.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.HerramientasProd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGuardarProd,
            this.toolStripSeparator1,
            this.BtnSalir});
            this.HerramientasProd.Location = new System.Drawing.Point(752, 0);
            this.HerramientasProd.Name = "HerramientasProd";
            this.HerramientasProd.Size = new System.Drawing.Size(84, 557);
            this.HerramientasProd.TabIndex = 0;
            this.HerramientasProd.Text = "cBarraHerramientas1";
            // 
            // BtnGuardarProd
            // 
            this.BtnGuardarProd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarProd.Image = global::LFVBNewTPV.Properties.Resources.disk_blue1;
            this.BtnGuardarProd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnGuardarProd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGuardarProd.Name = "BtnGuardarProd";
            this.BtnGuardarProd.Size = new System.Drawing.Size(82, 65);
            this.BtnGuardarProd.Text = "&Guardar";
            this.BtnGuardarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGuardarProd.Click += new System.EventHandler(this.BtnGuardarProd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(82, 6);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::LFVBNewTPV.Properties.Resources.error;
            this.BtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(82, 65);
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // cLabelBase1
            // 
            this.cLabelBase1.AutoSize = true;
            this.cLabelBase1.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase1.Location = new System.Drawing.Point(12, 9);
            this.cLabelBase1.Name = "cLabelBase1";
            this.cLabelBase1.Size = new System.Drawing.Size(174, 24);
            this.cLabelBase1.TabIndex = 1;
            this.cLabelBase1.Text = "Identificador Interno";
            // 
            // LblIdElem
            // 
            this.LblIdElem.AutoSize = true;
            this.LblIdElem.BackColor = System.Drawing.Color.Transparent;
            this.LblIdElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdElem.Location = new System.Drawing.Point(13, 40);
            this.LblIdElem.Name = "LblIdElem";
            this.LblIdElem.Size = new System.Drawing.Size(174, 24);
            this.LblIdElem.TabIndex = 2;
            this.LblIdElem.Text = "Identificador Interno";
            // 
            // cLabelBase2
            // 
            this.cLabelBase2.AutoSize = true;
            this.cLabelBase2.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase2.Location = new System.Drawing.Point(257, 11);
            this.cLabelBase2.Name = "cLabelBase2";
            this.cLabelBase2.Size = new System.Drawing.Size(156, 24);
            this.cLabelBase2.TabIndex = 3;
            this.cLabelBase2.Text = "Código de Barras";
            // 
            // TBoxCodigoBarras
            // 
            this.TBoxCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxCodigoBarras.Location = new System.Drawing.Point(261, 38);
            this.TBoxCodigoBarras.MaxLength = 40;
            this.TBoxCodigoBarras.Name = "TBoxCodigoBarras";
            this.TBoxCodigoBarras.Size = new System.Drawing.Size(272, 29);
            this.TBoxCodigoBarras.TabIndex = 4;
            // 
            // cLabelBase3
            // 
            this.cLabelBase3.AutoSize = true;
            this.cLabelBase3.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase3.Location = new System.Drawing.Point(13, 88);
            this.cLabelBase3.Name = "cLabelBase3";
            this.cLabelBase3.Size = new System.Drawing.Size(70, 24);
            this.cLabelBase3.TabIndex = 5;
            this.cLabelBase3.Text = "Familia";
            // 
            // CmbFamilia
            // 
            this.CmbFamilia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbFamilia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFamilia.FormattingEnabled = true;
            this.CmbFamilia.Location = new System.Drawing.Point(16, 115);
            this.CmbFamilia.Name = "CmbFamilia";
            this.CmbFamilia.Size = new System.Drawing.Size(284, 32);
            this.CmbFamilia.TabIndex = 6;
            this.CmbFamilia.SelectedValueChanged += new System.EventHandler(this.CmbFamilia_SelectedValueChanged);
            // 
            // cLabelBase4
            // 
            this.cLabelBase4.AutoSize = true;
            this.cLabelBase4.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase4.Location = new System.Drawing.Point(302, 88);
            this.cLabelBase4.Name = "cLabelBase4";
            this.cLabelBase4.Size = new System.Drawing.Size(96, 24);
            this.cLabelBase4.TabIndex = 7;
            this.cLabelBase4.Text = "Subfamilia";
            // 
            // CmbSubfamilia
            // 
            this.CmbSubfamilia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbSubfamilia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbSubfamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSubfamilia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbSubfamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSubfamilia.FormattingEnabled = true;
            this.CmbSubfamilia.Location = new System.Drawing.Point(306, 115);
            this.CmbSubfamilia.Name = "CmbSubfamilia";
            this.CmbSubfamilia.Size = new System.Drawing.Size(342, 32);
            this.CmbSubfamilia.TabIndex = 8;
            // 
            // cLabelBase5
            // 
            this.cLabelBase5.AutoSize = true;
            this.cLabelBase5.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase5.Location = new System.Drawing.Point(13, 162);
            this.cLabelBase5.Name = "cLabelBase5";
            this.cLabelBase5.Size = new System.Drawing.Size(190, 24);
            this.cLabelBase5.TabIndex = 9;
            this.cLabelBase5.Text = "Nombre del producto";
            // 
            // TBoxNombreProd
            // 
            this.TBoxNombreProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TBoxNombreProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxNombreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxNombreProd.Location = new System.Drawing.Point(17, 189);
            this.TBoxNombreProd.MaxLength = 60;
            this.TBoxNombreProd.Name = "TBoxNombreProd";
            this.TBoxNombreProd.Size = new System.Drawing.Size(734, 29);
            this.TBoxNombreProd.TabIndex = 10;
            // 
            // cLabelBase6
            // 
            this.cLabelBase6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cLabelBase6.AutoSize = true;
            this.cLabelBase6.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase6.Location = new System.Drawing.Point(495, 197);
            this.cLabelBase6.Name = "cLabelBase6";
            this.cLabelBase6.Size = new System.Drawing.Size(105, 24);
            this.cLabelBase6.TabIndex = 11;
            this.cLabelBase6.Text = "Existencias";
            // 
            // TBoxExistencias
            // 
            this.TBoxExistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBoxExistencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxExistencias.ColorNegativos = System.Drawing.Color.Red;
            this.TBoxExistencias.ColorPositivos = System.Drawing.Color.Green;
            this.TBoxExistencias.Decimales = ((short)(0));
            this.TBoxExistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxExistencias.Location = new System.Drawing.Point(631, 195);
            this.TBoxExistencias.MarcarNegativos = false;
            this.TBoxExistencias.MarcarPositivos = false;
            this.TBoxExistencias.Name = "TBoxExistencias";
            this.TBoxExistencias.PonerValorDefecto = false;
            this.TBoxExistencias.Size = new System.Drawing.Size(100, 29);
            this.TBoxExistencias.TabIndex = 12;
            this.TBoxExistencias.Text = "0";
            this.TBoxExistencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxExistencias.ValorDefecto = 0;
            // 
            // TBoxPrecioCompra
            // 
            this.TBoxPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxPrecioCompra.ColorNegativos = System.Drawing.Color.Red;
            this.TBoxPrecioCompra.ColorPositivos = System.Drawing.Color.Green;
            this.TBoxPrecioCompra.Decimales = ((short)(0));
            this.TBoxPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxPrecioCompra.Location = new System.Drawing.Point(20, 251);
            this.TBoxPrecioCompra.MarcarNegativos = false;
            this.TBoxPrecioCompra.MarcarPositivos = false;
            this.TBoxPrecioCompra.Name = "TBoxPrecioCompra";
            this.TBoxPrecioCompra.PonerValorDefecto = false;
            this.TBoxPrecioCompra.Size = new System.Drawing.Size(100, 29);
            this.TBoxPrecioCompra.TabIndex = 14;
            this.TBoxPrecioCompra.Text = "0";
            this.TBoxPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxPrecioCompra.ValorDefecto = 0;
            // 
            // cLabelBase7
            // 
            this.cLabelBase7.AutoSize = true;
            this.cLabelBase7.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase7.Location = new System.Drawing.Point(20, 224);
            this.cLabelBase7.Name = "cLabelBase7";
            this.cLabelBase7.Size = new System.Drawing.Size(136, 24);
            this.cLabelBase7.TabIndex = 13;
            this.cLabelBase7.Text = "Precio Compra";
            // 
            // TBoxPrecioSinIva
            // 
            this.TBoxPrecioSinIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxPrecioSinIva.ColorNegativos = System.Drawing.Color.Red;
            this.TBoxPrecioSinIva.ColorPositivos = System.Drawing.Color.Green;
            this.TBoxPrecioSinIva.Decimales = ((short)(0));
            this.TBoxPrecioSinIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxPrecioSinIva.Location = new System.Drawing.Point(177, 251);
            this.TBoxPrecioSinIva.MarcarNegativos = false;
            this.TBoxPrecioSinIva.MarcarPositivos = false;
            this.TBoxPrecioSinIva.Name = "TBoxPrecioSinIva";
            this.TBoxPrecioSinIva.PonerValorDefecto = false;
            this.TBoxPrecioSinIva.Size = new System.Drawing.Size(100, 29);
            this.TBoxPrecioSinIva.TabIndex = 16;
            this.TBoxPrecioSinIva.Text = "0";
            this.TBoxPrecioSinIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxPrecioSinIva.ValorDefecto = 0;
            this.TBoxPrecioSinIva.TextChanged += new System.EventHandler(this.TBoxPrecioSinIva_TextChanged);
            // 
            // cLabelBase8
            // 
            this.cLabelBase8.AutoSize = true;
            this.cLabelBase8.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase8.Location = new System.Drawing.Point(173, 224);
            this.cLabelBase8.Name = "cLabelBase8";
            this.cLabelBase8.Size = new System.Drawing.Size(121, 24);
            this.cLabelBase8.TabIndex = 15;
            this.cLabelBase8.Text = "Precio sin iva";
            // 
            // cLabelBase9
            // 
            this.cLabelBase9.AutoSize = true;
            this.cLabelBase9.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase9.Location = new System.Drawing.Point(310, 223);
            this.cLabelBase9.Name = "cLabelBase9";
            this.cLabelBase9.Size = new System.Drawing.Size(40, 24);
            this.cLabelBase9.TabIndex = 17;
            this.cLabelBase9.Text = "IVA";
            // 
            // CmbPorIva
            // 
            this.CmbPorIva.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbPorIva.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbPorIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPorIva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbPorIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPorIva.FormattingEnabled = true;
            this.CmbPorIva.Location = new System.Drawing.Point(314, 250);
            this.CmbPorIva.Name = "CmbPorIva";
            this.CmbPorIva.Size = new System.Drawing.Size(104, 32);
            this.CmbPorIva.TabIndex = 18;
            this.CmbPorIva.SelectedValueChanged += new System.EventHandler(this.CmbPorIva_SelectedValueChanged);
            // 
            // TBoxPVP
            // 
            this.TBoxPVP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxPVP.ColorNegativos = System.Drawing.Color.Red;
            this.TBoxPVP.ColorPositivos = System.Drawing.Color.Green;
            this.TBoxPVP.Decimales = ((short)(0));
            this.TBoxPVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxPVP.Location = new System.Drawing.Point(522, 253);
            this.TBoxPVP.MarcarNegativos = false;
            this.TBoxPVP.MarcarPositivos = false;
            this.TBoxPVP.Name = "TBoxPVP";
            this.TBoxPVP.PonerValorDefecto = false;
            this.TBoxPVP.Size = new System.Drawing.Size(100, 29);
            this.TBoxPVP.TabIndex = 20;
            this.TBoxPVP.Text = "0";
            this.TBoxPVP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxPVP.ValorDefecto = 0;
            this.TBoxPVP.TextChanged += new System.EventHandler(this.TBoxPVP_TextChanged);
            // 
            // cLabelBase10
            // 
            this.cLabelBase10.AutoSize = true;
            this.cLabelBase10.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase10.Location = new System.Drawing.Point(518, 224);
            this.cLabelBase10.Name = "cLabelBase10";
            this.cLabelBase10.Size = new System.Drawing.Size(190, 24);
            this.cLabelBase10.TabIndex = 19;
            this.cLabelBase10.Text = "Precio con IVA (PVP)";
            // 
            // cLabelBase11
            // 
            this.cLabelBase11.AutoSize = true;
            this.cLabelBase11.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase11.Location = new System.Drawing.Point(438, 224);
            this.cLabelBase11.Name = "cLabelBase11";
            this.cLabelBase11.Size = new System.Drawing.Size(60, 24);
            this.cLabelBase11.TabIndex = 21;
            this.cLabelBase11.Text = "% IVA";
            // 
            // TBoxPorIva
            // 
            this.TBoxPorIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxPorIva.ColorNegativos = System.Drawing.Color.Red;
            this.TBoxPorIva.ColorPositivos = System.Drawing.Color.Green;
            this.TBoxPorIva.Decimales = ((short)(0));
            this.TBoxPorIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxPorIva.Location = new System.Drawing.Point(442, 253);
            this.TBoxPorIva.MarcarNegativos = false;
            this.TBoxPorIva.MarcarPositivos = false;
            this.TBoxPorIva.Name = "TBoxPorIva";
            this.TBoxPorIva.PonerValorDefecto = false;
            this.TBoxPorIva.Size = new System.Drawing.Size(47, 29);
            this.TBoxPorIva.TabIndex = 22;
            this.TBoxPorIva.Text = "0";
            this.TBoxPorIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxPorIva.ValorDefecto = 0;
            // 
            // TCDatosProducto
            // 
            this.TCDatosProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TCDatosProducto.Controls.Add(this.TPMovStock);
            this.TCDatosProducto.Controls.Add(this.TPImagen);
            this.TCDatosProducto.Controls.Add(this.TPWeb);
            this.TCDatosProducto.Location = new System.Drawing.Point(4, 289);
            this.TCDatosProducto.Name = "TCDatosProducto";
            this.TCDatosProducto.SelectedIndex = 0;
            this.TCDatosProducto.Size = new System.Drawing.Size(745, 268);
            this.TCDatosProducto.TabIndex = 23;
            // 
            // TPMovStock
            // 
            this.TPMovStock.Controls.Add(this.DGDatosMovStock);
            this.TPMovStock.Controls.Add(this.TBoxExistencias);
            this.TPMovStock.Controls.Add(this.cLabelBase6);
            this.TPMovStock.Location = new System.Drawing.Point(4, 22);
            this.TPMovStock.Name = "TPMovStock";
            this.TPMovStock.Padding = new System.Windows.Forms.Padding(3);
            this.TPMovStock.Size = new System.Drawing.Size(737, 242);
            this.TPMovStock.TabIndex = 0;
            this.TPMovStock.Text = "Control stocks";
            this.TPMovStock.UseVisualStyleBackColor = true;
            // 
            // DGDatosMovStock
            // 
            this.DGDatosMovStock.AllowUserToAddRows = false;
            this.DGDatosMovStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGDatosMovStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGDatosMovStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGDatosMovStock.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGDatosMovStock.ColorOrdenAscendente = System.Drawing.Color.Empty;
            this.DGDatosMovStock.ColorOrdenDescendente = System.Drawing.Color.Empty;
            this.DGDatosMovStock.ColumnasFijadasSalto = null;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDatosMovStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGDatosMovStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDatosMovStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdelemMspr,
            this.cIdElemProdMspr,
            this.cFechaMovi,
            this.cEntradaMspr,
            this.cSalisaMspr,
            this.cIdElemOper});
            this.DGDatosMovStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGDatosMovStock.EnableHeadersVisualStyles = false;
            this.DGDatosMovStock.FormularioPadreMdi = null;
            this.DGDatosMovStock.Location = new System.Drawing.Point(6, 5);
            this.DGDatosMovStock.MostrarMenuContextualDefecto = false;
            this.DGDatosMovStock.Name = "DGDatosMovStock";
            this.DGDatosMovStock.OpcionesMenuContextualUsuario = null;
            this.DGDatosMovStock.OrigenDatos = null;
            this.DGDatosMovStock.PuedeUsuarioFiltrar = false;
            this.DGDatosMovStock.ReadOnly = true;
            this.DGDatosMovStock.RowHeadersWidth = 25;
            this.DGDatosMovStock.Size = new System.Drawing.Size(725, 184);
            this.DGDatosMovStock.TabIndex = 0;
            this.DGDatosMovStock.TransaparenciaDialogosGris = ((short)(100));
            // 
            // cIdelemMspr
            // 
            this.cIdelemMspr.DataPropertyName = "ID_ELEM";
            this.cIdelemMspr.HeaderText = "IdElem";
            this.cIdelemMspr.Name = "cIdelemMspr";
            this.cIdelemMspr.ReadOnly = true;
            this.cIdelemMspr.Visible = false;
            // 
            // cIdElemProdMspr
            // 
            this.cIdElemProdMspr.DataPropertyName = "ID_ELEM_PROD";
            this.cIdElemProdMspr.HeaderText = "IdElemProd";
            this.cIdElemProdMspr.Name = "cIdElemProdMspr";
            this.cIdElemProdMspr.ReadOnly = true;
            this.cIdElemProdMspr.Visible = false;
            // 
            // cFechaMovi
            // 
            this.cFechaMovi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cFechaMovi.DataPropertyName = "FECHA_MOVIMIENTO_MSPR";
            this.cFechaMovi.HeaderText = "Fecha Movimiento";
            this.cFechaMovi.Name = "cFechaMovi";
            this.cFechaMovi.ReadOnly = true;
            // 
            // cEntradaMspr
            // 
            this.cEntradaMspr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cEntradaMspr.ColorNegativos = System.Drawing.Color.Empty;
            this.cEntradaMspr.ColorPositivos = System.Drawing.Color.Empty;
            this.cEntradaMspr.DataPropertyName = "ENTRADA_MSPR";
            this.cEntradaMspr.HeaderText = "Entradas";
            this.cEntradaMspr.MarcarNegativos = false;
            this.cEntradaMspr.MarcarPositivos = false;
            this.cEntradaMspr.Name = "cEntradaMspr";
            this.cEntradaMspr.ReadOnly = true;
            this.cEntradaMspr.Width = 55;
            // 
            // cSalisaMspr
            // 
            this.cSalisaMspr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cSalisaMspr.ColorNegativos = System.Drawing.Color.Empty;
            this.cSalisaMspr.ColorPositivos = System.Drawing.Color.Empty;
            this.cSalisaMspr.DataPropertyName = "SALIDA_MSPR";
            this.cSalisaMspr.HeaderText = "Salidas";
            this.cSalisaMspr.MarcarNegativos = false;
            this.cSalisaMspr.MarcarPositivos = false;
            this.cSalisaMspr.Name = "cSalisaMspr";
            this.cSalisaMspr.ReadOnly = true;
            this.cSalisaMspr.Width = 47;
            // 
            // cIdElemOper
            // 
            this.cIdElemOper.DataPropertyName = "ID_ELEM_OPER";
            this.cIdElemOper.HeaderText = "IdElemOper";
            this.cIdElemOper.Name = "cIdElemOper";
            this.cIdElemOper.ReadOnly = true;
            this.cIdElemOper.Visible = false;
            // 
            // TPImagen
            // 
            this.TPImagen.Controls.Add(this.PBoxImagenProd);
            this.TPImagen.Controls.Add(this.BtnCargarImagen);
            this.TPImagen.Location = new System.Drawing.Point(4, 22);
            this.TPImagen.Name = "TPImagen";
            this.TPImagen.Padding = new System.Windows.Forms.Padding(3);
            this.TPImagen.Size = new System.Drawing.Size(737, 242);
            this.TPImagen.TabIndex = 1;
            this.TPImagen.Text = "Imagen";
            this.TPImagen.UseVisualStyleBackColor = true;
            // 
            // PBoxImagenProd
            // 
            this.PBoxImagenProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBoxImagenProd.Image = null;
            this.PBoxImagenProd.Location = new System.Drawing.Point(6, 6);
            this.PBoxImagenProd.Name = "PBoxImagenProd";
            this.PBoxImagenProd.Size = new System.Drawing.Size(263, 228);
            this.PBoxImagenProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBoxImagenProd.TabIndex = 10;
            this.PBoxImagenProd.TabStop = false;
            this.PBoxImagenProd.ValorStr = "";
            // 
            // BtnCargarImagen
            // 
            this.BtnCargarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCargarImagen.BackColor = System.Drawing.Color.Transparent;
            this.BtnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCargarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCargarImagen.Location = new System.Drawing.Point(551, 6);
            this.BtnCargarImagen.Name = "BtnCargarImagen";
            this.BtnCargarImagen.Size = new System.Drawing.Size(180, 48);
            this.BtnCargarImagen.TabIndex = 9;
            this.BtnCargarImagen.Text = "Cargar Imagen";
            this.BtnCargarImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCargarImagen.UseVisualStyleBackColor = true;
            this.BtnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // TPWeb
            // 
            this.TPWeb.Controls.Add(this.TBoxDescripcion);
            this.TPWeb.Controls.Add(this.cLabelBase12);
            this.TPWeb.Location = new System.Drawing.Point(4, 22);
            this.TPWeb.Name = "TPWeb";
            this.TPWeb.Padding = new System.Windows.Forms.Padding(3);
            this.TPWeb.Size = new System.Drawing.Size(737, 242);
            this.TPWeb.TabIndex = 2;
            this.TPWeb.Text = "Datos Web";
            this.TPWeb.UseVisualStyleBackColor = true;
            // 
            // DlgAbrirImagen
            // 
            this.DlgAbrirImagen.DefaultExt = "jpg";
            this.DlgAbrirImagen.Filter = "Archivos JPG|*.jpg|Todos los archivos|*.*";
            // 
            // cLabelBase12
            // 
            this.cLabelBase12.AutoSize = true;
            this.cLabelBase12.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase12.Location = new System.Drawing.Point(5, 3);
            this.cLabelBase12.Name = "cLabelBase12";
            this.cLabelBase12.Size = new System.Drawing.Size(89, 13);
            this.cLabelBase12.TabIndex = 0;
            this.cLabelBase12.Text = "Descripción Web";
            // 
            // TBoxDescripcion
            // 
            this.TBoxDescripcion.ActivarFormularioBusquedaF2 = true;
            this.TBoxDescripcion.ActivarMenuFormatoF3 = true;
            this.TBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TBoxDescripcion.Location = new System.Drawing.Point(9, 19);
            this.TBoxDescripcion.Name = "TBoxDescripcion";
            this.TBoxDescripcion.Size = new System.Drawing.Size(722, 215);
            this.TBoxDescripcion.TabIndex = 1;
            this.TBoxDescripcion.Text = "";
            this.TBoxDescripcion.TextoBase64 = "e1xydGYxXGFuc2lcYW5zaWNwZzEyNTJcZGVmZjBcZGVmbGFuZzMwODJ7XGZvbnR0Ymx7XGYwXGZuaWxcZ" +
                "mNoYXJzZXQwIE1pY3Jvc29mdCBTYW5zIFNlcmlmO319DQpcdmlld2tpbmQ0XHVjMVxwYXJkXGYwXGZzM" +
                "TdccGFyDQp9DQoAAA==";
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 557);
            this.Controls.Add(this.TCDatosProducto);
            this.Controls.Add(this.TBoxPorIva);
            this.Controls.Add(this.cLabelBase11);
            this.Controls.Add(this.TBoxPVP);
            this.Controls.Add(this.cLabelBase10);
            this.Controls.Add(this.CmbPorIva);
            this.Controls.Add(this.cLabelBase9);
            this.Controls.Add(this.TBoxPrecioSinIva);
            this.Controls.Add(this.cLabelBase8);
            this.Controls.Add(this.TBoxPrecioCompra);
            this.Controls.Add(this.cLabelBase7);
            this.Controls.Add(this.TBoxNombreProd);
            this.Controls.Add(this.cLabelBase5);
            this.Controls.Add(this.CmbSubfamilia);
            this.Controls.Add(this.cLabelBase4);
            this.Controls.Add(this.CmbFamilia);
            this.Controls.Add(this.cLabelBase3);
            this.Controls.Add(this.TBoxCodigoBarras);
            this.Controls.Add(this.cLabelBase2);
            this.Controls.Add(this.LblIdElem);
            this.Controls.Add(this.cLabelBase1);
            this.Controls.Add(this.HerramientasProd);
            this.Name = "FrmProducto";
            this.Text = "Ficha del producto";
            this.HerramientasProd.ResumeLayout(false);
            this.HerramientasProd.PerformLayout();
            this.TCDatosProducto.ResumeLayout(false);
            this.TPMovStock.ResumeLayout(false);
            this.TPMovStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDatosMovStock)).EndInit();
            this.TPImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImagenProd)).EndInit();
            this.TPWeb.ResumeLayout(false);
            this.TPWeb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTCBASE.cBarraHerramientas HerramientasProd;
        private CTCBASE.cLabelBase cLabelBase1;
        private CTCBASE.cLabelBase LblIdElem;
        private CTCBASE.cLabelBase cLabelBase2;
        private CTCBASE.cTextBoxBase TBoxCodigoBarras;
        private CTCBASE.cLabelBase cLabelBase3;
        private CTCBASE.cComboBoxBase CmbFamilia;
        private CTCBASE.cLabelBase cLabelBase4;
        private CTCBASE.cComboBoxBase CmbSubfamilia;
        private CTCBASE.cLabelBase cLabelBase5;
        private CTCBASE.cTextBoxBase TBoxNombreProd;
        private CTCBASE.cLabelBase cLabelBase6;
        private CTCBASE.cNumericBoxBase TBoxExistencias;
        private CTCBASE.cNumericBoxBase TBoxPrecioCompra;
        private CTCBASE.cLabelBase cLabelBase7;
        private CTCBASE.cNumericBoxBase TBoxPrecioSinIva;
        private CTCBASE.cLabelBase cLabelBase8;
        private CTCBASE.cLabelBase cLabelBase9;
        private CTCBASE.cComboBoxBase CmbPorIva;
        private CTCBASE.cNumericBoxBase TBoxPVP;
        private CTCBASE.cLabelBase cLabelBase10;
        private CTCBASE.cLabelBase cLabelBase11;
        private CTCBASE.cNumericBoxBase TBoxPorIva;
        private System.Windows.Forms.ToolStripButton BtnGuardarProd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnSalir;
        private System.Windows.Forms.TabControl TCDatosProducto;
        private System.Windows.Forms.TabPage TPMovStock;
        private System.Windows.Forms.TabPage TPImagen;
        private CTGRIDBASE.GRID.DataGridViewBase DGDatosMovStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdelemMspr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdElemProdMspr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechaMovi;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn cEntradaMspr;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn cSalisaMspr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdElemOper;
        private CTCBASE.cBoton BtnCargarImagen;
        private CTCBASE.cImagen PBoxImagenProd;
        private System.Windows.Forms.OpenFileDialog DlgAbrirImagen;
        private System.Windows.Forms.TabPage TPWeb;
        private CTCBASE.cRitchTextBox TBoxDescripcion;
        private CTCBASE.cLabelBase cLabelBase12;
    }
}