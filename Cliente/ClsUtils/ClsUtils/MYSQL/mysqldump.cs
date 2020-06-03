using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace ClsUtils.MYSQL
{
    public class mysqldump
    {
        private string _ejecutable = "";
        private string _host;
        private string _usuario;
        private string _password;
        private string _database;

        private string _commands = "--opt";
        public string ejecutable
        {
            set
            {
                this._ejecutable = value;
            }
            get
            {
                return this._ejecutable;
            }
        }
        public string host
        {
            set
            {
                this._host = value;
            }
            get
            {
                return this._host;
            }
        }
        public string usuario
        {
            set
            {
                this._usuario = value;
            }
            get
            {
                return this._usuario;
            }
        }
        public string password
        {
            set
            {
                this._password = value;
            }
            get
            {
                return this._password;
            }
        }
        public string database
        {
            set
            {
                this._database = value;
            }
            get
            {
                return this._database;
            }
        }
        private static  mysqldump _instancia;

        private mysqldump()
        {

        }

        public static mysqldump ObtenInstancia()
        {
            if (mysqldump._instancia == null)
            {
                mysqldump._instancia = new mysqldump();
            }
            mysqldump._instancia.host = IGlobal.MySqlDumpHost;
            mysqldump._instancia.database = IGlobal.MySqlDumpDataBase;
            mysqldump._instancia.usuario = IGlobal.MySqlDumpUser;
            mysqldump._instancia.password = IGlobal.MySqlDumpPass;
            mysqldump._instancia.ejecutable = IGlobal.MySqlDumpRuta;
            return mysqldump._instancia;
        }


        public void ObtenBBDD(string rutaFich)
        {
            string rutaBat = rutaFich.Replace(".sql", ".bat");
            StreamWriter sw = new StreamWriter(rutaBat);
            sw.WriteLine(this._ejecutable+" "+this._commands + " --host="+IGlobal.MySqlDumpHost+" --user=" + this._usuario + (this._password!=""?" --password=" + this._password:"")+ " " + this._database+" > "+rutaFich);
            sw.Close();
            Process my = new Process();            
            my.StartInfo.FileName = rutaBat;            
            my.Start();
            my.WaitForExit();
        }
    }
}
