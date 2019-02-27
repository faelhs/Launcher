using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace Launcher

{

    public partial class Main : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]

        public static extern bool ReleaseCapture();
        public Main()
        {
            InitializeComponent();
            Globals.pForm = this;

        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (Globals.pForm.lbstatus.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                Globals.pForm.lbstatus.Text = text;
            }
        }
        private void Status_server()
        {
            while (true)
            {
#if RAG_DEBUG_ || RAG_RELEASE_
                 try
                {
                    SetText("Login server: " + Funções.Online(Globals.hostip, Globals.loginport) + " | CharServer: " + Funções.Online(Globals.hostip, Globals.charport)+ " | MapServer: " + Funções.Online(Globals.hostip, Globals.mapport));
                }
                catch
                {
                    SetText("Login server: Falha | CharServer: Falha | MapServer: Falha");
                }
                Thread.Sleep(10000);
#else
                try
                {
                    SetText("Login server: " + Funções.Online(Globals.hostip, Globals.loginport) + " | GameServer: " + Funções.Online(Globals.hostip, Globals.gsport));
                }
                catch
                {
                    SetText("Login server: Falha | GameServer: Falha");
                }
                Thread.Sleep(10000);
#endif
            }
        }
        private void DefinirTexto(string texto)
        {
            Globals.pForm.lbstatus.Text = texto;
        }
        private void Attualizar()
        {
          
                try
                {
                    Networking.CheckNetwork();
                    
                }
                catch
                {
                    Status.Text = "Falha de atualização"; 
                }

        }
        private Thread server_status;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            Attualizar();
            this.server_status = new Thread(Status_server);
            this.server_status.Start();
            navegador.Navigate(Globals.sitelauncher);
            if (Common.IsGameRunning()) { Common.EnableStart(); }
            
            if (Globals.logado)
               {
                   btconta.Text = "Bem Vindo " + Globals.login;
               }
               
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btregistro_Click(object sender, EventArgs e)
        {
            Globals.pForm.Hide();
            Registro reg = new Registro();
            reg.Show();
        }

        private void btjogar_Click(object sender, EventArgs e)
        {

            try
            {
                Globals.jogo.StartInfo.FileName = Globals.BinaryName;
                Globals.jogo.StartInfo.WorkingDirectory = Globals.directory;
                Globals.jogo.StartInfo.Arguments = Globals.startparam;
                Globals.jogo.Start();
                
             
                //System.Diagnostics.Process.Start(Globals.BinaryName, Globals.startparam);
            }
            catch 
            {
                MessageBox.Show("Erro ao inicar o jogo.","Erro!");
            }

        }

        private void btconta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dash.PGBrasil.tk");
        }

        private void btopcoes_Click(object sender, EventArgs e)
        {
#if (DEBUG || RELEASE)
            Opcoes opt = new Opcoes();
            opt.ShowDialog();
#endif

#if (MINE_DEBUG_ || MINE_RELEASE_)
            System.Diagnostics.Process.Start("options.txt");
#endif

#if (RAG_DEBUG_ || RAG_RELEASE_)
        
            try
            {
                Globals.setup.StartInfo.FileName = "Setup.exe";
                Globals.setup.StartInfo.WorkingDirectory = "";
                Globals.setup.StartInfo.Arguments = "";
                Globals.setup.Start();


                //System.Diagnostics.Process.Start(Globals.BinaryName, Globals.startparam);
            }
            catch
            {
                MessageBox.Show("Erro ao configurar.", "Erro!");
            }
#endif

        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                ReleaseCapture();

                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Globals.pForm.Close();
        }

        private void ON_Close(object sender, FormClosedEventArgs e)
        {
            this.server_status.Abort();
            Application.Exit();
            try
            {
                Globals.jogo.Kill();
            }
            catch
            {

            }
        }

        private void onfocus(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(246,66,66);
        }
        private void ondefocus(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(246, 46, 46);
        }

        private void Gosite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://PGBrasil.tk");
        }

        private void Goforum_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("http://forum.PGBrasil.tk");
        }
    }

}
