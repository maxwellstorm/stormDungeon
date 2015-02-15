using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StormDugeon.Forms.UserControls;
using System.Linq;
using System.IO;

namespace StormDugeon.Forms
{
    public partial class Campaign : Form
    {
        string []LoadFiles;
        public Campaign()
        {
            InitializeComponent();
            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

            Utils.OpenForm(new MainMenu(), this);
        }

        private void Campaign_Load(object sender, EventArgs e)
        {
         try
            {
                List<NewLoadControl> controls = this.Controls.OfType<NewLoadControl>().OrderBy(name => name.Name).ToList();//order by name of control so will always come back in desired order for ordering save games
                int count = 0;
                string temp;
                LoadFiles = Directory.GetFiles("SaveGames");
                foreach (NewLoadControl nlc in controls)
                {
                        Console.WriteLine(nlc.Name);
                        temp = LoadFiles[count].Split('\\')[1];
                        temp = temp.Split('.')[0];
                        nlc.TextBox.Text = temp;
                        count++;
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
        }
    }
   
}
