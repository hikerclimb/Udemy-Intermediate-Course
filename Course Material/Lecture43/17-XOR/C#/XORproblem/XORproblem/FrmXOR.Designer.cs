namespace XORproblem
{
    partial class FrmXOR
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
            this.BtnXOR = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnXOR
            // 
            this.BtnXOR.Location = new System.Drawing.Point(490, 62);
            this.BtnXOR.Name = "BtnXOR";
            this.BtnXOR.Size = new System.Drawing.Size(140, 41);
            this.BtnXOR.TabIndex = 0;
            this.BtnXOR.Text = "XOR";
            this.BtnXOR.UseVisualStyleBackColor = true;
            this.BtnXOR.Click += new System.EventHandler(this.BtnXOR_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(64, 155);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(1030, 200);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmXOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 418);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnXOR);
            this.Name = "FrmXOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XOR Cryptography Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnXOR;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

