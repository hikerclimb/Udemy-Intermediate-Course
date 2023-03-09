namespace Flipper
{
    partial class FrmFlipper
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
            this.BtnFlipper = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnFlipper
            // 
            this.BtnFlipper.Location = new System.Drawing.Point(296, 46);
            this.BtnFlipper.Name = "BtnFlipper";
            this.BtnFlipper.Size = new System.Drawing.Size(176, 41);
            this.BtnFlipper.TabIndex = 0;
            this.BtnFlipper.Text = "Determine Flip Orientation";
            this.BtnFlipper.UseVisualStyleBackColor = true;
            this.BtnFlipper.Click += new System.EventHandler(this.BtnFlipper_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(63, 130);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(673, 272);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmFlipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnFlipper);
            this.Name = "FrmFlipper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flipper Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFlipper;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

