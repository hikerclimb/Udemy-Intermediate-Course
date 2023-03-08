namespace PriceDecline
{
    partial class FrmPrice
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
            this.BtnPrice = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnPrice
            // 
            this.BtnPrice.Location = new System.Drawing.Point(142, 37);
            this.BtnPrice.Name = "BtnPrice";
            this.BtnPrice.Size = new System.Drawing.Size(146, 36);
            this.BtnPrice.TabIndex = 0;
            this.BtnPrice.Text = "Determine Price Decline";
            this.BtnPrice.UseVisualStyleBackColor = true;
            this.BtnPrice.Click += new System.EventHandler(this.BtnPrice_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(45, 110);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(355, 245);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 397);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnPrice);
            this.Name = "FrmPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price Decline Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPrice;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

