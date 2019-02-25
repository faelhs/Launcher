using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Launcher
{
    class FileChecker
    {
        enum State
        {
            REPORT_NAME     = 0,
            REPORT_PROGRESS = 1
        }

        private static BackgroundWorker backgroundWorker = new BackgroundWorker();

        public static void CheckFiles()
        {
            backgroundWorker.WorkerReportsProgress = true;

            backgroundWorker.DoWork              += backgroundWorker_DoWork;
            backgroundWorker.ProgressChanged     += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted  += backgroundWorker_RunWorkerCompleted;

            if (backgroundWorker.IsBusy)
            {
                MessageBox.Show(Texts.GetText(Texts.Keys.UNKNOWNERROR, "CheckFiles isBusy"));
                Application.Exit();
            }
            else
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Globals.pForm.notificacoes.Icon = Properties.Resources.ico;
            Globals.pForm.notificacoes.BalloonTipText = "Baixando atualizações";
            Globals.pForm.notificacoes.ShowBalloonTip(1500);
            foreach (Globals.File file in Globals.Files)
            {
                Globals.FullSize += file.Size;

                backgroundWorker.ReportProgress((int)State.REPORT_NAME, Path.GetFileName(file.Name));

                if (!File.Exists(file.Name) || Common.GetHash(file.Name) != file.Hash)
                {
                    Globals.OldFiles.Add(file.Name);
                }
                else
                {
                    Globals.CompleteSize += file.Size;
                    backgroundWorker.ReportProgress((int)State.REPORT_PROGRESS);
                }
            }
        }

        private static void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage == (int)State.REPORT_NAME)
            {
                Common.ChangeStatus(Texts.Keys.CHECKFILE, e.UserState.ToString());
            }
            else
            {
                Common.UpdateCompleteProgress(Computer.Compute(Globals.CompleteSize));
            }
        }

        private static void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FileDownloader.DownloadFile();
        }
    }
}
