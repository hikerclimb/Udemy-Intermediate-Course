namespace CryptoSquare
{
    partial class FrmCrypto
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
            this.BtnCrypto = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCrypto
            // 
            this.BtnCrypto.Location = new System.Drawing.Point(298, 60);
            this.BtnCrypto.Name = "BtnCrypto";
            this.BtnCrypto.Size = new System.Drawing.Size(177, 39);
            this.BtnCrypto.TabIndex = 0;
            this.BtnCrypto.Text = "Encode Text Using Crypto Square";
            this.BtnCrypto.UseVisualStyleBackColor = true;
            this.BtnCrypto.Click += new System.EventHandler(this.BtnCrypto_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(57, 147);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(679, 259);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmCrypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnCrypto);
            this.Name = "FrmCrypto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto Square Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCrypto;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

