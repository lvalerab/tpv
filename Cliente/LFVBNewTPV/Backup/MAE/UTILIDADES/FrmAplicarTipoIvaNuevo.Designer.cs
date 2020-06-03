namespace LFVBNewTPV.MAE.UTILIDADES
{
    partial class FrmAplicarTipoIvaNuevo
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
            this.BtnAplicar = new CTCBASE.cBoton();
            this.BtnCancelar = new CTCBASE.cBoton();
            this.cLabelBase1 = new CTCBASE.cLabelBase();
            this.CmbTipoOrigen = new CTCBASE.cComboBoxBase();
            this.cLabelBase2 = new CTCBASE.cLabelBase();
            this.CmbTipoDestino = new CTCBASE.cComboBoxBase();
            this.ChkAplicarPVP = new CTCBASE.cCheckBox();
            this.SuspendLayout();
            // 
            // BtnAplicar
            // 
            this.BtnAplicar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAplicar.Location = new System.Drawing.Point(267, 135);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(120, 35);
            this.BtnAplicar.TabIndex = 0;
            this.BtnAplicar.Text = "Aplicar";
            this.BtnAplicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAplicar.UseVisualStyleBackColor = true;
            this.BtnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(393, 135);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(124, 35);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // cLabelBase1
            // 
            this.cLabelBase1.AutoSize = true;
            this.cLabelBase1.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase1.Location = new System.Drawing.Point(12, 9);
            this.cLabelBase1.Name = "cLabelBase1";
            this.cLabelBase1.Size = new System.Drawing.Size(95, 13);
            this.cLabelBase1.TabIndex = 2;
            this.cLabelBase1.Text = "Tipo de Iva Origen";
            // 
            // CmbTipoOrigen
            // 
            this.CmbTipoOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbTipoOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbTipoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbTipoOrigen.FormattingEnabled = true;
            this.CmbTipoOrigen.Location = new System.Drawing.Point(15, 25);
            this.CmbTipoOrigen.Name = "CmbTipoOrigen";
            this.CmbTipoOrigen.Size = new System.Drawing.Size(502, 21);
            this.CmbTipoOrigen.TabIndex = 3;
            // 
            // cLabelBase2
            // 
            this.cLabelBase2.AutoSize = true;
            this.cLabelBase2.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase2.Location = new System.Drawing.Point(12, 49);
            this.cLabelBase2.Name = "cLabelBase2";
            this.cLabelBase2.Size = new System.Drawing.Size(100, 13);
            this.cLabelBase2.TabIndex = 4;
            this.cLabelBase2.Text = "Tipo de Iva Destino";
            // 
            // CmbTipoDestino
            // 
            this.CmbTipoDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbTipoDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbTipoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbTipoDestino.FormattingEnabled = true;
            this.CmbTipoDestino.Location = new System.Drawing.Point(15, 65);
            this.CmbTipoDestino.Name = "CmbTipoDestino";
            this.CmbTipoDestino.Size = new System.Drawing.Size(502, 21);
            this.CmbTipoDestino.TabIndex = 5;
            // 
            // ChkAplicarPVP
            // 
            this.ChkAplicarPVP.AutoSize = true;
            this.ChkAplicarPVP.BackColor = System.Drawing.Color.Transparent;
            this.ChkAplicarPVP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChkAplicarPVP.Location = new System.Drawing.Point(15, 104);
            this.ChkAplicarPVP.Name = "ChkAplicarPVP";
            this.ChkAplicarPVP.Size = new System.Drawing.Size(179, 17);
            this.ChkAplicarPVP.TabIndex = 6;
            this.ChkAplicarPVP.Text = "Aplicar el IVA y recalcular el PVP";
            this.ChkAplicarPVP.UseVisualStyleBackColor = true;
            // 
            // FrmAplicarTipoIvaNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 177);
            this.Controls.Add(this.ChkAplicarPVP);
            this.Controls.Add(this.CmbTipoDestino);
            this.Controls.Add(this.cLabelBase2);
            this.Controls.Add(this.CmbTipoOrigen);
            this.Controls.Add(this.cLabelBase1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAplicar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAplicarTipoIvaNuevo";
            this.Text = "Aplicar nuevo tipo de iva";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTCBASE.cBoton BtnAplicar;
        private CTCBASE.cBoton BtnCancelar;
        private CTCBASE.cLabelBase cLabelBase1;
        private CTCBASE.cComboBoxBase CmbTipoOrigen;
        private CTCBASE.cLabelBase cLabelBase2;
        private CTCBASE.cComboBoxBase CmbTipoDestino;
        private CTCBASE.cCheckBox ChkAplicarPVP;
    }
}