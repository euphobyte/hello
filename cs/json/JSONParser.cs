// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

using System;
class JSONParser{
  public static void Main(){
    String msg = "[{\"Greeting\":\"Hello\",\"Name\":\"Your Name\"},{\"Greeting\":\"World!\"}]";
    String del = "},{";
    Char[] delch = del.ToCharArray();        
    String[] msgs = msg.Split(new[] { "},{" }, StringSplitOptions.None);
    for(int i=0; i < msgs.Length; i++){
      msgs[i] = msgs[i].Replace("[","").Replace("]","").Replace("{","").Replace("}","").Replace("\"","");
      Console.WriteLine("Record: {0}", i);
      String[] flds = msgs[i].Split(',');
      foreach(String fld in flds){
        Console.WriteLine("FieldName: {0}", fld.Split(':')[0]);
        Console.WriteLine("FieldValue: {0}", fld.Split(':')[1]);
      }
      Console.WriteLine();
    }
  }
}

/*
  Output:
  Record: 0
  FieldName: Greeting
  FieldValue: Hello
  FieldName: Name
  FieldValue: Your Name

  Record: 1
  FieldName: Greeting
  FieldValue: World!
*/
