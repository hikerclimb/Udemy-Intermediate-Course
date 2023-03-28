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
            this.BtnIntro = new System.Windows.Forms.Button();
            this.BtnProblem4 = new System.Windows.Forms.Button();
            this.LstDisplay = new System.Windows.Forms.ListBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnIntro
            // 
            this.BtnIntro.Location = new System.Drawing.Point(151, 24);
            this.BtnIntro.Name = "BtnIntro";
            this.BtnIntro.Size = new System.Drawing.Size(92, 30);
            this.BtnIntro.TabIndex = 0;
            this.BtnIntro.Text = "Intro Example";
            this.BtnIntro.UseVisualStyleBackColor = true;
            this.BtnIntro.Click += new System.EventHandler(this.BtnIntro_Click);
            // 
            // BtnProblem4
            // 
            this.BtnProblem4.Location = new System.Drawing.Point(154, 72);
            this.BtnProblem4.Name = "BtnProblem4";
            this.BtnProblem4.Size = new System.Drawing.Size(88, 30);
            this.BtnProblem4.TabIndex = 1;
            this.BtnProblem4.Text = "Problem 4";
            this.BtnProblem4.UseVisualStyleBackColor = true;
            this.BtnProblem4.Click += new System.EventHandler(this.BtnProblem4_Click);
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
            // FrmNumberProblems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 426);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LstDisplay);
            this.Controls.Add(this.BtnProblem4);
            this.Controls.Add(this.BtnIntro);
            this.Name = "FrmNumberProblems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Problems";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnIntro;
        private System.Windows.Forms.Button BtnProblem4;
        private System.Windows.Forms.ListBox LstDisplay;
        private System.Windows.Forms.Button BtnExit;
    }
}

