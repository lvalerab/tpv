namespace LFVBNewTPV.CRM.PERSONAS
{
    partial class FrmPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersona));
            this.HerramientasPersona = new CTCBASE.cBarraHerramientas();
            this.BtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.cLabelBase1 = new CTCBASE.cLabelBase();
            this.LblIdElemento = new CTCBASE.cLabelBase();
            this.cLabelBase2 = new CTCBASE.cLabelBase();
            this.TBoxNif = new CTCBASE.cTextBoxBase();
            this.cLabelBase3 = new CTCBASE.cLabelBase();
            this.TBoxNombre = new CTCBASE.cTextBoxBase();
            this.cLabelBase4 = new CTCBASE.cLabelBase();
            this.TBoxDireccion = new CTCBASE.cTextBoxBase();
            this.cLabelBase5 = new CTCBASE.cLabelBase();
            this.TBoxCodPostal = new CTCBASE.cNumericBoxBase();
            this.TBoxPoblacion = new CTCBASE.cTextBoxBase();
            this.cLabelBase6 = new CTCBASE.cLabelBase();
            this.TBoxProvincia = new CTCBASE.cTextBoxBase();
            this.cLabelBase7 = new CTCBASE.cLabelBase();
            this.TBoxEmail = new CTCBASE.cTextBoxBase();
            this.cLabelBase8 = new CTCBASE.cLabelBase();
            this.HerramientasPersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // HerramientasPersona
            // 
            this.HerramientasPersona.AutoSize = false;
            this.HerramientasPersona.color_final = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HerramientasPersona.color_inicial = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HerramientasPersona.Dock = System.Windows.Forms.DockStyle.Right;
            this.HerramientasPersona.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.HerramientasPersona.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGuardar,
            this.toolStripSeparator1,
            this.BtnCerrar});
            this.HerramientasPersona.Location = new System.Drawing.Point(728, 0);
            this.HerramientasPersona.Name = "HerramientasPersona";
            this.HerramientasPersona.Size = new System.Drawing.Size(111, 459);
            this.HerramientasPersona.TabIndex = 0;
            this.HerramientasPersona.Text = "cBarraHerramientas1";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(109, 67);
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrar.Image = global::LFVBNewTPV.Properties.Resources.error;
            this.BtnCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(109, 67);
            this.BtnCerrar.Text = "&Salir";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
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
            // LblIdElemento
            // 
            this.LblIdElemento.AutoSize = true;
            this.LblIdElemento.BackColor = System.Drawing.Color.Transparent;
            this.LblIdElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdElemento.Location = new System.Drawing.Point(12, 36);
            this.LblIdElemento.Name = "LblIdElemento";
            this.LblIdElemento.Size = new System.Drawing.Size(174, 24);
            this.LblIdElemento.TabIndex = 2;
            this.LblIdElemento.Text = "Identificador Interno";
            // 
            // cLabelBase2
            // 
            this.cLabelBase2.AutoSize = true;
            this.cLabelBase2.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase2.Location = new System.Drawing.Point(216, 9);
            this.cLabelBase2.Name = "cLabelBase2";
            this.cLabelBase2.Size = new System.Drawing.Size(55, 24);
            this.cLabelBase2.TabIndex = 3;
            this.cLabelBase2.Text = "N.I.F:";
            // 
            // TBoxNif
            // 
            this.TBoxNif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxNif.Location = new System.Drawing.Point(220, 34);
            this.TBoxNif.MaxLength = 15;
            this.TBoxNif.Name = "TBoxNif";
            this.TBoxNif.Size = new System.Drawing.Size(182, 29);
            this.TBoxNif.TabIndex = 4;
            // 
            // cLabelBase3
            // 
            this.cLabelBase3.AutoSize = true;
            this.cLabelBase3.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase3.Location = new System.Drawing.Point(12, 93);
            this.cLabelBase3.Name = "cLabelBase3";
            this.cLabelBase3.Size = new System.Drawing.Size(84, 24);
            this.cLabelBase3.TabIndex = 5;
            this.cLabelBase3.Text = "Nombre:";
            // 
            // TBoxNombre
            // 
            this.TBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxNombre.Location = new System.Drawing.Point(16, 120);
            this.TBoxNombre.MaxLength = 255;
            this.TBoxNombre.Name = "TBoxNombre";
            this.TBoxNombre.Size = new System.Drawing.Size(699, 29);
            this.TBoxNombre.TabIndex = 6;
            // 
            // cLabelBase4
            // 
            this.cLabelBase4.AutoSize = true;
            this.cLabelBase4.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase4.Location = new System.Drawing.Point(12, 174);
            this.cLabelBase4.Name = "cLabelBase4";
            this.cLabelBase4.Size = new System.Drawing.Size(95, 24);
            this.cLabelBase4.TabIndex = 7;
            this.cLabelBase4.Text = "Dirección:";
            // 
            // TBoxDireccion
            // 
            this.TBoxDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxDireccion.Location = new System.Drawing.Point(13, 201);
            this.TBoxDireccion.MaxLength = 255;
            this.TBoxDireccion.Name = "TBoxDireccion";
            this.TBoxDireccion.Size = new System.Drawing.Size(702, 29);
            this.TBoxDireccion.TabIndex = 8;
            // 
            // cLabelBase5
            // 
            this.cLabelBase5.AutoSize = true;
            this.cLabelBase5.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase5.Location = new System.Drawing.Point(9, 233);
            this.cLabelBase5.Name = "cLabelBase5";
            this.cLabelBase5.Size = new System.Drawing.Size(110, 24);
            this.cLabelBase5.TabIndex = 9;
            this.cLabelBase5.Text = "Cod. Postal:";
            // 
            // TBoxCodPostal
            // 
            this.TBoxCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxCodPostal.ColorNegativos = System.Drawing.Color.Empty;
            this.TBoxCodPostal.ColorPositivos = System.Drawing.Color.Empty;
            this.TBoxCodPostal.Decimales = ((short)(0));
            this.TBoxCodPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxCodPostal.Location = new System.Drawing.Point(12, 260);
            this.TBoxCodPostal.MarcarNegativos = false;
            this.TBoxCodPostal.MarcarPositivos = false;
            this.TBoxCodPostal.MaxLength = 5;
            this.TBoxCodPostal.Name = "TBoxCodPostal";
            this.TBoxCodPostal.PonerValorDefecto = false;
            this.TBoxCodPostal.Size = new System.Drawing.Size(95, 29);
            this.TBoxCodPostal.TabIndex = 10;
            this.TBoxCodPostal.Text = "0";
            this.TBoxCodPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxCodPostal.ValorDefecto = 0;
            // 
            // TBoxPoblacion
            // 
            this.TBoxPoblacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxPoblacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxPoblacion.Location = new System.Drawing.Point(139, 260);
            this.TBoxPoblacion.MaxLength = 255;
            this.TBoxPoblacion.Name = "TBoxPoblacion";
            this.TBoxPoblacion.Size = new System.Drawing.Size(251, 29);
            this.TBoxPoblacion.TabIndex = 12;
            // 
            // cLabelBase6
            // 
            this.cLabelBase6.AutoSize = true;
            this.cLabelBase6.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase6.Location = new System.Drawing.Point(135, 233);
            this.cLabelBase6.Name = "cLabelBase6";
            this.cLabelBase6.Size = new System.Drawing.Size(99, 24);
            this.cLabelBase6.TabIndex = 11;
            this.cLabelBase6.Text = "Población:";
            // 
            // TBoxProvincia
            // 
            this.TBoxProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TBoxProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxProvincia.Location = new System.Drawing.Point(396, 260);
            this.TBoxProvincia.MaxLength = 255;
            this.TBoxProvincia.Name = "TBoxProvincia";
            this.TBoxProvincia.Size = new System.Drawing.Size(319, 29);
            this.TBoxProvincia.TabIndex = 14;
            // 
            // cLabelBase7
            // 
            this.cLabelBase7.AutoSize = true;
            this.cLabelBase7.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase7.Location = new System.Drawing.Point(395, 233);
            this.cLabelBase7.Name = "cLabelBase7";
            this.cLabelBase7.Size = new System.Drawing.Size(92, 24);
            this.cLabelBase7.TabIndex = 13;
            this.cLabelBase7.Text = "Provincia:";
            // 
            // TBoxEmail
            // 
            this.TBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxEmail.Location = new System.Drawing.Point(12, 327);
            this.TBoxEmail.MaxLength = 255;
            this.TBoxEmail.Name = "TBoxEmail";
            this.TBoxEmail.Size = new System.Drawing.Size(703, 29);
            this.TBoxEmail.TabIndex = 16;
            // 
            // cLabelBase8
            // 
            this.cLabelBase8.AutoSize = true;
            this.cLabelBase8.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase8.Location = new System.Drawing.Point(8, 300);
            this.cLabelBase8.Name = "cLabelBase8";
            this.cLabelBase8.Size = new System.Drawing.Size(68, 24);
            this.cLabelBase8.TabIndex = 15;
            this.cLabelBase8.Text = "E-Mail:";
            // 
            // FrmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 459);
            this.Controls.Add(this.TBoxEmail);
            this.Controls.Add(this.cLabelBase8);
            this.Controls.Add(this.TBoxProvincia);
            this.Controls.Add(this.cLabelBase7);
            this.Controls.Add(this.TBoxPoblacion);
            this.Controls.Add(this.cLabelBase6);
            this.Controls.Add(this.TBoxCodPostal);
            this.Controls.Add(this.cLabelBase5);
            this.Controls.Add(this.TBoxDireccion);
            this.Controls.Add(this.cLabelBase4);
            this.Controls.Add(this.TBoxNombre);
            this.Controls.Add(this.cLabelBase3);
            this.Controls.Add(this.TBoxNif);
            this.Controls.Add(this.cLabelBase2);
            this.Controls.Add(this.LblIdElemento);
            this.Controls.Add(this.cLabelBase1);
            this.Controls.Add(this.HerramientasPersona);
            this.Name = "FrmPersona";
            this.Text = "Ficha de la persona";
            this.HerramientasPersona.ResumeLayout(false);
            this.HerramientasPersona.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTCBASE.cBarraHerramientas HerramientasPersona;
        private System.Windows.Forms.ToolStripButton BtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private CTCBASE.cLabelBase cLabelBase1;
        private CTCBASE.cLabelBase LblIdElemento;
        private CTCBASE.cLabelBase cLabelBase2;
        private CTCBASE.cTextBoxBase TBoxNif;
        private CTCBASE.cLabelBase cLabelBase3;
        private CTCBASE.cTextBoxBase TBoxNombre;
        private CTCBASE.cLabelBase cLabelBase4;
        private CTCBASE.cTextBoxBase TBoxDireccion;
        private CTCBASE.cLabelBase cLabelBase5;
        private CTCBASE.cNumericBoxBase TBoxCodPostal;
        private CTCBASE.cTextBoxBase TBoxPoblacion;
        private CTCBASE.cLabelBase cLabelBase6;
        private CTCBASE.cTextBoxBase TBoxProvincia;
        private CTCBASE.cLabelBase cLabelBase7;
        private CTCBASE.cTextBoxBase TBoxEmail;
        private CTCBASE.cLabelBase cLabelBase8;
    }
}