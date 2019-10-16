// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
// Http Server that can only be called from a local client. It is single threaded.
// Added some extra debug information.

using System;
using System.Net;
using System.IO;
using System.Text;

namespace Program2{
  class Listen2{
    
    public static void Main(){
      HttpListener serv = new HttpListener();
      serv.Prefixes.Add("http://localhost:8080/");
      Console.WriteLine("Listening...");    
      serv.Start();
      while(true){
        HttpListenerContext cont = serv.GetContext();
        HttpListenerRequest req = cont.Request;
        Console.WriteLine("Local Host: {0}", req.Url.IsLoopback);
        if(req.Url.IsLoopback){
          foreach(String key in req.Headers.AllKeys){
            Console.Write(key);
            Console.Write(" : ");
            Console.WriteLine(req.Headers.Get(key));
          }

          foreach(String seg in req.Url.Segments){
            Console.WriteLine(seg);
          }
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
}
