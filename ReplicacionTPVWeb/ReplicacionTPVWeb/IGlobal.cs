using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Data;
using MySql.Data.MySqlClient;

namespace ReplicacionTPVWeb
{
    public class IGlobal
    {
        /// <summary>
        /// Constante que define donde se encuentra el fichero de configuración
        /// </summary>
        /// 
        private const string FICHERO_CONF = @"\ConfReplicacionTPVWeb.xml";

        public const string RUTA_BASE_DAEMON = @"\TPV2WEB";

        
        /// <summary>
        /// Cadena de conexion local (BBDD TPV)
        /// </summary>
        public static string CADENA_CONEX_TPV 
        {
            set
            {
                CLSBASE.IGlobal.cad_conexion = value;
            }
            get
            {
                return CLSBASE.IGlobal.cad_conexion;
            }
        }

        private static string _CADENA_CONEX_WEB;
        /// <summary>
        /// Cadena de conexion remota (BBDD WEB)
        /// </summary>
        public static string CADENA_CONEX_WEB
        {
            set
            {
                IGlobal._CADENA_CONEX_WEB = value;
            }
            get
            {
                return IGlobal._CADENA_CONEX_WEB;
            }
        }

        /// <summary>
        /// Ruta donde se encuentran las imagenes del TPV
        /// </summary>
        public static string RUTA_IMAGENES_TPV
        {
            set
            {
                CLSBASE.IGlobal.RUTA_IMAG_PROD = value;
            }
            get
            {
                return CLSBASE.IGlobal.RUTA_IMAG_PROD;
            }
        }

        private static Int32 _TIEMPO_ESPERA_BUCLE;
        /// <summary>
        /// Tiempo de lantencia entre bucles
        /// </summary>
        public static Object TIEMPO_ESPERA_BUCLE
        {
            set
            {
                Int32.TryParse(value.ToString(), out IGlobal._TIEMPO_ESPERA_BUCLE);
                if (IGlobal._TIEMPO_ESPERA_BUCLE == 0)
                {
                    IGlobal._TIEMPO_ESPERA_BUCLE = 3;
                }
            }
            get
            {
                return IGlobal._TIEMPO_ESPERA_BUCLE;
            }
        }

        private static String _URL_FTP;
        /// <summary>
        /// URL del servidor FTP
        /// </summary>
        public static String URL_FTP
        {
            set
            {
                IGlobal._URL_FTP=value;
            }
            get
            {
                return IGlobal._URL_FTP;
            }
        }

        private static String _USER_FTP;
        /// <summary>
        /// Usuario del servidor FTP
        /// </summary>
        public static String USER_FTP
        {
            set
            {
                IGlobal._USER_FTP = value;
            }
            get
            {
                return IGlobal._USER_FTP;
            }
        }

        private static String _PASS_FTP;
        /// <summary>
        /// Password del servidor FTP
        /// </summary>
        public static String PASS_FTP
        {
            set
            {
                IGlobal._PASS_FTP = value;
            }
            get
            {
                return IGlobal._PASS_FTP;
            }
        }

        private static String _RUTA_FTP;

        /// <summary>
        /// Ruta de almacenamiento del servidor FTP
        /// </summary>
        public static String RUTA_FTP
        {
            set
            {
                IGlobal._RUTA_FTP = value;
            }
            get
            {
                return IGlobal._RUTA_FTP;
            }
        }
       
        private static Int16 _NUM_INTENTOS_FTP;
        /// <summary>
        /// Nº de veces que se intentará subir una imagen
        /// </summary>
        public static Int16 NUM_INTENTOS_FTP
        {
            set
            {
                IGlobal._NUM_INTENTOS_FTP = (value<=0?(Int16)3:(Int16)value);
            }
            get
            {
                return IGlobal._NUM_INTENTOS_FTP;
            }
        }

        private static String _CONDICION_ALTA_RESERVAS;

