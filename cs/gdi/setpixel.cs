// FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

using System.Windows.Forms;
using System.Drawing;
using System;
using System.IO;

namespace Form1{
  public class Form1 : Form{

    uint[] pixels = new uint[64];
 
    public Form1(){
      FileStream fs = new FileStream("test.txt", FileMode.Open);
      fs.Seek(1, SeekOrigin.Begin);
      for(int i=0; i < 4; i++)
        Console.WriteLine((char)fs.ReadByte());
      fs.Close();
      this.BackColor = Color.Black;
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.on_Paint);
      this.Text = "Set Pixel";
    }

    static void Main(string[] args){
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    private void on_Paint(object sender, System.Windows.Forms.PaintEventArgs e){
      IntPtr hdc = e.Graphics.GetHdc();
      uint colorRef = (uint)((0xFF << 16) | (0xFF << 8) | 0xFF);
      SetPixel(hdc, 10, 15, colorRef);
      e.Graphics.ReleaseHdc(hdc);
    }

    [System.Runtime.InteropServices.DllImport("gdi32.dll")]
    internal static extern bool SetPixel(IntPtr hdc, int X, int Y, uint crColor);
  }
}
