using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;


namespace Launcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
          /*  try
            {
                if (args[0] == "draconickbyfaelhs")
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Main());
                }
                else
                {
                    MessageBox.Show("Execute o jogo pelo launcher original !");

                }
            }
            catch
            {
                MessageBox.Show("Execute o jogo pelo launcher!");
            }*/
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
            
        }
    }
}
