namespace Lecture45
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
            BtnProblem1 = new Button();
            TxtOutput = new TextBox();
            SuspendLayout();
            // 
            // BtnProblem1
            // 
            BtnProblem1.Location = new Point(67, 62);
            BtnProblem1.Name = "BtnProblem1";
            BtnProblem1.Size = new Size(94, 29);
            BtnProblem1.TabIndex = 0;
            BtnProblem1.Text = "Problem1";
            BtnProblem1.UseVisualStyleBackColor = true;
            BtnProblem1.Click += BtnProblem1_Click;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(197, 62);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.Size = new Size(190, 99);
            TxtOutput.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtOutput);
            Controls.Add(BtnProblem1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnProblem1;
        private TextBox TxtOutput;
    }
}