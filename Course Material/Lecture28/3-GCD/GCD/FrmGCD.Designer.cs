namespace GCD
{
    partial class FrmGCD
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
            this.BtnGCDTwo = new System.Windows.Forms.Button();
            this.BtnGCDThree = new System.Windows.Forms.Button();
            this.BtnLCM = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGCDTwo
            // 
            this.BtnGCDTwo.Location = new System.Drawing.Point(130, 29);
            this.BtnGCDTwo.Name = "BtnGCDTwo";
            this.BtnGCDTwo.Size = new System.Drawing.Size(130, 27);
            this.BtnGCDTwo.TabIndex = 0;
            this.BtnGCDTwo.Text = "GCD of Two Numbers";
            this.BtnGCDTwo.UseVisualStyleBackColor = true;
            this.BtnGCDTwo.Click += new System.EventHandler(this.BtnGCDTwo_Click);
            // 
            // BtnGCDThree
            // 
            this.BtnGCDThree.Location = new System.Drawing.Point(131, 83);
            this.BtnGCDThree.Name = "BtnGCDThree";
            this.BtnGCDThree.Size = new System.Drawing.Size(129, 27);
            this.BtnGCDThree.TabIndex = 1;
            this.BtnGCDThree.Text = "GCD of Three Numbers";
            this.BtnGCDThree.UseVisualStyleBackColor = true;
            this.BtnGCDThree.Click += new System.EventHandler(this.BtnGCDThree_Click);
            // 
            // BtnLCM
            // 
            this.BtnLCM.Location = new System.Drawing.Point(133, 138);
            this.BtnLCM.Name = "BtnLCM";
            this.BtnLCM.Size = new System.Drawing.Size(127, 27);
            this.BtnLCM.TabIndex = 2;
            this.BtnLCM.Text = "LCM Of Two Numbers";
            this.BtnLCM.UseVisualStyleBackColor = true;
            this.BtnLCM.Click += new System.EventHandler(this.BtnLCM_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(155, 214);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(71, 25);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmGCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 262);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLCM);
            this.Controls.Add(this.BtnGCDThree);
            this.Controls.Add(this.BtnGCDTwo);
            this.Name = "FrmGCD";
            this.Text = "Greatest Common Divisor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGCDTwo;
        private System.Windows.Forms.Button BtnGCDThree;
        private System.Windows.Forms.Button BtnLCM;
        private System.Windows.Forms.Button BtnExit;
    }
}

