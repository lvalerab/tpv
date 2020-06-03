using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LFVBNewTPV.SISTEMA.UTILES
{
    public partial class FrmCopiaSeguridad : Form
    {

        private string _DirCopia;

        public FrmCopiaSeguridad()
        {
            InitializeComponent();
        }

        private void cBoton1_Click(object sender, EventArgs e)
        {
            this.FrmBusqDirectorio.ShowDialog();            
            this.TBoxRutaDestino.Text = this.FrmBusqDirectorio.SelectedPath;
        }

        private void cBoton2_Click(object sender, EventArgs e)
        {
            try
            {
                this._DirCopia = this.TBoxRutaDestino.Text;
                if (!System.IO.Directory.Exists(this.TBoxRutaDestino.Text))
                {
                    System.IO.Directory.CreateDirectory(this.TBoxRutaDestino.Text);
                }
                string mysqlruta = this.TBoxRutaDestino.Text + @"\CPBBDD";
                if (!System.IO.Directory.Exists(mysqlruta))
                {
                    System.IO.Directory.CreateDirectory(mysqlruta);
                }
                string imagruta = this.TBoxRutaDestino.Text + @"\IMAG";
                if (!System.IO.Directory.Exists(imagruta))
                {
                    System.IO.Directory.CreateDirectory(imagruta);
                }
                ClsUtils.MYSQL.mysqldump dump = ClsUtils.MYSQL.mysqldump.ObtenInstancia();
                string errtxt = "";
                dump.ObtenBBDD(mysqlruta + @"\" + DateTime.Now.ToString("yyyyMMdd_Hmmss") + ".sql");
                foreach (String f in System.IO.Directory.GetFiles(ClsUtils.IGlobal.RutaImagenes))
                {
                    string[] p = f.Split(new char[] { '\\', '/' });
                    System.IO.File.Copy(f, imagruta + @"\" + p[p.Length - 1], true);
                }
                MessageBox.Show("Copia de seguridad terminada en " + this.TBoxRutaDestino.Text);
            }
            catch (Exception err)
            {
                SISTEMA.MENSAJES.FrmError FErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);
                FErr.Show();
            }
        }

        private void cBoton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}