/*
  Minimal example to copy file data to an outputstream.
  Uses new Java 1.8 API classes.
*/

import java.io.OutputStream;
import java.io.FileOutputStream;
import java.io.File;
import java.nio.file.Files;

class FileCopy{
  public static void main(String[] args) throws Exception{
    if(args.length > 2){
      File f1 = new File(args[0]);
      File f2 = new File(args[1]);
      OutputStream os =  new FileOutputStream(f2);
      Files.copy(f1.toPath(), os);
      os.close();
    }
  }
}
