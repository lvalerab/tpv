namespace CLSRPT.PRODUCTOS
{
    partial class FrmListadoProductos
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
            this.cBoton4 = new CTCBASE.cBoton();
            this.cBoton3 = new CTCBASE.cBoton();
            this.cBoton2 = new CTCBASE.cBoton();
            this.cBoton1 = new CTCBASE.cBoton();
            this.SuspendLayout();
            // 
            // cBoton4
            // 
            this.cBoton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoton4.BackColor = System.Drawing.Color.Transparent;
            this.cBoton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoton4.Image = global::CLSRPT.Properties.Resources.box_add;
            this.cBoton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBoton4.Location = new System.Drawing.Point(695, 64);
            this.cBoton4.Name = "cBoton4";
            this.cBoton4.Size = new System.Drawing.Size(106, 94);
            this.cBoton4.TabIndex = 3;
            this.cBoton4.Text = "Reservas";
            this.cBoton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cBoton4.UseVisualStyleBackColor = true;
            // 
            // cBoton3
            // 
            this.cBoton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoton3.BackColor = System.Drawing.Color.Transparent;
            this.cBoton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoton3.Image = global::CLSRPT.Properties.Resources.box_out;
            this.cBoton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBoton3.Location = new System.Drawing.Point(498, 64);
            this.cBoton3.Name = "cBoton3";
            this.cBoton3.Size = new System.Drawing.Size(106, 94);
            this.cBoton3.TabIndex = 2;
            this.cBoton3.Text = "Ventas";
            this.cBoton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cBoton3.UseVisualStyleBackColor = true;
            // 
            // cBoton2
            // 
            this.cBoton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoton2.BackColor = System.Drawing.Color.Transparent;
            this.cBoton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoton2.Image = global::CLSRPT.Properties.Resources.note_edit;
            this.cBoton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBoton2.Location = new System.Drawing.Point(310, 64);
            this.cBoton2.Name = "cBoton2";
            this.cBoton2.Size = new System.Drawing.Size(106, 94);
            this.cBoton2.TabIndex = 1;
            this.cBoton2.Text = "Catálogo";
            this.cBoton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cBoton2.UseVisualStyleBackColor = true;
            // 
            // cBoton1
            // 
            this.cBoton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoton1.BackColor = System.Drawing.Color.Transparent;
            this.cBoton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoton1.Image = global::CLSRPT.Properties.Resources.box_into;
            this.cBoton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBoton1.Location = new System.Drawing.Point(120, 64);
            this.cBoton1.Name = "cBoton1";
            this.cBoton1.Size = new System.Drawing.Size(106, 94);
            this.cBoton1.TabIndex = 0;
            this.cBoton1.Text = "Stocks";
            this.cBoton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cBoton1.UseVisualStyleBackColor = true;
            // 
            // FrmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 223);
            this.Controls.Add(this.cBoton4);
            this.Controls.Add(this.cBoton3);
            this.Controls.Add(this.cBoton2);
            this.Controls.Add(this.cBoton1);
            this.Name = "FrmListadoProductos";
            this.Text = "Listados de productos";
            this.ResumeLayout(false);

        }

        #endregion

        private CTCBASE.cBoton cBoton1;
        private CTCBASE.cBoton cBoton2;
        private CTCBASE.cBoton cBoton3;
        private CTCBASE.cBoton cBoton4;
    }
}