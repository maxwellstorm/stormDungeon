using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StormDugeon;

namespace StormDugeon.Forms
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.MdiParent = this.MdiParent;
            mm.Dock = DockStyle.Fill;
            mm.Show();
            this.Dispose();
        }
    }
}
