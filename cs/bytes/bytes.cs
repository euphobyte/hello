// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

using System;
using System.Text;
using System.Globalization;

namespace ns_bytes{

  class bytes{

    public static void Main(){
      byte bt = 0x48;
      char[] hello = {'H', 'e', 'l', 'l', 'o'};
      byte[] hello2 = new byte[5];
      int i = 0;
      foreach(char c in hello){
        hello2[i] = (byte)c;
        i++;
      }
      Console.WriteLine("Byte character: {0}", (char)bt);
      Console.WriteLine("First character: {0}", hello[0]);
      Console.WriteLine("Value first character: {0}", (byte)hello[0]);
      Console.WriteLine("Hex value first character: {0:X2}", (byte)hello[0]);
      Console.WriteLine("Value first character: {0:0.00}", (byte)hello[0]);
      int val = (byte) hello[0];
      Console.WriteLine("US value first character: {0}", val.ToString("0.00", CultureInfo.CreateSpecificCulture("en-US")));
      StringBuilder sb = new StringBuilder();
      foreach(char c in hello){
        sb.Append(c);
      }
      Console.WriteLine("String built from character array: {0}", sb.ToString());
      String b64 = Convert.ToBase64String(hello2, Base64FormattingOptions.InsertLineBreaks);
      Console.WriteLine("Base64 of byte array: {0}", b64);
      Console.Write("Bytes in Base64: ");
      byte[] c64 = new byte[256];
      c64 = Convert.FromBase64String(b64);
      foreach(byte c in c64){
        Console.Write((char)c + " ");
      }
      Console.WriteLine();
    }
  }
}
/*

Byte character: H
First character: H
Value first character: 72
Hex value first character: 48
Value first character: 72,00
US value first character: 72.00
String built from character array: Hello
Base64 of byte array: SGVsbG8=
Bytes in Base64: H e l l o

*/
