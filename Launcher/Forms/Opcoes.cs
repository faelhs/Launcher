using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Launcher
{
    public partial class Opcoes : Form
    {
        public Opcoes()
        {
            InitializeComponent();
        }

        private void btaplicar_Click(object sender, EventArgs e)
        {
            int resolucao = 0;
            int resolucaoa = 0;
            int vollvl = 0;
            int musica = 0;
            int efeitos = 0;
            int janela = 0;
            if (rdres1.Checked) resolucao = 0;
            if (rdres2.Checked) resolucao = 1;
            if (rdres3.Checked) resolucao = 2;
            if (rdres4.Checked) { resolucao = 3; resolucaoa = 1; }
            if (ckmusica.Checked) musica = 1;
            if (ckefeitos.Checked) efeitos = 1;
            if (ckjanela.Checked) janela = 1;
            if (ckefeitos.Checked || ckmusica.Checked) vollvl = 5 ;
            string PATH = @"Software\Webzen\Mu\Config";
            RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(PATH);
            registryKey.SetValue("Resolution", resolucao);
            registryKey.SetValue("VolumeLevel", vollvl);
            registryKey.SetValue("ID", tblogin.Text);
            registryKey.SetValue("MusicOnOff", musica);
            registryKey.SetValue("SoundOnOff", efeitos);
            registryKey.SetValue("ResolutionA", resolucaoa);
            registryKey.SetValue("WindowMode", janela);
            registryKey.Close();
            MessageBox.Show("Configurações salvas");
            this.Dispose();
        }
        

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Opcoes_Load(object sender, EventArgs e)
        {
            try
            {
                int resolucao = 0;
                int musica = 0;
                int efeitos = 0;
                int janela = 0;
                string id = "";
                string PATH = @"Software\Webzen\Mu\Config";
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(PATH);
                string a = registryKey.GetValue("Resolution").ToString();
                resolucao = int.Parse(a);
                a = registryKey.GetValue("MusicOnOff").ToString();
                musica = int.Parse(a);
                a = registryKey.GetValue("SoundOnOff").ToString();
                efeitos = int.Parse(a);
                a = registryKey.GetValue("WindowMode").ToString();
                janela = int.Parse(a);
                id = registryKey.GetValue("ID").ToString();

                tblogin.Text = id;
                if (musica == 1) ckmusica.Checked = true;
                if (efeitos == 1) ckefeitos.Checked = true;
                if (janela == 1) ckjanela.Checked = true;
                switch (resolucao)
                {
                    case 0:
                        rdres1.Checked = true;
                        break;
                    case 1:
                        rdres2.Checked = true;
                        break;
                    case 2:
                        rdres3.Checked = true;
                        break;
                    case 3:
                        rdres4.Checked = true;
                        break;
                    default:
                        rdres1.Checked = true;
                        break;
                }
            }
            catch { }
            
            }
    }
}
