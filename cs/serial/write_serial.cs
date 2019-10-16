// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
// Program to test serial communication from PC ic C#
// H= 72 (HIGH turn LED on), L = 76 (LOW turn LED off)

using System;
using System.IO.Ports;

namespace ns_serial{
  class write_serial{

    public static void Main(){
      byte[] buf = new byte[] {0,0};
      byte ch = 0;
      SerialPort sp = new SerialPort("COM1", 9600);
      try{
        sp.Open();
        while(true){
          ch = (byte)Console.ReadKey(true).KeyChar;		
          Console.WriteLine(ch);
          buf[0] = ch;
          sp.Write(buf, 0, 1);
        }
      }catch(Exception ex){
        Console.WriteLine(ex);
      }
    }	
  }
}
