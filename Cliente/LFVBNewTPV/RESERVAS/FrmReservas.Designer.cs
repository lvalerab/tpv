namespace LFVBNewTPV.RESERVAS
{
    partial class FrmReservas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HerramientasListRes = new CTCBASE.cBarraHerramientas();
            this.BtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.BtnFicha = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.BtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.BtnAceptar = new System.Windows.Forms.ToolStripButton();
            this.DGDatos = new CTGRIDBASE.GRID.DataGridViewBase();
            this.cIdElem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombrePersCare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdElemCado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdElemPers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCodEsre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cFechaGrabacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumeroCado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFechaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBoxFiltroCliente = new CTCBASE.cTextBoxBase();
            this.CmbFiltroEstado = new CTCBASE.cComboBoxBase();
            this.cLabelBase1 = new CTCBASE.cLabelBase();
            this.cLabelBase2 = new CTCBASE.cLabelBase();
            this.HerramientasListRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // HerramientasListRes
            // 
            this.HerramientasListRes.AutoSize = false;
            this.HerramientasListRes.color_final = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HerramientasListRes.color_inicial = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HerramientasListRes.Dock = System.Windows.Forms.DockStyle.Right;
            this.HerramientasListRes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.HerramientasListRes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNuevo,
            this.BtnFicha,
            this.toolStripSeparator1,
            this.BtnRefrescar,
            this.BtnCancelar,
            this.BtnAceptar});
            this.HerramientasListRes.Location = new System.Drawing.Point(870, 0);
            this.HerramientasListRes.Name = "HerramientasListRes";
            this.HerramientasListRes.Size = new System.Drawing.Size(103, 478);
            this.HerramientasListRes.TabIndex = 0;
            this.HerramientasListRes.Text = "cBarraHerramientas1";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Image = global::LFVBNewTPV.Properties.Resources.document_dirty;
            this.BtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(101, 67);
            this.BtnNuevo.Text = "&Nueva Reserva";
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnFicha
            // 
            this.BtnFicha.Image = global::LFVBNewTPV.Properties.Resources.document_dirty;
            this.BtnFicha.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnFicha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFicha.Name = "BtnFicha";
            this.BtnFicha.Size = new System.Drawing.Size(101, 67);
            this.BtnFicha.Text = "&Ficha Reserva";
            this.BtnFicha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnFicha.Click += new System.EventHandler(this.BtnFicha_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(101, 6);
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.Image = global::LFVBNewTPV.Properties.Resources.refresh;
            this.BtnRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(101, 67);
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
            this.BtnCancelar.Size = new System.Drawing.Size(101, 67);
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
            this.BtnAceptar.Size = new System.Drawing.Size(101, 67);
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdElem,
            this.cNombrePersCare,
            this.cIdElemCado,
            this.cIdElemPers,
            this.cCodEsre,
            this.cFechaGrabacion,
            this.cNumeroCado,
            this.cFechaEstado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGDatos.EnableHeadersVisualStyles = false;
            this.DGDatos.FormularioPadreMdi = null;
            this.DGDatos.Location = new System.Drawing.Point(12, 78);
            this.DGDatos.MostrarMenuContextualDefecto = true;
            this.DGDatos.Name = "DGDatos";
            this.DGDatos.OpcionesMenuContextualUsuario = null;
            this.DGDatos.OrigenDatos = null;
            this.DGDatos.PuedeUsuarioFiltrar = true;
            this.DGDatos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGDatos.RowHeadersWidth = 15;
            this.DGDatos.RowTemplate.Height = 35;
            this.DGDatos.Size = new System.Drawing.Size(855, 388);
            this.DGDatos.TabIndex = 1;
            this.DGDatos.TransaparenciaDialogosGris = ((short)(100));
            // 
            // cIdElem
            // 
            this.cIdElem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cIdElem.DataPropertyName = "ID_ELEM";
            this.cIdElem.HeaderText = "ID";
            this.cIdElem.Name = "cIdElem";
            this.cIdElem.ReadOnly = true;
            this.cIdElem.Width = 51;
            // 
            // cNombrePersCare
            // 
            this.cNombrePersCare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNombrePersCare.DataPropertyName = "NOMBRE_PERS_CARE";
            this.cNombrePersCare.HeaderText = "Cliente";
            this.cNombrePersCare.Name = "cNombrePersCare";
            this.cNombrePersCare.ReadOnly = true;
            // 
            // cIdElemCado
            // 
            this.cIdElemCado.DataPropertyName = "ID_ELEM_CADO";
            this.cIdElemCado.HeaderText = "IdElemCado";
            this.cIdElemCado.Name = "cIdElemCado";
            this.cIdElemCado.ReadOnly = true;
            this.cIdElemCado.Visible = false;
            // 
            // cIdElemPers
            // 
            this.cIdElemPers.DataPropertyName = "ID_ELEM_PERS";
            this.cIdElemPers.HeaderText = "IdElemPers";
            this.cIdElemPers.Name = "cIdElemPers";
            this.cIdElemPers.ReadOnly = true;
            this.cIdElemPers.Visible = false;
            // 
            // cCodEsre
            // 
            this.cCodEsre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cCodEsre.DataPropertyName = "COD_ESRE";
            this.cCodEsre.HeaderText = "Estado";
            this.cCodEsre.Name = "cCodEsre";
            this.cCodEsre.ReadOnly = true;
            this.cCodEsre.Width = 66;
            // 
            // cFechaGrabacion
            // 
            this.cFechaGrabacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cFechaGrabacion.DataPropertyName = "FECHA_GRABACION_CARE";
            this.cFechaGrabacion.HeaderText = "Fecha Grabacion";
            this.cFechaGrabacion.Name = "cFechaGrabacion";
            this.cFechaGrabacion.ReadOnly = true;
            this.cFechaGrabacion.Width = 143;
            // 
            // cNumeroCado
            // 
            this.cNumeroCado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cNumeroCado.DataPropertyName = "NUMERO_CADO";
            this.cNumeroCado.HeaderText = "Nº Documento";
            this.cNumeroCado.Name = "cNumeroCado";
            this.cNumeroCado.ReadOnly = true;
            this.cNumeroCado.Width = 126;
            // 
            // cFechaEstado
            // 
            this.cFechaEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cFechaEstado.DataPropertyName = "FECHA_ESRE";
            this.cFechaEstado.HeaderText = "Fecha Último Estado";
            this.cFechaEstado.Name = "cFechaEstado";
            this.cFechaEstado.ReadOnly = true;
            this.cFechaEstado.Width = 167;
            // 
            // TBoxFiltroCliente
            // 
            this.TBoxFiltroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TBoxFiltroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxFiltroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TBoxFiltroCliente.Location = new System.Drawing.Point(12, 43);
            this.TBoxFiltroCliente.Name = "TBoxFiltroCliente";
            this.TBoxFiltroCliente.Size = new System.Drawing.Size(516, 29);
            this.TBoxFiltroCliente.TabIndex = 2;
            this.TBoxFiltroCliente.TextChanged += new System.EventHandler(this.TBoxFiltroCliente_TextChanged);
            // 
            // CmbFiltroEstado
            // 
            this.CmbFiltroEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbFiltroEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbFiltroEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltroEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbFiltroEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CmbFiltroEstado.FormattingEnabled = true;
            this.CmbFiltroEstado.Location = new System.Drawing.Point(534, 40);
            this.CmbFiltroEstado.Name = "CmbFiltroEstado";
            this.CmbFiltroEstado.Size = new System.Drawing.Size(333, 32);
            this.CmbFiltroEstado.TabIndex = 3;
            this.CmbFiltroEstado.SelectedValueChanged += new System.EventHandler(this.CmbFiltroEstado_SelectedValueChanged);
            // 
            // cLabelBase1
            // 
            this.cLabelBase1.AutoSize = true;
            this.cLabelBase1.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase1.Location = new System.Drawing.Point(12, 9);
            this.cLabelBase1.Name = "cLabelBase1";
            this.cLabelBase1.Size = new System.Drawing.Size(68, 24);
            this.cLabelBase1.TabIndex = 4;
            this.cLabelBase1.Text = "Cliente";
            // 
            // cLabelBase2
            // 
            this.cLabelBase2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cLabelBase2.AutoSize = true;
            this.cLabelBase2.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase2.Location = new System.Drawing.Point(531, 9);
            this.cLabelBase2.Name = "cLabelBase2";
            this.cLabelBase2.Size = new System.Drawing.Size(163, 24);
            this.cLabelBase2.TabIndex = 5;
            this.cLabelBase2.Text = "Estado del pedido";
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 478);
            this.Controls.Add(this.cLabelBase2);
            this.Controls.Add(this.cLabelBase1);
            this.Controls.Add(this.CmbFiltroEstado);
            this.Controls.Add(this.TBoxFiltroCliente);
            this.Controls.Add(this.DGDatos);
            this.Controls.Add(this.HerramientasListRes);
            this.Name = "FrmReservas";
            this.Text = "Reservas";
            this.HerramientasListRes.ResumeLayout(false);
            this.HerramientasListRes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTCBASE.cBarraHerramientas HerramientasListRes;
        private System.Windows.Forms.ToolStripButton BtnNuevo;
        private System.Windows.Forms.ToolStripButton BtnFicha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnRefrescar;
        private System.Windows.Forms.ToolStripButton BtnCancelar;
        private System.Windows.Forms.ToolStripButton BtnAceptar;
        private CTGRIDBASE.GRID.DataGridViewBase DGDatos;
        private CTCBASE.cTextBoxBase TBoxFiltroCliente;
        private CTCBASE.cComboBoxBase CmbFiltroEstado;
        private CTCBASE.cLabelBase cLabelBase1;
        private CTCBASE.cLabelBase cLabelBase2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdElem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombrePersCare;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdElemCado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdElemPers;
        private System.Windows.Forms.DataGridViewComboBoxColumn cCodEsre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechaGrabacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumeroCado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechaEstado;
    }
}