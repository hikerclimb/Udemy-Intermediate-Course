namespace Lecture44
{
    partial class Form1
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
            BtnProblem2 = new Button();
            BtnProblem3 = new Button();
            BtnProblem4 = new Button();
            SuspendLayout();
            // 
            // BtnProblem2
            // 
            BtnProblem2.Location = new Point(47, 77);
            BtnProblem2.Name = "BtnProblem2";
            BtnProblem2.Size = new Size(94, 29);
            BtnProblem2.TabIndex = 0;
            BtnProblem2.Text = "Problem2";
            BtnProblem2.UseVisualStyleBackColor = true;
            BtnProblem2.Click += BtnProblem2_Click;
            // 
            // BtnProblem3
            // 
            BtnProblem3.Location = new Point(47, 137);
            BtnProblem3.Name = "BtnProblem3";
            BtnProblem3.Size = new Size(94, 29);
            BtnProblem3.TabIndex = 1;
            BtnProblem3.Text = "Problem3";
            BtnProblem3.UseVisualStyleBackColor = true;
            BtnProblem3.Click += BtnProblem3_Click;
            // 
            // BtnProblem4
            // 
            BtnProblem4.Location = new Point(47, 193);
            BtnProblem4.Name = "BtnProblem4";
            BtnProblem4.Size = new Size(94, 28);
            BtnProblem4.TabIndex = 2;
            BtnProblem4.Text = "Problem4";
            BtnProblem4.UseVisualStyleBackColor = true;
            BtnProblem4.Click += BtnProblem4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnProblem4);
            Controls.Add(BtnProblem3);
            Controls.Add(BtnProblem2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnProblem2;
        private Button BtnProblem3;
        private Button BtnProblem4;
    }
}