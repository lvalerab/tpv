using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ClsUtils.TECLADO
{
    public class Teclado
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool Wow64DisableWow64FsRedirection(ref IntPtr ptr);
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool Wow64RevertWow64FsRedirection(ref IntPtr ptr);

        private const UInt32 WM_SYSCOMMAND = 0x112;
        private const UInt32 SC_RESTORE = 0xf120;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        public Teclado()
        {
            this.MetodoWin7 = IGlobal.UsarMetodoWin7;
        }
        private static Teclado _instancia;
        private bool _MethodW7;
        public bool MetodoWin7
        {
            set
            {
                this._MethodW7 = value;
            }
            get
            {
                return this._MethodW7;
            }
        }
        public static Teclado ObtenInstancia()
        {
            if (Teclado._instancia == null)
            {
                Teclado._instancia = new Teclado();
            }
            Teclado._instancia.MetodoWin7 = IGlobal.UsarMetodoWin7;
            return Teclado._instancia;
        }

        private void MetodoAntW7()
        {
            try
            {
                Process teclado = new Process();
                teclado.StartInfo.FileName = IGlobal.ProgramaTeclado;
                teclado.Start();
            }
            catch (Exception err)
            {
                MessageBox.Show("No es posible lanzar el teclado, revise la configuración [Pestaña Miscelanea>Programa de teclado en pantalla]", "Error al lanzar el teclado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MetodoW7()
        {
            try
            {
                string pname = System.IO.Path.GetFileNameWithoutExtension(IGlobal.ProgramaTeclado);
                //si se pasa a c# VS2008 o superior cambiar por linq
                Process keyBoard = null;
                foreach (Process p in Process.GetProcesses())
                {
                    if (p.ProcessName == pname)
                    {
                        keyBoard = p;
                    }
                }
                if (keyBoard == null)
                {
                    IntPtr puntero = new IntPtr();
                    bool sucessfullyDisabledWow64Redirect = false;
                    sucessfullyDisabledWow64Redirect = Wow64DisableWow64FsRedirection(ref puntero);
                    using (Process osk = new Process())
                    {
                        osk.StartInfo.FileName = IGlobal.ProgramaTeclado;
                        osk.Start();
                        osk.WaitForInputIdle(2000);
                    }
                    if (sucessfullyDisabledWow64Redirect)
                    {
                        Wow64RevertWow64FsRedirection(ref puntero);
                    }
                }
                else
                {
                    IntPtr puntero = keyBoard.MainWindowHandle;
                    SendMessage(puntero, WM_SYSCOMMAND, new IntPtr(SC_RESTORE), new IntPtr(0));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No es posible lanzar el teclado, revise la configuración [Pestaña Miscelanea>Programa de teclado en pantalla]", "Error al lanzar el teclado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Lanzar()
        {
            if (this.MetodoWin7)
            {
                this.MetodoW7();
            }
            else
            {
                this.MetodoAntW7();
            }
        }


    }
}
