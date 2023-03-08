namespace ProblemsPartA
{
    partial class FrmGrades
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
            BtnPartA.Location = new Point(139, 83);
            BtnPartA.Name = "BtnPartA";
            BtnPartA.Size = new Size(75, 23);
            BtnPartA.TabIndex = 0;
            BtnPartA.Text = "PartA";
            BtnPartA.UseVisualStyleBackColor = true;
            BtnPartA.Click += BtnPartA_Click;
            // 
            // Output
            // 
            Output.FormattingEnabled = true;
            Output.ItemHeight = 15;
            Output.Location = new Point(311, 87);
            Output.Name = "Output";
            Output.Size = new Size(200, 109);
            Output.TabIndex = 1;
            // 
            // FrmGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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