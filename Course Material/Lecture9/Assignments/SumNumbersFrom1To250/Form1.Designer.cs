namespace SumNumbersFrom1To250
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
            BtnSum = new Button();
            SuspendLayout();
            // 
            // BtnSum
            // 
            BtnSum.Location = new Point(201, 88);
            BtnSum.Name = "BtnSum";
            BtnSum.Size = new Size(251, 29);
            BtnSum.TabIndex = 0;
            BtnSum.Text = "Sum Numbers from 1 to 250";
            BtnSum.UseVisualStyleBackColor = true;
            BtnSum.Click += BtnSum_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSum;
    }
}