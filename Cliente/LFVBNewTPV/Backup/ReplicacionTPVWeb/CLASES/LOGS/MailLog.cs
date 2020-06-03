using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace ReplicacionTPVWeb.CLASES.LOGS
{
    public class MailLog
    {
        private static String _smtpUrl;
        public static String SmtpUrl
        {
            set
            {
                MailLog._smtpUrl = value;
            }
            get
            {
                return MailLog._smtpUrl;
            }
        }
        
        private SmtpClient _Cliente;
        private static MailAddressCollection _Destinatarios;
        public  static MailAddressCollection Destinatarios
        {
            set
            {
                MailLog._Destinatarios = value;
            }
            get
            {
                return MailLog._Destinatarios;
            }
        }
        private string _Asunto;
        public  string Asunto
        {
            set
            {
                this._Asunto = value;
            }
            get
            {
                return this._Asunto;
            }
        }
        private string _TxtMensaje;
        public  string TxtMensaje
        {
            set
            {
                this._TxtMensaje = value;
            }
            get
            {
                return this._TxtMensaje;
            }
        }
        private MailMessage _Mensaje;
        private string _MsgErrores;

        public MailLog(string asunto, string mensaje)
        {
            this._Cliente = new SmtpClient(MailLog.SmtpUrl);
            this.Asunto = asunto;
            this.TxtMensaje = mensaje;
            this._Mensaje = new MailMessage();
            this._MsgErrores = "";
        }

        public void AnadeAdjunto(string ruta)
        {
            if (System.IO.File.Exists(ruta))
            {
                try
                {
                    this._Mensaje.Attachments.Add(new Attachment(ruta));
                }
                catch (Exception err)
                {
                    this._MsgErrores += "[ERROR ADJUNTO] Causa: "+err.Message+"\n";
                }
            }
            else
            {
                this._MsgErrores += "[ERROR ADJUNTO]  <" + ruta + "> no existe\n";
            }
        }

        public void Enviar()
        {
            this._Mensaje.From = new MailAddress("lvalerab@gmail.com","[DAEMON TPV2WEB]");
            this._Mensaje.ReplyTo = this._Mensaje.From;
            foreach (MailAddress ma in MailLog._Destinatarios)
            {
                this._Mensaje.To.Add(ma);
            }
            this._Mensaje.Body = this._TxtMensaje;
            if (this._MsgErrores != "")
            {
                this._Mensaje.Body += "\n\n\n==============================================\nErrores al crear el mensaje==============================================\n";
                this._Mensaje.Body += this._MsgErrores;
            }
            this._Cliente.Send(this._Mensaje);
        }
    }
}
