// FOR EDUCATIONAL PURPOSES ONLY
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

using System;
using System.Text;

class JSONBuilder{

  const char QUOTE = '\u0022';
  private StringBuilder rw;    // Contains data for a single row
  private StringBuilder bufar;  // Contains an array of rows
  
  public static void Main(){
    JSONBuilder jb = new JSONBuilder();
    jb.AddRow();
    jb.Put("Greeting", "Hello");
    jb.AddRow();
    jb.Put("Greeting", "World!");
    Console.WriteLine(jb.Build());
  }

  public JSONBuilder(){
    rw = new StringBuilder();
  }
  
  public void AddRow(){
    if(bufar == null){  
      bufar = new StringBuilder();
      bufar.Append("[");
    }else
      bufar.Append(rw).Append("},");
    bufar.Append("{");
    rw.Clear();
  }
  
  public void Put(String field, String value){
    if(rw.Length > 0)
      rw.Append(",");
    rw.Append(QUOTE).Append(field).Append(QUOTE);
    rw.Append(":");
    rw.Append(QUOTE).Append(value).Append(QUOTE);
  }
  
  public String Build(){
    bufar.Append(rw).Append("}]");
    return bufar.ToString();
  }
}

// Output:
//   [{"Greeting":"Hello"},{"Greeting":"World!"}]
