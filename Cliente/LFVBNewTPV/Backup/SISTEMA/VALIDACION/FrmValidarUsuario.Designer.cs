namespace LFVBNewTPV.SISTEMA.VALIDACION
{
    partial class FrmValidarUsuario
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
            this.cLabelBase1 = new CTCBASE.cLabelBase();
            this.cLabelBase2 = new CTCBASE.cLabelBase();
            this.TBoxUsuario = new CTCBASE.cTextBoxBase();
            this.TBoxPassword = new CTCBASE.cTextBoxBase();
            this.BtnValidar = new CTCBASE.cBoton();
            this.BtnCancelar = new CTCBASE.cBoton();
            this.BtnTeclado = new CTCBASE.cBoton();
            this.SuspendLayout();
            // 
            // cLabelBase1
            // 
            this.cLabelBase1.AutoSize = true;
            this.cLabelBase1.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase1.Location = new System.Drawing.Point(72, 7);
            this.cLabelBase1.Name = "cLabelBase1";
            this.cLabelBase1.Size = new System.Drawing.Size(92, 25);
            this.cLabelBase1.TabIndex = 0;
            this.cLabelBase1.Text = "Usuario:";
            // 
            // cLabelBase2
            // 
            this.cLabelBase2.AutoSize = true;
            this.cLabelBase2.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase2.Location = new System.Drawing.Point(72, 69);
            this.cLabelBase2.Name = "cLabelBase2";
            this.cLabelBase2.Size = new System.Drawing.Size(112, 25);
            this.cLabelBase2.TabIndex = 1;
            this.cLabelBase2.Text = "Password:";
            // 
            // TBoxUsuario
            // 
            this.TBoxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxUsuario.Location = new System.Drawing.Point(72, 35);
            this.TBoxUsuario.MaxLength = 255;
            this.TBoxUsuario.Name = "TBoxUsuario";
            this.TBoxUsuario.Size = new System.Drawing.Size(455, 31);
            this.TBoxUsuario.TabIndex = 2;
            this.TBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBoxPassword
            // 
            this.TBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxPassword.Location = new System.Drawing.Point(72, 97);
            this.TBoxPassword.MaxLength = 255;
            this.TBoxPassword.Name = "TBoxPassword";
            this.TBoxPassword.Size = new System.Drawing.Size(455, 31);
            this.TBoxPassword.TabIndex = 3;
            this.TBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBoxPassword.UseSystemPasswordChar = true;
            // 
            // BtnValidar
            // 
            this.BtnValidar.BackColor = System.Drawing.Color.Transparent;
            this.BtnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnValidar.Location = new System.Drawing.Point(12, 134);
            this.BtnValidar.Name = "BtnValidar";
            this.BtnValidar.Size = new System.Drawing.Size(166, 38);
            this.BtnValidar.TabIndex = 4;
            this.BtnValidar.Text = "Validar";
            this.BtnValidar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnValidar.UseVisualStyleBackColor = true;
            this.BtnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(361, 134);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(166, 38);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnTeclado
            // 
            this.BtnTeclado.BackColor = System.Drawing.Color.Transparent;
            this.BtnTeclado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTeclado.Image = global::LFVBNewTPV.Properties.Resources.keyboard;
            this.BtnTeclado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTeclado.Location = new System.Drawing.Point(12, 12);
            this.BtnTeclado.Name = "BtnTeclado";
            this.BtnTeclado.Size = new System.Drawing.Size(54, 116);
            this.BtnTeclado.TabIndex = 6;
            this.BtnTeclado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnTeclado.UseVisualStyleBackColor = true;
            this.BtnTeclado.Click += new System.EventHandler(this.BtnTeclado_Click);
            // 
            // FrmValidarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 184);
            this.Controls.Add(this.BtnTeclado);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnValidar);
            this.Controls.Add(this.TBoxPassword);
            this.Controls.Add(this.TBoxUsuario);
            this.Controls.Add(this.cLabelBase2);
            this.Controls.Add(this.cLabelBase1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmValidarUsuario";
            this.Text = "Validar usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTCBASE.cLabelBase cLabelBase1;
        private CTCBASE.cLabelBase cLabelBase2;
        private CTCBASE.cBoton BtnValidar;
        private CTCBASE.cBoton BtnCancelar;
        private CTCBASE.cBoton BtnTeclado;
        public CTCBASE.cTextBoxBase TBoxUsuario;
        public CTCBASE.cTextBoxBase TBoxPassword;
    }
}