using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StormDugeon.Forms.UserControls
{
    public partial class NewLoadControl : UserControl
    {
        public ContainerForm cf;
        public NewLoadControl()
        {
            InitializeComponent();
            
        }

        private void start_Click(object sender, EventArgs e)
        {
          
            if (start.Text == "Start New")
                if (TextBox.Text != "")
                    cf.StartNewGame(TextBox.Text);
                else
                    MessageBox.Show("please enter desired game name");
            else
                cf.LoadGame(TextBox.Text);
        }

        private void NewLoadControl_Load(object sender, EventArgs e)
        {
            cf = (ContainerForm)this.ParentForm.MdiParent;
             
        }

        
    }
}
