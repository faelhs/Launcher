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
#if DEBUG || MINE_DEBUG_ || RAG_DEBUG_
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

#endif
#if RELEASE
            try
            {
                if (args[0] == "PGBrasilMuOnline")
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
            }
#endif
#if RAG_RELEASE_
            try
            {
                if (args[0] == "PGBrasilRagnarok")
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
            }
#endif
#if MINE_RELEASE_
            try
            {
                if (args[0] == "PGBrasilMinecraft")
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
            }
#endif

        }
    }
}
