using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace _17_WinService
{
    [RunInstaller(true)]
    public class MyServiceInstaller : Installer
    {
        ServiceProcessInstaller processInstaller;
        ServiceInstaller serviceInstaller;
        public MyServiceInstaller()
        {
            processInstaller = new ServiceProcessInstaller();
            processInstaller.Account = ServiceAccount.LocalSystem;

            serviceInstaller = new ServiceInstaller();
            serviceInstaller.ServiceName = "TEST SERVICE";
            serviceInstaller.Description = "My Service";
            serviceInstaller.StartType = ServiceStartMode.Automatic;

            base.Installers.Add(processInstaller);
            base.Installers.Add(serviceInstaller);
        }
    }
}