        public static String CONDICION_ALTA_RESERVAS
        {
            set
            {
                IGlobal._CONDICION_ALTA_RESERVAS = value;
            }
            get
            {
                return IGlobal._CONDICION_ALTA_RESERVAS;
            }
        }

        private static Int32 _ResImgX;

        /// <summary>
        /// Resolución máxima de la imagen subida (horizontal)
        /// </summary>
        public static Int32 ResImgX
        {
            set
            {
                IGlobal._ResImgX = value;
            }
            get
            {
                return IGlobal._ResImgX;
            }
        }

        private static Int32 _ResImgY;

        /// <summary>
        /// Resolución máxima de la imagen subida (vertical)
        /// </summary>
        public static Int32 ResImgY
        {
            set
            {
                IGlobal._ResImgY = value;
            }
            get
            {
                return IGlobal._ResImgY;
            }
        }

        /// <summary>
        /// Carga la configuración almacenada en el fichero de configuración
        /// </summary>
        public static void ObtenConfiguracion()
        {
            if (!System.IO.Directory.Exists(IGlobal.RUTA_BASE_DAEMON))
            {
                System.IO.Directory.CreateDirectory(IGlobal.RUTA_BASE_DAEMON);
            }
            if (System.IO.File.Exists(IGlobal.RUTA_BASE_DAEMON+FICHERO_CONF))
            {
                string dummy="";
                XmlTextReader XTReader = new XmlTextReader(IGlobal.RUTA_BASE_DAEMON + FICHERO_CONF);
                XTReader.ReadStartElement("CONFIGURACION");
                    XTReader.ReadStartElement("TPV");
                        XTReader.ReadStartElement("CADENA_CONEX_TPV");
                            IGlobal.CADENA_CONEX_TPV = XTReader.ReadString();
                        XTReader.ReadEndElement();
                        XTReader.ReadStartElement("RUTA_IMG");
                            IGlobal.RUTA_IMAGENES_TPV = XTReader.ReadString();
                        XTReader.ReadEndElement();
                    XTReader.ReadEndElement();
                    XTReader.ReadStartElement("WEB");
                        XTReader.ReadStartElement("CADENA_CONEX_WEB");
                            IGlobal.CADENA_CONEX_WEB = XTReader.ReadString();
                        XTReader.ReadEndElement();
                        XTReader.ReadStartElement("FTP_URL");
                            IGlobal.URL_FTP = XTReader.ReadString();
                        XTReader.ReadEndElement();
                        XTReader.ReadStartElement("FTP_RUTA_IMAG");
                            IGlobal.RUTA_FTP = XTReader.ReadString();
                        XTReader.ReadEndElement();
                        XTReader.ReadStartElement("FTP_USER");
                            IGlobal.USER_FTP = XTReader.ReadString();
                        XTReader.ReadEndElement();
                        XTReader.ReadStartElement("FTP_PASS");
                            IGlobal.PASS_FTP = XTReader.ReadString();
                        XTReader.ReadEndElement();
                        XTReader.ReadStartElement("NUM_INTENTOS_FTP");
                            dummy = XTReader.ReadString();
                            Int16 dummyi16 = 0;
                            Int16.TryParse(dummy, out dummyi16);
                            IGlobal.NUM_INTENTOS_FTP=dummyi16;
                        XTReader.ReadEndElement();
                    XTReader.ReadEndElement();
                    XTReader.ReadStartElement("MAIL_LOG");
                        XTReader.ReadStartElement("SMTP_SERVER");
                            CLASES.LOGS.MailLog.SmtpUrl = XTReader.ReadString();
                        XTReader.ReadEndElement();
                        XTReader.ReadStartElement("DESTINATARIOS");
                            dummy = XTReader.ReadString();
                            CLASES.LOGS.MailLog.Destinatarios = new System.Net.Mail.MailAddressCollection();
                            foreach (string d in dummy.Split(new char[] { ';' }))
                            {
                                CLASES.LOGS.MailLog.Destinatarios.Add(d);
                            }
                        XTReader.ReadEndElement();
                    XTReader.ReadEndElement();
                    XTReader.ReadStartElement("HILO");
                        XTReader.ReadStartElement("TIEMPO_INACTIVIDAD");
                        IGlobal.TIEMPO_ESPERA_BUCLE = XTReader.ReadString();
                        XTReader.ReadEndElement();
                    XTReader.ReadEndElement();
                    XTReader.ReadStartElement("RESERVAS");
                        XTReader.ReadStartElement("CONDICION_ALTA");
                            IGlobal.CONDICION_ALTA_RESERVAS = XTReader.ReadString();
                        XTReader.ReadEndElement();
                    XTReader.ReadEndElement();
                    XTReader.ReadStartElement("IMAGENES");
                        XTReader.ReadStartElement("RESOLUCIONX");
                           dummy = XTReader.ReadString();
                           if (!short.TryParse(dummy, out dummyi16))
                           {
                               dummyi16 = 600;
                           }
                           IGlobal.ResImgX = dummyi16;
                        XTReader.ReadEndElement();
                        XTReader.ReadStartElement("RESOLUCIONY");
                            dummy = XTReader.ReadString();
                            if (!short.TryParse(dummy, out dummyi16))
                            {
                                dummyi16 = 800;
                            }
                            IGlobal.ResImgY = dummyi16;
                        XTReader.ReadEndElement();
                    XTReader.ReadEndElement();
                XTReader.Close();
            }
            else
            {
                XmlTextWriter XTWriter = new XmlTextWriter(IGlobal.RUTA_BASE_DAEMON +IGlobal.FICHERO_CONF, Encoding.UTF8);
                XTWriter.WriteStartDocument();
                XTWriter.WriteStartElement("CONFIGURACION");
                    XTWriter.WriteStartElement("TPV");
                        XTWriter.WriteStartElement("CADENA_CONEX_TPV");
                        XTWriter.WriteString("Server=127.0.0.1;Database=TPV;Uid=root;Pwd=;");
                        XTWriter.WriteEndElement();
                        XTWriter.WriteStartElement("RUTA_IMG");
                        XTWriter.WriteString(@"C:\TPV\");
                        XTWriter.WriteEndElement();
                    XTWriter.WriteEndElement();
                    XTWriter.WriteStartElement("WEB");
                        XTWriter.WriteStartElement("CADENA_CONEX_WEB");
                        XTWriter.WriteString("Server=127.0.0.1;Database=TPV_WEB;Uid=root;Pwd=;");
                        XTWriter.WriteEndElement();
                        XTWriter.WriteStartElement("FTP_URL");
                        XTWriter.WriteString("ftp://dominio.com");
                        XTWriter.WriteEndElement();
                        XTWriter.WriteStartElement("FTP_RUTA_IMAG");
                        XTWriter.WriteString("UPLOADS/IMAGENES/PRODUCTOS/");
                        XTWriter.WriteEndElement();
                        XTWriter.WriteStartElement("FTP_USER");
                        XTWriter.WriteString("usuario@dominio.com");
                        XTWriter.WriteEndElement();
                        XTWriter.WriteStartElement("FTP_PASS");
                        XTWriter.WriteString("PASS");
                        XTWriter.WriteEndElement();
                        XTWriter.WriteStartElement("NUM_INTENTOS_FTP");
                        XTWriter.WriteString("3");
                        XTWriter.WriteEndElement();
                    XTWriter.WriteEndElement();
                    XTWriter.WriteStartElement("MAIL_LOG");
                        XTWriter.WriteStartElement("SMTP_SERVER");
                        XTWriter.WriteString("smpt://smtp.dominio.com");
                        XTWriter.WriteEndElement();
                        XTWriter.WriteStartElement("DESTINATARIOS");
                        XTWriter.WriteString("lvalerab@gmail.com");
                        XTWriter.WriteEndElement();
                    XTWriter.WriteEndElement();
                    XTWriter.WriteStartElement("HILO");
                        XTWriter.WriteStartElement("TIEMPO_INACTIVIDAD");
                        XTWriter.WriteString("30");
                        IGlobal.TIEMPO_ESPERA_BUCLE = 30;
                        XTWriter.WriteEndElement();
                    XTWriter.WriteEndElement();
                    XTWriter.WriteStartElement("RESERVAS");
                        XTWriter.WriteStartElement("CONDICION_ALTA");
                            XTWriter.WriteString("ID_ELEM_CARE_TPV is null");
                        XTWriter.WriteEndElement();
                    XTWriter.WriteEndElement();
                    XTWriter.WriteStartElement("IMAGENES");
                        XTWriter.WriteStartElement("RESOLUCIONX");
                            XTWriter.WriteString("600");
                        XTWriter.WriteEndElement();
                        XTWriter.WriteStartElement("RESOLUCIONY");
                           XTWriter.WriteString("800");
                        XTWriter.WriteEndElement();
                    XTWriter.WriteEndElement();
                XTWriter.WriteEndElement();
                XTWriter.WriteEndDocument();
                XTWriter.Close();
                throw new Exception("No se ha encontrado el fichero de configuración, se ha creado uno de ejemplo");
            }
        }

        /// <summary>
        /// Guarda en el log, la configuración que se carga en el daemon
        /// </summary>
        /// <param name="fl"></param>
        public static void ImprimeConfCargada(CLASES.LOGS.FileLog fl)
        {
            fl.EscribeLinea(new String('=', 100));
            fl.EscribeLinea("CONF > TPV > CADENA_CONEX_TPV = " + IGlobal.CADENA_CONEX_TPV);
            fl.EscribeLinea("CONF > WEB > CADENA_CONEX_WEB = " + IGlobal.CADENA_CONEX_WEB);
            fl.EscribeLinea("CONF > FTP > URL " + IGlobal.URL_FTP);
            fl.EscribeLinea("CONF > FTP > RUTA " + IGlobal.RUTA_FTP);
            fl.EscribeLinea("CONF > FTP > USUARIO " + IGlobal.USER_FTP);
            fl.EscribeLinea("CONF > FTP > PASSWORD " + IGlobal.PASS_FTP);
            fl.EscribeLinea("CONF > FTP > INTENTOS " + IGlobal.NUM_INTENTOS_FTP);
            fl.EscribeLinea("CONF > BUCLE > TIEMPO_ESPERA_BUCLE = " + IGlobal.TIEMPO_ESPERA_BUCLE);
            fl.EscribeLinea(new String('=', 100));
        }


        public static void ObtenDatosSQL(string sql, ref DataTable tabla, ref MySqlConnection cn, ref MySqlTransaction tr)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cn);
            if (tabla == null)
            {
                tabla = new DataTable();
            }
            da.Fill(tabla);
        }

        public static void GuardaDatosSql(string sql, ref DataTable tabla, ref MySqlConnection cn, ref MySqlTransaction tr) 
        {
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cn);
            da.SelectCommand.Transaction = tr;
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            da.InsertCommand = cb.GetInsertCommand();
            da.InsertCommand.Transaction = tr;
            da.UpdateCommand = cb.GetUpdateCommand();
            da.UpdateCommand.Transaction = tr;
            da.DeleteCommand = cb.GetDeleteCommand();
            da.DeleteCommand.Transaction = tr;

            da.Update(tabla);
        }

        public static void EjecutaSql(string sql, ref MySqlConnection cn, ref MySqlTransaction tr)
        {
            MySqlCommand cm = new MySqlCommand(sql, cn, tr);
            cm.ExecuteNonQuery();
        }
    }
}
