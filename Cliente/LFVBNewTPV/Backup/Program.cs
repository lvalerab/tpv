using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LFVBNewTPV
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Comprobaciones iniciales
            if (global::LFVBNewTPV.Properties.Settings.Default.CADENA_CONEXION.Trim() == "")
            {
                MessageBox.Show("Debe de configurar primero la aplicación", "Configuracion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                
                Application.Run(new LFVBNewTPV.SISTEMA.CONFIGURACION.FrmConfiguracion());
            }
            CargaConfiguracionLibrerias();
            
            Int32 contaValidaciones = 0;
            SISTEMA.VALIDACION.FrmValidarUsuario aux = new LFVBNewTPV.SISTEMA.VALIDACION.FrmValidarUsuario();            
            try
            {
                CLSBASE.IGlobal.user = CLSBASE.SISTEMA.USUARIOS.Usuario.Validar("", "");
                while (!CLSBASE.IGlobal.user.valido && contaValidaciones < 3)
                {
                    aux.ShowDialog();
                    if (aux.resultado == DialogResult.Cancel)
                    {
                        contaValidaciones = 3;
                    }
                    else
                    {
                        CLSBASE.IGlobal.user = CLSBASE.SISTEMA.USUARIOS.Usuario.Validar(aux.TBoxUsuario.Text, aux.TBoxPassword.Text);
                        if (CLSBASE.IGlobal.user.valido)
                        {
                            contaValidaciones = 3;
                        }
                    }
                    contaValidaciones++;
                }
                if (CLSBASE.IGlobal.user.valido)
                {
                    //Validacion del usuario
                    Application.Run(new FrmMain());
                }
            }
            catch (Exception err)
            {
                SISTEMA.MENSAJES.FrmError FrmErr = new LFVBNewTPV.SISTEMA.MENSAJES.FrmError(err);                
            }
        }

        internal static void CargaConfiguracionLibrerias()
        {
            CLSBASE.IGlobal.RUTA_IMAG_PROD = global::LFVBNewTPV.Properties.Settings.Default.PROD_RUTA_IMAGENES.Trim();
            CLSBASE.IGlobal.cad_conexion = global::LFVBNewTPV.Properties.Settings.Default.CADENA_CONEXION.Trim();
            ClsUtils.IGlobal.ProgramaTeclado = global::LFVBNewTPV.Properties.Settings.Default.PROGRAMA_TECLADO.Trim();
            ClsUtils.IGlobal.UsarMetodoWin7 = global::LFVBNewTPV.Properties.Settings.Default.WIN7_METODO_TECLADO;
            ClsUtils.IGlobal.MySqlDumpRuta = global::LFVBNewTPV.Properties.Settings.Default.MYSQDUMP_RUTA;
            ClsUtils.IGlobal.RutaImagenes = CLSBASE.IGlobal.RUTA_IMAG_PROD;
            ClsUtils.IGlobal.RellenaDatosMySqlDump(global::LFVBNewTPV.Properties.Settings.Default.CADENA_CONEXION.Trim());
        }
    }
}