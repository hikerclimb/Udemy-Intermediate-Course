namespace ArmstrongNumbers
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
            BtnArmstrongNumbers = new Button();
            TxtOutpt = new TextBox();
            SuspendLayout();
            // 
            // BtnArmstrongNumbers
            // 
            BtnArmstrongNumbers.Location = new Point(151, 99);
            BtnArmstrongNumbers.Name = "BtnArmstrongNumbers";
            BtnArmstrongNumbers.Size = new Size(255, 29);
            BtnArmstrongNumbers.TabIndex = 0;
            BtnArmstrongNumbers.Text = "ArmstrongNumbers";
            BtnArmstrongNumbers.UseVisualStyleBackColor = true;
            BtnArmstrongNumbers.Click += BtnArmstrongNumbers_Click;
            // 
            // TxtOutpt
            // 
            TxtOutpt.Location = new Point(151, 185);
            TxtOutpt.Multiline = true;
            TxtOutpt.Name = "TxtOutpt";
            TxtOutpt.ScrollBars = ScrollBars.Vertical;
            TxtOutpt.Size = new Size(307, 162);
            TxtOutpt.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtOutpt);
            Controls.Add(BtnArmstrongNumbers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnArmstrongNumbers;
        private TextBox TxtOutpt;
    }
}