namespace SumOfSquaresBy5
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
            BtnSumOfSquares = new Button();
            SuspendLayout();
            // 
            // BtnSumOfSquares
            // 
            BtnSumOfSquares.Location = new Point(147, 74);
            BtnSumOfSquares.Name = "BtnSumOfSquares";
            BtnSumOfSquares.Size = new Size(169, 29);
            BtnSumOfSquares.TabIndex = 0;
            BtnSumOfSquares.Text = "Sum Of Squares by 5";
            BtnSumOfSquares.UseVisualStyleBackColor = true;
            BtnSumOfSquares.Click += BtnSumOfSquares_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSumOfSquares);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSumOfSquares;
    }
}