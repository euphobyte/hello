// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
  
using System;
using System.Net;
using System.IO;
using System.Text;

namespace Prog1{
  class Listen1{
    public static void Main(){
      HttpListener serv = new HttpListener();
      serv.Prefixes.Add("http://localhost:8080/");
      serv.Start();
      Console.WriteLine("Listenening...");
      while(true){
        HttpListenerContext cont  = serv.GetContext();
        HttpListenerRequest req   = cont.Request;
        HttpListenerResponse resp = cont.Response;
        Stream ost = resp.OutputStream;
        byte[] buf = Encoding.ASCII.GetBytes("<h1>Hello World!</h1>");
        resp.ContentLength64 = buf.Length;
        resp.StatusCode = 200;
        ost.Write(buf, 0, buf.Length);
        ost.Close();
      }
    }
  }
}
