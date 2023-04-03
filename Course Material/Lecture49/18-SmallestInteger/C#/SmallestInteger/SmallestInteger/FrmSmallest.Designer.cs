namespace SmallestInteger
{
    partial class FrmSmallest
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
            this.BtnSmallest = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSmallest
            // 
            this.BtnSmallest.Location = new System.Drawing.Point(252, 39);
            this.BtnSmallest.Name = "BtnSmallest";
            this.BtnSmallest.Size = new System.Drawing.Size(128, 35);
            this.BtnSmallest.TabIndex = 0;
            this.BtnSmallest.Text = "Determine Smallest Integers and Sort";
            this.BtnSmallest.UseVisualStyleBackColor = true;
            this.BtnSmallest.Click += new System.EventHandler(this.BtnSmallest_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(60, 111);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(508, 127);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmSmallest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 331);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnSmallest);
            this.Name = "FrmSmallest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smallest Integer Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSmallest;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

