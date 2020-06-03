namespace LFVBRptTpvServer.FRM.PRODUCTOS.FRMAUX
{
    partial class FrmFiltroStock
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
            this.LblFiltroFamilias = new CTCBASE.cLabelBase();
            this.TBoxStockMin = new CTCBASE.cNumericBoxBase();
            this.cLabelBase1 = new CTCBASE.cLabelBase();
            this.cLabelBase2 = new CTCBASE.cLabelBase();
            this.TBoxStockMax = new CTCBASE.cNumericBoxBase();
            this.BHerramientas = new CTCBASE.cBarraHerramientas();
            this.TSBtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.TSBtnAceptar = new System.Windows.Forms.ToolStripButton();
            this.DGFamilias = new CTGRIDBASE.GRID.DataGridViewBase();
            this.cCodFami = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreFami = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGFamilias)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFiltroFamilias
            // 
            this.LblFiltroFamilias.AutoSize = true;
            this.LblFiltroFamilias.BackColor = System.Drawing.Color.Transparent;
            this.LblFiltroFamilias.Location = new System.Drawing.Point(12, 9);
            this.LblFiltroFamilias.Name = "LblFiltroFamilias";
            this.LblFiltroFamilias.Size = new System.Drawing.Size(103, 13);
            this.LblFiltroFamilias.TabIndex = 1;
            this.LblFiltroFamilias.Text = "Seleccionar Familias";
            // 
            // TBoxStockMin
            // 
            this.TBoxStockMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxStockMin.ColorNegativos = System.Drawing.Color.Empty;
            this.TBoxStockMin.ColorPositivos = System.Drawing.Color.Empty;
            this.TBoxStockMin.Decimales = ((short)(0));
            this.TBoxStockMin.Location = new System.Drawing.Point(294, 217);
            this.TBoxStockMin.MarcarNegativos = false;
            this.TBoxStockMin.MarcarPositivos = false;
            this.TBoxStockMin.Name = "TBoxStockMin";
            this.TBoxStockMin.PonerValorDefecto = false;
            this.TBoxStockMin.Size = new System.Drawing.Size(100, 20);
            this.TBoxStockMin.TabIndex = 2;
            this.TBoxStockMin.Text = "0";
            this.TBoxStockMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxStockMin.ValorDefecto = 0;
            // 
            // cLabelBase1
            // 
            this.cLabelBase1.AutoSize = true;
            this.cLabelBase1.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase1.Location = new System.Drawing.Point(291, 201);
            this.cLabelBase1.Name = "cLabelBase1";
            this.cLabelBase1.Size = new System.Drawing.Size(73, 13);
            this.cLabelBase1.TabIndex = 3;
            this.cLabelBase1.Text = "Stock Mínimo";
            // 
            // cLabelBase2
            // 
            this.cLabelBase2.AutoSize = true;
            this.cLabelBase2.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase2.Location = new System.Drawing.Point(397, 201);
            this.cLabelBase2.Name = "cLabelBase2";
            this.cLabelBase2.Size = new System.Drawing.Size(74, 13);
            this.cLabelBase2.TabIndex = 5;
            this.cLabelBase2.Text = "Stock Máximo";
            // 
            // TBoxStockMax
            // 
            this.TBoxStockMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxStockMax.ColorNegativos = System.Drawing.Color.Empty;
            this.TBoxStockMax.ColorPositivos = System.Drawing.Color.Empty;
            this.TBoxStockMax.Decimales = ((short)(0));
            this.TBoxStockMax.Location = new System.Drawing.Point(400, 217);
            this.TBoxStockMax.MarcarNegativos = false;
            this.TBoxStockMax.MarcarPositivos = false;
            this.TBoxStockMax.Name = "TBoxStockMax";
            this.TBoxStockMax.PonerValorDefecto = false;
            this.TBoxStockMax.Size = new System.Drawing.Size(100, 20);
            this.TBoxStockMax.TabIndex = 4;
            this.TBoxStockMax.Text = "0";
            this.TBoxStockMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxStockMax.ValorDefecto = 0;
            // 
            // BHerramientas
            // 
            this.BHerramientas.AutoSize = false;
            this.BHerramientas.color_final = System.Drawing.Color.Empty;
            this.BHerramientas.color_inicial = System.Drawing.Color.Empty;
            this.BHerramientas.Dock = System.Windows.Forms.DockStyle.Right;
            this.BHerramientas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBtnCancelar,
            this.TSBtnAceptar});
            this.BHerramientas.Location = new System.Drawing.Point(503, 0);
            this.BHerramientas.Name = "BHerramientas";
            this.BHerramientas.Size = new System.Drawing.Size(74, 245);
            this.BHerramientas.TabIndex = 6;
            this.BHerramientas.Text = "B";
            // 
            // TSBtnCancelar
            // 
            this.TSBtnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBtnCancelar.Image = global::LFVBRptTpvServer.Properties.Resources.delete2;
            this.TSBtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnCancelar.Name = "TSBtnCancelar";
            this.TSBtnCancelar.Size = new System.Drawing.Size(72, 67);
            this.TSBtnCancelar.Text = "Cancelar";
            this.TSBtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBtnCancelar.Click += new System.EventHandler(this.TSBtnCancelar_Click);
            // 
            // TSBtnAceptar
            // 
            this.TSBtnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBtnAceptar.Image = global::LFVBRptTpvServer.Properties.Resources.check2;
            this.TSBtnAceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBtnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnAceptar.Name = "TSBtnAceptar";
            this.TSBtnAceptar.Size = new System.Drawing.Size(72, 67);
            this.TSBtnAceptar.Text = "Aceptar";
            this.TSBtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBtnAceptar.Click += new System.EventHandler(this.TSBtnAceptar_Click);
            // 
            // DGFamilias
            // 
            this.DGFamilias.AllowUserToAddRows = false;
            this.DGFamilias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGFamilias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGFamilias.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGFamilias.ColorOrdenAscendente = System.Drawing.Color.Empty;
            this.DGFamilias.ColorOrdenDescendente = System.Drawing.Color.Empty;
            this.DGFamilias.ColumnasFijadasSalto = null;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGFamilias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFamilias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodFami,
            this.cNombreFami});
            this.DGFamilias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGFamilias.EnableHeadersVisualStyles = false;
            this.DGFamilias.FormularioPadreMdi = null;
            this.DGFamilias.Location = new System.Drawing.Point(15, 25);
            this.DGFamilias.MostrarMenuContextualDefecto = false;
            this.DGFamilias.Name = "DGFamilias";
            this.DGFamilias.OpcionesMenuContextualUsuario = null;
            this.DGFamilias.OrigenDatos = null;
            this.DGFamilias.PuedeUsuarioFiltrar = false;
            this.DGFamilias.ReadOnly = true;
            this.DGFamilias.RowHeadersWidth = 25;
            this.DGFamilias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGFamilias.Size = new System.Drawing.Size(485, 163);
            this.DGFamilias.TabIndex = 7;
            this.DGFamilias.TransaparenciaDialogosGris = ((short)(100));
            // 
            // cCodFami
            // 
            this.cCodFami.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cCodFami.DataPropertyName = "COD_FAMI";
            this.cCodFami.HeaderText = "Código";
            this.cCodFami.Name = "cCodFami";
            this.cCodFami.ReadOnly = true;
            this.cCodFami.Width = 65;
            // 
            // cNombreFami
            // 
            this.cNombreFami.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNombreFami.DataPropertyName = "NOMBRE_FAMI";
            this.cNombreFami.HeaderText = "Familia";
            this.cNombreFami.Name = "cNombreFami";
            this.cNombreFami.ReadOnly = true;
            // 
            // FrmFiltroStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 245);
            this.Controls.Add(this.DGFamilias);
            this.Controls.Add(this.BHerramientas);
            this.Controls.Add(this.cLabelBase2);
            this.Controls.Add(this.TBoxStockMax);
            this.Controls.Add(this.cLabelBase1);
            this.Controls.Add(this.TBoxStockMin);
            this.Controls.Add(this.LblFiltroFamilias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFiltroStock";
            this.Text = "Listado de Stocks";
            this.BHerramientas.ResumeLayout(false);
            this.BHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGFamilias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTCBASE.cLabelBase LblFiltroFamilias;
        private CTCBASE.cLabelBase cLabelBase1;
        private CTCBASE.cLabelBase cLabelBase2;
        private CTCBASE.cBarraHerramientas BHerramientas;
        private System.Windows.Forms.ToolStripButton TSBtnCancelar;
        private System.Windows.Forms.ToolStripButton TSBtnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodFami;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreFami;
        internal CTCBASE.cNumericBoxBase TBoxStockMin;
        internal CTCBASE.cNumericBoxBase TBoxStockMax;
        internal CTGRIDBASE.GRID.DataGridViewBase DGFamilias;
    }
}