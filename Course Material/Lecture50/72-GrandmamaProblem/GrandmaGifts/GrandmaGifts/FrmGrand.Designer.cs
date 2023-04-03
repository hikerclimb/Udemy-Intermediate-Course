namespace GrandmaGifts
{
    partial class FrmGrand
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
            this.BtnGrand = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnGrand
            // 
            this.BtnGrand.Location = new System.Drawing.Point(307, 49);
            this.BtnGrand.Name = "BtnGrand";
            this.BtnGrand.Size = new System.Drawing.Size(189, 53);
            this.BtnGrand.TabIndex = 0;
            this.BtnGrand.Text = "Determine Gifts";
            this.BtnGrand.UseVisualStyleBackColor = true;
            this.BtnGrand.Click += new System.EventHandler(this.BtnGrand_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(58, 148);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(658, 259);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmGrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnGrand);
            this.Name = "FrmGrand";
            this.Text = "GrandMama Gifts Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGrand;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

