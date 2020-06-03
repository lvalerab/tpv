namespace LFVBNewTPV.TPV.FrmAuxiliares
{
    partial class FrmCobrarDocu
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
            this.LblImporteTotal = new CTCBASE.cLabelBase();
            this.cLabelBase3 = new CTCBASE.cLabelBase();
            this.LblPagadoAnteriormente = new CTCBASE.cLabelBase();
            this.cLabelBase5 = new CTCBASE.cLabelBase();
            this.TBoxEntregado = new CTCBASE.cNumericBoxBase();
            this.cLabelBase6 = new CTCBASE.cLabelBase();
            this.LblDevolver = new CTCBASE.cLabelBase();
            this.BtnCobrar = new CTCBASE.cBoton();
            this.BtnCancelar = new CTCBASE.cBoton();
            this.cLabelBase2 = new CTCBASE.cLabelBase();
            this.LblTotalPendiente = new CTCBASE.cLabelBase();
            this.SuspendLayout();
            // 
            // cLabelBase1
            // 
            this.cLabelBase1.AutoSize = true;
            this.cLabelBase1.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase1.Location = new System.Drawing.Point(12, 25);
            this.cLabelBase1.Name = "cLabelBase1";
            this.cLabelBase1.Size = new System.Drawing.Size(116, 24);
            this.cLabelBase1.TabIndex = 0;
            this.cLabelBase1.Text = "Importe total:";
            // 
            // LblImporteTotal
            // 
            this.LblImporteTotal.BackColor = System.Drawing.Color.Transparent;
            this.LblImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImporteTotal.Location = new System.Drawing.Point(267, 25);
            this.LblImporteTotal.Name = "LblImporteTotal";
            this.LblImporteTotal.Size = new System.Drawing.Size(114, 25);
            this.LblImporteTotal.TabIndex = 1;
            this.LblImporteTotal.Text = "0.00 €";
            this.LblImporteTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabelBase3
            // 
            this.cLabelBase3.AutoSize = true;
            this.cLabelBase3.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase3.Location = new System.Drawing.Point(12, 50);
            this.cLabelBase3.Name = "cLabelBase3";
            this.cLabelBase3.Size = new System.Drawing.Size(204, 24);
            this.cLabelBase3.TabIndex = 2;
            this.cLabelBase3.Text = "Pagado Anteriormente:";
            // 
            // LblPagadoAnteriormente
            // 
            this.LblPagadoAnteriormente.BackColor = System.Drawing.Color.Transparent;
            this.LblPagadoAnteriormente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPagadoAnteriormente.Location = new System.Drawing.Point(271, 50);
            this.LblPagadoAnteriormente.Name = "LblPagadoAnteriormente";
            this.LblPagadoAnteriormente.Size = new System.Drawing.Size(110, 24);
            this.LblPagadoAnteriormente.TabIndex = 3;
            this.LblPagadoAnteriormente.Text = "0.00 €";
            this.LblPagadoAnteriormente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabelBase5
            // 
            this.cLabelBase5.AutoSize = true;
            this.cLabelBase5.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase5.Location = new System.Drawing.Point(13, 127);
            this.cLabelBase5.Name = "cLabelBase5";
            this.cLabelBase5.Size = new System.Drawing.Size(164, 24);
            this.cLabelBase5.TabIndex = 4;
            this.cLabelBase5.Text = "Dinero Entregado:";
            // 
            // TBoxEntregado
            // 
            this.TBoxEntregado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxEntregado.ColorNegativos = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TBoxEntregado.ColorPositivos = System.Drawing.Color.Green;
            this.TBoxEntregado.Decimales = ((short)(0));
            this.TBoxEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxEntregado.Location = new System.Drawing.Point(284, 125);
            this.TBoxEntregado.MarcarNegativos = true;
            this.TBoxEntregado.MarcarPositivos = true;
            this.TBoxEntregado.Name = "TBoxEntregado";
            this.TBoxEntregado.PonerValorDefecto = false;
            this.TBoxEntregado.Size = new System.Drawing.Size(97, 29);
            this.TBoxEntregado.TabIndex = 5;
            this.TBoxEntregado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxEntregado.ValorDefecto = 0;
            this.TBoxEntregado.TextChanged += new System.EventHandler(this.TBoxEntregado_TextChanged);
            // 
            // cLabelBase6
            // 
            this.cLabelBase6.AutoSize = true;
            this.cLabelBase6.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase6.Location = new System.Drawing.Point(12, 168);
            this.cLabelBase6.Name = "cLabelBase6";
            this.cLabelBase6.Size = new System.Drawing.Size(165, 24);
            this.cLabelBase6.TabIndex = 6;
            this.cLabelBase6.Text = "Dinero a Devolver:";
            // 
            // LblDevolver
            // 
            this.LblDevolver.BackColor = System.Drawing.Color.Transparent;
            this.LblDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDevolver.Location = new System.Drawing.Point(271, 168);
            this.LblDevolver.Name = "LblDevolver";
            this.LblDevolver.Size = new System.Drawing.Size(110, 24);
            this.LblDevolver.TabIndex = 7;
            this.LblDevolver.Text = "0.00 €";
            this.LblDevolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnCobrar
            // 
            this.BtnCobrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCobrar.Location = new System.Drawing.Point(16, 208);
            this.BtnCobrar.Name = "BtnCobrar";
            this.BtnCobrar.Size = new System.Drawing.Size(131, 74);
            this.BtnCobrar.TabIndex = 8;
            this.BtnCobrar.Text = "Cobrar";
            this.BtnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCobrar.UseVisualStyleBackColor = true;
            this.BtnCobrar.Click += new System.EventHandler(this.BtnCobrar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(250, 208);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(131, 74);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // cLabelBase2
            // 
            this.cLabelBase2.AutoSize = true;
            this.cLabelBase2.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelBase2.Location = new System.Drawing.Point(13, 77);
            this.cLabelBase2.Name = "cLabelBase2";
            this.cLabelBase2.Size = new System.Drawing.Size(169, 24);
            this.cLabelBase2.TabIndex = 10;
            this.cLabelBase2.Text = "Importe Pendiente:";
            // 
            // LblTotalPendiente
            // 
            this.LblTotalPendiente.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPendiente.Location = new System.Drawing.Point(271, 77);
            this.LblTotalPendiente.Name = "LblTotalPendiente";
            this.LblTotalPendiente.Size = new System.Drawing.Size(110, 24);
            this.LblTotalPendiente.TabIndex = 11;
            this.LblTotalPendiente.Text = "0.00 €";
            this.LblTotalPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmCobrarDocu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 294);
            this.Controls.Add(this.LblTotalPendiente);
            this.Controls.Add(this.cLabelBase2);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCobrar);
            this.Controls.Add(this.LblDevolver);
            this.Controls.Add(this.cLabelBase6);
            this.Controls.Add(this.TBoxEntregado);
            this.Controls.Add(this.cLabelBase5);
            this.Controls.Add(this.LblPagadoAnteriormente);
            this.Controls.Add(this.cLabelBase3);
            this.Controls.Add(this.LblImporteTotal);
            this.Controls.Add(this.cLabelBase1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCobrarDocu";
            this.Text = "Cobrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTCBASE.cLabelBase cLabelBase1;
        private CTCBASE.cLabelBase LblImporteTotal;
        private CTCBASE.cLabelBase cLabelBase3;
        private CTCBASE.cLabelBase LblPagadoAnteriormente;
        private CTCBASE.cLabelBase cLabelBase5;
        private CTCBASE.cNumericBoxBase TBoxEntregado;
        private CTCBASE.cLabelBase cLabelBase6;
        private CTCBASE.cLabelBase LblDevolver;
        private CTCBASE.cBoton BtnCobrar;
        private CTCBASE.cBoton BtnCancelar;
        private CTCBASE.cLabelBase cLabelBase2;
        private CTCBASE.cLabelBase LblTotalPendiente;
    }
}