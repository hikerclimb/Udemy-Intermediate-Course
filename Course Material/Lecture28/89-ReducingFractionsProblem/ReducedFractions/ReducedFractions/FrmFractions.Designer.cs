namespace ReducedFractions
{
    partial class FrmFractions
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
            this.BtnFractions = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnFractions
            // 
            this.BtnFractions.Location = new System.Drawing.Point(298, 57);
            this.BtnFractions.Name = "BtnFractions";
            this.BtnFractions.Size = new System.Drawing.Size(194, 49);
            this.BtnFractions.TabIndex = 0;
            this.BtnFractions.Text = "Determine Reduced Fractions";
            this.BtnFractions.UseVisualStyleBackColor = true;
            this.BtnFractions.Click += new System.EventHandler(this.BtnFractions_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(45, 138);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(704, 269);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmFractions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnFractions);
            this.Name = "FrmFractions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reducing Fractions Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFractions;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

