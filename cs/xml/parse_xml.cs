    
// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

using System;
using System.IO;
using System.Xml;

class Program{
  public static void Main(){
    String xml = "<Message><Greeting>Hello World!</Greeting></Message>";
    XmlDocument xdoc = new XmlDocument();
    xdoc.Load(new StringReader(xml));
    XmlNodeList xnodes = xdoc.SelectNodes("//Message");
    foreach(XmlNode xnode in xnodes){
      XmlNode greeting = xnode.SelectSingleNode("Greeting");
      Console.WriteLine(greeting.Name);
      Console.WriteLine(greeting.InnerText);
    }
  }
}
