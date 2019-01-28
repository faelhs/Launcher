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
            this.label1 = new System.Windows.Forms.Label();
            this.completeProgress = new QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.MinimumSize = new System.Drawing.Size(460, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Loading...";
            // 
            // completeProgress
            // 
            this.completeProgress.BackColor = System.Drawing.Color.DarkOrange;
            this.completeProgress.ForeColor = System.Drawing.Color.Orange;
            this.completeProgress.Location = new System.Drawing.Point(0, 36);
            this.completeProgress.Name = "completeProgress";
            this.completeProgress.Size = new System.Drawing.Size(460, 30);
            this.completeProgress.TabIndex = 10;
            this.completeProgress.Value = 100;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(460, 75);
            this.ControlBox = false;
            this.Controls.Add(this.completeProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentProgress);
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
        private System.Windows.Forms.Label label1;
        public QuantumConcepts.Common.Forms.UI.Controls.ProgressBarEx completeProgress;
    }
}

