namespace SuperLong
{
    partial class FrmSuperLong
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
            this.BtnSuperLong = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSuperLong
            // 
            this.BtnSuperLong.Location = new System.Drawing.Point(423, 38);
            this.BtnSuperLong.Name = "BtnSuperLong";
            this.BtnSuperLong.Size = new System.Drawing.Size(170, 42);
            this.BtnSuperLong.TabIndex = 0;
            this.BtnSuperLong.Text = "Super Long Sums";
            this.BtnSuperLong.UseVisualStyleBackColor = true;
            this.BtnSuperLong.Click += new System.EventHandler(this.BtnSuperLong_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(51, 118);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(890, 164);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmSuperLong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 321);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnSuperLong);
            this.Name = "FrmSuperLong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Long Sums Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSuperLong;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

