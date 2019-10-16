// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

using System;
using System.Text;
using System.Xml;

class Program{

  static void Main(){
    StringBuilder sb = new StringBuilder();
    String[] msgs = {"Hello", "World!"};
    XmlWriter xwriter = XmlWriter.Create(sb);
    xwriter.WriteStartDocument();
    xwriter.WriteStartElement("Messages");
    foreach (String msg in msgs){
      xwriter.WriteStartElement("Message");
      xwriter.WriteElementString("Greeting", msg);
      xwriter.WriteEndElement();
    }
    xwriter.WriteEndElement();
    xwriter.WriteEndDocument();
    xwriter.Flush();
    Console.WriteLine(sb);
  }
}
