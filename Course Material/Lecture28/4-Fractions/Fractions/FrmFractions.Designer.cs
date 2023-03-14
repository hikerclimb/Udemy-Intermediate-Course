namespace Fractions
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
            this.BtnProblem1 = new System.Windows.Forms.Button();
            this.BtnProblem2 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProblem1
            // 
            this.BtnProblem1.Location = new System.Drawing.Point(170, 40);
            this.BtnProblem1.Name = "BtnProblem1";
            this.BtnProblem1.Size = new System.Drawing.Size(98, 30);
            this.BtnProblem1.TabIndex = 0;
            this.BtnProblem1.Text = "Problem 1";
            this.BtnProblem1.UseVisualStyleBackColor = true;
            this.BtnProblem1.Click += new System.EventHandler(this.BtnProblem1_Click);
            // 
            // BtnProblem2
            // 
            this.BtnProblem2.Location = new System.Drawing.Point(170, 93);
            this.BtnProblem2.Name = "BtnProblem2";
            this.BtnProblem2.Size = new System.Drawing.Size(97, 31);
            this.BtnProblem2.TabIndex = 1;
            this.BtnProblem2.Text = "Problem 2";
            this.BtnProblem2.UseVisualStyleBackColor = true;
            this.BtnProblem2.Click += new System.EventHandler(this.BtnProblem2_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(170, 208);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(93, 31);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmFractions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 262);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnProblem2);
            this.Controls.Add(this.BtnProblem1);
            this.Name = "FrmFractions";
            this.Text = "Fractions Problems (GCD Application)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProblem1;
        private System.Windows.Forms.Button BtnProblem2;
        private System.Windows.Forms.Button BtnExit;
    }
}

