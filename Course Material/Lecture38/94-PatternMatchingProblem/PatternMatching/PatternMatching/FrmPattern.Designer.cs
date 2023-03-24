namespace PatternMatching
{
    partial class FrmPattern
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
            this.BtnPattern = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnPattern
            // 
            this.BtnPattern.Location = new System.Drawing.Point(304, 49);
            this.BtnPattern.Name = "BtnPattern";
            this.BtnPattern.Size = new System.Drawing.Size(175, 40);
            this.BtnPattern.TabIndex = 0;
            this.BtnPattern.Text = "Check for Pattern Matches";
            this.BtnPattern.UseVisualStyleBackColor = true;
            this.BtnPattern.Click += new System.EventHandler(this.BtnPattern_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(53, 147);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(691, 257);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnPattern);
            this.Name = "FrmPattern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pattern Matching Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPattern;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

