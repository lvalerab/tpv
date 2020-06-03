namespace LFVBNewTPV.TPV
{
    partial class FrmDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocumentos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HerramientasListDoc = new CTCBASE.cBarraHerramientas();
            this.BtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.BtnFicha = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.BtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.BtnAceptar = new System.Windows.Forms.ToolStripButton();
            this.cLabelBase1 = new CTCBASE.cLabelBase();
            this.TBoxTipoDocFiltro = new CTCBASE.cTextBoxBase();
            this.cLabelBase3 = new CTCBASE.cLabelBase();
            this.cLabelBase4 = new CTCBASE.cLabelBase();
            this.TBoxNumeroDocFiltro = new CTCBASE.cNumericBoxBase();
            this.cLabelBase5 = new CTCBASE.cLabelBase();
            this.TBoxAnyoDocFiltro = new CTCBASE.cNumericBoxBase();
            this.TBoxNombreClienteFiltro = new CTCBASE.cTextBoxBase();
            this.DGDatos = new CTGRIDBASE.GRID.DataGridViewBase();
            this.cNumDocCado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdElem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCodTido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAnyoCado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumeroCado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFechaEntradaCado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdelemPers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreTituCado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotalCado = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.cPagadoCado = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.HerramientasListDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // HerramientasListDoc
            // 
            this.HerramientasListDoc.AutoSize = false;
            this.HerramientasListDoc.color_final = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HerramientasListDoc.color_inicial = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HerramientasListDoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.HerramientasListDoc.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.HerramientasListDoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNuevo,
            this.BtnFicha,
            this.toolStripSeparator1,
            this.BtnRefrescar,
            this.BtnCancelar,
            this.BtnAceptar});
            this.HerramientasListDoc.Location = new System.Drawing.Point(807, 0);
            this.HerramientasListDoc.Name = "HerramientasListDoc";
            this.HerramientasListDoc.Size = new System.Drawing.Size(98, 580);
            this.HerramientasListDoc.TabIndex = 0;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(96, 67);
            this.BtnNuevo.Text = "&Nuevo Documento";
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnFicha
            // 
            this.BtnFicha.Image = ((System.Drawing.Image)(resources.GetObject("BtnFicha.Image")));
            this.BtnFicha.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnFicha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFicha.Name = "BtnFicha";
            this.BtnFicha.Size = new System.Drawing.Size(96, 67);
            this.BtnFicha.Text = "&Ficha documento";
            this.BtnFicha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnFicha.Click += new System.EventHandler(this.BtnFicha_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(96, 6);
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.Image = global::LFVBNewTPV.Properties.Resources.refresh;
            this.BtnRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(96, 67);
            this.BtnRefrescar.Text = "&Refrescar";
            this.BtnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCancelar.Image = global::LFVBNewTPV.Properties.Resources.delete2;
            this.BtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(96, 67);
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnAceptar.Image = global::LFVBNewTPV.Properties.Resources.check2;
            this.BtnAceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(96, 67);
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // cLabelBase1
            // 
            this.cLabelBase1.AutoSize = true;
            this.cLabelBase1.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase1.Location = new System.Drawing.Point(12, 9);
            this.cLabelBase1.Name = "cLabelBase1";
            this.cLabelBase1.Size = new System.Drawing.Size(207, 24);
            this.cLabelBase1.TabIndex = 1;
            this.cLabelBase1.Text = "Número de documento";
            // 
            // TBoxTipoDocFiltro
            // 
            this.TBoxTipoDocFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxTipoDocFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxTipoDocFiltro.Location = new System.Drawing.Point(15, 36);
            this.TBoxTipoDocFiltro.MaxLength = 2;
            this.TBoxTipoDocFiltro.Name = "TBoxTipoDocFiltro";
            this.TBoxTipoDocFiltro.Size = new System.Drawing.Size(35, 29);
            this.TBoxTipoDocFiltro.TabIndex = 2;
            this.TBoxTipoDocFiltro.TextChanged += new System.EventHandler(this.TBoxTipoDocFiltro_TextChanged);
            // 
            // cLabelBase3
            // 
            this.cLabelBase3.AutoSize = true;
            this.cLabelBase3.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase3.Location = new System.Drawing.Point(278, 9);
            this.cLabelBase3.Name = "cLabelBase3";
            this.cLabelBase3.Size = new System.Drawing.Size(170, 24);
            this.cLabelBase3.TabIndex = 4;
            this.cLabelBase3.Text = "Nombre del cliente";
            // 
            // cLabelBase4
            // 
            this.cLabelBase4.AutoSize = true;
            this.cLabelBase4.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase4.Location = new System.Drawing.Point(56, 38);
            this.cLabelBase4.Name = "cLabelBase4";
            this.cLabelBase4.Size = new System.Drawing.Size(15, 24);
            this.cLabelBase4.TabIndex = 6;
            this.cLabelBase4.Text = "/";
            // 
            // TBoxNumeroDocFiltro
            // 
            this.TBoxNumeroDocFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxNumeroDocFiltro.ColorNegativos = System.Drawing.Color.Empty;
            this.TBoxNumeroDocFiltro.ColorPositivos = System.Drawing.Color.Empty;
            this.TBoxNumeroDocFiltro.Decimales = ((short)(0));
            this.TBoxNumeroDocFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxNumeroDocFiltro.Location = new System.Drawing.Point(77, 36);
            this.TBoxNumeroDocFiltro.MarcarNegativos = false;
            this.TBoxNumeroDocFiltro.MarcarPositivos = false;
            this.TBoxNumeroDocFiltro.MaxLength = 10;
            this.TBoxNumeroDocFiltro.Name = "TBoxNumeroDocFiltro";
            this.TBoxNumeroDocFiltro.PonerValorDefecto = false;
            this.TBoxNumeroDocFiltro.Size = new System.Drawing.Size(116, 29);
            this.TBoxNumeroDocFiltro.TabIndex = 7;
            this.TBoxNumeroDocFiltro.Text = "0";
            this.TBoxNumeroDocFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxNumeroDocFiltro.ValorDefecto = 0;
            this.TBoxNumeroDocFiltro.TextChanged += new System.EventHandler(this.TBoxTipoDocFiltro_TextChanged);
            // 
            // cLabelBase5
            // 
            this.cLabelBase5.AutoSize = true;
            this.cLabelBase5.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase5.Location = new System.Drawing.Point(199, 38);
            this.cLabelBase5.Name = "cLabelBase5";
            this.cLabelBase5.Size = new System.Drawing.Size(15, 24);
            this.cLabelBase5.TabIndex = 8;
            this.cLabelBase5.Text = "/";
            // 
            // TBoxAnyoDocFiltro
            // 
            this.TBoxAnyoDocFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxAnyoDocFiltro.ColorNegativos = System.Drawing.Color.Empty;
            this.TBoxAnyoDocFiltro.ColorPositivos = System.Drawing.Color.Empty;
            this.TBoxAnyoDocFiltro.Decimales = ((short)(0));
            this.TBoxAnyoDocFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxAnyoDocFiltro.Location = new System.Drawing.Point(220, 36);
            this.TBoxAnyoDocFiltro.MarcarNegativos = false;
            this.TBoxAnyoDocFiltro.MarcarPositivos = false;
            this.TBoxAnyoDocFiltro.MaxLength = 4;
            this.TBoxAnyoDocFiltro.Name = "TBoxAnyoDocFiltro";
            this.TBoxAnyoDocFiltro.PonerValorDefecto = false;
            this.TBoxAnyoDocFiltro.Size = new System.Drawing.Size(56, 29);
            this.TBoxAnyoDocFiltro.TabIndex = 9;
            this.TBoxAnyoDocFiltro.Text = "0";
            this.TBoxAnyoDocFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxAnyoDocFiltro.ValorDefecto = 0;
            this.TBoxAnyoDocFiltro.TextChanged += new System.EventHandler(this.TBoxTipoDocFiltro_TextChanged);
            // 
            // TBoxNombreClienteFiltro
            // 
            this.TBoxNombreClienteFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxNombreClienteFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxNombreClienteFiltro.Location = new System.Drawing.Point(282, 36);
            this.TBoxNombreClienteFiltro.Name = "TBoxNombreClienteFiltro";
            this.TBoxNombreClienteFiltro.Size = new System.Drawing.Size(522, 29);
            this.TBoxNombreClienteFiltro.TabIndex = 10;
            this.TBoxNombreClienteFiltro.TextChanged += new System.EventHandler(this.TBoxTipoDocFiltro_TextChanged);
            // 
            // DGDatos
            // 
            this.DGDatos.AllowUserToAddRows = false;
            this.DGDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGDatos.ColorOrdenAscendente = System.Drawing.Color.Empty;
            this.DGDatos.ColorOrdenDescendente = System.Drawing.Color.Empty;
            this.DGDatos.ColumnasFijadasSalto = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNumDocCado,
            this.cIdElem,
            this.cCodTido,
            this.CAnyoCado,
            this.cNumeroCado,
            this.CFechaSistema,
            this.cFechaEntradaCado,
            this.cIdelemPers,
            this.cNombreTituCado,
            this.cTotalCado,
            this.cPagadoCado});
            this.DGDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGDatos.EnableHeadersVisualStyles = false;
            this.DGDatos.FormularioPadreMdi = null;
            this.DGDatos.Location = new System.Drawing.Point(15, 71);
            this.DGDatos.MostrarMenuContextualDefecto = true;
            this.DGDatos.Name = "DGDatos";
            this.DGDatos.OpcionesMenuContextualUsuario = null;
            this.DGDatos.OrigenDatos = null;
            this.DGDatos.PuedeUsuarioFiltrar = true;
            this.DGDatos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGDatos.RowHeadersWidth = 15;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGDatos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGDatos.RowTemplate.Height = 35;
            this.DGDatos.Size = new System.Drawing.Size(789, 497);
            this.DGDatos.TabIndex = 11;
            this.DGDatos.TransaparenciaDialogosGris = ((short)(100));
            // 
            // cNumDocCado
            // 
            this.cNumDocCado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cNumDocCado.DataPropertyName = "NUM_DOC_FORM";
            this.cNumDocCado.HeaderText = "Número Documento";
            this.cNumDocCado.Name = "cNumDocCado";
            this.cNumDocCado.ReadOnly = true;
            this.cNumDocCado.Width = 161;
            // 
            // cIdElem
            // 
            this.cIdElem.DataPropertyName = "ID_ELEM";
            this.cIdElem.HeaderText = "IdElem";
            this.cIdElem.Name = "cIdElem";
            this.cIdElem.ReadOnly = true;
            this.cIdElem.Visible = false;
            // 
            // cCodTido
            // 
            this.cCodTido.DataPropertyName = "COD_TIDO";
            this.cCodTido.HeaderText = "Cod Tido";
            this.cCodTido.Name = "cCodTido";
            this.cCodTido.ReadOnly = true;
            this.cCodTido.Visible = false;
            // 
            // CAnyoCado
            // 
            this.CAnyoCado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CAnyoCado.DataPropertyName = "ANYO_CADO";
            this.CAnyoCado.HeaderText = "Año";
            this.CAnyoCado.Name = "CAnyoCado";
            this.CAnyoCado.ReadOnly = true;
            this.CAnyoCado.Width = 63;
            // 
            // cNumeroCado
            // 
            this.cNumeroCado.DataPropertyName = "NUMERO_CADO";
            this.cNumeroCado.HeaderText = "NumeroCado";
            this.cNumeroCado.Name = "cNumeroCado";
            this.cNumeroCado.ReadOnly = true;
            this.cNumeroCado.Visible = false;
            // 
            // CFechaSistema
            // 
            this.CFechaSistema.DataPropertyName = "FECHA_SYSTEMA_CADO";
            this.CFechaSistema.HeaderText = "Fecha Entrada Sistema";
            this.CFechaSistema.Name = "CFechaSistema";
            this.CFechaSistema.ReadOnly = true;
            this.CFechaSistema.Visible = false;
            // 
            // cFechaEntradaCado
            // 
            this.cFechaEntradaCado.DataPropertyName = "FECHA_ENTRADA_CADO";
            this.cFechaEntradaCado.HeaderText = "Fecha documento";
            this.cFechaEntradaCado.Name = "cFechaEntradaCado";
            this.cFechaEntradaCado.ReadOnly = true;
            // 
            // cIdelemPers
            // 
            this.cIdelemPers.DataPropertyName = "ID_ELEM_PERS";
            this.cIdelemPers.HeaderText = "cIdElemPers";
            this.cIdelemPers.Name = "cIdelemPers";
            this.cIdelemPers.ReadOnly = true;
            this.cIdelemPers.Visible = false;
            // 
            // cNombreTituCado
            // 
            this.cNombreTituCado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNombreTituCado.DataPropertyName = "NOMBRE_PERS_CADO";
            this.cNombreTituCado.HeaderText = "Nombre titular";
            this.cNombreTituCado.Name = "cNombreTituCado";
            this.cNombreTituCado.ReadOnly = true;
            // 
            // cTotalCado
            // 
            this.cTotalCado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cTotalCado.ColorNegativos = System.Drawing.Color.Empty;
            this.cTotalCado.ColorPositivos = System.Drawing.Color.Empty;
            this.cTotalCado.DataPropertyName = "TOTAL_CADO";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.cTotalCado.DefaultCellStyle = dataGridViewCellStyle3;
            this.cTotalCado.HeaderText = "Total";
            this.cTotalCado.MarcarNegativos = false;
            this.cTotalCado.MarcarPositivos = false;
            this.cTotalCado.Name = "cTotalCado";
            this.cTotalCado.ReadOnly = true;
            this.cTotalCado.Width = 50;
            // 
            // cPagadoCado
            // 
            this.cPagadoCado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cPagadoCado.ColorNegativos = System.Drawing.Color.Empty;
            this.cPagadoCado.ColorPositivos = System.Drawing.Color.Empty;
            this.cPagadoCado.DataPropertyName = "PAGADO_CADO";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.cPagadoCado.DefaultCellStyle = dataGridViewCellStyle4;
            this.cPagadoCado.HeaderText = "Pagado";
            this.cPagadoCado.MarcarNegativos = false;
            this.cPagadoCado.MarcarPositivos = false;
            this.cPagadoCado.Name = "cPagadoCado";
            this.cPagadoCado.ReadOnly = true;
            this.cPagadoCado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cPagadoCado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cPagadoCado.Width = 89;
            // 
            // FrmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 580);
            this.Controls.Add(this.DGDatos);
            this.Controls.Add(this.TBoxNombreClienteFiltro);
            this.Controls.Add(this.TBoxAnyoDocFiltro);
            this.Controls.Add(this.cLabelBase5);
            this.Controls.Add(this.TBoxNumeroDocFiltro);
            this.Controls.Add(this.cLabelBase4);
            this.Controls.Add(this.cLabelBase3);
            this.Controls.Add(this.TBoxTipoDocFiltro);
            this.Controls.Add(this.cLabelBase1);
            this.Controls.Add(this.HerramientasListDoc);
            this.Name = "FrmDocumentos";
            this.Text = "Listado de documentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDocumentos_FormClosing);
            this.HerramientasListDoc.ResumeLayout(false);
            this.HerramientasListDoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTCBASE.cBarraHerramientas HerramientasListDoc;
        private CTCBASE.cLabelBase cLabelBase1;
        private CTCBASE.cTextBoxBase TBoxTipoDocFiltro;
        private CTCBASE.cLabelBase cLabelBase3;
        private CTCBASE.cLabelBase cLabelBase4;
        private CTCBASE.cNumericBoxBase TBoxNumeroDocFiltro;
        private CTCBASE.cLabelBase cLabelBase5;
        private CTCBASE.cNumericBoxBase TBoxAnyoDocFiltro;
        private CTCBASE.cTextBoxBase TBoxNombreClienteFiltro;
        private CTGRIDBASE.GRID.DataGridViewBase DGDatos;
        private System.Windows.Forms.ToolStripButton BtnNuevo;
        private System.Windows.Forms.ToolStripButton BtnFicha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnRefrescar;
        private System.Windows.Forms.ToolStripButton BtnCancelar;
        private System.Windows.Forms.ToolStripButton BtnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumDocCado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdElem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodTido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAnyoCado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumeroCado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechaEntradaCado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdelemPers;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreTituCado;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn cTotalCado;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn cPagadoCado;
    }
}