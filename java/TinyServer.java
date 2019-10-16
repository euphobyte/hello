/*
  Tiny Webserver using the Java HttpServer API
  Minimal implementation without security and error handling.
*/

import com.sun.net.httpserver.HttpServer;
import com.sun.net.httpserver.HttpExchange;
import com.sun.net.httpserver.HttpHandler;
import com.sun.net.httpserver.Headers;

import java.io.OutputStream;
import java.io.IOException;

import java.net.InetSocketAddress;

public class TinyServer{
  public static void main(String[] args) throws Exception{
    HttpServer server = HttpServer.create(new InetSocketAddress(1200), 0);
    server.createContext("/", new BaseHandler());
    server.setExecutor(null);
    server.start();
  }
}

class BaseHandler implements HttpHandler{
  public void handle(HttpExchange t) throws IOException{
    String msg = "<h3>Hello World!</h3>";
    Headers h = t.getResponseHeaders();
    h.add("Content-Type", "text/html");
    t.sendResponseHeaders(200, msg.length());
    OutputStream os = t.getResponseBody();
    os.write(msg.getBytes());
    os.close();
  }
}
