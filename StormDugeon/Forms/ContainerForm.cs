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
using System.IO;

namespace StormDugeon.Forms
{
    public partial class ContainerForm : Form
    {
        public List<string> SavedGames;
        public ContainerForm()
        {
            InitializeComponent();
            StartMenu sm = new StartMenu();
            sm.MdiParent = this;
            sm.Dock = DockStyle.Fill;
            sm.Show();
        }

      
        public void StartNewGame(string GameName)
        {
            Utils.MakeNewGameFile(GameName);
        }

        public void LoadGame(string GameName)
        {

        }
    }
}
