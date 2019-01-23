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
    public partial class MinhaConta : Form
    {
        public MinhaConta()
        {
            InitializeComponent();
        }
        private async void MinhaConta_Load(object sender, EventArgs e)
        {
            string[] x = await Funções.logar();
            label1.Text = x[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Globals.logado = false;
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrocarSenha troc = new TrocarSenha();
            troc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://draconick.ddns.net/pagseguro/carrinho.php");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuyVip cv = new BuyVip();
            cv.Show();
        }
    }
}
