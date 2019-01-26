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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btjogar = new System.Windows.Forms.Button();
            this.btopcoes = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.currentProgressText = new System.Windows.Forms.Label();
            this.completeProgressText = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbstatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.navegador = new System.Windows.Forms.WebBrowser();
            this.btregistro = new System.Windows.Forms.Button();
            this.btconta = new System.Windows.Forms.Button();
            this.gosite = new System.Windows.Forms.Button();
            this.notificacoes = new System.Windows.Forms.NotifyIcon(this.components);
            this.goforum = new System.Windows.Forms.Button();
            this.currentProgress = new QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx();
            this.completeProgress = new QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx();
            this.SuspendLayout();
            // 
            // btjogar
            // 
            this.btjogar.BackColor = System.Drawing.Color.DarkOrange;
            this.btjogar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btjogar.Enabled = false;
            this.btjogar.FlatAppearance.BorderSize = 0;
            this.btjogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btjogar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btjogar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btjogar.Location = new System.Drawing.Point(15, 54);
            this.btjogar.Name = "btjogar";
            this.btjogar.Size = new System.Drawing.Size(185, 50);
            this.btjogar.TabIndex = 0;
            this.btjogar.Text = "JOGAR";
            this.btjogar.UseVisualStyleBackColor = false;
            this.btjogar.Click += new System.EventHandler(this.btjogar_Click);
            // 
            // btopcoes
            // 
            this.btopcoes.BackColor = System.Drawing.Color.DarkOrange;
            this.btopcoes.FlatAppearance.BorderSize = 0;
            this.btopcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btopcoes.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btopcoes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btopcoes.Location = new System.Drawing.Point(15, 110);
            this.btopcoes.Name = "btopcoes";
            this.btopcoes.Size = new System.Drawing.Size(185, 50);
            this.btopcoes.TabIndex = 2;
            this.btopcoes.Text = "CONFIGURAR";
            this.btopcoes.UseVisualStyleBackColor = false;
            this.btopcoes.Click += new System.EventHandler(this.btopcoes_Click);
            // 
            // btsair
            // 
            this.btsair.BackColor = System.Drawing.Color.DarkOrange;
            this.btsair.FlatAppearance.BorderSize = 0;
            this.btsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsair.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btsair.Location = new System.Drawing.Point(15, 448);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(185, 50);
            this.btsair.TabIndex = 3;
            this.btsair.Text = "SAIR";
            this.btsair.UseVisualStyleBackColor = false;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // currentProgressText
            // 
            this.currentProgressText.AutoSize = true;
            this.currentProgressText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.currentProgressText.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentProgressText.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.currentProgressText.Location = new System.Drawing.Point(799, 551);
            this.currentProgressText.Name = "currentProgressText";
            this.currentProgressText.Size = new System.Drawing.Size(171, 15);
            this.currentProgressText.TabIndex = 12;
            this.currentProgressText.Text = "Progresso parcial: 100%  |  0.00 kb/s";
            // 
            // completeProgressText
            // 
            this.completeProgressText.AutoSize = true;
            this.completeProgressText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.completeProgressText.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeProgressText.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.completeProgressText.Location = new System.Drawing.Point(799, 524);
            this.completeProgressText.Name = "completeProgressText";
            this.completeProgressText.Size = new System.Drawing.Size(96, 15);
            this.completeProgressText.TabIndex = 11;
            this.completeProgressText.Text = "Progresso total: 0%";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Status.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Status.Location = new System.Drawing.Point(14, 572);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(13, 15);
            this.Status.TabIndex = 13;
            this.Status.Text = "...";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(922, 0);
            this.label1.MinimumSize = new System.Drawing.Size(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 30);
            this.label1.TabIndex = 14;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(958, 0);
            this.label2.MinimumSize = new System.Drawing.Size(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 30);
            this.label2.TabIndex = 15;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbstatus.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbstatus.Location = new System.Drawing.Point(341, 572);
            this.lbstatus.MinimumSize = new System.Drawing.Size(300, 0);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(300, 15);
            this.lbstatus.TabIndex = 16;
            this.lbstatus.Text = "Status do Servidor";
            this.lbstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("Impact", 15.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(-2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MinimumSize = new System.Drawing.Size(1000, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1000, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "P R I V A T E     G A M E S     B R A S I L";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // navegador
            // 
            this.navegador.Location = new System.Drawing.Point(212, 54);
            this.navegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.navegador.Name = "navegador";
            this.navegador.ScriptErrorsSuppressed = true;
            this.navegador.ScrollBarsEnabled = false;
            this.navegador.Size = new System.Drawing.Size(776, 444);
            this.navegador.TabIndex = 8;
            this.navegador.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // btregistro
            // 
            this.btregistro.BackColor = System.Drawing.Color.DarkOrange;
            this.btregistro.FlatAppearance.BorderSize = 0;
            this.btregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btregistro.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btregistro.Location = new System.Drawing.Point(15, 166);
            this.btregistro.Name = "btregistro";
            this.btregistro.Size = new System.Drawing.Size(185, 50);
            this.btregistro.TabIndex = 18;
            this.btregistro.Text = "CADASTRE-SE";
            this.btregistro.UseVisualStyleBackColor = false;
            this.btregistro.Click += new System.EventHandler(this.btregistro_Click);
            // 
            // btconta
            // 
            this.btconta.BackColor = System.Drawing.Color.DarkOrange;
            this.btconta.FlatAppearance.BorderSize = 0;
            this.btconta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btconta.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btconta.Location = new System.Drawing.Point(15, 222);
            this.btconta.Name = "btconta";
            this.btconta.Size = new System.Drawing.Size(185, 50);
            this.btconta.TabIndex = 19;
            this.btconta.Text = "ENTRAR";
            this.btconta.UseVisualStyleBackColor = false;
            this.btconta.Click += new System.EventHandler(this.btconta_Click);
            // 
            // gosite
            // 
            this.gosite.BackColor = System.Drawing.Color.DarkOrange;
            this.gosite.FlatAppearance.BorderSize = 0;
            this.gosite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gosite.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gosite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gosite.Location = new System.Drawing.Point(15, 278);
            this.gosite.Name = "gosite";
            this.gosite.Size = new System.Drawing.Size(185, 50);
            this.gosite.TabIndex = 20;
            this.gosite.Text = "PORTAL PGBRASIL";
            this.gosite.UseVisualStyleBackColor = false;
            this.gosite.Click += new System.EventHandler(this.Gosite_Click);
            // 
            // notificacoes
            // 
            this.notificacoes.Text = "notificacoes";
            this.notificacoes.Visible = true;
            // 
            // goforum
            // 
            this.goforum.BackColor = System.Drawing.Color.DarkOrange;
            this.goforum.FlatAppearance.BorderSize = 0;
            this.goforum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goforum.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goforum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goforum.Location = new System.Drawing.Point(15, 334);
            this.goforum.Name = "goforum";
            this.goforum.Size = new System.Drawing.Size(185, 50);
            this.goforum.TabIndex = 21;
            this.goforum.Text = "FORUM PGBRASIL";
            this.goforum.UseVisualStyleBackColor = false;
            this.goforum.Click += new System.EventHandler(this.Goforum_Click);
            // 
            // currentProgress
            // 
            this.currentProgress.BackColor = System.Drawing.Color.Tomato;
            this.currentProgress.ForeColor = System.Drawing.Color.Orange;
            this.currentProgress.Location = new System.Drawing.Point(15, 541);
            this.currentProgress.Margin = new System.Windows.Forms.Padding(0);
            this.currentProgress.Name = "currentProgress";
            this.currentProgress.Size = new System.Drawing.Size(781, 23);
            this.currentProgress.TabIndex = 10;
            this.currentProgress.Value = 100;
            // 
            // completeProgress
            // 
            this.completeProgress.BackColor = System.Drawing.Color.Tomato;
            this.completeProgress.ForeColor = System.Drawing.Color.Orange;
            this.completeProgress.Location = new System.Drawing.Point(15, 514);
            this.completeProgress.Margin = new System.Windows.Forms.Padding(0);
            this.completeProgress.Name = "completeProgress";
            this.completeProgress.Size = new System.Drawing.Size(781, 23);
            this.completeProgress.TabIndex = 10;
            this.completeProgress.Value = 100;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.goforum);
            this.Controls.Add(this.gosite);
            this.Controls.Add(this.btconta);
            this.Controls.Add(this.btregistro);
            this.Controls.Add(this.currentProgress);
            this.Controls.Add(this.completeProgress);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.currentProgressText);
            this.Controls.Add(this.completeProgressText);
            this.Controls.Add(this.navegador);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btopcoes);
            this.Controls.Add(this.btjogar);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Button btopcoes;
        private System.Windows.Forms.Button btsair;
        public System.Windows.Forms.Label currentProgressText;
        public System.Windows.Forms.Label completeProgressText;
        public System.Windows.Forms.Label Status;
        public System.Windows.Forms.Button btjogar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.Label label3;
        public QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx completeProgress;
        public QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx currentProgress;
        private System.Windows.Forms.WebBrowser navegador;
        private System.Windows.Forms.Button btregistro;
        private System.Windows.Forms.Button btconta;
        private System.Windows.Forms.Button gosite;
        private System.Windows.Forms.Button goforum;
        public System.Windows.Forms.NotifyIcon notificacoes;
    }
}

