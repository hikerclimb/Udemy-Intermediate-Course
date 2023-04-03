namespace MoneyPrize
{
    partial class FrmMoneyPrize
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
            this.BtnMoneyPrize = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnMoneyPrize
            // 
            this.BtnMoneyPrize.Location = new System.Drawing.Point(251, 71);
            this.BtnMoneyPrize.Name = "BtnMoneyPrize";
            this.BtnMoneyPrize.Size = new System.Drawing.Size(130, 35);
            this.BtnMoneyPrize.TabIndex = 0;
            this.BtnMoneyPrize.Text = "Determine Money Prize";
            this.BtnMoneyPrize.UseVisualStyleBackColor = true;
            this.BtnMoneyPrize.Click += new System.EventHandler(this.BtnMoneyPrize_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(61, 144);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(518, 251);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmMoneyPrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 432);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnMoneyPrize);
            this.Name = "FrmMoneyPrize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Prize Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMoneyPrize;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

