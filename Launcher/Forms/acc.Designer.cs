namespace Launcher
{
    partial class Acc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acc));
            this.btenviar = new System.Windows.Forms.Button();
            this.btrecuperar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tblogin = new System.Windows.Forms.TextBox();
            this.tbsenha = new System.Windows.Forms.TextBox();
            this.lbresposta = new System.Windows.Forms.Label();
            this.cksalvar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btenviar
            // 
            this.btenviar.Location = new System.Drawing.Point(15, 117);
            this.btenviar.Name = "btenviar";
            this.btenviar.Size = new System.Drawing.Size(138, 40);
            this.btenviar.TabIndex = 0;
            this.btenviar.Text = "Login";
            this.btenviar.UseVisualStyleBackColor = true;
            this.btenviar.Click += new System.EventHandler(this.btmudarsenha_Click);
            // 
            // btrecuperar
            // 
            this.btrecuperar.Location = new System.Drawing.Point(15, 163);
            this.btrecuperar.Name = "btrecuperar";
            this.btrecuperar.Size = new System.Drawing.Size(138, 40);
            this.btrecuperar.TabIndex = 1;
            this.btrecuperar.Text = "Recuperar Senha";
            this.btrecuperar.UseVisualStyleBackColor = true;
            this.btrecuperar.Click += new System.EventHandler(this.btrecuperar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // tblogin
            // 
            this.tblogin.Location = new System.Drawing.Point(15, 27);
            this.tblogin.MaxLength = 10;
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(138, 20);
            this.tblogin.TabIndex = 5;
            // 
            // tbsenha
            // 
            this.tbsenha.Location = new System.Drawing.Point(15, 66);
            this.tbsenha.MaxLength = 10;
            this.tbsenha.Name = "tbsenha";
            this.tbsenha.PasswordChar = '*';
            this.tbsenha.Size = new System.Drawing.Size(138, 20);
            this.tbsenha.TabIndex = 5;
            // 
            // lbresposta
            // 
            this.lbresposta.AutoSize = true;
            this.lbresposta.Location = new System.Drawing.Point(14, 211);
            this.lbresposta.MaximumSize = new System.Drawing.Size(138, 20);
            this.lbresposta.MinimumSize = new System.Drawing.Size(138, 20);
            this.lbresposta.Name = "lbresposta";
            this.lbresposta.Size = new System.Drawing.Size(138, 20);
            this.lbresposta.TabIndex = 6;
            // 
            // cksalvar
            // 
            this.cksalvar.AutoSize = true;
            this.cksalvar.Location = new System.Drawing.Point(15, 94);
            this.cksalvar.Name = "cksalvar";
            this.cksalvar.Size = new System.Drawing.Size(62, 17);
            this.cksalvar.TabIndex = 7;
            this.cksalvar.Text = "Salvar?";
            this.cksalvar.UseVisualStyleBackColor = true;
            // 
            // Acc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 250);
            this.ControlBox = false;
            this.Controls.Add(this.cksalvar);
            this.Controls.Add(this.tblogin);
            this.Controls.Add(this.tbsenha);
            this.Controls.Add(this.lbresposta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btrecuperar);
            this.Controls.Add(this.btenviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Acc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "acc";
            this.Load += new System.EventHandler(this.Acc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btenviar;
        private System.Windows.Forms.Button btrecuperar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tblogin;
        private System.Windows.Forms.TextBox tbsenha;
        private System.Windows.Forms.Label lbresposta;
        private System.Windows.Forms.CheckBox cksalvar;
    }
}