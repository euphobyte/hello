using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Hello World!")]
[assembly: AssemblyProduct("Test product")]
[assembly: AssemblyCopyright("Copyright © 2018")]
[assembly: AssemblyFileVersion("1.0.0.2")]
[assembly: AssemblyVersion("1.2.3.4")]

namespace ns_hello{
  class hello1{
    public static void Main(){
      Console.WriteLine("Hello World!");
      Console.WriteLine(Assembly.GetEntryAssembly().GetName().Version.ToString());
    }
  }
}
