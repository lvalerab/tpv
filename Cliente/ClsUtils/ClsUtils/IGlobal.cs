using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

namespace ClsUtils
{
    public class IGlobal
    {
        private static string _ProgramaTeclado;

        public static string ProgramaTeclado
        {
            set
            {
                IGlobal._ProgramaTeclado = value;
            }
            get
            {
                return IGlobal._ProgramaTeclado;
            }
        }

        private static bool _UsarMetodoWin7;

        public static bool UsarMetodoWin7
        {
            set
            {
                IGlobal._UsarMetodoWin7 = value;
            }
            get
            {
                return IGlobal._UsarMetodoWin7;
            }
        }

        public static TECLADO.Teclado teclado
        {
            get
            {
                return TECLADO.Teclado.ObtenInstancia();
            }
        }

        private static string _MySqlDumpRuta;
        public static string MySqlDumpRuta
        {
            set
            {
                IGlobal._MySqlDumpRuta = value;
            }
            get
            {
                return IGlobal._MySqlDumpRuta;
            }
        }
        private static string _MySqlDumpHost;
        public static string MySqlDumpHost
        {
            set
            {
                IGlobal._MySqlDumpHost = value;
            }
            get
            {
                return IGlobal._MySqlDumpHost;
            }
        }
        private static string _MySqlDumpUser;
        public static string MySqlDumpUser
        {
            set
            {
                IGlobal._MySqlDumpUser = value;
            }
            get
            {
                return IGlobal._MySqlDumpUser;
            }
        }
        private static string _MySqlDumpPass;
        public static string MySqlDumpPass
        {
            set 
            {
                IGlobal._MySqlDumpPass = value;
            }
            get
            {
                return IGlobal._MySqlDumpPass;
            }
        }
        private static string _MySqlDumpDataBase;
        public static string MySqlDumpDataBase
        {
            set
            {
                IGlobal._MySqlDumpDataBase = value;
            }
            get
            {
                return IGlobal._MySqlDumpDataBase;
            }
        }
        public static void RellenaDatosMySqlDump(string CadConexion)
        {
            string[] elems = CadConexion.Split(new char[] { ';' });
            IGlobal.MySqlDumpHost = "";
            IGlobal.MySqlDumpDataBase = "";
            IGlobal.MySqlDumpUser = "";
            IGlobal.MySqlDumpPass = "";
            foreach (string e in elems)
            {
                string[] vars = e.Split(new char[] { '=' });
                switch(vars[0].ToUpper()) 
                {
                    case "SERVER":
                        IGlobal.MySqlDumpHost = vars[1];
                        break;
                    case "DATABASE":
                        IGlobal.MySqlDumpDataBase = vars[1];
                        break;
                    case "UID":
                    case "USER":
                        IGlobal.MySqlDumpUser = vars[1];
                        break;
                    case "PWD":
                    case "PASSWORD":
                        IGlobal.MySqlDumpPass = vars[1];
                        break;
                }
            }
        }
        private static string _RutaImagenes;
        public static string RutaImagenes
        {
            set
            {
                IGlobal._RutaImagenes = value;
            }
            get
            {
                return IGlobal._RutaImagenes;
            }
        }
    }
}
