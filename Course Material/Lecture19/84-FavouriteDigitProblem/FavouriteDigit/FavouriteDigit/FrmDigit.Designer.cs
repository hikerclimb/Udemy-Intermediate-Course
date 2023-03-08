namespace FavouriteDigit
{
    partial class FrmDigit
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
            this.BtnDigit = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDigit
            // 
            this.BtnDigit.Location = new System.Drawing.Point(296, 54);
            this.BtnDigit.Name = "BtnDigit";
            this.BtnDigit.Size = new System.Drawing.Size(164, 41);
            this.BtnDigit.TabIndex = 0;
            this.BtnDigit.Text = "Determine Favourite Digits";
            this.BtnDigit.UseVisualStyleBackColor = true;
            this.BtnDigit.Click += new System.EventHandler(this.BtnDigit_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(43, 153);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(694, 256);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmDigit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnDigit);
            this.Name = "FrmDigit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Favourite Digit Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDigit;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

