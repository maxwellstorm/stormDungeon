using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StormDugeon
{
    static class Utils
    {
        public static void OpenForm(Form FormToOpen, Form FormToClose)
        {
            FormToOpen.MdiParent = FormToClose.MdiParent;
            FormToOpen.Dock = DockStyle.Fill;
            FormToOpen.Show();
            FormToClose.Dispose();
        }
    }
}
