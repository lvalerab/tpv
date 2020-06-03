namespace LFVBRptTpvServer.FRM
{
    partial class FrmConfiguracion
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
            this.bHerramientas = new CTCBASE.cBarraHerramientas();
            this.TSGuardar = new System.Windows.Forms.ToolStripButton();
            this.TControl = new System.Windows.Forms.TabControl();
            this.TPConexion = new System.Windows.Forms.TabPage();
            this.cLabelBase1 = new CTCBASE.cLabelBase();
            this.TboxCadConexion = new CTCBASE.cTextBoxBase();
            this.bHerramientas.SuspendLayout();
            this.TControl.SuspendLayout();
            this.TPConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // bHerramientas
            // 
            this.bHerramientas.AutoSize = false;
            this.bHerramientas.color_final = System.Drawing.Color.Empty;
            this.bHerramientas.color_inicial = System.Drawing.Color.Empty;
            this.bHerramientas.Dock = System.Windows.Forms.DockStyle.Right;
            this.bHerramientas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSGuardar});
            this.bHerramientas.Location = new System.Drawing.Point(639, 0);
            this.bHerramientas.Name = "bHerramientas";
            this.bHerramientas.Size = new System.Drawing.Size(92, 414);
            this.bHerramientas.TabIndex = 0;
            this.bHerramientas.Text = "bHerramientas";
            // 
            // TSGuardar
            // 
            this.TSGuardar.Image = global::LFVBRptTpvServer.Properties.Resources.disk_blue;
            this.TSGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSGuardar.Name = "TSGuardar";
            this.TSGuardar.Size = new System.Drawing.Size(90, 67);
            this.TSGuardar.Text = "Guardar";
            this.TSGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSGuardar.Click += new System.EventHandler(this.TSGuardar_Click);
            // 
            // TControl
            // 
            this.TControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TControl.Controls.Add(this.TPConexion);
            this.TControl.Location = new System.Drawing.Point(12, 12);
            this.TControl.Name = "TControl";
            this.TControl.SelectedIndex = 0;
            this.TControl.Size = new System.Drawing.Size(624, 390);
            this.TControl.TabIndex = 1;
            // 
            // TPConexion
            // 
            this.TPConexion.Controls.Add(this.TboxCadConexion);
            this.TPConexion.Controls.Add(this.cLabelBase1);
            this.TPConexion.Location = new System.Drawing.Point(4, 22);
            this.TPConexion.Name = "TPConexion";
            this.TPConexion.Padding = new System.Windows.Forms.Padding(3);
            this.TPConexion.Size = new System.Drawing.Size(616, 364);
            this.TPConexion.TabIndex = 1;
            this.TPConexion.Text = "Conexión BBDD";
            this.TPConexion.UseVisualStyleBackColor = true;
            // 
            // cLabelBase1
            // 
            this.cLabelBase1.AutoSize = true;
            this.cLabelBase1.BackColor = System.Drawing.Color.Transparent;
            this.cLabelBase1.Location = new System.Drawing.Point(3, 12);
            this.cLabelBase1.Name = "cLabelBase1";
            this.cLabelBase1.Size = new System.Drawing.Size(105, 13);
            this.cLabelBase1.TabIndex = 0;
            this.cLabelBase1.Text = "Cadena de conexión";
            // 
            // TboxCadConexion
            // 
            this.TboxCadConexion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TboxCadConexion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TboxCadConexion.Location = new System.Drawing.Point(6, 28);
            this.TboxCadConexion.Name = "TboxCadConexion";
            this.TboxCadConexion.Size = new System.Drawing.Size(604, 20);
            this.TboxCadConexion.TabIndex = 1;
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 414);
            this.Controls.Add(this.TControl);
            this.Controls.Add(this.bHerramientas);
            this.Name = "FrmConfiguracion";
            this.Text = "Configuración";
            this.bHerramientas.ResumeLayout(false);
            this.bHerramientas.PerformLayout();
            this.TControl.ResumeLayout(false);
            this.TPConexion.ResumeLayout(false);
            this.TPConexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CTCBASE.cBarraHerramientas bHerramientas;
        private System.Windows.Forms.ToolStripButton TSGuardar;
        private System.Windows.Forms.TabControl TControl;
        private System.Windows.Forms.TabPage TPConexion;
        private CTCBASE.cTextBoxBase TboxCadConexion;
        private CTCBASE.cLabelBase cLabelBase1;
    }
}