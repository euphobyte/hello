// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
  
using System;
using System.IO.Ports;

namespace ns_serial{
  class read_serial{
    public static void Main(){
      SerialPort sp = new SerialPort("COM1", 9600);
      try{
        sp.Open();
        while(true){
          if(sp.BytesToRead > 0){
            // (byte)ReadByte() is used for reading a single byte form the serial port.
            Console.Write((char)sp.ReadChar());
          }
          sp.Close();
        }
      }catch(Exception ex){
        Console.WriteLine(ex);
      }
    }	
  }
}
