namespace RomanNumerals
{
    partial class FrmRoman
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
            this.BtnRoman = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnRoman
            // 
            this.BtnRoman.Location = new System.Drawing.Point(308, 63);
            this.BtnRoman.Name = "BtnRoman";
            this.BtnRoman.Size = new System.Drawing.Size(168, 53);
            this.BtnRoman.TabIndex = 0;
            this.BtnRoman.Text = "Start Conversions";
            this.BtnRoman.UseVisualStyleBackColor = true;
            this.BtnRoman.Click += new System.EventHandler(this.BtnRoman_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(56, 152);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(678, 264);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmRoman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnRoman);
            this.Name = "FrmRoman";
            this.Text = "Roman Numerals Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRoman;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

