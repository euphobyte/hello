// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

using System;
using System.IO;

namespace ns_hexlist{
  class hexlist{
    
    public static int Main(string[] args){
      
      byte bt;
      int pos = 0;
      char[] ch = new char[16];
      
      if(args.Length == 0){
        Console.WriteLine("usage: hexlist filename");
        return(1);
      }
      
      if(! File.Exists(args[0])){
        Console.WriteLine("File: {0}, does not Exist!", args[0]);
        return(1);        
      }

      FileStream fs = File.Open(args[0], FileMode.Open);
      Console.WriteLine("\r\nFile length: {0}\r\n", fs.Length);
      
      for(int i = 0; i < fs.Length; i++){
        pos = i % 16;
        if(pos == 0){
          if(i > 0){
            Console.Write("| ");
            Console.WriteLine(ch);
            Array.Clear(ch, 0, ch.Length);
          }
          Console.Write("{0:X6} ", i);
        }
        bt = (byte)fs.ReadByte();
        Console.Write("{0:X2} ", bt);
        ch[pos] = ((bt > 0x20) && (bt < 0x7F)) ? (char)bt : '.'; 
      }
      
      for(int j = 0; j < (15 - pos); j++){
        Console.Write("  ");
      }
      
      Console.Write("| ");  
      Console.WriteLine(ch);

      fs.Close();
      return(0);
    }
  }
}

/*

> hexlist hello.txt

File length: 26

000000 48 65 6C 6C 6F 20 57 6F 72 6C 64 21 0D 0A 48 65 | Hello.World!..He
000010 6C 6C 6F 20 57 6F 72 6C 64 21                   | llo.World!

*/
