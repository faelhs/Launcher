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
    public partial class Site_Doar : Form
    {
        public Site_Doar()
        {
            InitializeComponent();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.GetElementById("conta").InnerText = Globals.login;
            webBrowser1.Document.GetElementById("valor").InnerText = Globals.donate;
            webBrowser1.Document.GetElementById("Submit").InvokeMember("click");
        }

        private void On_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://draconick.ddns.net/pagseguro/");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
