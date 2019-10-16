/* 
  Single threaded Socket Server for HTTP communication using the standard Java API
*/

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.PrintWriter;

import java.net.ServerSocket;
import java.net.Socket;

public class STServer{

  public static void main(String[] args) throws Exception{
    ServerSocket ssock = new ServerSocket(1200);
    System.out.println("Starting server ...");
    while(true){
      Socket sock = ssock.accept();
      BufferedReader br = new BufferedReader(new InputStreamReader(sock.getInputStream()));
      PrintWriter pw = new PrintWriter(sock.getOutputStream(), true);
      String msg;
      while(((msg = br.readLine()) != null) && msg.length() != 0){
        System.out.println("Message: " + msg);
      }
      pw.println("HTTP/1.0 200");
      pw.println("Content-type: text/html");
      pw.println("");
      pw.println("<html><h3>Hello World!</h3></html>");
      pw.flush();
      pw.close();
      sock.close();
    }
  }
}
