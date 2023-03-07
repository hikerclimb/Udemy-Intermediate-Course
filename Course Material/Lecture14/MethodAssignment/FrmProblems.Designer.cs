namespace MethodAssignment
{
    partial class FrmProblems
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnProblem1 = new Button();
            BtnProblem2 = new Button();
            BtnProblem3 = new Button();
            BtnProblem4 = new Button();
            BtnProblem5 = new Button();
            SuspendLayout();
            // 
            // BtnProblem1
            // 
            BtnProblem1.Location = new Point(187, 72);
            BtnProblem1.Name = "BtnProblem1";
            BtnProblem1.Size = new Size(94, 29);
            BtnProblem1.TabIndex = 0;
            BtnProblem1.Text = "Problem1";
            BtnProblem1.UseVisualStyleBackColor = true;
            BtnProblem1.Click += BtnProblem1_Click;
            // 
            // BtnProblem2
            // 
            BtnProblem2.Location = new Point(191, 133);
            BtnProblem2.Name = "BtnProblem2";
            BtnProblem2.Size = new Size(94, 29);
            BtnProblem2.TabIndex = 1;
            BtnProblem2.Text = "Problem2";
            BtnProblem2.UseVisualStyleBackColor = true;
            BtnProblem2.Click += BtnProblem2_Click;
            // 
            // BtnProblem3
            // 
            BtnProblem3.Location = new Point(194, 189);
            BtnProblem3.Name = "BtnProblem3";
            BtnProblem3.Size = new Size(94, 29);
            BtnProblem3.TabIndex = 2;
            BtnProblem3.Text = "Problem3";
            BtnProblem3.UseVisualStyleBackColor = true;
            BtnProblem3.Click += BtnProblem3_Click;
            // 
            // BtnProblem4
            // 
            BtnProblem4.Location = new Point(194, 243);
            BtnProblem4.Name = "BtnProblem4";
            BtnProblem4.Size = new Size(94, 29);
            BtnProblem4.TabIndex = 3;
            BtnProblem4.Text = "Problem4";
            BtnProblem4.UseVisualStyleBackColor = true;
            BtnProblem4.Click += BtnProblem4_Click;
            // 
            // BtnProblem5
            // 
            BtnProblem5.Location = new Point(200, 292);
            BtnProblem5.Name = "BtnProblem5";
            BtnProblem5.Size = new Size(94, 29);
            BtnProblem5.TabIndex = 4;
            BtnProblem5.Text = "Problem5";
            BtnProblem5.UseVisualStyleBackColor = true;
            BtnProblem5.Click += BtnProblem5_Click;
            // 
            // FrmProblems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnProblem5);
            Controls.Add(BtnProblem4);
            Controls.Add(BtnProblem3);
            Controls.Add(BtnProblem2);
            Controls.Add(BtnProblem1);
            Name = "FrmProblems";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnProblem1;
        private Button BtnProblem2;
        private Button BtnProblem3;
        private Button BtnProblem4;
        private Button BtnProblem5;
    }
}