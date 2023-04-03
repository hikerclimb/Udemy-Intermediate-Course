namespace Problem2
{
    partial class FrmProblem2
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
            SuspendLayout();
            // 
            // BtnProblem2
            // 
            BtnProblem2.Location = new Point(91, 86);
            BtnProblem2.Name = "BtnProblem2";
            BtnProblem2.Size = new Size(75, 23);
            BtnProblem2.TabIndex = 0;
            BtnProblem2.Text = "Problem2";
            BtnProblem2.UseVisualStyleBackColor = true;
            BtnProblem2.Click += BtnProblem2_Click;
            // 
            // FrmProblem2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnProblem2);
            Name = "FrmProblem2";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnProblem2;
    }
}