using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher.Forms
{
    public partial class Doar : Form
    {
        public Doar()
        {
            InitializeComponent();
        }

        private void Change(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Somente numeros");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.donate = textBox1.Text;
            Launcher.Forms.Site_Doar x = new Forms.Site_Doar();
            x.Show();
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
