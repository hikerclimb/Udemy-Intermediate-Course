namespace Assingments
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
            BtnProblem3 = new Button();
            TxtOutput = new TextBox();
            BtnProblem4 = new Button();
            BtnProblem5 = new Button();
            BtnProblem6 = new Button();
            SuspendLayout();
            // 
            // BtnProblem3
            // 
            BtnProblem3.Location = new Point(45, 46);
            BtnProblem3.Name = "BtnProblem3";
            BtnProblem3.Size = new Size(94, 29);
            BtnProblem3.TabIndex = 0;
            BtnProblem3.Text = "Problem3";
            BtnProblem3.UseVisualStyleBackColor = true;
            BtnProblem3.Click += BtnProblem3_Click;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(208, 50);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.ScrollBars = ScrollBars.Vertical;
            TxtOutput.Size = new Size(251, 202);
            TxtOutput.TabIndex = 1;
            // 
            // BtnProblem4
            // 
            BtnProblem4.Location = new Point(46, 106);
            BtnProblem4.Name = "BtnProblem4";
            BtnProblem4.Size = new Size(94, 29);
            BtnProblem4.TabIndex = 2;
            BtnProblem4.Text = "Problem4";
            BtnProblem4.UseVisualStyleBackColor = true;
            BtnProblem4.Click += BtnProblem4_Click;
            // 
            // BtnProblem5
            // 
            BtnProblem5.Location = new Point(46, 157);
            BtnProblem5.Name = "BtnProblem5";
            BtnProblem5.Size = new Size(94, 29);
            BtnProblem5.TabIndex = 3;
            BtnProblem5.Text = "Problem5";
            BtnProblem5.UseVisualStyleBackColor = true;
            BtnProblem5.Click += BtnProblem5_Click;
            // 
            // BtnProblem6
            // 
            BtnProblem6.Location = new Point(46, 207);
            BtnProblem6.Name = "BtnProblem6";
            BtnProblem6.Size = new Size(94, 29);
            BtnProblem6.TabIndex = 4;
            BtnProblem6.Text = "Problem6";
            BtnProblem6.UseVisualStyleBackColor = true;
            BtnProblem6.Click += BtnProblem6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnProblem6);
            Controls.Add(BtnProblem5);
            Controls.Add(BtnProblem4);
            Controls.Add(TxtOutput);
            Controls.Add(BtnProblem3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnProblem3;
        private TextBox TxtOutput;
        private Button BtnProblem4;
        private Button BtnProblem5;
        private Button BtnProblem6;
    }
}