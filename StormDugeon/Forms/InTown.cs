using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StormDugeon.Forms
{
    public partial class InTown : Form
    {
        public InTown()
        {
            InitializeComponent();
        }

        private void Barracks_MouseEnter(object sender, EventArgs e)
        {
            this.Barracks.BorderStyle = BorderStyle.Fixed3D;
            this.Barracks.BackColor = Color.Cyan;
        }

        private void Barracks_MouseLeave(object sender, EventArgs e)
        {
            this.Barracks.BorderStyle = BorderStyle.None;
            this.Barracks.BackColor = Color.Chocolate;
        }
    }
}
