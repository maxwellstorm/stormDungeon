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
        public NewLoadControl()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            ContainerForm cf = (ContainerForm)this.ParentForm.MdiParent;
            cf.StartNewGame("test");
        }

        private void NewLoadControl_Load(object sender, EventArgs e)
        {
            TextBox.Text = "test";
        }

        
    }
}
