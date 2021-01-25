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
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Data;

namespace GestioneTreni
{
    public partial class Form1 : Form
    {
        int index = -1;
        bool creazione = false;
        int maxstep = 3199;
        string version = "beta 3.2";

        SerialPort portaSeriale = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generaElementi();

            if (!File.Exists("Settings.json"))
            {
                StreamWriter settings = new StreamWriter("Settings.json");
                settings.Write("{");
                settings.Close();

                JSONNode salvasettings = JSONNode.Parse("{");
                salvasettings["options"]["currentversion"] = version;
                salvasettings["options"]["scanonboot"] = "True";
                salvasettings["options"]["changelog"] = "";
                salvasettings["options"]["scanhour"]["0"]["active"] = "False";
                salvasettings["options"]["scanhour"]["0"]["timescan"] = "00:00";
                salvasettings["options"]["theme"] = "Chiaro";
                salvasettings["options"]["temeathour"]["0"]["active"] = "False";
                salvasettings["options"]["temeathour"]["0"]["timetoactive"] = "00:00";

                if (salvasettings["options"]["scanonboot"].AsBool)
                {
                    Aggiornamento();
                }

                if (salvasettings["options"]["scanhour"]["0"]["active"].AsBool)
                {
                    timer1.Start();
                }


                StreamWriter salvadata = new StreamWriter("Settings.json");
                salvadata.Write(salvasettings.ToString(Environment.NewLine));
                salvadata.Close();
            }
            else
            {

                StreamReader lettorefile = new StreamReader("Settings.json");
                string download = lettorefile.ReadToEnd();
                lettorefile.Close();
                
                JSONNode salvasettings = JSONNode.Parse(download);

                salvasettings["options"]["currentversion"] = version;

                if (salvasettings["options"]["scanonboot"].AsBool)
                {
                    Aggiornamento();
                }

                if (salvasettings["options"]["scanhour"]["0"]["active"].AsBool)
                {
                    timer1.Start();
                }


                StreamWriter salvadata2 = new StreamWriter("Settings.json");
                salvadata2.Write(salvasettings.ToString(Environment.NewLine));
                salvadata2.Close();
            }
        }

