using System;
namespace ns_bitconverter{
  class bitconverter{
    public static void Main(){
      byte[] bytes = {0, 0, 0, 29};
      if (BitConverter.IsLittleEndian)
        Array.Reverse(bytes);
      uint ui = BitConverter.ToUInt32(bytes, 0);
      Console.WriteLine("Int: {0}", ui);
      Console.WriteLine("Hex: {0:x2}", ui);
    }
  }
}
