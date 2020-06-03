namespace LFVBNewTPV.CRM.PRODUCTOS
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HerramientasListProd = new CTCBASE.cBarraHerramientas();
            this.TSNuevoProd = new System.Windows.Forms.ToolStripButton();
            this.TSFichaProd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSRefrescar = new System.Windows.Forms.ToolStripButton();
            this.TSSalir = new System.Windows.Forms.ToolStripButton();
            this.TSAceptar = new System.Windows.Forms.ToolStripButton();
            this.DGDatos = new CTGRIDBASE.GRID.DataGridViewBase();
            this.CIdElem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCodBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodFamilia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cCodSufa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cExistencias = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.cPrecioVenta = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.cImagenProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescripProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLabelBase1 = new CTCBASE.cLabelBase();
            this.cLabelBase2 = new CTCBASE.cLabelBase();
            this.TBoxFiltroCodBarras = new CTCBASE.cTextBoxBase();
            this.TBoxFiltroDescripcion = new CTCBASE.cTextBoxBase();
            this.HerramientasListProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // HerramientasListProd
            // 
            this.HerramientasListProd.AutoSize = false;
            this.HerramientasListProd.color_final = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HerramientasListProd.color_inicial = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HerramientasListProd.Dock = System.Windows.Forms.DockStyle.Right;
            this.HerramientasListProd.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.HerramientasListProd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSNuevoProd,
            this.TSFichaProd,
            this.toolStripSeparator1,
            this.TSRefrescar,
            this.TSSalir,
            this.TSAceptar});
            this.HerramientasListProd.Location = new System.Drawing.Point(742, 0);
            this.HerramientasListProd.Name = "HerramientasListProd";
            this.HerramientasListProd.Size = new System.Drawing.Size(111, 582);
            this.HerramientasListProd.TabIndex = 0;
            // 
            // TSNuevoProd
            // 
            this.TSNuevoProd.Image = ((System.Drawing.Image)(resources.GetObject("TSNuevoProd.Image")));
            this.TSNuevoProd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSNuevoProd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSNuevoProd.Name = "TSNuevoProd";
            this.TSNuevoProd.Size = new System.Drawing.Size(109, 67);
            this.TSNuevoProd.Text = "&Nuevo producto";
            this.TSNuevoProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSNuevoProd.Click += new System.EventHandler(this.TSNuevoProd_Click);
            // 
            // TSFichaProd
            // 
            this.TSFichaProd.Image = ((System.Drawing.Image)(resources.GetObject("TSFichaProd.Image")));
            this.TSFichaProd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSFichaProd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSFichaProd.Name = "TSFichaProd";
            this.TSFichaProd.Size = new System.Drawing.Size(109, 67);
            this.TSFichaProd.Text = "&Ficha producto";
            this.TSFichaProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSFichaProd.Click += new System.EventHandler(this.TSFichaProd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // TSRefrescar
            // 
            this.TSRefrescar.Image = global::LFVBNewTPV.Properties.Resources.refresh;
            this.TSRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSRefrescar.Name = "TSRefrescar";
            this.TSRefrescar.Size = new System.Drawing.Size(109, 67);
            this.TSRefrescar.Text = "&Refrescar lista";
            this.TSRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSRefrescar.Click += new System.EventHandler(this.TSRefrescar_Click);
            // 
            // TSSalir
            // 
            this.TSSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSSalir.Image = global::LFVBNewTPV.Properties.Resources.delete2;
            this.TSSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSSalir.Name = "TSSalir";
            this.TSSalir.Size = new System.Drawing.Size(109, 67);
            this.TSSalir.Text = "&Cancelar";
            this.TSSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSSalir.Click += new System.EventHandler(this.TSSalir_Click);
            // 
            // TSAceptar
            // 
            this.TSAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSAceptar.Image = global::LFVBNewTPV.Properties.Resources.check2;
            this.TSAceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSAceptar.Name = "TSAceptar";
            this.TSAceptar.Size = new System.Drawing.Size(109, 67);
            this.TSAceptar.Text = "&Aceptar";
            this.TSAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSAceptar.Click += new System.EventHandler(this.TSAceptar_Click);
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
            this.DGDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGDatos.ColorOrdenAscendente = System.Drawing.Color.Empty;
            this.DGDatos.ColorOrdenDescendente = System.Drawing.Color.Empty;
            this.DGDatos.ColumnasFijadasSalto = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdElem,
            this.cCodBarras,
            this.CNombreProd,
            this.CCodFamilia,
            this.cCodSufa,
            this.cExistencias,
            this.cPrecioVenta,
            this.cImagenProd,
            this.cDescripProd});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGDatos.EnableHeadersVisualStyles = false;
            this.DGDatos.FormularioPadreMdi = null;
            this.DGDatos.Location = new System.Drawing.Point(12, 75);
            this.DGDatos.MostrarMenuContextualDefecto = true;
            this.DGDatos.Name = "DGDatos";
            this.DGDatos.OpcionesMenuContextualUsuario = null;
            this.DGDatos.OrigenDatos = null;
            this.DGDatos.PuedeUsuarioFiltrar = true;
            this.DGDatos.ReadOnly = true;
            this.DGDatos.RowHeadersWidth = 15;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGDatos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGDatos.RowTemplate.Height = 35;
            this.DGDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGDatos.Size = new System.Drawing.Size(727, 495);
            this.DGDatos.TabIndex = 1;
            this.DGDatos.TransaparenciaDialogosGris = ((short)(100));
            // 
            // CIdElem
            // 
            this.CIdElem.DataPropertyName = "ID_ELEM";
            this.CIdElem.HeaderText = "IdElem";
            this.CIdElem.Name = "CIdElem";
            this.CIdElem.ReadOnly = true;
            this.CIdElem.Visible = false;
            // 
            // cCodBarras
            // 
            this.cCodBarras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cCodBarras.DataPropertyName = "COD_BARRAS";
            this.cCodBarras.HeaderText = "Cod. Barras";
            this.cCodBarras.Name = "cCodBarras";
            this.cCodBarras.ReadOnly = true;
            this.cCodBarras.Width = 133;
            // 
            // CNombreProd
            // 
            this.CNombreProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CNombreProd.DataPropertyName = "NOMBRE_PROD";
            this.CNombreProd.HeaderText = "Producto";
            this.CNombreProd.Name = "CNombreProd";
            this.CNombreProd.ReadOnly = true;
            this.CNombreProd.Width = 111;
            // 
            // CCodFamilia
            // 
            this.CCodFamilia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CCodFamilia.DataPropertyName = "COD_FAMI";
            this.CCodFamilia.HeaderText = "Familia";
            this.CCodFamilia.Name = "CCodFamilia";
            this.CCodFamilia.ReadOnly = true;
            this.CCodFamilia.Width = 76;
            // 
            // cCodSufa
            // 
            this.cCodSufa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cCodSufa.DataPropertyName = "COD_SUFA";
            this.cCodSufa.HeaderText = "Subfamilia";
            this.cCodSufa.Name = "cCodSufa";
            this.cCodSufa.ReadOnly = true;
            this.cCodSufa.Width = 102;
            // 
            // cExistencias
            // 
            this.cExistencias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cExistencias.ColorNegativos = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cExistencias.ColorPositivos = System.Drawing.Color.Green;
            this.cExistencias.DataPropertyName = "EXISTENCIAS_PROD";
            this.cExistencias.HeaderText = "Existencias";
            this.cExistencias.MarcarNegativos = true;
            this.cExistencias.MarcarPositivos = true;
            this.cExistencias.Name = "cExistencias";
            this.cExistencias.ReadOnly = true;
            this.cExistencias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cExistencias.Width = 130;
            // 
            // cPrecioVenta
            // 
            this.cPrecioVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cPrecioVenta.ColorNegativos = System.Drawing.Color.Empty;
            this.cPrecioVenta.ColorPositivos = System.Drawing.Color.Empty;
            this.cPrecioVenta.DataPropertyName = "PVP_PROD";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.cPrecioVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.cPrecioVenta.HeaderText = "PVP";
            this.cPrecioVenta.MarcarNegativos = false;
            this.cPrecioVenta.MarcarPositivos = false;
            this.cPrecioVenta.Name = "cPrecioVenta";
            this.cPrecioVenta.ReadOnly = true;
            this.cPrecioVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cPrecioVenta.Width = 72;
            // 
            // cImagenProd
            // 
            this.cImagenProd.DataPropertyName = "IMAGEN_PROD";
            this.cImagenProd.HeaderText = "Imagen";
            this.cImagenProd.Name = "cImagenProd";
            this.cImagenProd.ReadOnly = true;
            this.cImagenProd.Visible = false;
            // 
            // cDescripProd
            // 
            this.cDescripProd.DataPropertyName = "DESCRIPCION_PROD";
            this.cDescripProd.HeaderText = "Descrip.";
            this.cDescripProd.Name = "cDescripProd";
            this.cDescripProd.ReadOnly = true;
            this.cDescripProd.Visible = false;
            // 
            // cLabelBase1
            // 
            this.cLabelBase1.AutoSize = true;
            this.cLabelBase1.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase1.Location = new System.Drawing.Point(9, 9);
            this.cLabelBase1.Name = "cLabelBase1";
            this.cLabelBase1.Size = new System.Drawing.Size(155, 24);
            this.cLabelBase1.TabIndex = 2;
            this.cLabelBase1.Text = "Código de barras";
            // 
            // cLabelBase2
            // 
            this.cLabelBase2.AutoSize = true;
            this.cLabelBase2.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase2.Location = new System.Drawing.Point(170, 9);
            this.cLabelBase2.Name = "cLabelBase2";
            this.cLabelBase2.Size = new System.Drawing.Size(221, 24);
            this.cLabelBase2.TabIndex = 3;
            this.cLabelBase2.Text = "Descripción del producto";
            // 
            // TBoxFiltroCodBarras
            // 
            this.TBoxFiltroCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxFiltroCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxFiltroCodBarras.Location = new System.Drawing.Point(12, 36);
            this.TBoxFiltroCodBarras.Name = "TBoxFiltroCodBarras";
            this.TBoxFiltroCodBarras.Size = new System.Drawing.Size(152, 29);
            this.TBoxFiltroCodBarras.TabIndex = 4;
            this.TBoxFiltroCodBarras.TextChanged += new System.EventHandler(this.TBoxFiltroCodBarras_TextChanged);
            // 
            // TBoxFiltroDescripcion
            // 
            this.TBoxFiltroDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxFiltroDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxFiltroDescripcion.Location = new System.Drawing.Point(174, 36);
            this.TBoxFiltroDescripcion.Name = "TBoxFiltroDescripcion";
            this.TBoxFiltroDescripcion.Size = new System.Drawing.Size(565, 29);
            this.TBoxFiltroDescripcion.TabIndex = 5;
            this.TBoxFiltroDescripcion.TextChanged += new System.EventHandler(this.TBoxFiltroCodBarras_TextChanged);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 582);
            this.Controls.Add(this.TBoxFiltroDescripcion);
            this.Controls.Add(this.TBoxFiltroCodBarras);
            this.Controls.Add(this.cLabelBase2);
            this.Controls.Add(this.cLabelBase1);
            this.Controls.Add(this.DGDatos);
            this.Controls.Add(this.HerramientasListProd);
            this.Name = "FrmProductos";
            this.Text = "Listado de productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProductos_FormClosing);
            this.HerramientasListProd.ResumeLayout(false);
            this.HerramientasListProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTCBASE.cBarraHerramientas HerramientasListProd;
        private System.Windows.Forms.ToolStripButton TSNuevoProd;
        private System.Windows.Forms.ToolStripButton TSFichaProd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSRefrescar;
        private System.Windows.Forms.ToolStripButton TSSalir;
        private System.Windows.Forms.ToolStripButton TSAceptar;
        private CTGRIDBASE.GRID.DataGridViewBase DGDatos;
        private CTCBASE.cLabelBase cLabelBase1;
        private CTCBASE.cLabelBase cLabelBase2;
        private CTCBASE.cTextBoxBase TBoxFiltroDescripcion;
        public CTCBASE.cTextBoxBase TBoxFiltroCodBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdElem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreProd;
        private System.Windows.Forms.DataGridViewComboBoxColumn CCodFamilia;
        private System.Windows.Forms.DataGridViewComboBoxColumn cCodSufa;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn cExistencias;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn cPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cImagenProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescripProd;
    }
}