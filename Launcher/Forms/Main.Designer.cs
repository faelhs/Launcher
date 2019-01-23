namespace Launcher
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btjogar = new System.Windows.Forms.Button();
            this.btregistro = new System.Windows.Forms.Button();
            this.btopcoes = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.navegador = new System.Windows.Forms.WebBrowser();
            this.currentProgressText = new System.Windows.Forms.Label();
            this.completeProgressText = new System.Windows.Forms.Label();
            this.currentProgress = new System.Windows.Forms.ProgressBar();
            this.completeProgress = new System.Windows.Forms.ProgressBar();
            this.Status = new System.Windows.Forms.Label();
            this.btconta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btjogar
            // 
            this.btjogar.Enabled = false;
            this.btjogar.Location = new System.Drawing.Point(647, 15);
            this.btjogar.Name = "btjogar";
            this.btjogar.Size = new System.Drawing.Size(125, 76);
            this.btjogar.TabIndex = 0;
            this.btjogar.Text = "Jogar";
            this.btjogar.UseVisualStyleBackColor = true;
            this.btjogar.Click += new System.EventHandler(this.btjogar_Click);
            // 
            // btregistro
            // 
            this.btregistro.Location = new System.Drawing.Point(647, 94);
            this.btregistro.Name = "btregistro";
            this.btregistro.Size = new System.Drawing.Size(125, 76);
            this.btregistro.TabIndex = 1;
            this.btregistro.Text = "Registro";
            this.btregistro.UseVisualStyleBackColor = true;
            this.btregistro.Click += new System.EventHandler(this.btregistro_Click);
            // 
            // btopcoes
            // 
            this.btopcoes.Location = new System.Drawing.Point(647, 250);
            this.btopcoes.Name = "btopcoes";
            this.btopcoes.Size = new System.Drawing.Size(125, 76);
            this.btopcoes.TabIndex = 2;
            this.btopcoes.Text = "Opções";
            this.btopcoes.UseVisualStyleBackColor = true;
            this.btopcoes.Click += new System.EventHandler(this.btopcoes_Click);
            // 
            // btsair
            // 
            this.btsair.Location = new System.Drawing.Point(647, 328);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(125, 76);
            this.btsair.TabIndex = 3;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // navegador
            // 
            this.navegador.Location = new System.Drawing.Point(13, 16);
            this.navegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.navegador.Name = "navegador";
            this.navegador.ScrollBarsEnabled = false;
            this.navegador.Size = new System.Drawing.Size(628, 319);
            this.navegador.TabIndex = 8;
            this.navegador.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // currentProgressText
            // 
            this.currentProgressText.AutoSize = true;
            this.currentProgressText.Location = new System.Drawing.Point(452, 378);
            this.currentProgressText.Name = "currentProgressText";
            this.currentProgressText.Size = new System.Drawing.Size(180, 13);
            this.currentProgressText.TabIndex = 12;
            this.currentProgressText.Text = "Progresso parcial: 100%  |  0.00 kb/s";
            // 
            // completeProgressText
            // 
            this.completeProgressText.AutoSize = true;
            this.completeProgressText.Location = new System.Drawing.Point(452, 352);
            this.completeProgressText.Name = "completeProgressText";
            this.completeProgressText.Size = new System.Drawing.Size(97, 13);
            this.completeProgressText.TabIndex = 11;
            this.completeProgressText.Text = "Progresso total: 0%";
            // 
            // currentProgress
            // 
            this.currentProgress.Location = new System.Drawing.Point(13, 374);
            this.currentProgress.Name = "currentProgress";
            this.currentProgress.Size = new System.Drawing.Size(436, 21);
            this.currentProgress.TabIndex = 10;
            this.currentProgress.Value = 100;
            // 
            // completeProgress
            // 
            this.completeProgress.Location = new System.Drawing.Point(13, 347);
            this.completeProgress.Name = "completeProgress";
            this.completeProgress.Size = new System.Drawing.Size(436, 21);
            this.completeProgress.TabIndex = 9;
            this.completeProgress.Value = 100;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(12, 403);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(16, 13);
            this.Status.TabIndex = 13;
            this.Status.Text = "...";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btconta
            // 
            this.btconta.Location = new System.Drawing.Point(647, 172);
            this.btconta.Name = "btconta";
            this.btconta.Size = new System.Drawing.Size(125, 76);
            this.btconta.TabIndex = 1;
            this.btconta.Text = "Minha Conta";
            this.btconta.UseVisualStyleBackColor = true;
            this.btconta.Click += new System.EventHandler(this.btconta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "—";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Location = new System.Drawing.Point(242, 403);
            this.lbstatus.MinimumSize = new System.Drawing.Size(300, 0);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(300, 13);
            this.lbstatus.TabIndex = 16;
            this.lbstatus.Text = "Status do Servidor";
            this.lbstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.ControlBox = false;
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.currentProgressText);
            this.Controls.Add(this.completeProgressText);
            this.Controls.Add(this.currentProgress);
            this.Controls.Add(this.completeProgress);
            this.Controls.Add(this.navegador);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btopcoes);
            this.Controls.Add(this.btconta);
            this.Controls.Add(this.btregistro);
            this.Controls.Add(this.btjogar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ON_Close);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btregistro;
        private System.Windows.Forms.Button btopcoes;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.WebBrowser navegador;
        public System.Windows.Forms.Label currentProgressText;
        public System.Windows.Forms.Label completeProgressText;
        public System.Windows.Forms.ProgressBar currentProgress;
        public System.Windows.Forms.ProgressBar completeProgress;
        public System.Windows.Forms.Label Status;
        public System.Windows.Forms.Button btjogar;
        public System.Windows.Forms.Button btconta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbstatus;
    }
}

