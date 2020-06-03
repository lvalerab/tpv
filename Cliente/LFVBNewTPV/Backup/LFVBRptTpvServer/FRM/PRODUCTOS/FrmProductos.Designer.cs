namespace LFVBRptTpvServer.FRM.PRODUCTOS
{
    partial class FrmProductos
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
            this.BHBotonera = new CTCBASE.cBarraHerramientas();
            this.CRViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.TSStocks = new System.Windows.Forms.ToolStripButton();
            this.TSPrecios = new System.Windows.Forms.ToolStripButton();
            this.BHBotonera.SuspendLayout();
            this.SuspendLayout();
            // 
            // BHBotonera
            // 
            this.BHBotonera.AutoSize = false;
            this.BHBotonera.color_final = System.Drawing.Color.Empty;
            this.BHBotonera.color_inicial = System.Drawing.Color.Empty;
            this.BHBotonera.Dock = System.Windows.Forms.DockStyle.Right;
            this.BHBotonera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BHBotonera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSStocks,
            this.TSPrecios});
            this.BHBotonera.Location = new System.Drawing.Point(840, 0);
            this.BHBotonera.Name = "BHBotonera";
            this.BHBotonera.Size = new System.Drawing.Size(93, 447);
            this.BHBotonera.TabIndex = 0;
            this.BHBotonera.Text = "cBarraHerramientas1";
            // 
            // CRViewer
            // 
            this.CRViewer.ActiveViewIndex = -1;
            this.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRViewer.Location = new System.Drawing.Point(0, 0);
            this.CRViewer.Name = "CRViewer";
            this.CRViewer.SelectionFormula = "";
            this.CRViewer.Size = new System.Drawing.Size(840, 447);
            this.CRViewer.TabIndex = 1;
            this.CRViewer.ViewTimeSelectionFormula = "";
            // 
            // TSStocks
            // 
            this.TSStocks.Image = global::LFVBRptTpvServer.Properties.Resources.box;
            this.TSStocks.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSStocks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSStocks.Name = "TSStocks";
            this.TSStocks.Size = new System.Drawing.Size(91, 67);
            this.TSStocks.Text = "Stock";
            this.TSStocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSStocks.Click += new System.EventHandler(this.TSStocks_Click);
            // 
            // TSPrecios
            // 
            this.TSPrecios.Image = global::LFVBRptTpvServer.Properties.Resources.money2;
            this.TSPrecios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSPrecios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSPrecios.Name = "TSPrecios";
            this.TSPrecios.Size = new System.Drawing.Size(91, 67);
            this.TSPrecios.Text = "Precios";
            this.TSPrecios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSPrecios.Click += new System.EventHandler(this.TSPrecios_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 447);
            this.Controls.Add(this.CRViewer);
            this.Controls.Add(this.BHBotonera);
            this.Name = "FrmProductos";
            this.Text = "Reportes relacionados con el catálogo";
            this.BHBotonera.ResumeLayout(false);
            this.BHBotonera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CTCBASE.cBarraHerramientas BHBotonera;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRViewer;
        private System.Windows.Forms.ToolStripButton TSStocks;
        private System.Windows.Forms.ToolStripButton TSPrecios;
    }
}