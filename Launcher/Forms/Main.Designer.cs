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
            this.currentProgress = new QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx();
            this.completeProgress = new QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx();
            this.SuspendLayout();
            // 
            // btjogar
            // 
            this.btjogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btjogar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btjogar.Enabled = false;
            this.btjogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btjogar.Location = new System.Drawing.Point(778, 471);
            this.btjogar.Name = "btjogar";
            this.btjogar.Size = new System.Drawing.Size(130, 80);
            this.btjogar.TabIndex = 0;
            this.btjogar.Text = "Jogar";
            this.btjogar.UseVisualStyleBackColor = false;
            this.btjogar.Click += new System.EventHandler(this.btjogar_Click);
            // 
            // btopcoes
            // 
            this.btopcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btopcoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btopcoes.Location = new System.Drawing.Point(909, 471);
            this.btopcoes.Name = "btopcoes";
            this.btopcoes.Size = new System.Drawing.Size(65, 39);
            this.btopcoes.TabIndex = 2;
            this.btopcoes.Text = "Opções";
            this.btopcoes.UseVisualStyleBackColor = false;
            this.btopcoes.Click += new System.EventHandler(this.btopcoes_Click);
            // 
            // btsair
            // 
            this.btsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btsair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btsair.Location = new System.Drawing.Point(909, 512);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(65, 39);
            this.btsair.TabIndex = 3;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = false;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // currentProgressText
            // 
            this.currentProgressText.AutoSize = true;
            this.currentProgressText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.currentProgressText.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.currentProgressText.Location = new System.Drawing.Point(562, 517);
            this.currentProgressText.Name = "currentProgressText";
            this.currentProgressText.Size = new System.Drawing.Size(180, 13);
            this.currentProgressText.TabIndex = 12;
            this.currentProgressText.Text = "Progresso parcial: 100%  |  0.00 kb/s";
            // 
            // completeProgressText
            // 
            this.completeProgressText.AutoSize = true;
            this.completeProgressText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.completeProgressText.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.completeProgressText.Location = new System.Drawing.Point(562, 484);
            this.completeProgressText.Name = "completeProgressText";
            this.completeProgressText.Size = new System.Drawing.Size(97, 13);
            this.completeProgressText.TabIndex = 11;
            this.completeProgressText.Text = "Progresso total: 0%";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Status.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Status.Location = new System.Drawing.Point(23, 538);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(16, 13);
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
            this.lbstatus.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbstatus.Location = new System.Drawing.Point(350, 538);
            this.lbstatus.MinimumSize = new System.Drawing.Size(300, 0);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(300, 13);
            this.lbstatus.TabIndex = 16;
            this.lbstatus.Text = "Status do Servidor";
            this.lbstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(-2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MinimumSize = new System.Drawing.Size(1000, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1000, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "PRIVATE GAMES BRASIL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // navegador
            // 
            this.navegador.Location = new System.Drawing.Point(24, 54);
            this.navegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.navegador.Name = "navegador";
            this.navegador.ScriptErrorsSuppressed = true;
            this.navegador.ScrollBarsEnabled = false;
            this.navegador.Size = new System.Drawing.Size(950, 400);
            this.navegador.TabIndex = 8;
            this.navegador.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // currentProgress
            // 
            this.currentProgress.BackColor = System.Drawing.Color.Red;
            this.currentProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.currentProgress.Location = new System.Drawing.Point(24, 507);
            this.currentProgress.Margin = new System.Windows.Forms.Padding(0);
            this.currentProgress.Name = "currentProgress";
            this.currentProgress.Size = new System.Drawing.Size(532, 23);
            this.currentProgress.TabIndex = 10;
            this.currentProgress.Value = 100;
            // 
            // completeProgress
            // 
            this.completeProgress.BackColor = System.Drawing.Color.Red;
            this.completeProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.completeProgress.Location = new System.Drawing.Point(24, 480);
            this.completeProgress.Margin = new System.Windows.Forms.Padding(0);
            this.completeProgress.Name = "completeProgress";
            this.completeProgress.Size = new System.Drawing.Size(532, 23);
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
    }
}

