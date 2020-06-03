namespace LFVBNewTPV.SISTEMA.MENSAJES
{
    partial class FrmAviso
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
            this.Icono = new System.Windows.Forms.PictureBox();
            this.BtnContinuar = new CTCBASE.cBoton();
            this.LblMensaje = new CTCBASE.cLabelBase();
            ((System.ComponentModel.ISupportInitialize)(this.Icono)).BeginInit();
            this.SuspendLayout();
            // 
            // Icono
            // 
            this.Icono.BackColor = System.Drawing.Color.Transparent;
            this.Icono.Image = global::LFVBNewTPV.Properties.Resources.message;
            this.Icono.Location = new System.Drawing.Point(12, 12);
            this.Icono.Name = "Icono";
            this.Icono.Size = new System.Drawing.Size(52, 50);
            this.Icono.TabIndex = 0;
            this.Icono.TabStop = false;
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.BackColor = System.Drawing.Color.Transparent;
            this.BtnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContinuar.Location = new System.Drawing.Point(251, 123);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(113, 65);
            this.BtnContinuar.TabIndex = 2;
            this.BtnContinuar.Text = "&Continuar";
            this.BtnContinuar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnContinuar.UseVisualStyleBackColor = true;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // LblMensaje
            // 
            this.LblMensaje.BackColor = System.Drawing.Color.White;
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.Location = new System.Drawing.Point(70, 12);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(519, 108);
            this.LblMensaje.TabIndex = 3;
            this.LblMensaje.Text = "cLabelBase1";
            this.LblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 200);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.BtnContinuar);
            this.Controls.Add(this.Icono);
            this.Name = "FrmAviso";
            this.Text = "Aviso";
            ((System.ComponentModel.ISupportInitialize)(this.Icono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Icono;
        private CTCBASE.cBoton BtnContinuar;
        private CTCBASE.cLabelBase LblMensaje;
    }
}