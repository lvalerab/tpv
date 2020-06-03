namespace LFVBRptTpvServer
{
    partial class FrmMain
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
            this.BtnSalir = new CTCBASE.cBoton();
            this.cBoton1 = new CTCBASE.cBoton();
            this.BtnReportesReservas = new CTCBASE.cBoton();
            this.BtnReportesFacturacion = new CTCBASE.cBoton();
            this.BtnReportesClientess = new CTCBASE.cBoton();
            this.BtnReportesProductos = new CTCBASE.cBoton();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.Image = global::LFVBRptTpvServer.Properties.Resources.delete2;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(414, 356);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(108, 90);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // cBoton1
            // 
            this.cBoton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoton1.BackColor = System.Drawing.Color.Transparent;
            this.cBoton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoton1.Image = global::LFVBRptTpvServer.Properties.Resources.gear;
            this.cBoton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBoton1.Location = new System.Drawing.Point(528, 356);
            this.cBoton1.Name = "cBoton1";
            this.cBoton1.Size = new System.Drawing.Size(108, 90);
            this.cBoton1.TabIndex = 4;
            this.cBoton1.Text = "Configuración";
            this.cBoton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cBoton1.UseVisualStyleBackColor = true;
            this.cBoton1.Click += new System.EventHandler(this.cBoton1_Click);
            // 
            // BtnReportesReservas
            // 
            this.BtnReportesReservas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnReportesReservas.BackColor = System.Drawing.Color.Transparent;
            this.BtnReportesReservas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReportesReservas.Image = global::LFVBRptTpvServer.Properties.Resources.document_attachment;
            this.BtnReportesReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportesReservas.Location = new System.Drawing.Point(524, 184);
            this.BtnReportesReservas.Name = "BtnReportesReservas";
            this.BtnReportesReservas.Size = new System.Drawing.Size(108, 90);
            this.BtnReportesReservas.TabIndex = 3;
            this.BtnReportesReservas.Text = "Reservas";
            this.BtnReportesReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnReportesReservas.UseVisualStyleBackColor = true;
            this.BtnReportesReservas.Visible = false;
            // 
            // BtnReportesFacturacion
            // 
            this.BtnReportesFacturacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnReportesFacturacion.BackColor = System.Drawing.Color.Transparent;
            this.BtnReportesFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReportesFacturacion.Image = global::LFVBRptTpvServer.Properties.Resources.document_certificate;
            this.BtnReportesFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportesFacturacion.Location = new System.Drawing.Point(355, 184);
            this.BtnReportesFacturacion.Name = "BtnReportesFacturacion";
            this.BtnReportesFacturacion.Size = new System.Drawing.Size(108, 90);
            this.BtnReportesFacturacion.TabIndex = 2;
            this.BtnReportesFacturacion.Text = "Facturación";
            this.BtnReportesFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnReportesFacturacion.UseVisualStyleBackColor = true;
            this.BtnReportesFacturacion.Click += new System.EventHandler(this.BtnReportesFacturacion_Click);
            // 
            // BtnReportesClientess
            // 
            this.BtnReportesClientess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnReportesClientess.BackColor = System.Drawing.Color.Transparent;
            this.BtnReportesClientess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReportesClientess.Image = global::LFVBRptTpvServer.Properties.Resources.users1;
            this.BtnReportesClientess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportesClientess.Location = new System.Drawing.Point(186, 184);
            this.BtnReportesClientess.Name = "BtnReportesClientess";
            this.BtnReportesClientess.Size = new System.Drawing.Size(108, 90);
            this.BtnReportesClientess.TabIndex = 1;
            this.BtnReportesClientess.Text = "Clientes";
            this.BtnReportesClientess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnReportesClientess.UseVisualStyleBackColor = true;
            this.BtnReportesClientess.Click += new System.EventHandler(this.BtnReportesClientess_Click);
            // 
            // BtnReportesProductos
            // 
            this.BtnReportesProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnReportesProductos.BackColor = System.Drawing.Color.Transparent;
            this.BtnReportesProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReportesProductos.Image = global::LFVBRptTpvServer.Properties.Resources.box_tall;
            this.BtnReportesProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportesProductos.Location = new System.Drawing.Point(17, 184);
            this.BtnReportesProductos.Name = "BtnReportesProductos";
            this.BtnReportesProductos.Size = new System.Drawing.Size(108, 90);
            this.BtnReportesProductos.TabIndex = 0;
            this.BtnReportesProductos.Text = "Productos";
            this.BtnReportesProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnReportesProductos.UseVisualStyleBackColor = true;
            this.BtnReportesProductos.Click += new System.EventHandler(this.BtnReportesProductos_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 458);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.cBoton1);
            this.Controls.Add(this.BtnReportesReservas);
            this.Controls.Add(this.BtnReportesFacturacion);
            this.Controls.Add(this.BtnReportesClientess);
            this.Controls.Add(this.BtnReportesProductos);
            this.Name = "FrmMain";
            this.Text = "Listados disponibles";
            this.ResumeLayout(false);

        }

        #endregion

        private CTCBASE.cBoton BtnReportesProductos;
        private CTCBASE.cBoton BtnReportesClientess;
        private CTCBASE.cBoton BtnReportesFacturacion;
        private CTCBASE.cBoton BtnReportesReservas;
        private CTCBASE.cBoton cBoton1;
        private CTCBASE.cBoton BtnSalir;
    }
}