        private void software_info_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Creato da: Luca Pelicioli" + Environment.NewLine + "Versione: " +version+ Environment.NewLine + "Creato da: Luca Pelicioli Mail: luca.pelicioli@gmail.com");
            Settings f1 = new Settings();
            f1.Show();
            f1.FormClosed += chiuso;
        }

        void MakeMenu()
        {
            creazione = !creazione;
            if (creazione)
            {
                label5.Visible = true;
                label6.Visible = true;
                name_txtb.Visible = true;
                Position_txtb.Visible = true;
                Make_btn.Visible = true;
                Occupata_chkbox.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
            }
            else
            {
                label6.Visible = false;
                label5.Visible = false;
                name_txtb.Visible = false;
                Position_txtb.Visible = false;
                Make_btn.Visible = false;
                Occupata_chkbox.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
            }

        }

        void chiuso(object sender, EventArgs e)
        {
            if (File.Exists("Update.json"))
            {
                Process.Start("Updater.exe");
                this.Close();
            }
        }

        void generaElementi()
        {
            if (File.Exists("PlatformPsositionSave.json"))
            {
                StreamReader lettorefile = new StreamReader("PlatformPsositionSave.json");
                string download = lettorefile.ReadToEnd();
                lettorefile.Close();

                JSONNode lettoreJson = JSONNode.Parse(download);
                int count = 0;

                string name = name_txtb.Text;
                string position = Position_txtb.Text;
                string busy = Occupata_chkbox.Checked.ToString();

                do
                {
                    name = lettoreJson["Oggetti"][count]["Name"];
                    position = lettoreJson["Oggetti"][count]["Position"];
                    busy = lettoreJson["Oggetti"][count]["Busy"];

                    ListViewItem sovrascrittore = new ListViewItem(name);
                    sovrascrittore.SubItems.Add(position);
                    sovrascrittore.SubItems.Add(busy);
                    ListItems.Items.Add(sovrascrittore);
                    count++;

                }
                while (count < Convert.ToInt32(lettoreJson["numbertowrite"]));


            }
            else
            {
                StreamWriter creadata = new StreamWriter("PlatformPsositionSave.json");
                creadata.Write("{");
                creadata.Close();

                JSONNode scrittoreNewdata = JSONNode.Parse("{");
                scrittoreNewdata["numbertowrite"] = "0";

                StreamWriter salvadata = new StreamWriter("PlatformPsositionSave.json");
                salvadata.Write(scrittoreNewdata.ToString(Environment.NewLine));
                salvadata.Close();
            }
        }
         
        private void button3_Click(object sender, EventArgs e)
        {
            Make_btn.Text = "Crea";
            MakeMenu();
        }

        private void Make_btn_Click(object sender, EventArgs e)
        {
            if (Make_btn.Text == "Crea")
            {
                if (name_txtb.Text != "" && Position_txtb.Text != "")
                {
                    //MakeMenu();
                    string name = name_txtb.Text;
                    string position = Position_txtb.Text;

                    if (Convert.ToInt32(position) < maxstep && Convert.ToInt32(position) >= 0)
                    {//200
                        if (checkBox1.Checked)
                        {
                            name_txtb.Text = "";
                        }
                        if (checkBox2.Checked)
                        {
                            Position_txtb.Text = "0";
                        }
                        

                        StreamReader lettorefile = new StreamReader("PlatformPsositionSave.json");
                        string download = lettorefile.ReadToEnd();
                        lettorefile.Close();

                        JSONNode scrittorenewdatajson = JSONNode.Parse(download);

                        int pos = Convert.ToInt32(scrittorenewdatajson["numbertowrite"]);

                        scrittorenewdatajson["Oggetti"][pos]["Name"] = name.ToString();
                        scrittorenewdatajson["Oggetti"][pos]["Position"] = position;
                        scrittorenewdatajson["Oggetti"][pos]["Busy"] = Occupata_chkbox.Checked.ToString();

                        pos++;
                        scrittorenewdatajson["numbertowrite"] = Convert.ToString(pos);



                        StreamWriter salvadata = new StreamWriter("PlatformPsositionSave.json");
                        salvadata.Write(scrittorenewdatajson.ToString(Environment.NewLine));
                        salvadata.Close();
                    }
                    else
                    {
                        MessageBox.Show("Parametro posizione non valido! Max:199 Min:0");
                    }
                    

                }
            }
            else if (Make_btn.Text == "Modifica")
            {

                StreamReader lettorefile2 = new StreamReader("PlatformPsositionSave.json");
                string download = lettorefile2.ReadToEnd();
                lettorefile2.Close();

                JSONNode modificajson = JSONNode.Parse(download);


                string name = name_txtb.Text;
                string position = Position_txtb.Text;

                modificajson["Oggetti"][index]["Name"] = name.ToString();
                modificajson["Oggetti"][index]["Position"] = position;
                modificajson["Oggetti"][index]["Busy"] = Occupata_chkbox.Checked.ToString();


                StreamWriter salvadata = new StreamWriter("PlatformPsositionSave.json");
                salvadata.Write(modificajson.ToString(Environment.NewLine));
                salvadata.Close();

                Make_btn.Text = "Crea";


                MakeMenu();
            }
            else
            {

            }

            ListItems.Items.Clear();
            generaElementi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = ListItems.SelectedItems[0].SubItems[0].Text;


                StreamReader lettorefile = new StreamReader("PlatformPsositionSave.json");
                string download = lettorefile.ReadToEnd();
                lettorefile.Close();

                JSONNode ricercajson = JSONNode.Parse(download);
                int pos = 0;
                do
                {
                    string nome = ricercajson["Oggetti"][pos]["Name"];
                    if (nome == name)
                    {
                        index = pos;
                        pos++;
                    }
                    else
                        pos++;
                }
                while (pos < Convert.ToInt32(ricercajson["numbertowrite"]));

                //------------------------------------------------------------------------------------

                StreamReader lettorefile2 = new StreamReader("PlatformPsositionSave.json");
                download = lettorefile2.ReadToEnd();
                lettorefile2.Close();

                JSONNode eliminajson = JSONNode.Parse(download);

                eliminajson["Oggetti"].Remove(index);
                eliminajson["numbertowrite"] = Convert.ToString(Convert.ToInt32(eliminajson["numbertowrite"]) - 1);

                StreamWriter salvadata = new StreamWriter("PlatformPsositionSave.json");
                salvadata.Write(eliminajson.ToString(Environment.NewLine));
                salvadata.Close();

                ListItems.Items.Clear();
                generaElementi();

                Remove_btn.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Nulla selezionato!");
            }
            
        }

        private void ListItems_MouseClick(object sender, MouseEventArgs e)
        {
            if (StatusConnection_lab.Text== "Stato: Connesso")
            { 
                Move_btn.Enabled = true;
            }
            Remove_btn.Enabled = true;
            Change_btn.Enabled = true;

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Make_btn.Text = "Crea";
            Change_btn.Enabled = false;
            Move_btn.Enabled = false;
            creazione = true;
            MakeMenu();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int x = this.Width;
            int y = this.Height;
            ////436 473 listbox
            ////680 534
            ////244 61

            ListItems.Width = x - 244;
            ListItems.Height = y - 61;
        }

        private void Move_btn_Click(object sender, EventArgs e)
        {
            string name = ListItems.SelectedItems[0].SubItems[0].Text;


            StreamReader lettorefile = new StreamReader("PlatformPsositionSave.json");
            string download = lettorefile.ReadToEnd();
            lettorefile.Close();

            JSONNode ricercajson = JSONNode.Parse(download);
            int pos = 0;
            do
            {
                string nome = ricercajson["Oggetti"][pos]["Name"];
                if (nome == name)
                {
                    index = pos;
                    pos++;
                }
                else
                    pos++;
            }
            while (pos < Convert.ToInt32(ricercajson["numbertowrite"]));

            bool presentetreno = Convert.ToBoolean(ricercajson["Oggetti"][pos]["Busy"]);
            presentetreno = !presentetreno;
            ricercajson["Oggetti"][pos]["Busy"] = presentetreno.ToString();

            //------------------------------------------------------------------------------------

            
            string letturajs = ricercajson["Oggetti"][index]["Position"];
            string send = letturajs + ";"+ mlssXsec_txtb.Text+ Environment.NewLine;
            portaSeriale.Write(send);
            PosizioneCrursore_lab.Text = letturajs;

            StreamWriter saveBusy = new StreamWriter("PlatformPsositionSave.json");
            saveBusy.Write(ricercajson.ToString(Environment.NewLine));
            saveBusy.Close();

            ListItems.Items.Clear();
            generaElementi();
        }

        private void Change_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = ListItems.SelectedItems[0].SubItems[0].Text;


                StreamReader lettorefile = new StreamReader("PlatformPsositionSave.json");
                string download = lettorefile.ReadToEnd();
                lettorefile.Close();

                JSONNode ricercajson = JSONNode.Parse(download);
                int pos = 0;
                do
                {
                    string nome = ricercajson["Oggetti"][pos]["Name"];
                    if (nome == name)
                    {
                        index = pos;
                        pos++;
                    }
                    else
                        pos++;
                }
                while (pos < Convert.ToInt32(ricercajson["numbertowrite"]));

                //------------------------------------------------------------------------------------

                StreamReader lettorefile2 = new StreamReader("PlatformPsositionSave.json");
                download = lettorefile2.ReadToEnd();
                lettorefile2.Close();

                JSONNode modificajson = JSONNode.Parse(download);

                name_txtb.Text = modificajson["Oggetti"][index]["Name"];
                Position_txtb.Text = modificajson["Oggetti"][index]["Position"];
                Occupata_chkbox.Checked = Convert.ToBoolean(modificajson["Oggetti"][index]["Busy"]);
                Make_btn.Text = "Modifica";

                if (name_txtb.Visible == false)
                {
                    MakeMenu();
                }
            }
            catch
            {
                MessageBox.Show("Nulla selezionato!");
            }
            
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            if (Connect_btn.Text == "Connetti")
            {
                try
                {
                    portaSeriale.PortName = NamePort_txtbox.Text;
                    portaSeriale.BaudRate = 9600;
                    portaSeriale.WriteBufferSize = 4;
                    portaSeriale.Open();
                    Connect_btn.Text = "Disconnetti";
                    StatusConnection_lab.Text = "Stato: Connesso";
                    Move_btn.Enabled = true;
                    Antiorario_btn.Enabled = true;
                    Orario_btn.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Impossibile connettersi!");
                    StatusConnection_lab.Text = "Stato: Disconnesso";
                    Move_btn.Enabled = false;
                    Antiorario_btn.Enabled = false;
                    Orario_btn.Enabled = false;
                }
                
            }
            else if (Connect_btn.Text == "Disconnetti")
            {
                try
                {
                    portaSeriale.Close();
                    Connect_btn.Text = "Connetti";
                    StatusConnection_lab.Text = "Stato: Disconnesso";
                    Move_btn.Enabled = false;
                    Antiorario_btn.Enabled = false;
                    Orario_btn.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Impossibile disconnettersi!");
                    StatusConnection_lab.Text = "Stato: Connesso";
                    Move_btn.Enabled = true;
                    Antiorario_btn.Enabled = true;
                    Orario_btn.Enabled = true;
                }
                
            }
            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                portaSeriale.Close();
                Connect_btn.Text = "Connetti";
                StatusConnection_lab.Text = "Stato: Disconnesso";
            }
            catch
            {
                
                StatusConnection_lab.Text = "Stato: Connesso";
            }
        }

        private void Antiorario_btn_Click(object sender, EventArgs e)
        {
            int risultato = Convert.ToInt32(PosizioneCrursore_lab.Text) - 1;
            if (risultato<0)
            {
                risultato = maxstep;
            }

            if (risultato > maxstep)
            {
                risultato = 0;
            }
            portaSeriale.Write(Convert.ToString(risultato + Convert.ToInt32(CorrectionMove_txtbox.Text)) + ";" + mlssXsec_txtb.Text + Environment.NewLine);
            PosizioneCrursore_lab.Text = Convert.ToString(risultato);
        }

        private void Orario_btn_Click(object sender, EventArgs e)
        {
            int risultato = Convert.ToInt32(PosizioneCrursore_lab.Text) + 1;
            if (risultato < 0)
            {
                risultato = maxstep;
            }

            if (risultato > maxstep)
            {
                risultato = 0;
            }
            portaSeriale.Write(Convert.ToString(risultato) + ";" + mlssXsec_txtb.Text + Environment.NewLine);
            PosizioneCrursore_lab.Text = Convert.ToString(risultato);
        }

        private void PosizioneCrursore_lab_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(PosizioneCrursore_lab.Text);

                if (i > maxstep && 0 > i)
                {
                    PosizioneCrursore_lab.Text = "0";
                }
            }
            catch
            {
                PosizioneCrursore_lab.Text = "0";
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StreamReader lettorefile = new StreamReader("Settings.json");
            string download = lettorefile.ReadToEnd();
            lettorefile.Close();

            JSONNode salvasettings = JSONNode.Parse(download);

            DateTime dataora = DateTime.Now;
            string dsw = salvasettings["options"]["scanhour"]["0"]["timescan"];
            if (dsw == dataora.Hour.ToString()+":"+ dataora.Minute.ToString())
            {
                Aggiornamento();
            }
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


                JSONNode letturaupdate = JSONNode.Parse(downloadurljson);

                string risultato = letturaupdate["program"]["2"]["version"];

                if (version != risultato)
                {
                    MessageBox.Show("Update disponibile!");
                    
                }
                else
                {
                    
                }
            }
            catch
            {
                
            }


        }

        private void CorrectionMove_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
