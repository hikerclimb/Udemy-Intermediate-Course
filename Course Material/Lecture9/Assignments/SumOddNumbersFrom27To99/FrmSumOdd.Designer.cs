namespace SumOddNumbersFrom27To99
{
    partial class FrmSumOdd
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
            BtnSumOdd = new Button();
            SuspendLayout();
            // 
            // BtnSumOdd
            // 
            BtnSumOdd.Location = new Point(267, 92);
            BtnSumOdd.Name = "BtnSumOdd";
            BtnSumOdd.Size = new Size(243, 29);
            BtnSumOdd.TabIndex = 0;
            BtnSumOdd.Text = "Sum odd numbers from 27 to 99";
            BtnSumOdd.UseVisualStyleBackColor = true;
            BtnSumOdd.Click += BtnSumOdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSumOdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSumOdd;
    }
}