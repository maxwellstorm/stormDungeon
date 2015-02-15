using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

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

        public static void MakeNewGameFile(string FileName)//file name without extension
        {
            string path = @"SaveGames/" + FileName + ".STORM"; //really is an xml file
            try
            {
                if (!Directory.Exists("SaveGames"))
                    Directory.CreateDirectory("SaveGames");
                XmlWriter writer = XmlWriter.Create(path);
                writer.WriteStartDocument();
                writer.WriteStartElement("General");
                writer.WriteElementString("Week", "1");
                writer.WriteStartElement("town");
                writer.WriteStartElement("barracks");
                writer.WriteElementString("barracks_level", "0");
                writer.WriteElementString("roster_level", "0");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();              
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
