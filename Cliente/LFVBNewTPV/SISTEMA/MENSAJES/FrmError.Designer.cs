namespace LFVBNewTPV.SISTEMA.MENSAJES
{
    partial class FrmError
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
            this.IconoError = new System.Windows.Forms.PictureBox();
            this.BtnContinuar = new CTCBASE.cBoton();
            this.BtnCerrar = new CTCBASE.cBoton();
            this.TBoxDescripcion = new CTCBASE.cTextBoxBase();
            this.TBoxStackTrace = new CTCBASE.cTextBoxBase();
            this.cLabelBase1 = new CTCBASE.cLabelBase();
            this.LblStackTrace = new CTCBASE.cLabelBase();
            this.BtnConfiguracion = new CTCBASE.cBoton();
            ((System.ComponentModel.ISupportInitialize)(this.IconoError)).BeginInit();
            this.SuspendLayout();
            // 
            // IconoError
            // 
            this.IconoError.BackColor = System.Drawing.Color.Transparent;
            this.IconoError.Image = global::LFVBNewTPV.Properties.Resources.error;
            this.IconoError.Location = new System.Drawing.Point(12, 28);
            this.IconoError.Name = "IconoError";
            this.IconoError.Size = new System.Drawing.Size(47, 45);
            this.IconoError.TabIndex = 0;
            this.IconoError.TabStop = false;
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnContinuar.BackColor = System.Drawing.Color.Transparent;
            this.BtnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContinuar.Location = new System.Drawing.Point(12, 297);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(147, 84);
            this.BtnContinuar.TabIndex = 1;
            this.BtnContinuar.Text = "&Continuar";
            this.BtnContinuar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnContinuar.UseVisualStyleBackColor = true;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrar.Location = new System.Drawing.Point(478, 297);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(147, 84);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.Text = "Cerrar &Aplicación";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TBoxDescripcion
            // 
            this.TBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxDescripcion.Location = new System.Drawing.Point(71, 28);
            this.TBoxDescripcion.Multiline = true;
            this.TBoxDescripcion.Name = "TBoxDescripcion";
            this.TBoxDescripcion.Size = new System.Drawing.Size(554, 97);
            this.TBoxDescripcion.TabIndex = 3;
            // 
            // TBoxStackTrace
            // 
            this.TBoxStackTrace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxStackTrace.Location = new System.Drawing.Point(12, 144);
            this.TBoxStackTrace.Multiline = true;
            this.TBoxStackTrace.Name = "TBoxStackTrace";
            this.TBoxStackTrace.Size = new System.Drawing.Size(613, 148);
            this.TBoxStackTrace.TabIndex = 4;
            // 
            // cLabelBase1
            // 
            this.cLabelBase1.AutoSize = true;
            this.cLabelBase1.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase1.Location = new System.Drawing.Point(68, 12);
            this.cLabelBase1.Name = "cLabelBase1";
            this.cLabelBase1.Size = new System.Drawing.Size(104, 13);
            this.cLabelBase1.TabIndex = 5;
            this.cLabelBase1.Text = "Descripción del error";
            // 
            // LblStackTrace
            // 
            this.LblStackTrace.AutoSize = true;
            this.LblStackTrace.BackColor = System.Drawing.Color.Transparent;
            this.LblStackTrace.Location = new System.Drawing.Point(12, 128);
            this.LblStackTrace.Name = "LblStackTrace";
            this.LblStackTrace.Size = new System.Drawing.Size(62, 13);
            this.LblStackTrace.TabIndex = 6;
            this.LblStackTrace.Text = "Stack trace";
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.BtnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracion.Location = new System.Drawing.Point(165, 297);
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Size = new System.Drawing.Size(147, 84);
            this.BtnConfiguracion.TabIndex = 7;
            this.BtnConfiguracion.Text = "C&onfiguración";
            this.BtnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnConfiguracion.UseVisualStyleBackColor = true;
            this.BtnConfiguracion.Click += new System.EventHandler(this.BtnConfiguracion_Click);
            // 
            // FrmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 393);
            this.Controls.Add(this.BtnConfiguracion);
            this.Controls.Add(this.LblStackTrace);
            this.Controls.Add(this.cLabelBase1);
            this.Controls.Add(this.TBoxStackTrace);
            this.Controls.Add(this.TBoxDescripcion);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnContinuar);
            this.Controls.Add(this.IconoError);
            this.Name = "FrmError";
            this.Text = "Error del sistema";
            ((System.ComponentModel.ISupportInitialize)(this.IconoError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconoError;
        private CTCBASE.cBoton BtnContinuar;
        private CTCBASE.cBoton BtnCerrar;
        private CTCBASE.cTextBoxBase TBoxDescripcion;
        private CTCBASE.cTextBoxBase TBoxStackTrace;
        private CTCBASE.cLabelBase cLabelBase1;
        private CTCBASE.cLabelBase LblStackTrace;
        private CTCBASE.cBoton BtnConfiguracion;
    }
}