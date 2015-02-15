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
using System.Xml;

namespace StormDugeon.Forms
{
    public partial class ContainerForm : Form
    {
        public const string FileExt = ".STORM";
        public List<string> SavedGames;
        int BarracksLevel;
        int RosterLevel;
        int CurrentWeek;

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
            BarracksLevel = 0;
            RosterLevel = 0;
            CurrentWeek = 1;
        }

        public void LoadGame(string GameName)
        {
            try
            {
                string path = "SaveGames\\"+GameName + FileExt;
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                XmlNodeList test = doc.GetElementsByTagName("barracks_level");
                BarracksLevel = Int32.Parse(doc.GetElementsByTagName("barracks_level").Item(0).InnerText);
                RosterLevel = Int32.Parse(doc.GetElementsByTagName("roster_level").Item(0).InnerText);
                CurrentWeek = Int32.Parse(doc.GetElementsByTagName("Week").Item(0).InnerText);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
