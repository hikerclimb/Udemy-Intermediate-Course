namespace Passwords
{
    partial class FrmPasswords
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
            this.BtnPasswords = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnPasswords
            // 
            this.BtnPasswords.Location = new System.Drawing.Point(184, 42);
            this.BtnPasswords.Name = "BtnPasswords";
            this.BtnPasswords.Size = new System.Drawing.Size(125, 33);
            this.BtnPasswords.TabIndex = 0;
            this.BtnPasswords.Text = "Password Strength";
            this.BtnPasswords.UseVisualStyleBackColor = true;
            this.BtnPasswords.Click += new System.EventHandler(this.BtnPasswords_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(56, 121);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(417, 122);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 307);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnPasswords);
            this.Name = "FrmPasswords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passwords Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPasswords;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

