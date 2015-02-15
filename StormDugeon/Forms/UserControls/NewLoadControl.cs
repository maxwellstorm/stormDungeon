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
                    cf.StartNewGame(this.Name.ToCharArray()[this.Name.Length - 1] + TextBox.Text);//ensure games will be in order of save
                else
                {
                    MessageBox.Show("please enter desired game name");
                    return;
                }
            else
            {
                cf.LoadGame(this.Name.ToCharArray()[this.Name.Length - 1] + TextBox.Text);
            }
            Utils.OpenForm(new InTown(), (Form)this.Parent);
        }

        private void NewLoadControl_Load(object sender, EventArgs e)
        {
            cf = (ContainerForm)this.ParentForm.MdiParent;
             
        }

        
    }
}
