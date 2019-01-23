namespace Launcher
{
    partial class Opcoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opcoes));
            this.lbtitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckefeitos = new System.Windows.Forms.CheckBox();
            this.ckmusica = new System.Windows.Forms.CheckBox();
            this.rdres1 = new System.Windows.Forms.RadioButton();
            this.rdres2 = new System.Windows.Forms.RadioButton();
            this.rdres3 = new System.Windows.Forms.RadioButton();
            this.rdres4 = new System.Windows.Forms.RadioButton();
            this.btaplicar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ckjanela = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lbtitulo.Location = new System.Drawing.Point(5, 10);
            this.lbtitulo.MinimumSize = new System.Drawing.Size(220, 20);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(220, 25);
            this.lbtitulo.TabIndex = 0;
            this.lbtitulo.Text = "Opções";
            this.lbtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // tblogin
            // 
            this.tblogin.Location = new System.Drawing.Point(51, 53);
            this.tblogin.MaxLength = 10;
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(167, 20);
            this.tblogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resolução:";
            // 
            // ckefeitos
            // 
            this.ckefeitos.AutoSize = true;
            this.ckefeitos.Location = new System.Drawing.Point(15, 201);
            this.ckefeitos.Name = "ckefeitos";
            this.ckefeitos.Size = new System.Drawing.Size(58, 17);
            this.ckefeitos.TabIndex = 4;
            this.ckefeitos.Text = "Efeitos";
            this.ckefeitos.UseVisualStyleBackColor = true;
            // 
            // ckmusica
            // 
            this.ckmusica.AutoSize = true;
            this.ckmusica.Location = new System.Drawing.Point(140, 201);
            this.ckmusica.Name = "ckmusica";
            this.ckmusica.Size = new System.Drawing.Size(60, 17);
            this.ckmusica.TabIndex = 5;
            this.ckmusica.Text = "Musica";
            this.ckmusica.UseVisualStyleBackColor = true;
            // 
            // rdres1
            // 
            this.rdres1.AutoSize = true;
            this.rdres1.Location = new System.Drawing.Point(15, 121);
            this.rdres1.Name = "rdres1";
            this.rdres1.Size = new System.Drawing.Size(66, 17);
            this.rdres1.TabIndex = 6;
            this.rdres1.TabStop = true;
            this.rdres1.Text = "640x480";
            this.rdres1.UseVisualStyleBackColor = true;
            // 
            // rdres2
            // 
            this.rdres2.AutoSize = true;
            this.rdres2.Location = new System.Drawing.Point(140, 121);
            this.rdres2.Name = "rdres2";
            this.rdres2.Size = new System.Drawing.Size(66, 17);
            this.rdres2.TabIndex = 7;
            this.rdres2.TabStop = true;
            this.rdres2.Text = "800x600";
            this.rdres2.UseVisualStyleBackColor = true;
            // 
            // rdres3
            // 
            this.rdres3.AutoSize = true;
            this.rdres3.Location = new System.Drawing.Point(15, 144);
            this.rdres3.Name = "rdres3";
            this.rdres3.Size = new System.Drawing.Size(72, 17);
            this.rdres3.TabIndex = 8;
            this.rdres3.TabStop = true;
            this.rdres3.Text = "1024x768";
            this.rdres3.UseVisualStyleBackColor = true;
            // 
            // rdres4
            // 
            this.rdres4.AutoSize = true;
            this.rdres4.Location = new System.Drawing.Point(140, 144);
            this.rdres4.Name = "rdres4";
            this.rdres4.Size = new System.Drawing.Size(78, 17);
            this.rdres4.TabIndex = 9;
            this.rdres4.TabStop = true;
            this.rdres4.Text = "1280x1024";
            this.rdres4.UseVisualStyleBackColor = true;
            // 
            // btaplicar
            // 
            this.btaplicar.Location = new System.Drawing.Point(30, 258);
            this.btaplicar.Name = "btaplicar";
            this.btaplicar.Size = new System.Drawing.Size(80, 30);
            this.btaplicar.TabIndex = 10;
            this.btaplicar.Text = "Aplicar";
            this.btaplicar.UseVisualStyleBackColor = true;
            this.btaplicar.Click += new System.EventHandler(this.btaplicar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(120, 258);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(80, 30);
            this.btcancelar.TabIndex = 10;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sons:";
            // 
            // ckjanela
            // 
            this.ckjanela.AutoSize = true;
            this.ckjanela.Location = new System.Drawing.Point(15, 224);
            this.ckjanela.Name = "ckjanela";
            this.ckjanela.Size = new System.Drawing.Size(87, 17);
            this.ckjanela.TabIndex = 12;
            this.ckjanela.Text = "Modo Janela";
            this.ckjanela.UseVisualStyleBackColor = true;
            // 
            // Opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 306);
            this.ControlBox = false;
            this.Controls.Add(this.ckjanela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btaplicar);
            this.Controls.Add(this.rdres4);
            this.Controls.Add(this.rdres3);
            this.Controls.Add(this.rdres2);
            this.Controls.Add(this.rdres1);
            this.Controls.Add(this.ckmusica);
            this.Controls.Add(this.ckefeitos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tblogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbtitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Opcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Opcoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tblogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckefeitos;
        private System.Windows.Forms.CheckBox ckmusica;
        private System.Windows.Forms.RadioButton rdres1;
        private System.Windows.Forms.RadioButton rdres2;
        private System.Windows.Forms.RadioButton rdres3;
        private System.Windows.Forms.RadioButton rdres4;
        private System.Windows.Forms.Button btaplicar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckjanela;
    }
}