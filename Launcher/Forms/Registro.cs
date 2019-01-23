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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            Globals.pForm.Show();
            this.Dispose();
        }

        private static readonly HttpClient client = new HttpClient();

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btenviar_Click(object sender, EventArgs e)
        {
            btenviar.Enabled = false;
            string sexo = "";
            if (rdmasculino.Checked)
            {
                sexo = "Masculino";
            }
            if (rdfeminino.Checked)
            {
                sexo = "Feminino";
            }
            var values = new Dictionary<string, string>
                {
                     { "Account", tblogin.Text },
                     { "Mail", tbemail.Text },
                     { "Re_Mail", tbemail.Text },
                     { "Name", tbnome.Text },
                     { "Password", tbsenha.Text },
                     { "Re_Password", tbresenha.Text },
                     { "Phone", tbtelefone.Text },
                     { "PID", tbpersonalid.Text },
                     { "Question", tbpergunta.Text },
                     { "Resp", tbresposta.Text },
                     { "Sex", sexo },
                     { "Date_D", tbano.Text },
                     { "Date_M", tbmes.Text},
                     { "Date_Y", tbdia.Text}
                };

            var content = new FormUrlEncodedContent(values);
            try
            {
                var response = await client.PostAsync(Globals.webrequest + "?pag=register&cmd=true", content);

                var responseString = await response.Content.ReadAsStringAsync();
                btenviar.Enabled = true;
                string test = Funções.LimpaString(responseString);
                lbresposta.Text = test;
                if (test.Contains("Sucesso!"))
                {
                    btenviar.Enabled = false;
                    
                }
            }
            catch
            {
                lbresposta.Text = "Erro de soliciatação";
            }
        }
    }
}
