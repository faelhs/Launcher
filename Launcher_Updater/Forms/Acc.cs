using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Acc : Form
    {
        public Acc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btrecuperar_Click(object sender, EventArgs e)
        {
            RecuperarSenha rec = new RecuperarSenha();
            rec.ShowDialog();
            this.Dispose();
        }
        private static readonly HttpClient client = new HttpClient();
        private async void btmudarsenha_Click(object sender, EventArgs e)
        {

            Globals.login = tblogin.Text;
            Globals.senha = tbsenha.Text;
            if (cksalvar.Checked)
            {
                string PATH = @"Software\Webzen\Mu\Config";
                RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(PATH);
                registryKey.SetValue("LLogin", Globals.login);
                registryKey.SetValue("LSenha", Globals.senha);
                registryKey.Close();
            }
            else
            {
                string PATH = @"Software\Webzen\Mu\Config";
                RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(PATH);
                registryKey.SetValue("LLogin", "");
                registryKey.SetValue("LSenha", "");
                registryKey.Close();
            }
            btenviar.Enabled = false;
           string[] test = await Funções.logar();
                if (test[1].Contains("Sucesso"))
                {
                    btenviar.Enabled = false;
                    Globals.logado = true;
                lbresposta.Text = "logado com sucesso";
                this.Dispose();
                }
                if (test[1].Contains("Digite"))
                {
                    lbresposta.Text = "Preencha todos os campos.";
                btenviar.Enabled = true;
                return;
                }
                if (test[1].Contains("Incorreto"))
                {
                    lbresposta.Text = "Login ou senha Incorreto";
                btenviar.Enabled = true;
                return;
                }

        }

        private void Acc_Load(object sender, EventArgs e)
        {
            try
            {
                string login = "";
                string senha = "";
                string PATH = @"Software\Webzen\Mu\Config";
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(PATH);

                login = registryKey.GetValue("LLogin").ToString();
                senha = registryKey.GetValue("LSenha").ToString();

                tblogin.Text = login;
                tbsenha.Text = senha;

                if (login != "")
                {
                    cksalvar.Checked = true;
                }
                
            }
            catch { }
        }
    }
}
