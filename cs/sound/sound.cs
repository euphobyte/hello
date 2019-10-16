using System;
using System.Media;

namespace ns_sound{
  class sound{
		
    public static void Main(string[] args){
      if(args.Length == 1){
        SoundPlayer sp = new SoundPlayer(args[0]);
        sp.PlaySync();
      }else{
        Console.WriteLine("Format: sound filename");
      }	
    }
  }
}
