// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.ServiceProcess;

namespace HService{

  public class HelloService : System.ServiceProcess.ServiceBase {
    private EventLog eventLog;
	
    public HelloService() {
      evenLog = new EventLog();
      eventLog.Source = "HelloService";
      this.ServiceName = "HelloService";
    }
	
    static void Main() {
      System.ServiceProcess.ServiceBase[] ServicesToRun;
      ServicesToRun = new System.ServiceProcess.ServiceBase[] { new HelloService() };
      System.ServiceProcess.ServiceBase.Run(ServicesToRun);
    }

    protected override void OnStart(string[] args) {
      eventLog.WriteEntry("Start Hello Service!");
    }

    protected override void OnStop() {
      eventLog.WriteEntry("Stop Hello Service!");
    }
  }
}
