namespace LFVBNewTPV.TPV.FrmAuxiliares
{
    partial class FrmTipoDocumento
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
            this.CmbTiposDocumento = new CTCBASE.cComboBoxBase();
            this.BtnAceptar = new CTCBASE.cBoton();
            this.BtnCancelar = new CTCBASE.cBoton();
            this.SuspendLayout();
            // 
            // CmbTiposDocumento
            // 
            this.CmbTiposDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbTiposDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbTiposDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTiposDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbTiposDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTiposDocumento.FormattingEnabled = true;
            this.CmbTiposDocumento.Location = new System.Drawing.Point(12, 12);
            this.CmbTiposDocumento.Name = "CmbTiposDocumento";
            this.CmbTiposDocumento.Size = new System.Drawing.Size(366, 32);
            this.CmbTiposDocumento.TabIndex = 0;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAceptar.Location = new System.Drawing.Point(12, 50);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(118, 58);
            this.BtnAceptar.TabIndex = 1;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(260, 50);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(118, 58);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 120);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.CmbTiposDocumento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTipoDocumento";
            this.Text = "Tipo documento";
            this.ResumeLayout(false);

        }

        #endregion

        private CTCBASE.cComboBoxBase CmbTiposDocumento;
        private CTCBASE.cBoton BtnAceptar;
        private CTCBASE.cBoton BtnCancelar;
    }
}