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
    public partial class ContainerForm : Form
    {
        public ContainerForm()
        {
            InitializeComponent();
            StartMenu sm = new StartMenu();
            sm.MdiParent = this;
            sm.Dock = DockStyle.Fill;
            sm.Show();
        }
    }
}
