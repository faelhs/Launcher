using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Main : Form
    {
       
        public Main()
        {
            InitializeComponent();
            Globals.pForm = this;

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (Common.IsGameRunning())
               EnableStart();
            else
                Networking.CheckNetwork();
            
            if (Globals.logado)
            {
                
            }

        }

        private void btsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static void EnableStart()
        {
            try
            {
                System.Diagnostics.Process jogo = new System.Diagnostics.Process();
                jogo.StartInfo.FileName = Globals.BinaryName;
                jogo.StartInfo.WorkingDirectory = Globals.directory;
                jogo.StartInfo.Arguments = Globals.startparam;
                jogo.Start();
            }
            catch
            {
                MessageBox.Show("Erro ao iniciar o jogo.");
            }
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
                System.Diagnostics.Process jogo = new System.Diagnostics.Process();
                 jogo.StartInfo.FileName = Globals.BinaryName;
                 jogo.StartInfo.WorkingDirectory = Globals.directory;
                 jogo.StartInfo.Arguments = Globals.startparam;
                 jogo.Start();
             
                //System.Diagnostics.Process.Start(Globals.BinaryName, Globals.startparam);
            }
            catch 
            {
                MessageBox.Show("Erro ao inicar o jogo.","Erro!");
            }
        }

        private void btconta_Click(object sender, EventArgs e)
        {
            if (!Globals.logado)
            {
                Acc gerenciar = new Acc();
                gerenciar.ShowDialog();
            }
            else
            {
                MinhaConta my = new MinhaConta();
                my.ShowDialog();
            }
        }

        private void btopcoes_Click(object sender, EventArgs e)
        {
            Opcoes opt = new Opcoes();
            opt.ShowDialog();
        }

        private void completeProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
