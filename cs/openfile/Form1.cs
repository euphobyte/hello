using System.Windows.Forms;
using System.IO;
using System;
using System.Drawing;

namespace Prog1{
  public class Form1 : Form{

    internal MainMenu main;
    internal TextBox tb1;
    internal OpenFileDialog dlg1;

    public Form1(){

      this.Text = "File Example";
      main = new MainMenu();
      MenuItem mh = main.MenuItems.Add("File");
      mh.MenuItems.Add("Open File", new EventHandler(this.Open_Clicked));
      this.Menu = main;
      tb1 = new TextBox();
      tb1.Multiline = true;
      tb1.Dock = DockStyle.Fill;
      tb1.Enabled = false;
      tb1.BackColor = SystemColors.Window;
      this.Controls.Add(tb1);	
    }

    private void Open_Clicked(object sender, EventArgs e){
      dlg1 = new OpenFileDialog();  
      dlg1.Title = "Open File";  
      dlg1.Filter = "Text Files (*.txt) | *.txt"; 
      DialogResult dr1 = dlg1.ShowDialog();  
      if (dr1 == DialogResult.OK) {  
        StreamReader sr1 = new StreamReader(dlg1.FileName);  
        tb1.Text = sr1.ReadToEnd();  
        sr1.Close();  
      }	   
    }

    [STAThread]
    static void Main(){
    Application.Run(new Form1());
    }
  }
}
