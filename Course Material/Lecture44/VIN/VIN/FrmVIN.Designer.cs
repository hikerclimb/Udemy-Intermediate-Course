namespace VIN
{
    partial class FrmVIN
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
            this.BtnVIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVIN
            // 
            this.BtnVIN.Location = new System.Drawing.Point(83, 85);
            this.BtnVIN.Name = "BtnVIN";
            this.BtnVIN.Size = new System.Drawing.Size(114, 44);
            this.BtnVIN.TabIndex = 0;
            this.BtnVIN.Text = "Determine VIN Check Digit";
            this.BtnVIN.UseVisualStyleBackColor = true;
            this.BtnVIN.Click += new System.EventHandler(this.BtnVIN_Click);
            // 
            // FrmVIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.BtnVIN);
            this.Name = "FrmVIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVIN;
    }
}

