namespace DiffOfSquares
{
    partial class FrmDiff
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
            this.BtnDiff = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDiff
            // 
            this.BtnDiff.Location = new System.Drawing.Point(300, 56);
            this.BtnDiff.Name = "BtnDiff";
            this.BtnDiff.Size = new System.Drawing.Size(143, 51);
            this.BtnDiff.TabIndex = 0;
            this.BtnDiff.Text = "Determine Differences of Squares";
            this.BtnDiff.UseVisualStyleBackColor = true;
            this.BtnDiff.Click += new System.EventHandler(this.BtnDiff_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(35, 165);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(704, 248);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnDiff);
            this.Name = "FrmDiff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Difference of Squares Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDiff;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

