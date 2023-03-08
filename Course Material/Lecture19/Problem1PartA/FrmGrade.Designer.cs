namespace Problem1PartA
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
            BtnPartA = new Button();
            Output = new ListBox();
            SuspendLayout();
            // 
            // BtnPartA
            // 
            BtnPartA.Location = new Point(90, 58);
            BtnPartA.Name = "BtnPartA";
            BtnPartA.Size = new Size(94, 29);
            BtnPartA.TabIndex = 0;
            BtnPartA.Text = "Part A";
            BtnPartA.UseVisualStyleBackColor = true;
            BtnPartA.Click += BtnPartA_Click;
            // 
            // Output
            // 
            Output.FormattingEnabled = true;
            Output.ItemHeight = 20;
            Output.Location = new Point(327, 64);
            Output.Name = "Output";
            Output.Size = new Size(214, 184);
            Output.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Output);
            Controls.Add(BtnPartA);
            Name = "FrmGrades";
            Text = "FrmGrades";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnPartA;
        private ListBox Output;
    }
}