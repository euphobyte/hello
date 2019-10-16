// FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
// There is no error handling or sanity checks in this example.

using System.Windows.Forms;
using System;
using System.IO;

namespace Form1{
  public class Form1 : Form{

    uint[] pixels;
    uint wd = 0;
    int ht  = 0;
    uint sz = 0;

     public Form1(){
      FileStream fs = new FileStream("test.bin", FileMode.Open);
      ReadHeader(fs);
      ReadPixels(fs);
      fs.Close();
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.on_Paint);
      this.Text = string.Format("wd={0:x2} ht={1:x2}", wd, ht);
    }

    static void Main(string[] args){
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    private void on_Paint(object sender, System.Windows.Forms.PaintEventArgs e){
      IntPtr hdc = e.Graphics.GetHdc();
      int a = 0;
      for( int y = 0; y < ht; y++){
        for(int x = 0; x < wd ; x++){
          SetPixel(hdc, x , (ht - y), pixels[a]);
          a++;
        }
      }
      e.Graphics.ReleaseHdc(hdc);
    }

    private void ReadHeader(FileStream fs){
      fs.Seek(0x12, SeekOrigin.Begin);
      wd = (uint)((fs.ReadByte()) | (fs.ReadByte() << 8) | (fs.ReadByte() << 16));
      fs.Seek(0x16, SeekOrigin.Begin);
      ht = (int)((fs.ReadByte()) | (fs.ReadByte() << 8) | (fs.ReadByte() << 16));
      fs.Seek(0x22, SeekOrigin.Begin);
      sz = (uint)((fs.ReadByte()) | (fs.ReadByte() << 8) | (fs.ReadByte() << 16));
      pixels = new uint[sz];
    }

    private void ReadPixels(FileStream fs){
      fs.Seek(0x36, SeekOrigin.Begin);
      byte[] bytes = new byte[3];
      for(int i = 0; i < sz; i++){
        fs.Read(bytes, 0, 3);
        pixels[i] = (uint)((bytes[0] << 16) | (bytes[1] << 8) | (bytes[2]));
      }
    }

    [System.Runtime.InteropServices.DllImport("gdi32.dll")]
    internal static extern bool SetPixel(IntPtr hdc, int X, int Y, uint crColor);
  }
}
