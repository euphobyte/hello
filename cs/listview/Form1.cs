using System.Windows.Forms;
using System;

namespace Prog1{
  public class Form1 : Form{

    private ListView lView1;

    public Form1(){
      lView1 = new ListView();
      lView1.Columns.Add("Greeting");
      lView1.Columns.Add("Who");
      lView1.Items.Add(new ListViewItem (new string[]{"Hello","World"}));
      lView1.Items.Add(new ListViewItem (new string[]{"Morning","Galaxy"}));
      lView1.View =  View.Details;
      lView1.FullRowSelect = true;
      this.Text = "Hello World!";
      this.Controls.Add(lView1);
      lView1.Dock = DockStyle.Fill;
      lView1.SelectedIndexChanged += new EventHandler(this.OnSelectedIndexChanged);
    }

    private void OnSelectedIndexChanged(object sender, EventArgs e){
      if (lView1.SelectedItems.Count > 0) 
        MessageBox.Show(lView1.Items.IndexOf(lView1.SelectedItems[0]).ToString());
    }
		
    static void Main(){
      Application.Run(new Form1());
    }
  }
}
