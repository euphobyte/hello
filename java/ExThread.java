/*
  Minimal example of an Executor (threadpool) first Thread A starts, 5 seconds later Thread B.
  Then Thread A prints a message every 2 seconds, Thread B every 4 seconds
*/

import java.util.concurrent.Executor;
import java.util.concurrent.Executors;

public class ExThread{
  private static Executor tp = Executors.newFixedThreadPool(2);

  public static void main(String[] args) throws Exception{
    System.out.println("Hello World!");
    tp.execute(new TThread("A", 2000));
    Thread.sleep(10000);
    tp.execute(new TThread("B", 4000));
  }
}

class TThread implements Runnable {
  String name;
  int wt;

  TThread(String n, int w){
    name = n;
    wt = w;
  }

  public void run(){
    Thread t = new Thread(this);
    while(true){
      System.out.println("Thread: " + name );
      try{
        t.sleep(wt);
      }catch(Exception e){;}
    }
  }
}
