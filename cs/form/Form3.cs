using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System;

namespace Form3{
  public class Form1 : Form{

    private MainMenu main;
    private PictureBox picb = new PictureBox();
    private static string msg;

    public Form1(){
      main = new MainMenu();
      MenuItem mh = main.MenuItems.Add("Hello");
      mh.MenuItems.Add("Greeting!", new EventHandler(this.Greeting_Clicked));
      this.Menu = main;
      picb.Dock = DockStyle.Fill;
      picb.BackColor = Color.Red;
      picb.Paint += new System.Windows.Forms.PaintEventHandler(this.picb_Paint);
      this.Controls.Add(picb);
      this.Text = "Hello World!";
    }

    private void Greeting_Clicked(object sender, EventArgs e){
      MessageBox.Show(msg);
    }

    static void Main(string[] args){
      if(args.Length == 0)
        msg = "Hello World!";
      else
         msg = args[0];
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    private void picb_Paint(object sender, System.Windows.Forms.PaintEventArgs e){
      Bitmap img = new Bitmap(320,200, PixelFormat.Format16bppRgb555);
      img.SetPixel(100, 150, Color.White);
      Graphics g = e.Graphics;
      g.DrawLine(System.Drawing.Pens.Green, picb.Left, picb.Top, picb.Right, picb.Bottom);
      picb.Image = image1;
    }
    
  }
}
