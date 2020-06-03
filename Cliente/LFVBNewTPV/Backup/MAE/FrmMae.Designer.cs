namespace LFVBNewTPV.MAE
{
    partial class FrmMae
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HerramientasMae = new CTCBASE.cBarraHerramientas();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TSUtilsAplicaTipoIva = new System.Windows.Forms.ToolStripButton();
            this.DGDatos = new CTGRIDBASE.GRID.DataGridViewBase();
            this.cFamilias = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cPorIva = new CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn();
            this.cVigenteIva = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HerramientasMae.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // HerramientasMae
            // 
            this.HerramientasMae.AutoSize = false;
            this.HerramientasMae.color_final = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HerramientasMae.color_inicial = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HerramientasMae.Dock = System.Windows.Forms.DockStyle.Right;
            this.HerramientasMae.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.HerramientasMae.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.TSUtilsAplicaTipoIva});
            this.HerramientasMae.Location = new System.Drawing.Point(568, 0);
            this.HerramientasMae.Name = "HerramientasMae";
            this.HerramientasMae.Size = new System.Drawing.Size(106, 475);
            this.HerramientasMae.TabIndex = 0;
            this.HerramientasMae.Text = "cBarraHerramientas1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::LFVBNewTPV.Properties.Resources.disk_blue;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(104, 67);
            this.toolStripButton1.Text = "&Guardar";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // TSUtilsAplicaTipoIva
            // 
            this.TSUtilsAplicaTipoIva.Image = global::LFVBNewTPV.Properties.Resources.money21;
            this.TSUtilsAplicaTipoIva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSUtilsAplicaTipoIva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSUtilsAplicaTipoIva.Name = "TSUtilsAplicaTipoIva";
            this.TSUtilsAplicaTipoIva.Size = new System.Drawing.Size(104, 67);
            this.TSUtilsAplicaTipoIva.Text = "Aplicar Tipo Iva";
            this.TSUtilsAplicaTipoIva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSUtilsAplicaTipoIva.Click += new System.EventHandler(this.TSUtilsAplicaTipoIva_Click);
            // 
            // DGDatos
            // 
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFamilias,
            this.cPorIva,
            this.cVigenteIva});
            this.DGDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGDatos.EnableHeadersVisualStyles = false;
            this.DGDatos.FormularioPadreMdi = null;
            this.DGDatos.Location = new System.Drawing.Point(12, 12);
            this.DGDatos.MostrarMenuContextualDefecto = true;
            this.DGDatos.Name = "DGDatos";
            this.DGDatos.OpcionesMenuContextualUsuario = null;
            this.DGDatos.OrigenDatos = null;
            this.DGDatos.PuedeUsuarioFiltrar = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGDatos.RowHeadersWidth = 25;
            this.DGDatos.Size = new System.Drawing.Size(553, 451);
            this.DGDatos.TabIndex = 1;
            this.DGDatos.TransaparenciaDialogosGris = ((short)(100));
            this.DGDatos.DataSourceChanged += new System.EventHandler(this.DGDatos_DataSourceChanged);
            // 
            // cFamilias
            // 
            this.cFamilias.HeaderText = "Familia";
            this.cFamilias.Name = "cFamilias";
            this.cFamilias.Visible = false;
            // 
            // cPorIva
            // 
            this.cPorIva.ColorNegativos = System.Drawing.Color.Red;
            this.cPorIva.ColorPositivos = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cPorIva.DataPropertyName = "POR_IVA";
            this.cPorIva.HeaderText = "% Iva";
            this.cPorIva.MarcarNegativos = true;
            this.cPorIva.MarcarPositivos = true;
            this.cPorIva.Name = "cPorIva";
            this.cPorIva.Visible = false;
            // 
            // cVigenteIva
            // 
            this.cVigenteIva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cVigenteIva.DataPropertyName = "VIGENTE_IVA";
            this.cVigenteIva.FalseValue = "N";
            this.cVigenteIva.HeaderText = "Vigente";
            this.cVigenteIva.Name = "cVigenteIva";
            this.cVigenteIva.TrueValue = "S";
            this.cVigenteIva.Visible = false;
            this.cVigenteIva.Width = 81;
            // 
            // FrmMae
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 475);
            this.Controls.Add(this.DGDatos);
            this.Controls.Add(this.HerramientasMae);
            this.Name = "FrmMae";
            this.Text = "Configuración de tablas maestras: ";
            this.HerramientasMae.ResumeLayout(false);
            this.HerramientasMae.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CTCBASE.cBarraHerramientas HerramientasMae;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private CTGRIDBASE.GRID.DataGridViewBase DGDatos;
        private System.Windows.Forms.DataGridViewComboBoxColumn cFamilias;
        private CTGRIDBASE.GRID.COLUMNAS.DataGridViewNumericColumn cPorIva;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cVigenteIva;
        private System.Windows.Forms.ToolStripButton TSUtilsAplicaTipoIva;
    }
}