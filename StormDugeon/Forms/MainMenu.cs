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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            NewGame ng = new NewGame();
            ng.MdiParent = this.MdiParent;
            ng.Dock = DockStyle.Fill;
            ng.Show();
            this.Dispose();

        }
    }
}
