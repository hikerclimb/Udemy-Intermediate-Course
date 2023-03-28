namespace NumberProblems
{
    partial class FrmNumberProblems
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
            this.LstDisplay = new System.Windows.Forms.ListBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnProblem5 = new System.Windows.Forms.Button();
            this.BtnProblem6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstDisplay
            // 
            this.LstDisplay.FormattingEnabled = true;
            this.LstDisplay.Location = new System.Drawing.Point(12, 133);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(377, 212);
            this.LstDisplay.TabIndex = 2;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(154, 378);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(89, 28);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnProblem5
            // 
            this.BtnProblem5.Location = new System.Drawing.Point(154, 26);
            this.BtnProblem5.Name = "BtnProblem5";
            this.BtnProblem5.Size = new System.Drawing.Size(91, 29);
            this.BtnProblem5.TabIndex = 4;
            this.BtnProblem5.Text = "Problem 5";
            this.BtnProblem5.UseVisualStyleBackColor = true;
            this.BtnProblem5.Click += new System.EventHandler(this.BtnProblem5_Click);
            // 
            // BtnProblem6
            // 
            this.BtnProblem6.Location = new System.Drawing.Point(154, 62);
            this.BtnProblem6.Name = "BtnProblem6";
            this.BtnProblem6.Size = new System.Drawing.Size(88, 29);
            this.BtnProblem6.TabIndex = 5;
            this.BtnProblem6.Text = "Problem 6";
            this.BtnProblem6.UseVisualStyleBackColor = true;
            this.BtnProblem6.Click += new System.EventHandler(this.BtnProblem6_Click);
            // 
            // FrmNumberProblems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 426);
            this.Controls.Add(this.BtnProblem6);
            this.Controls.Add(this.BtnProblem5);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LstDisplay);
            this.Name = "FrmNumberProblems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Problems";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstDisplay;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnProblem5;
        private System.Windows.Forms.Button BtnProblem6;
    }
}

