// List of serial com ports from commandline
// csc /out:comlist.exe comlist.cs

using System;
using System.IO.Ports;

namespace ns_comlist{
  class comlist{
    public static void Main(){
      foreach(string name in SerialPort.GetPortNames()){
        Console.WriteLine(name);
      }   
    }	
  }
}
