namespace Diff
{
    partial class FrmDiff
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
            this.BtnDiff = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDiff
            // 
            this.BtnDiff.Location = new System.Drawing.Point(157, 54);
            this.BtnDiff.Name = "BtnDiff";
            this.BtnDiff.Size = new System.Drawing.Size(143, 43);
            this.BtnDiff.TabIndex = 0;
            this.BtnDiff.Text = "Determine Diff";
            this.BtnDiff.UseVisualStyleBackColor = true;
            this.BtnDiff.Click += new System.EventHandler(this.BtnDiff_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(70, 155);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(318, 190);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 427);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnDiff);
            this.Name = "FrmDiff";
            this.Text = "Diff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDiff;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

