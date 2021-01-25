using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SimpleJSON;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace GestioneTreni
{
    public partial class Settings : Form
    {
        string download = "";
        string currentver = "";
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            StreamReader lettoresettings = new StreamReader("Settings.json");
            download = lettoresettings.ReadToEnd();
            lettoresettings.Close();

            JSONNode salvasettings = JSONNode.Parse(download);
            label1.Text = "Versione corrente: " + salvasettings["options"]["currentversion"];
            currentver = salvasettings["options"]["currentversion"];
            Scanupdateboot_chkbox.Checked = salvasettings["options"]["scanonboot"].AsBool;
            //salvasettings["options"]["changelog"];
            Scanupdatehour_chkbox.Checked = salvasettings["options"]["scanhour"]["0"]["active"].AsBool;
            Hourtoscan_txtb.Text = salvasettings["options"]["scanhour"]["0"]["timescan"];
            //salvasettings["options"]["theme"];
            Changethemeathour_chkbox.Checked = salvasettings["options"]["temeathour"]["0"]["active"].AsBool;
            Hourtochange_txtb.Text = salvasettings["options"]["temeathour"]["0"]["timetoactive"];


            if (Scanupdatehour_chkbox.Checked)
            {
                Hourtoscan_txtb.Enabled = true;
            }
            else
            {
                Hourtoscan_txtb.Enabled = false;
            }
        }

        private void Info_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creato da: Luke Screwdriver Mail: lukescrewdriver@phoenixpixel.it");
        }

        private void Scanupdateboot_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            StreamReader lettoresettings1 = new StreamReader("Settings.json");
            download = lettoresettings1.ReadToEnd();
            lettoresettings1.Close();

            JSONNode salvasettings = JSONNode.Parse(download);

            salvasettings["options"]["scanonboot"] = Scanupdateboot_chkbox.Checked.ToString();

            StreamWriter salvadata1 = new StreamWriter("Settings.json");
            salvadata1.Write(salvasettings.ToString(Environment.NewLine));
            salvadata1.Close();
        }

        private void Scanupdatehour_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            StreamReader lettoresettings2 = new StreamReader("Settings.json");
            download = lettoresettings2.ReadToEnd();
            lettoresettings2.Close();

            JSONNode salvasettings = JSONNode.Parse(download);

            salvasettings["options"]["scanhour"]["0"]["active"] = Scanupdatehour_chkbox.Checked.ToString();

            StreamWriter salvadata2 = new StreamWriter("Settings.json");
            salvadata2.Write(salvasettings.ToString(Environment.NewLine));
            salvadata2.Close();
            if (Scanupdatehour_chkbox.Checked)
            {
                Hourtoscan_txtb.Enabled = true;
            }
            else
            {
                Hourtoscan_txtb.Enabled = false;
            }
        }

        private void Hourtoscan_txtb_TextChanged(object sender, EventArgs e)
        {
            StreamReader lettoresettings3 = new StreamReader("Settings.json");
            download = lettoresettings3.ReadToEnd();
            lettoresettings3.Close();

            JSONNode salvasettings = JSONNode.Parse(download);

            salvasettings["options"]["scanhour"]["0"]["timescan"] = Hourtoscan_txtb.Text;

            StreamWriter salvadata3 = new StreamWriter("Settings.json");
            salvadata3.Write(salvasettings.ToString(Environment.NewLine));
            salvadata3.Close();
        }

        private void Scannowforupdate_Click(object sender, EventArgs e)
        {
            Aggiornamento();
        }

        private void Changelog_btn_Click(object sender, EventArgs e)
        {
            Changelog f1 = new Changelog();
            f1.Show();
        }

        void Aggiornamento()
        {

            string remoteUri = "https://pastebin.com/0DgnQR5i";
            string fileName = Environment.CurrentDirectory + "\\prova.txt";

            WebClient myWebClient = new WebClient();

            try
            {
                myWebClient.DownloadFile(remoteUri, fileName);


                int counter = 0;
                string line;
                string downloadurljson = "";
                // Read the file and display it line by line.  
                System.IO.StreamReader file =
                    new System.IO.StreamReader(Environment.CurrentDirectory + "\\prova.txt");
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("\"version\":"))
                    {
                        downloadurljson = line.Replace("		<textarea id=\"paste_code\" class=\"paste_code\" name=\"paste_code\" onkeydown=\"return catchTab(this,event)\">", "");
                        downloadurljson = downloadurljson.Replace("</textarea>", "");
                    }
                    counter++;
                }

                file.Close();

                File.Delete("prova.txt");

                downloadurljson = downloadurljson.Replace("\\\"", "\"");


                JSONNode letturaupdate = JSONNode.Parse(downloadurljson.Replace("{{","{").Replace("}}", "}"));

                string risultato = letturaupdate["program"]["2"]["version"];

                if (currentver != risultato)
                {
                    MessageBox.Show("Update disponibile!");
                    
                }
                else
                {
                    MessageBox.Show("Non ci sono update.");
                }
            }
            catch
            {
                MessageBox.Show("Connessione assente.");
            }
            

        }
    }
}
