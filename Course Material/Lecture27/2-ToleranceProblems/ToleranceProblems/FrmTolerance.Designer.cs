namespace ToleranceProblems
{
    partial class FrmTolerance
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
            this.BtnProblem3 = new System.Windows.Forms.Button();
            this.BtnProblem4 = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProblem1
            // 
            this.BtnProblem1.Location = new System.Drawing.Point(161, 13);
            this.BtnProblem1.Name = "BtnProblem1";
            this.BtnProblem1.Size = new System.Drawing.Size(93, 30);
            this.BtnProblem1.TabIndex = 0;
            this.BtnProblem1.Text = "Problem 1";
            this.BtnProblem1.UseVisualStyleBackColor = true;
            this.BtnProblem1.Click += new System.EventHandler(this.BtnProblem1_Click);
            // 
            // BtnProblem2
            // 
            this.BtnProblem2.Location = new System.Drawing.Point(161, 60);
            this.BtnProblem2.Name = "BtnProblem2";
            this.BtnProblem2.Size = new System.Drawing.Size(92, 31);
            this.BtnProblem2.TabIndex = 1;
            this.BtnProblem2.Text = "Problem 2";
            this.BtnProblem2.UseVisualStyleBackColor = true;
            this.BtnProblem2.Click += new System.EventHandler(this.BtnProblem2_Click);
            // 
            // BtnProblem3
            // 
            this.BtnProblem3.Location = new System.Drawing.Point(161, 110);
            this.BtnProblem3.Name = "BtnProblem3";
            this.BtnProblem3.Size = new System.Drawing.Size(93, 29);
            this.BtnProblem3.TabIndex = 2;
            this.BtnProblem3.Text = "Problem 3";
            this.BtnProblem3.UseVisualStyleBackColor = true;
            this.BtnProblem3.Click += new System.EventHandler(this.BtnProblem3_Click);
            // 
            // BtnProblem4
            // 
            this.BtnProblem4.Location = new System.Drawing.Point(161, 161);
            this.BtnProblem4.Name = "BtnProblem4";
            this.BtnProblem4.Size = new System.Drawing.Size(93, 30);
            this.BtnProblem4.TabIndex = 3;
            this.BtnProblem4.Text = "Problem 4";
            this.BtnProblem4.UseVisualStyleBackColor = true;
            this.BtnProblem4.Click += new System.EventHandler(this.BtnProblem4_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(57, 243);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(330, 182);
            this.TxtDisplay.TabIndex = 4;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(175, 450);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(68, 27);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmTolerance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 502);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnProblem4);
            this.Controls.Add(this.BtnProblem3);
            this.Controls.Add(this.BtnProblem2);
            this.Controls.Add(this.BtnProblem1);
            this.Name = "FrmTolerance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tolerance Problems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProblem1;
        private System.Windows.Forms.Button BtnProblem2;
        private System.Windows.Forms.Button BtnProblem3;
        private System.Windows.Forms.Button BtnProblem4;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnExit;
    }
}

