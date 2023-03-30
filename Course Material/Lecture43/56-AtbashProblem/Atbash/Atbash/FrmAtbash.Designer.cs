namespace Atbash
{
    partial class FrmAtbash
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
            this.BtnCipher = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCipher
            // 
            this.BtnCipher.Location = new System.Drawing.Point(287, 51);
            this.BtnCipher.Name = "BtnCipher";
            this.BtnCipher.Size = new System.Drawing.Size(165, 46);
            this.BtnCipher.TabIndex = 0;
            this.BtnCipher.Text = "Create Atbash Cipher Text";
            this.BtnCipher.UseVisualStyleBackColor = true;
            this.BtnCipher.Click += new System.EventHandler(this.BtnCipher_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(63, 139);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(660, 263);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmAtbash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnCipher);
            this.Name = "FrmAtbash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atbash Cipher Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCipher;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

