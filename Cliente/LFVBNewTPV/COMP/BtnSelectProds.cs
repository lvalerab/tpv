using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LFVBNewTPV.COMP
{
    public delegate void SelectProducto(Control c);
    public partial class BtnSelectProds : UserControl
    {
        public event SelectProducto OnSelectProducto;

        public BtnSelectProds()
        {
            InitializeComponent();
            this.CargaBotonesFamilias();
        }

        private void CargaBotonesFamilias()
        {
            this.PFamilias.Controls.Clear();
            try
            {
                CLSBASE.CRM.PRODUCTOS.Familias Fami = CLSBASE.CRM.PRODUCTOS.Familias.ObtenInstancia();
                Int32 posy = 0;
                foreach (DataRow dr in Fami.Datos.Rows)
                {
                    CTCBASE.cBoton btnFami = new CTCBASE.cBoton();
                    btnFami.Name = "Btn" + dr["COD_FAMI"].ToString();
                    btnFami.Size = new Size(this.PFamilias.Width-20, 40);
                    btnFami.Top = posy;
                    posy += 50;
                    btnFami.Text = dr["NOMBRE_FAMI"].ToString();
                    btnFami.Tag = dr["COD_FAMI"].ToString();
                    btnFami.Click += new EventHandler(btnFami_Click);
                    this.PFamilias.Controls.Add(btnFami);
                }
            }
            catch (Exception err)
            {
            }
        }

        private void CargaSubFamilias(string codfami)
        {
            this.PSubFamilias.Controls.Clear();
            this.PProductos.Controls.Clear();
            try
            {
                CLSBASE.CRM.PRODUCTOS.Subfamilias sufa = CLSBASE.CRM.PRODUCTOS.Subfamilias.ObtenInstancia();
                Int32 posy = 0;
                foreach (DataRow dr in sufa.Datos.Select("cod_fami='" + codfami + "'"))
                {
                    CTCBASE.cBoton btnSufa = new CTCBASE.cBoton();
                    btnSufa.Name = "Btn" + dr["COD_FAMI"].ToString() + "_" + dr["COD_SUFA"].ToString();
                    btnSufa.Size = new Size(this.PSubFamilias.Width - 20, 40);
                    btnSufa.Top = posy;
                    posy += 50;
                    btnSufa.Text = dr["NOMBRE_SUFA"].ToString();
                    btnSufa.Tag = dr["COD_FAMI"].ToString() + "[@]" + dr["COD_SUFA"].ToString();
                    btnSufa.Click += new EventHandler(btnSufa_Click);
                    this.PSubFamilias.Controls.Add(btnSufa);
                }
            }
            catch (Exception err) { }
        }

        private Image getIconoProd(string fich)
        {
            try
            {
                if (fich != "" && File.Exists(global::LFVBNewTPV.Properties.Settings.Default.PROD_RUTA_IMAGENES + @"\" + fich))
                {
                    Image aux = Image.FromFile(global::LFVBNewTPV.Properties.Settings.Default.PROD_RUTA_IMAGENES + @"\" + fich);
                    return aux.GetThumbnailImage(50, 50, null, IntPtr.Zero);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception err)
            {
                return null;
            }
        }

        private void CargaProductos(string codfami, string codsufa)
        {
            this.PProductos.Controls.Clear();
            try
            {
                CLSBASE.CRM.PRODUCTOS.Productos prod = CLSBASE.CRM.PRODUCTOS.Productos.ObtenInstancia();
                Int32 posy = 0;
                Int32 posx = 0;
                foreach (DataRow dr in prod.Datos.Select("COD_FAMI='" + codfami + "' and COD_SUFA='" + codsufa + "'"))
                {
                    CTCBASE.cBoton btnProd = new CTCBASE.cBoton();
                    btnProd.Name = "Btn" + dr["ID_ELEM"].ToString();
                    btnProd.Size = new Size(100, 100);
                    btnProd.ImageAlign = ContentAlignment.MiddleCenter;
                    btnProd.Text = dr["NOMBRE_PROD"].ToString();
                    btnProd.Tag = dr["ID_ELEM"].ToString();
                    btnProd.Image = this.getIconoProd(dr["IMAGEN_PROD"].ToString());
                    btnProd.Left = posx;
                    btnProd.Top = posy;
                    posx+=110;
                    if (this.PProductos.Size.Width <= posx)
                    {
                        posx = 0;
                        posy += 110;
                    }
                    btnProd.Click += new EventHandler(btnProd_Click);
                    this.PProductos.Controls.Add(btnProd);
                }
            }
            catch (Exception err)
            {
            }
        }

        void btnProd_Click(object sender, EventArgs e)
        {
            if (this.OnSelectProducto != null)
            {
                this.OnSelectProducto((Control)sender);
            }
        }

        void btnSufa_Click(object sender, EventArgs e)
        {
            string[] part = ((Control)sender).Tag.ToString().Split(new string[] { "[@]" },StringSplitOptions.None);
            if (part.Length == 2)
            {
                this.CargaProductos(part[0], part[1]);
            }
        }

        void btnFami_Click(object sender, EventArgs e)
        {
            this.CargaSubFamilias(((Control)sender).Tag.ToString());
        }

        private void PFamilias_Resize(object sender, EventArgs e)
        {
            foreach (Control c in this.PFamilias.Controls)
            {
                if (c.GetType().Name == "cBoton")
                {
                    c.Width = this.PFamilias.Size.Width-20;
                }
            }
        }

        private void PSubFamilias_Resize(object sender, EventArgs e)
        {
            foreach (Control c in this.PSubFamilias.Controls)
            {
                if (c.GetType().Name == "cBoton")
                {
                    c.Width = this.PSubFamilias.Size.Width - 20;
                }
            }
        }

        private void PProductos_Resize(object sender, EventArgs e)
        {
            //Reubicamos los botones
            Int32 posx = 0;
            Int32 posy = 0;
            foreach (Control c in this.PProductos.Controls)
            {
                if (c.GetType().Name == "cBoton")
                {
                    if (this.PProductos.Left >= 300)
                    {
                        c.Top = posy;
                        c.Left = posx;
                        posx += 110;
                        if (this.PProductos.Left <= posx - 10)
                        {
                            posx = 0;
                            posy += 110;
                        }
                    }
                }
            }
        }
    }
}
