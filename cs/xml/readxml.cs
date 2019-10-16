// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

using System;
using System.Xml;
using System.IO;

class Program{
public static void Main(){
  string xml ="<Messages><Message id='1'>Hello</Message><Message id='2'>World!</Message></Messages>";
  XmlReader xreader = XmlReader.Create(new StringReader(xml));
  while(xreader.Read()){
    if(xreader.IsStartElement()){
      if(xreader.Name == "Message"){
        Console.Write(xreader.Name);
        Console.Write(" {0} / ", xreader["id"]);
      }else
        Console.WriteLine(xreader.Name);
      }
      if(xreader.NodeType == XmlNodeType.Text)
        Console.WriteLine(xreader.Value);
    }
  }
}
