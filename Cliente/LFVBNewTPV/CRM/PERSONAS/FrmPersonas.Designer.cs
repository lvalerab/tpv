namespace LFVBNewTPV.CRM.PERSONAS
{
    partial class FrmPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HerramientasListPersonas = new CTCBASE.cBarraHerramientas();
            this.BtnNuevaPersona = new System.Windows.Forms.ToolStripButton();
            this.BtnFichaPersona = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.BtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.BtnAceptar = new System.Windows.Forms.ToolStripButton();
            this.DGDatos = new CTGRIDBASE.GRID.DataGridViewBase();
            this.cIdElem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNifPers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombrePers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCodPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPoblacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLabelBase1 = new CTCBASE.cLabelBase();
            this.cLabelBase2 = new CTCBASE.cLabelBase();
            this.TBoxFiltroNif = new CTCBASE.cTextBoxBase();
            this.TBoxFiltroNombre = new CTCBASE.cTextBoxBase();
            this.HerramientasListPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // HerramientasListPersonas
            // 
            this.HerramientasListPersonas.AutoSize = false;
            this.HerramientasListPersonas.color_final = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HerramientasListPersonas.color_inicial = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HerramientasListPersonas.Dock = System.Windows.Forms.DockStyle.Right;
            this.HerramientasListPersonas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.HerramientasListPersonas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNuevaPersona,
            this.BtnFichaPersona,
            this.toolStripSeparator1,
            this.BtnRefrescar,
            this.BtnCancelar,
            this.BtnAceptar});
            this.HerramientasListPersonas.Location = new System.Drawing.Point(548, 0);
            this.HerramientasListPersonas.Name = "HerramientasListPersonas";
            this.HerramientasListPersonas.Size = new System.Drawing.Size(111, 470);
            this.HerramientasListPersonas.TabIndex = 0;
            // 
            // BtnNuevaPersona
            // 
            this.BtnNuevaPersona.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevaPersona.Image")));
            this.BtnNuevaPersona.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnNuevaPersona.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNuevaPersona.Name = "BtnNuevaPersona";
            this.BtnNuevaPersona.Size = new System.Drawing.Size(109, 67);
            this.BtnNuevaPersona.Text = "&Nueva Persona";
            this.BtnNuevaPersona.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNuevaPersona.Click += new System.EventHandler(this.BtnNuevaPersona_Click);
            // 
            // BtnFichaPersona
            // 
            this.BtnFichaPersona.Image = ((System.Drawing.Image)(resources.GetObject("BtnFichaPersona.Image")));
            this.BtnFichaPersona.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnFichaPersona.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFichaPersona.Name = "BtnFichaPersona";
            this.BtnFichaPersona.Size = new System.Drawing.Size(109, 67);
            this.BtnFichaPersona.Text = "&Ficha Persona";
            this.BtnFichaPersona.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnFichaPersona.Click += new System.EventHandler(this.BtnFichaPersona_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.Image = global::LFVBNewTPV.Properties.Resources.refresh;
            this.BtnRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(109, 67);
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
            this.BtnCancelar.Size = new System.Drawing.Size(109, 67);
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnAceptar.Image = global::LFVBNewTPV.Properties.Resources.check2;
            this.BtnAceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(109, 67);
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdElem,
            this.cNifPers,
            this.cNombrePers,
            this.cDire,
            this.cCodPostal,
            this.cPoblacion,
            this.cProvincia,
            this.cMail});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGDatos.EnableHeadersVisualStyles = false;
            this.DGDatos.FormularioPadreMdi = null;
            this.DGDatos.Location = new System.Drawing.Point(12, 71);
            this.DGDatos.MostrarMenuContextualDefecto = true;
            this.DGDatos.Name = "DGDatos";
            this.DGDatos.OpcionesMenuContextualUsuario = null;
            this.DGDatos.OrigenDatos = null;
            this.DGDatos.PuedeUsuarioFiltrar = true;
            this.DGDatos.ReadOnly = true;
            this.DGDatos.RowHeadersWidth = 15;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGDatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGDatos.RowTemplate.Height = 35;
            this.DGDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGDatos.Size = new System.Drawing.Size(533, 387);
            this.DGDatos.TabIndex = 1;
            this.DGDatos.TransaparenciaDialogosGris = ((short)(100));
            // 
            // cIdElem
            // 
            this.cIdElem.DataPropertyName = "ID_ELEM";
            this.cIdElem.HeaderText = "IdElem";
            this.cIdElem.Name = "cIdElem";
            this.cIdElem.ReadOnly = true;
            this.cIdElem.Visible = false;
            // 
            // cNifPers
            // 
            this.cNifPers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cNifPers.DataPropertyName = "NIF_PERS";
            this.cNifPers.HeaderText = "NIF";
            this.cNifPers.Name = "cNifPers";
            this.cNifPers.ReadOnly = true;
            this.cNifPers.Width = 65;
            // 
            // cNombrePers
            // 
            this.cNombrePers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNombrePers.DataPropertyName = "NOMBRE_PERS";
            this.cNombrePers.HeaderText = "Nombre";
            this.cNombrePers.Name = "cNombrePers";
            this.cNombrePers.ReadOnly = true;
            // 
            // cDire
            // 
            this.cDire.DataPropertyName = "DIRE_PERS";
            this.cDire.HeaderText = "Direccion";
            this.cDire.Name = "cDire";
            this.cDire.ReadOnly = true;
            this.cDire.Visible = false;
            // 
            // cCodPostal
            // 
            this.cCodPostal.DataPropertyName = "CODPOSTAL_PERS";
            this.cCodPostal.HeaderText = "Cod. Postal";
            this.cCodPostal.Name = "cCodPostal";
            this.cCodPostal.ReadOnly = true;
            this.cCodPostal.Visible = false;
            // 
            // cPoblacion
            // 
            this.cPoblacion.DataPropertyName = "POBLACION_PERS";
            this.cPoblacion.HeaderText = "Poblacion";
            this.cPoblacion.Name = "cPoblacion";
            this.cPoblacion.ReadOnly = true;
            this.cPoblacion.Visible = false;
            // 
            // cProvincia
            // 
            this.cProvincia.DataPropertyName = "PROVINCIA_PERS";
            this.cProvincia.HeaderText = "Provincia";
            this.cProvincia.Name = "cProvincia";
            this.cProvincia.ReadOnly = true;
            this.cProvincia.Visible = false;
            // 
            // cMail
            // 
            this.cMail.DataPropertyName = "EMAIL_PERS";
            this.cMail.HeaderText = "e-Mail";
            this.cMail.Name = "cMail";
            this.cMail.ReadOnly = true;
            this.cMail.Visible = false;
            // 
            // cLabelBase1
            // 
            this.cLabelBase1.AutoSize = true;
            this.cLabelBase1.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase1.Location = new System.Drawing.Point(12, 9);
            this.cLabelBase1.Name = "cLabelBase1";
            this.cLabelBase1.Size = new System.Drawing.Size(40, 24);
            this.cLabelBase1.TabIndex = 2;
            this.cLabelBase1.Text = "NIF";
            // 
            // cLabelBase2
            // 
            this.cLabelBase2.AutoSize = true;
            this.cLabelBase2.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase2.Location = new System.Drawing.Point(155, 9);
            this.cLabelBase2.Name = "cLabelBase2";
            this.cLabelBase2.Size = new System.Drawing.Size(93, 24);
            this.cLabelBase2.TabIndex = 3;
            this.cLabelBase2.Text = "NOMBRE";
            // 
            // TBoxFiltroNif
            // 
            this.TBoxFiltroNif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxFiltroNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxFiltroNif.Location = new System.Drawing.Point(16, 36);
            this.TBoxFiltroNif.Name = "TBoxFiltroNif";
            this.TBoxFiltroNif.Size = new System.Drawing.Size(136, 29);
            this.TBoxFiltroNif.TabIndex = 4;
            this.TBoxFiltroNif.TextChanged += new System.EventHandler(this.TBoxFiltroNif_TextChanged);
            // 
            // TBoxFiltroNombre
            // 
            this.TBoxFiltroNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxFiltroNombre.Location = new System.Drawing.Point(158, 36);
            this.TBoxFiltroNombre.Name = "TBoxFiltroNombre";
            this.TBoxFiltroNombre.Size = new System.Drawing.Size(387, 29);
            this.TBoxFiltroNombre.TabIndex = 5;
            this.TBoxFiltroNombre.TextChanged += new System.EventHandler(this.TBoxFiltroNif_TextChanged);
            // 
            // FrmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 470);
            this.Controls.Add(this.TBoxFiltroNombre);
            this.Controls.Add(this.TBoxFiltroNif);
            this.Controls.Add(this.cLabelBase2);
            this.Controls.Add(this.cLabelBase1);
            this.Controls.Add(this.DGDatos);
            this.Controls.Add(this.HerramientasListPersonas);
            this.Name = "FrmPersonas";
            this.Text = "Listado de personas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPersonas_FormClosing);
            this.HerramientasListPersonas.ResumeLayout(false);
            this.HerramientasListPersonas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTCBASE.cBarraHerramientas HerramientasListPersonas;
        private CTGRIDBASE.GRID.DataGridViewBase DGDatos;
        private CTCBASE.cLabelBase cLabelBase1;
        private CTCBASE.cLabelBase cLabelBase2;
        private CTCBASE.cTextBoxBase TBoxFiltroNif;
        private CTCBASE.cTextBoxBase TBoxFiltroNombre;
        private System.Windows.Forms.ToolStripButton BtnNuevaPersona;
        private System.Windows.Forms.ToolStripButton BtnFichaPersona;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnRefrescar;
        private System.Windows.Forms.ToolStripButton BtnCancelar;
        private System.Windows.Forms.ToolStripButton BtnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdElem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNifPers;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombrePers;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDire;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPoblacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMail;
    }
}