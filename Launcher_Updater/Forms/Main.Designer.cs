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
            this.currentProgress = new System.Windows.Forms.ProgressBar();
            this.completeProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentProgress
            // 
            this.currentProgress.Location = new System.Drawing.Point(12, 39);
            this.currentProgress.MaximumSize = new System.Drawing.Size(1, 1);
            this.currentProgress.Name = "currentProgress";
            this.currentProgress.Size = new System.Drawing.Size(0, 0);
            this.currentProgress.TabIndex = 10;
            this.currentProgress.Value = 100;
            // 
            // completeProgress
            // 
            this.completeProgress.Location = new System.Drawing.Point(12, 39);
            this.completeProgress.Name = "completeProgress";
            this.completeProgress.Size = new System.Drawing.Size(436, 21);
            this.completeProgress.TabIndex = 9;
            this.completeProgress.Value = 100;
            this.completeProgress.Click += new System.EventHandler(this.completeProgress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mu-DraconicK";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 73);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentProgress);
            this.Controls.Add(this.completeProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ProgressBar currentProgress;
        public System.Windows.Forms.ProgressBar completeProgress;
        private System.Windows.Forms.Label label1;
    }
}

