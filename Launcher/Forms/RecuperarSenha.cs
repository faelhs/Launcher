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
    public partial class RecuperarSenha : Form
    {
        public RecuperarSenha()
        {
            InitializeComponent();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private static readonly HttpClient client = new HttpClient();
        private async void btenviar_Click(object sender, EventArgs e)
        {
            btenviar.Enabled = false;
            var values = new Dictionary<string, string>
                {
                     { "Mail", tbemail.Text}
                };

            var content = new FormUrlEncodedContent(values);
            try
            {
                var response = await client.PostAsync(Globals.webrequest + "?pag=recovery&cmd=true", content);

                var responseString = await response.Content.ReadAsStringAsync();
                btenviar.Enabled = true;
                string test = responseString.Replace("<div class=", "")
                    .Replace("div", "")
                    .Replace("error-box", "")
                    .Replace("warning-box", "")
                    .Replace("<br", "\n")
                    .Replace(">", "").Replace("/", "")
                    .Replace("&atilde;", "ã")
                    .Replace("&aacute;", "á")
                    .Replace("&raquo;", "»")
                    .Replace("&ecirc;", "ê")
                    .Replace("&uacute;", "ú")
                    .Replace("&ccedil;", "ç")
                    .Replace("\"", "")
                    .Replace("<", "")
                    .Replace("success-box", "");
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
