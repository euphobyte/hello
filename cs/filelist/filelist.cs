// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

using System;
using System.IO;
using System.Text;

namespace ns_filelist{
  class filelist{
    public static int Main(string[] args){
      byte[] buf = new byte[256];
      
      if(args.Length == 0){
        Console.WriteLine("usage: filelist filename");
        return(1);
      }

      if(! File.Exists(args[0])){
        Console.WriteLine("File: {0}, does not Exist!", args[0]);
        return(1);        
      }

      FileStream fs = File.Open(args[0], FileMode.Open);
      BufferedStream bs = new BufferedStream(fs);

      Console.WriteLine("\r\nFile length: {0}\r\n", fs.Length);
      int offset = 0;
      int n = 0;
      do{
        n = bs.Read(buf, offset, 256);
        offset += n;
        Console.Write(Encoding.Default.GetString(buf));
        Array.Clear(buf, 0, buf.Length);
      }while (n == 256);

      bs.Close();
      return(0);
    }
  }
}
