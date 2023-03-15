namespace SkatingScoring
{
    partial class FrmSkatingScoring
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
            this.BtnScores = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnScores
            // 
            this.BtnScores.Location = new System.Drawing.Point(184, 53);
            this.BtnScores.Name = "BtnScores";
            this.BtnScores.Size = new System.Drawing.Size(155, 42);
            this.BtnScores.TabIndex = 0;
            this.BtnScores.Text = "Determine Scores";
            this.BtnScores.UseVisualStyleBackColor = true;
            this.BtnScores.Click += new System.EventHandler(this.BtnScores_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(69, 154);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(384, 150);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmSkatingScoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 392);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnScores);
            this.Name = "FrmSkatingScoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skating Scoring Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnScores;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

