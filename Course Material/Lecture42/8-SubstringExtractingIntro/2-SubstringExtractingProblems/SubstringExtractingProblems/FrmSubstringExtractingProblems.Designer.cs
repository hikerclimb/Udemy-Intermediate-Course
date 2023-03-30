namespace SubstringExtractingProblems
{
    partial class FrmSubstringExtractingProblems
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
            this.BtnProblem2 = new System.Windows.Forms.Button();
            this.BtnProblem3 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProblem2
            // 
            this.BtnProblem2.Location = new System.Drawing.Point(170, 35);
            this.BtnProblem2.Name = "BtnProblem2";
            this.BtnProblem2.Size = new System.Drawing.Size(94, 31);
            this.BtnProblem2.TabIndex = 0;
            this.BtnProblem2.Text = "Problem 2";
            this.BtnProblem2.UseVisualStyleBackColor = true;
            this.BtnProblem2.Click += new System.EventHandler(this.BtnProblem2_Click);
            // 
            // BtnProblem3
            // 
            this.BtnProblem3.Location = new System.Drawing.Point(171, 100);
            this.BtnProblem3.Name = "BtnProblem3";
            this.BtnProblem3.Size = new System.Drawing.Size(92, 30);
            this.BtnProblem3.TabIndex = 1;
            this.BtnProblem3.Text = "Problem 3";
            this.BtnProblem3.UseVisualStyleBackColor = true;
            this.BtnProblem3.Click += new System.EventHandler(this.BtnProblem3_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(173, 204);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(89, 28);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmSubstringExtractingProblems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 262);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnProblem3);
            this.Controls.Add(this.BtnProblem2);
            this.Name = "FrmSubstringExtractingProblems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Substring Extracting Problems";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProblem2;
        private System.Windows.Forms.Button BtnProblem3;
        private System.Windows.Forms.Button BtnExit;
    }
}

