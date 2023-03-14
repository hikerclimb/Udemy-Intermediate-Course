namespace ToleranceProblems
{
    partial class Tolerance
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
            TxtOutput = new TextBox();
            BtnProblem2 = new Button();
            BtnProblem3 = new Button();
            BtnProblem4 = new Button();
            SuspendLayout();
            // 
            // BtnProblem1
            // 
            BtnProblem1.Location = new Point(194, 44);
            BtnProblem1.Name = "BtnProblem1";
            BtnProblem1.Size = new Size(75, 23);
            BtnProblem1.TabIndex = 0;
            BtnProblem1.Text = "Problem1";
            BtnProblem1.UseVisualStyleBackColor = true;
            BtnProblem1.Click += BtnProblem1_Click;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(91, 170);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.Size = new Size(500, 203);
            TxtOutput.TabIndex = 1;
            // 
            // BtnProblem2
            // 
            BtnProblem2.Location = new Point(194, 87);
            BtnProblem2.Margin = new Padding(3, 2, 3, 2);
            BtnProblem2.Name = "BtnProblem2";
            BtnProblem2.Size = new Size(82, 22);
            BtnProblem2.TabIndex = 2;
            BtnProblem2.Text = "Problem2";
            BtnProblem2.UseVisualStyleBackColor = true;
            BtnProblem2.Click += BtnProblem2_Click;
            // 
            // BtnProblem3
            // 
            BtnProblem3.Location = new Point(307, 46);
            BtnProblem3.Margin = new Padding(3, 2, 3, 2);
            BtnProblem3.Name = "BtnProblem3";
            BtnProblem3.Size = new Size(82, 22);
            BtnProblem3.TabIndex = 3;
            BtnProblem3.Text = "Problem3";
            BtnProblem3.UseVisualStyleBackColor = true;
            BtnProblem3.Click += BtnProblem3_Click;
            // 
            // BtnProblem4
            // 
            BtnProblem4.Location = new Point(314, 87);
            BtnProblem4.Name = "BtnProblem4";
            BtnProblem4.Size = new Size(75, 23);
            BtnProblem4.TabIndex = 4;
            BtnProblem4.Text = "Problem4";
            BtnProblem4.UseVisualStyleBackColor = true;
            BtnProblem4.Click += BtnProblem4_Click;
            // 
            // Tolerance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnProblem4);
            Controls.Add(BtnProblem3);
            Controls.Add(BtnProblem2);
            Controls.Add(TxtOutput);
            Controls.Add(BtnProblem1);
            Name = "Tolerance";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnProblem1;
        private TextBox TxtOutput;
        private Button BtnProblem2;
        private Button BtnProblem3;
        private Button BtnProblem4;
    }
}