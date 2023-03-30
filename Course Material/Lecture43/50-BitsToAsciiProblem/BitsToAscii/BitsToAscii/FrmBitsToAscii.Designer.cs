namespace BitsToAscii
{
    partial class FrmBitsToAscii
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
            this.BtnBits = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnBits
            // 
            this.BtnBits.Location = new System.Drawing.Point(294, 77);
            this.BtnBits.Name = "BtnBits";
            this.BtnBits.Size = new System.Drawing.Size(213, 40);
            this.BtnBits.TabIndex = 0;
            this.BtnBits.Text = "Convert Bits To Ascii";
            this.BtnBits.UseVisualStyleBackColor = true;
            this.BtnBits.Click += new System.EventHandler(this.BtnBits_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(82, 161);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(620, 241);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmBitsToAscii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnBits);
            this.Name = "FrmBitsToAscii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bits To Ascii Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBits;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

