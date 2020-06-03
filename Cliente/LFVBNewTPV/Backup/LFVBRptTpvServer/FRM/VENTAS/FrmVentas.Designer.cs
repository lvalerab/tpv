namespace LFVBRptTpvServer.FRM.VENTAS
{
    partial class FrmVentas
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
            this.CRViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.TSBtnLstVentas = new System.Windows.Forms.ToolStripButton();
            this.TSBtnLstIva = new System.Windows.Forms.ToolStripButton();
            this.bHerramientas.SuspendLayout();
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
            this.TSBtnLstVentas,
            this.TSBtnLstIva});
            this.bHerramientas.Location = new System.Drawing.Point(765, 0);
            this.bHerramientas.Name = "bHerramientas";
            this.bHerramientas.Size = new System.Drawing.Size(90, 463);
            this.bHerramientas.TabIndex = 0;
            this.bHerramientas.Text = "cBarraHerramientas1";
            // 
            // CRViewer
            // 
            this.CRViewer.ActiveViewIndex = -1;
            this.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRViewer.Location = new System.Drawing.Point(0, 0);
            this.CRViewer.Name = "CRViewer";
            this.CRViewer.SelectionFormula = "";
            this.CRViewer.Size = new System.Drawing.Size(765, 463);
            this.CRViewer.TabIndex = 1;
            this.CRViewer.ViewTimeSelectionFormula = "";
            // 
            // TSBtnLstVentas
            // 
            this.TSBtnLstVentas.Image = global::LFVBRptTpvServer.Properties.Resources.document_certificate;
            this.TSBtnLstVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBtnLstVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnLstVentas.Name = "TSBtnLstVentas";
            this.TSBtnLstVentas.Size = new System.Drawing.Size(88, 67);
            this.TSBtnLstVentas.Text = "Documentos";
            this.TSBtnLstVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBtnLstVentas.ToolTipText = "Documentos";
            this.TSBtnLstVentas.Click += new System.EventHandler(this.TSBtnLstVentas_Click);
            // 
            // TSBtnLstIva
            // 
            this.TSBtnLstIva.Image = global::LFVBRptTpvServer.Properties.Resources.money2;
            this.TSBtnLstIva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBtnLstIva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnLstIva.Name = "TSBtnLstIva";
            this.TSBtnLstIva.Size = new System.Drawing.Size(88, 67);
            this.TSBtnLstIva.Text = "I.V.A";
            this.TSBtnLstIva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBtnLstIva.Click += new System.EventHandler(this.TSBtnLstIva_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 463);
            this.Controls.Add(this.CRViewer);
            this.Controls.Add(this.bHerramientas);
            this.Name = "FrmVentas";
            this.Text = "Listado de ventas";
            this.bHerramientas.ResumeLayout(false);
            this.bHerramientas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CTCBASE.cBarraHerramientas bHerramientas;
        private System.Windows.Forms.ToolStripButton TSBtnLstVentas;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRViewer;
        private System.Windows.Forms.ToolStripButton TSBtnLstIva;
    }
}