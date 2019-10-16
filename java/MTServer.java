import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.PrintWriter;

import java.net.ServerSocket;
import java.net.Socket;

import java.util.concurrent.Executor;
import java.util.concurrent.Executors;

public class MTServer{

  private static Executor tp = Executors.newFixedThreadPool(10);

  public static void main(String[] args) throws Exception{
    ServerSocket ssock = new ServerSocket(1200);
    System.out.println("Hello World!");
    while(true){
      Socket sock = ssock.accept();
      tp.execute(new Handler(sock));
    }
  }
}

class Handler implements Runnable{
  private Socket sock;

  Handler(Socket sk){
    this.sock = sk;
  }

  public void run(){
  try{
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
    br.close();
    sock.close();
    }catch(Exception e){;}
  }
}
