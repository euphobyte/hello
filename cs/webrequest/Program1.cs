// FOR EDUCATIONAL PURPOSES ONLY

using System;
using System.Net;
using System.IO;
using System.Text;

namespace Prog1{
  public class WebReq1{
    public static void Main(){
      WebRequest wreq = WebRequest.Create("http://localhost:8080/");
      HttpWebResponse resp = (HttpWebResponse)wreq.GetResponse();
      Console.WriteLine("Status Code: " + resp.StatusCode);
      StreamReader str1 =  new StreamReader (resp.GetResponseStream());
      Console.WriteLine(str1.ReadToEnd());
    }
  }
}
