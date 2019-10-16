// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;

namespace HService{

  [RunInstaller(true)]
  public class Installer1 : System.Configuration.Install.Installer{

    private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller1;
    private System.ServiceProcess.ServiceInstaller serviceInstaller1;

    public Installer1(){
      this.serviceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
      this.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
      this.serviceProcessInstaller1.Password = null;
      this.serviceProcessInstaller1.Username = null;
      this.serviceInstaller1 = new System.ServiceProcess.ServiceInstaller();
      this.serviceInstaller1.ServiceName = "HelloService";
      this.serviceInstaller1.DisplayName = "HelloService";
      this.serviceInstaller1.Description = "Hello World Service";
      this.Installers.AddRange(new System.Configuration.Install.Installer[] { this.serviceProcessInstaller1, this.serviceInstaller1});
    }
  }
}
