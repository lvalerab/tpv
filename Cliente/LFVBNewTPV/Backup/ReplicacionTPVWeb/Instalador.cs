using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace ReplicacionTPVWeb
{
    [RunInstaller(true)]
    public partial class Instalador : Installer
    {
        private ServiceInstaller _si;
        private ServiceProcessInstaller _spi;
        public Instalador()
        {
            InitializeComponent();

            this._si = new ServiceInstaller();
            this._spi = new ServiceProcessInstaller();

            this._spi.Account = ServiceAccount.LocalService;
            this._si.StartType = ServiceStartMode.Manual;
            this._si.ServiceName = "TPV2WEB";
            Installers.Add(this._si);
            Installers.Add(this._spi);
        }
    }
}