namespace ArmstrongNumbers
{
    partial class FrmArmstrong
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
            this.BtnArmstrong = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnArmstrong
            // 
            this.BtnArmstrong.Location = new System.Drawing.Point(331, 60);
            this.BtnArmstrong.Name = "BtnArmstrong";
            this.BtnArmstrong.Size = new System.Drawing.Size(142, 44);
            this.BtnArmstrong.TabIndex = 0;
            this.BtnArmstrong.Text = "Test for Armstrong Numbers";
            this.BtnArmstrong.UseVisualStyleBackColor = true;
            this.BtnArmstrong.Click += new System.EventHandler(this.BtnArmstrong_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(49, 153);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(715, 260);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmArmstrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnArmstrong);
            this.Name = "FrmArmstrong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Armstrong Number Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnArmstrong;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

