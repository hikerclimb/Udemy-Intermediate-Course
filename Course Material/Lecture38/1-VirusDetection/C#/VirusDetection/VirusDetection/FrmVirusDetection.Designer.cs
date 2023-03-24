namespace VirusDetection
{
    partial class FrmVirusDetection
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
            this.BtnVirusDetection = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnVirusDetection
            // 
            this.BtnVirusDetection.Location = new System.Drawing.Point(302, 68);
            this.BtnVirusDetection.Name = "BtnVirusDetection";
            this.BtnVirusDetection.Size = new System.Drawing.Size(143, 37);
            this.BtnVirusDetection.TabIndex = 0;
            this.BtnVirusDetection.Text = "Detect Virus";
            this.BtnVirusDetection.UseVisualStyleBackColor = true;
            this.BtnVirusDetection.Click += new System.EventHandler(this.BtnVirusDetection_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(49, 154);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(665, 220);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmVirusDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 430);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnVirusDetection);
            this.Name = "FrmVirusDetection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virus Detection Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVirusDetection;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

