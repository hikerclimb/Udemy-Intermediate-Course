namespace CalculatePay
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
            btnCalculatePay = new Button();
            SuspendLayout();
            // 
            // btnCalculatePay
            // 
            btnCalculatePay.Location = new Point(186, 97);
            btnCalculatePay.Name = "btnCalculatePay";
            btnCalculatePay.Size = new Size(199, 29);
            btnCalculatePay.TabIndex = 0;
            btnCalculatePay.Text = "Calculate Pay";
            btnCalculatePay.UseVisualStyleBackColor = true;
            btnCalculatePay.Click += btnCalculatePay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculatePay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalculatePay;
    }
}