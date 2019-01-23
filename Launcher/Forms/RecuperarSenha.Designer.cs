namespace Launcher
{
    partial class RecuperarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarSenha));
            this.label1 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.btenviar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.lbresposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(21, 34);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(251, 20);
            this.tbemail.TabIndex = 1;
            // 
            // btenviar
            // 
            this.btenviar.Location = new System.Drawing.Point(21, 70);
            this.btenviar.Name = "btenviar";
            this.btenviar.Size = new System.Drawing.Size(75, 23);
            this.btenviar.TabIndex = 2;
            this.btenviar.Text = "Enviar";
            this.btenviar.UseVisualStyleBackColor = true;
            this.btenviar.Click += new System.EventHandler(this.btenviar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(197, 70);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(75, 23);
            this.btcancelar.TabIndex = 3;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // lbresposta
            // 
            this.lbresposta.AutoSize = true;
            this.lbresposta.Location = new System.Drawing.Point(21, 101);
            this.lbresposta.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbresposta.MinimumSize = new System.Drawing.Size(245, 50);
            this.lbresposta.Name = "lbresposta";
            this.lbresposta.Size = new System.Drawing.Size(245, 50);
            this.lbresposta.TabIndex = 4;
            // 
            // RecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 170);
            this.ControlBox = false;
            this.Controls.Add(this.lbresposta);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btenviar);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecuperarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Button btenviar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Label lbresposta;
    }
}