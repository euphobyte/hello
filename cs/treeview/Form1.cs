using System.Windows.Forms;

namespace Prog1{
  public class Form1 : Form{

    internal TreeView TView1;
  
    public Form1(){
      this.Text = "Hello World!";
      TView1 = new TreeView();
      TView1.Dock = DockStyle.Fill;
      TView1.AfterSelect += new TreeViewEventHandler(TView1_AfterSelect);
      TreeNode tn = TView1.Nodes.Add("Hello");
      tn.Nodes.Add("World!");
      this.Controls.Add(TView1);
    }

    private void TView1_AfterSelect(object sender, TreeViewEventArgs e){
      if (e.Action == TreeViewAction.ByMouse)
        MessageBox.Show(e.Node.FullPath);
    }
		
    static void Main(){
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }
  }
}
