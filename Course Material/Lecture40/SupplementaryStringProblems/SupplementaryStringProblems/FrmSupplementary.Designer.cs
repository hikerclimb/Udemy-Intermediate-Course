namespace SupplementaryStringProblems
{
    partial class FrmSupplementary
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
            this.BtnMax = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnArmstrong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMax
            // 
            this.BtnMax.Location = new System.Drawing.Point(133, 31);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(126, 37);
            this.BtnMax.TabIndex = 0;
            this.BtnMax.Text = "Max Characters";
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(78, 173);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(274, 142);
            this.TxtDisplay.TabIndex = 1;
            // 
            // BtnArmstrong
            // 
            this.BtnArmstrong.Location = new System.Drawing.Point(131, 87);
            this.BtnArmstrong.Name = "BtnArmstrong";
            this.BtnArmstrong.Size = new System.Drawing.Size(127, 44);
            this.BtnArmstrong.TabIndex = 2;
            this.BtnArmstrong.Text = "Armstrong Numbers";
            this.BtnArmstrong.UseVisualStyleBackColor = true;
            this.BtnArmstrong.Click += new System.EventHandler(this.BtnArmstrong_Click);
            // 
            // FrmSupplementary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 348);
            this.Controls.Add(this.BtnArmstrong);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnMax);
            this.Name = "FrmSupplementary";
            this.Text = "Supplementary String Problems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnArmstrong;
    }
}

