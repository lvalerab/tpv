using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ReplicacionTPVWeb.CLASES.LOGS
{
    public class FileLog
    {
        private string _cab_fich;
        public string cab_fichero
        {
            set
            {
                this._cab_fich = value;
            }
            get
            {
                return this._cab_fich;
            }
        }

        public string Fichero
        {
            get
            {
                string DirBase=IGlobal.RUTA_BASE_DAEMON+@"\LOGS";
                if (!Directory.Exists(DirBase))
                {
                    Directory.CreateDirectory(DirBase);
                }
                return DirBase + @"\" + cab_fichero + "_" + DateTime.Now.ToString("yyyyMMdd");
            }
        }

        public virtual void EscribeLinea(string texto)
        {
            lock (this)
            {
                StreamWriter SW = new StreamWriter(this.Fichero, true);
                SW.WriteLine(texto);
                SW.Close();
                SW.Dispose();
            }
        }
    }
}
