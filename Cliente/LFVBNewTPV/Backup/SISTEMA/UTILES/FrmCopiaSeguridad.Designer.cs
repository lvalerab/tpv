namespace LFVBNewTPV.SISTEMA.UTILES
{
    partial class FrmCopiaSeguridad
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
            this.TBoxRutaDestino = new CTCBASE.cTextBoxBase();
            this.cBoton1 = new CTCBASE.cBoton();
            this.cBoton2 = new CTCBASE.cBoton();
            this.cBoton3 = new CTCBASE.cBoton();
            this.FrmBusqDirectorio = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // cLabelBase1
            // 
            this.cLabelBase1.AutoSize = true;
            this.cLabelBase1.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase1.Location = new System.Drawing.Point(12, 9);
            this.cLabelBase1.Name = "cLabelBase1";
            this.cLabelBase1.Size = new System.Drawing.Size(99, 13);
            this.cLabelBase1.TabIndex = 0;
            this.cLabelBase1.Text = "Ruta Destino Copia";
            // 
            // TBoxRutaDestino
            // 
            this.TBoxRutaDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxRutaDestino.Location = new System.Drawing.Point(15, 25);
            this.TBoxRutaDestino.Name = "TBoxRutaDestino";
            this.TBoxRutaDestino.Size = new System.Drawing.Size(361, 20);
            this.TBoxRutaDestino.TabIndex = 1;
            // 
            // cBoton1
            // 
            this.cBoton1.BackColor = System.Drawing.Color.Transparent;
            this.cBoton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBoton1.Location = new System.Drawing.Point(381, 22);
            this.cBoton1.Name = "cBoton1";
            this.cBoton1.Size = new System.Drawing.Size(27, 23);
            this.cBoton1.TabIndex = 2;
            this.cBoton1.Text = "...";
            this.cBoton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cBoton1.UseVisualStyleBackColor = true;
            this.cBoton1.Click += new System.EventHandler(this.cBoton1_Click);
            // 
            // cBoton2
            // 
            this.cBoton2.BackColor = System.Drawing.Color.Transparent;
            this.cBoton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBoton2.Location = new System.Drawing.Point(200, 51);
            this.cBoton2.Name = "cBoton2";
            this.cBoton2.Size = new System.Drawing.Size(101, 23);
            this.cBoton2.TabIndex = 3;
            this.cBoton2.Text = "Realizar Copia";
            this.cBoton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cBoton2.UseVisualStyleBackColor = true;
            this.cBoton2.Click += new System.EventHandler(this.cBoton2_Click);
            // 
            // cBoton3
            // 
            this.cBoton3.BackColor = System.Drawing.Color.Transparent;
            this.cBoton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBoton3.Location = new System.Drawing.Point(307, 51);
            this.cBoton3.Name = "cBoton3";
            this.cBoton3.Size = new System.Drawing.Size(101, 23);
            this.cBoton3.TabIndex = 4;
            this.cBoton3.Text = "Cancelar";
            this.cBoton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cBoton3.UseVisualStyleBackColor = true;
            this.cBoton3.Click += new System.EventHandler(this.cBoton3_Click);
            // 
            // FrmCopiaSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 81);
            this.Controls.Add(this.cBoton3);
            this.Controls.Add(this.cBoton2);
            this.Controls.Add(this.cBoton1);
            this.Controls.Add(this.TBoxRutaDestino);
            this.Controls.Add(this.cLabelBase1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCopiaSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copia de Seguridad";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTCBASE.cLabelBase cLabelBase1;
        private CTCBASE.cTextBoxBase TBoxRutaDestino;
        private CTCBASE.cBoton cBoton1;
        private CTCBASE.cBoton cBoton2;
        private CTCBASE.cBoton cBoton3;
        private System.Windows.Forms.FolderBrowserDialog FrmBusqDirectorio;
    }
}