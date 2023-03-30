namespace CipherShift
{
    partial class FrmCipherShift
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
            this.BtnShift = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnShift
            // 
            this.BtnShift.Location = new System.Drawing.Point(299, 32);
            this.BtnShift.Name = "BtnShift";
            this.BtnShift.Size = new System.Drawing.Size(185, 41);
            this.BtnShift.TabIndex = 0;
            this.BtnShift.Text = "Encrypt/Decrypt Cipher Shift";
            this.BtnShift.UseVisualStyleBackColor = true;
            this.BtnShift.Click += new System.EventHandler(this.BtnShift_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(41, 124);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(717, 275);
            this.TxtDisplay.TabIndex = 1;           
            // 
            // FrmCipherShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnShift);
            this.Name = "FrmCipherShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Message Cipher Shift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShift;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

