namespace OneTimePad
{
    partial class FrmOneTimePad
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
            this.BtnOneTimePad = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOneTimePad
            // 
            this.BtnOneTimePad.Location = new System.Drawing.Point(314, 47);
            this.BtnOneTimePad.Name = "BtnOneTimePad";
            this.BtnOneTimePad.Size = new System.Drawing.Size(158, 36);
            this.BtnOneTimePad.TabIndex = 0;
            this.BtnOneTimePad.Text = "Decrypt Using One Time Pad";
            this.BtnOneTimePad.UseVisualStyleBackColor = true;
            this.BtnOneTimePad.Click += new System.EventHandler(this.BtnOneTimePad_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay.Location = new System.Drawing.Point(74, 141);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(656, 267);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmOneTimePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnOneTimePad);
            this.Name = "FrmOneTimePad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Time Pad Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOneTimePad;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

