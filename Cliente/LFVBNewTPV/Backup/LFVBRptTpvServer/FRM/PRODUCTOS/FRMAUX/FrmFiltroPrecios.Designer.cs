namespace LFVBRptTpvServer.FRM.PRODUCTOS.FRMAUX
{
    partial class FrmFiltroPrecios
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
            this.LblFiltroFamilias = new CTCBASE.cLabelBase();
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
            this.BHerramientas.Size = new System.Drawing.Size(74, 196);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGFamilias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGFamilias.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGFamilias.ColorOrdenAscendente = System.Drawing.Color.Empty;
            this.DGFamilias.ColorOrdenDescendente = System.Drawing.Color.Empty;
            this.DGFamilias.ColumnasFijadasSalto = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGFamilias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.ClientSize = new System.Drawing.Size(577, 196);
            this.Controls.Add(this.DGFamilias);
            this.Controls.Add(this.BHerramientas);
            this.Controls.Add(this.LblFiltroFamilias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFiltroStock";
            this.Text = "Listado de Precios";
            this.BHerramientas.ResumeLayout(false);
            this.BHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGFamilias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTCBASE.cLabelBase LblFiltroFamilias;
        private CTCBASE.cBarraHerramientas BHerramientas;
        private System.Windows.Forms.ToolStripButton TSBtnCancelar;
        private System.Windows.Forms.ToolStripButton TSBtnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodFami;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreFami;
        internal CTGRIDBASE.GRID.DataGridViewBase DGFamilias;
    }
}