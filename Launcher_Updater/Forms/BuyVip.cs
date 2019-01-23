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
    public partial class BuyVip : Form
    {
        public BuyVip()
        {
            InitializeComponent();
        }
        private static readonly HttpClient client = new HttpClient();
        private async void button1_Click(object sender, EventArgs e)
        {
            string type = "";
            if (rdvp0.Checked) type = "1";
            if (rdvp1.Checked) type = "2";
            if (rdvp2.Checked) type = "3";
            if (rdvp3.Checked) type = "4";
            if (rdvp4.Checked) type = "5";
            btenviar.Enabled = false;
            var test = await Funções.CompraVip(type);
            btenviar.Enabled = true;
            if (test.Contains("sucesso"))
            {
                btenviar.Enabled = false;
            }
            lbresposta.Text = test;
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

