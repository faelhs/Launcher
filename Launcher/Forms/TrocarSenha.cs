using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace Launcher
{
    public partial class TrocarSenha : Form
    {
        public TrocarSenha()
        {
            InitializeComponent();
        }
        private static readonly HttpClient client = new HttpClient();
        private async void button1_Click(object sender, EventArgs e)
        {
            btenviar.Enabled = false;
            string test = await Funções.MudarSenha(tbsatual.Text,tbnsenha.Text, tbrnsenha.Text);
            if (test.Contains("Sucesso"))
            {
                btenviar.Enabled = false;
                Globals.senha = tbnsenha.Text;
            }
            lbresposta.Text = test;
            btenviar.Enabled = true;
           
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void TrocarSenha_Load(object sender, EventArgs e)
        {

        }
    }
}
