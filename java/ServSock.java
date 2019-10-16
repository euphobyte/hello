/* 
  Simple ServerSocket example, single threaded server prints clients socket port to the screen and closes the client socket.
*/

import java.net.ServerSocket;
import java.net.Socket;

public class ServSock{

  public static void main(String[] args) throws Exception{
    ServerSocket ssock = new ServerSocket(1200);
    System.out.println("Hello World!");
    while(true){
      Socket sock = ssock.accept();
      System.out.println(sock.getPort());
      sock.close();
    }
  }
}
