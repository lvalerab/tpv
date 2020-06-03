namespace LFVBNewTPV.COMP
{
    partial class BtnSelectProds
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PFamilias = new System.Windows.Forms.Panel();
            this.PSubFamilias = new System.Windows.Forms.Panel();
            this.PProductos = new System.Windows.Forms.Panel();
            this.TLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLayout
            // 
            this.TLayout.ColumnCount = 3;
            this.TLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TLayout.Controls.Add(this.PFamilias, 0, 0);
            this.TLayout.Controls.Add(this.PSubFamilias, 1, 0);
            this.TLayout.Controls.Add(this.PProductos, 2, 0);
            this.TLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLayout.Location = new System.Drawing.Point(0, 0);
            this.TLayout.Name = "TLayout";
            this.TLayout.RowCount = 1;
            this.TLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLayout.Size = new System.Drawing.Size(836, 320);
            this.TLayout.TabIndex = 0;
            // 
            // PFamilias
            // 
            this.PFamilias.AutoScroll = true;
            this.PFamilias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PFamilias.Location = new System.Drawing.Point(3, 3);
            this.PFamilias.Name = "PFamilias";
            this.PFamilias.Size = new System.Drawing.Size(161, 314);
            this.PFamilias.TabIndex = 0;
            this.PFamilias.Resize += new System.EventHandler(this.PFamilias_Resize);
            // 
            // PSubFamilias
            // 
            this.PSubFamilias.AutoScroll = true;
            this.PSubFamilias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PSubFamilias.Location = new System.Drawing.Point(170, 3);
            this.PSubFamilias.Name = "PSubFamilias";
            this.PSubFamilias.Size = new System.Drawing.Size(161, 314);
            this.PSubFamilias.TabIndex = 1;
            this.PSubFamilias.Resize += new System.EventHandler(this.PSubFamilias_Resize);
            // 
            // PProductos
            // 
            this.PProductos.AutoScroll = true;
            this.PProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PProductos.Location = new System.Drawing.Point(337, 3);
            this.PProductos.Name = "PProductos";
            this.PProductos.Size = new System.Drawing.Size(496, 314);
            this.PProductos.TabIndex = 2;
            this.PProductos.Resize += new System.EventHandler(this.PProductos_Resize);
            // 
            // BtnSelectProds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TLayout);
            this.Name = "BtnSelectProds";
            this.Size = new System.Drawing.Size(836, 320);
            this.TLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLayout;
        private System.Windows.Forms.Panel PFamilias;
        private System.Windows.Forms.Panel PSubFamilias;
        private System.Windows.Forms.Panel PProductos;
    }
}
