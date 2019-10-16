// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
// Not usable for actual encryption! It just explains the mechanisms.
// The variable tst should be replaced by a proper routine to generate SALT bytes.

using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace ns_encrypt{
  class encrypt{
    
    public static void Main(){

      String inp = "Hello";
      String passw = "World";
      String outp = Encrypt(inp, passw);
      Console.WriteLine(outp);
      Console.WriteLine(Decrypt(outp, passw));
    }

    public static String Encrypt(String inp, String passw){

      byte[] buf = Encoding.ASCII.GetBytes(inp);
      byte[] tst = new byte[] {2, 2, 2, 3, 3, 4, 4, 5};
      MemoryStream ms = new MemoryStream();
      Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(passw, tst);
      Aes aes = Aes.Create();
      aes.Key = rfc.GetBytes(32); 
      aes.IV  = rfc.GetBytes(16);
      CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
      cs.Write(buf, 0, buf.Length);
      cs.Close();
      return Convert.ToBase64String(ms.ToArray());
    }

    public static String Decrypt(String inp, String passw){

      byte[] buf = Convert.FromBase64String(inp);
      byte[] tst = new byte[] {2, 2, 2, 3, 3, 4, 4, 5};
      MemoryStream ms = new MemoryStream();
      Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(passw, tst);
      Aes aes = Aes.Create();
      aes.Key = rfc.GetBytes(32); 
      aes.IV  = rfc.GetBytes(16);
      CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write);
      cs.Write(buf, 0, buf.Length);
      cs.Close();
      return Encoding.ASCII.GetString(ms.ToArray());
    }
  }
}
