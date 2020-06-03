namespace LFVBRptTpvServer.FRM.VENTAS.FRMAUX
{
    partial class FrmFiltroVentas
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
            this.ChkFiltroFechas = new CTCBASE.cCheckBox();
            this.bHerramientas = new CTCBASE.cBarraHerramientas();
            this.TPFechaDesde = new CTCBASE.cDateTimePicker();
            this.TPFechaHasta = new CTCBASE.cDateTimePicker();
            this.cLabelBase1 = new CTCBASE.cLabelBase();
            this.cLabelBase2 = new CTCBASE.cLabelBase();
            this.DGTiposDocus = new CTGRIDBASE.GRID.DataGridViewBase();
            this.cLabelBase3 = new CTCBASE.cLabelBase();
            this.cCodTido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescTido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSCancelar = new System.Windows.Forms.ToolStripButton();
            this.TSAceptar = new System.Windows.Forms.ToolStripButton();
            this.bHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGTiposDocus)).BeginInit();
            this.SuspendLayout();
            // 
            // ChkFiltroFechas
            // 
            this.ChkFiltroFechas.AutoSize = true;
            this.ChkFiltroFechas.BackColor = System.Drawing.Color.Transparent;
            this.ChkFiltroFechas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChkFiltroFechas.Location = new System.Drawing.Point(12, 121);
            this.ChkFiltroFechas.Name = "ChkFiltroFechas";
            this.ChkFiltroFechas.Size = new System.Drawing.Size(105, 17);
            this.ChkFiltroFechas.TabIndex = 0;
            this.ChkFiltroFechas.Text = "Filtrar por Fechas";
            this.ChkFiltroFechas.UseVisualStyleBackColor = true;
            // 
            // bHerramientas
            // 
            this.bHerramientas.AutoSize = false;
            this.bHerramientas.color_final = System.Drawing.Color.Empty;
            this.bHerramientas.color_inicial = System.Drawing.Color.Empty;
            this.bHerramientas.Dock = System.Windows.Forms.DockStyle.Right;
            this.bHerramientas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSCancelar,
            this.TSAceptar});
            this.bHerramientas.Location = new System.Drawing.Point(420, 0);
            this.bHerramientas.Name = "bHerramientas";
            this.bHerramientas.Size = new System.Drawing.Size(87, 194);
            this.bHerramientas.TabIndex = 1;
            this.bHerramientas.Text = "bHerramientas";
            // 
            // TPFechaDesde
            // 
            this.TPFechaDesde.Location = new System.Drawing.Point(12, 162);
            this.TPFechaDesde.Name = "TPFechaDesde";
            this.TPFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.TPFechaDesde.TabIndex = 2;
            // 
            // TPFechaHasta
            // 
            this.TPFechaHasta.Location = new System.Drawing.Point(218, 162);
            this.TPFechaHasta.Name = "TPFechaHasta";
            this.TPFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.TPFechaHasta.TabIndex = 3;
            // 
            // cLabelBase1
            // 
            this.cLabelBase1.AutoSize = true;
            this.cLabelBase1.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase1.Location = new System.Drawing.Point(12, 146);
            this.cLabelBase1.Name = "cLabelBase1";
            this.cLabelBase1.Size = new System.Drawing.Size(38, 13);
            this.cLabelBase1.TabIndex = 4;
            this.cLabelBase1.Text = "Desde";
            // 
            // cLabelBase2
            // 
            this.cLabelBase2.AutoSize = true;
            this.cLabelBase2.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase2.Location = new System.Drawing.Point(215, 146);
            this.cLabelBase2.Name = "cLabelBase2";
            this.cLabelBase2.Size = new System.Drawing.Size(35, 13);
            this.cLabelBase2.TabIndex = 5;
            this.cLabelBase2.Text = "Hasta";
            // 
            // DGTiposDocus
            // 
            this.DGTiposDocus.AllowUserToAddRows = false;
            this.DGTiposDocus.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGTiposDocus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGTiposDocus.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGTiposDocus.ColorOrdenAscendente = System.Drawing.Color.Empty;
            this.DGTiposDocus.ColorOrdenDescendente = System.Drawing.Color.Empty;
            this.DGTiposDocus.ColumnasFijadasSalto = null;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGTiposDocus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGTiposDocus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTiposDocus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodTido,
            this.cDescTido});
            this.DGTiposDocus.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGTiposDocus.EnableHeadersVisualStyles = false;
            this.DGTiposDocus.FormularioPadreMdi = null;
            this.DGTiposDocus.Location = new System.Drawing.Point(10, 26);
            this.DGTiposDocus.MostrarMenuContextualDefecto = false;
            this.DGTiposDocus.Name = "DGTiposDocus";
            this.DGTiposDocus.OpcionesMenuContextualUsuario = null;
            this.DGTiposDocus.OrigenDatos = null;
            this.DGTiposDocus.PuedeUsuarioFiltrar = false;
            this.DGTiposDocus.ReadOnly = true;
            this.DGTiposDocus.RowHeadersWidth = 25;
            this.DGTiposDocus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGTiposDocus.Size = new System.Drawing.Size(407, 91);
            this.DGTiposDocus.TabIndex = 6;
            this.DGTiposDocus.TransaparenciaDialogosGris = ((short)(100));
            // 
            // cLabelBase3
            // 
            this.cLabelBase3.AutoSize = true;
            this.cLabelBase3.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase3.Location = new System.Drawing.Point(9, 9);
            this.cLabelBase3.Name = "cLabelBase3";
            this.cLabelBase3.Size = new System.Drawing.Size(91, 13);
            this.cLabelBase3.TabIndex = 7;
            this.cLabelBase3.Text = "Tipo Documentos";
            // 
            // cCodTido
            // 
            this.cCodTido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cCodTido.DataPropertyName = "COD_TIDO";
            this.cCodTido.HeaderText = "Código";
            this.cCodTido.Name = "cCodTido";
            this.cCodTido.ReadOnly = true;
            this.cCodTido.Width = 65;
            // 
            // cDescTido
            // 
            this.cDescTido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cDescTido.DataPropertyName = "DESCR_TIDO";
            this.cDescTido.HeaderText = "Documento";
            this.cDescTido.Name = "cDescTido";
            this.cDescTido.ReadOnly = true;
            // 
            // TSCancelar
            // 
            this.TSCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSCancelar.Image = global::LFVBRptTpvServer.Properties.Resources.delete2;
            this.TSCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSCancelar.Name = "TSCancelar";
            this.TSCancelar.Size = new System.Drawing.Size(85, 67);
            this.TSCancelar.Text = "Cancelar";
            this.TSCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSCancelar.Click += new System.EventHandler(this.TSCancelar_Click);
            // 
            // TSAceptar
            // 
            this.TSAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSAceptar.Image = global::LFVBRptTpvServer.Properties.Resources.check2;
            this.TSAceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSAceptar.Name = "TSAceptar";
            this.TSAceptar.Size = new System.Drawing.Size(85, 67);
            this.TSAceptar.Text = "Aceptar";
            this.TSAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSAceptar.Click += new System.EventHandler(this.TSAceptar_Click);
            // 
            // FrmFiltroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 194);
            this.Controls.Add(this.cLabelBase3);
            this.Controls.Add(this.DGTiposDocus);
            this.Controls.Add(this.cLabelBase2);
            this.Controls.Add(this.cLabelBase1);
            this.Controls.Add(this.TPFechaHasta);
            this.Controls.Add(this.TPFechaDesde);
            this.Controls.Add(this.bHerramientas);
            this.Controls.Add(this.ChkFiltroFechas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFiltroVentas";
            this.Text = "Filtro";
            this.bHerramientas.ResumeLayout(false);
            this.bHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGTiposDocus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTCBASE.cBarraHerramientas bHerramientas;
        private CTCBASE.cLabelBase cLabelBase1;
        private CTCBASE.cLabelBase cLabelBase2;
        private CTCBASE.cLabelBase cLabelBase3;
        internal CTCBASE.cDateTimePicker TPFechaDesde;
        internal CTCBASE.cDateTimePicker TPFechaHasta;
        internal CTGRIDBASE.GRID.DataGridViewBase DGTiposDocus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodTido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescTido;
        private System.Windows.Forms.ToolStripButton TSCancelar;
        private System.Windows.Forms.ToolStripButton TSAceptar;
        internal CTCBASE.cCheckBox ChkFiltroFechas;
    }
}