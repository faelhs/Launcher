namespace Launcher
{
    partial class TrocarSenha
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbnsenha = new System.Windows.Forms.TextBox();
            this.tbrnsenha = new System.Windows.Forms.TextBox();
            this.btenviar = new System.Windows.Forms.Button();
            this.lbresposta = new System.Windows.Forms.Label();
            this.btcancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbsatual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nova Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Re-Nova Senha";
            // 
            // tbnsenha
            // 
            this.tbnsenha.Location = new System.Drawing.Point(13, 65);
            this.tbnsenha.Name = "tbnsenha";
            this.tbnsenha.PasswordChar = '*';
            this.tbnsenha.Size = new System.Drawing.Size(257, 20);
            this.tbnsenha.TabIndex = 3;
            // 
            // tbrnsenha
            // 
            this.tbrnsenha.Location = new System.Drawing.Point(13, 104);
            this.tbrnsenha.Name = "tbrnsenha";
            this.tbrnsenha.PasswordChar = '*';
            this.tbrnsenha.Size = new System.Drawing.Size(257, 20);
            this.tbrnsenha.TabIndex = 4;
            // 
            // btenviar
            // 
            this.btenviar.Location = new System.Drawing.Point(13, 130);
            this.btenviar.Name = "btenviar";
            this.btenviar.Size = new System.Drawing.Size(75, 23);
            this.btenviar.TabIndex = 5;
            this.btenviar.Text = "Enviar";
            this.btenviar.UseVisualStyleBackColor = true;
            this.btenviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbresposta
            // 
            this.lbresposta.AutoSize = true;
            this.lbresposta.Location = new System.Drawing.Point(17, 161);
            this.lbresposta.MinimumSize = new System.Drawing.Size(250, 30);
            this.lbresposta.Name = "lbresposta";
            this.lbresposta.Size = new System.Drawing.Size(250, 30);
            this.lbresposta.TabIndex = 6;
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(195, 130);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(75, 23);
            this.btcancelar.TabIndex = 5;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha atual";
            // 
            // tbsatual
            // 
            this.tbsatual.Location = new System.Drawing.Point(13, 25);
            this.tbsatual.Name = "tbsatual";
            this.tbsatual.PasswordChar = '*';
            this.tbsatual.Size = new System.Drawing.Size(257, 20);
            this.tbsatual.TabIndex = 3;
            // 
            // TrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.lbresposta);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btenviar);
            this.Controls.Add(this.tbrnsenha);
            this.Controls.Add(this.tbsatual);
            this.Controls.Add(this.tbnsenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrocarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrocarSenha";
            this.Load += new System.EventHandler(this.TrocarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbnsenha;
        private System.Windows.Forms.TextBox tbrnsenha;
        private System.Windows.Forms.Button btenviar;
        private System.Windows.Forms.Label lbresposta;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbsatual;
    }
}