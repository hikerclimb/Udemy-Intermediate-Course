namespace Assignment2
{
    partial class Assignment2
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
            BtnSubmit = new Button();
            TxtOutput = new TextBox();
            SuspendLayout();
            // 
            // BtnSubmit
            // 
            BtnSubmit.Location = new Point(157, 47);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(94, 29);
            BtnSubmit.TabIndex = 0;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = true;
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(160, 136);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.Size = new Size(213, 162);
            TxtOutput.TabIndex = 1;
            // 
            // Assignment2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtOutput);
            Controls.Add(BtnSubmit);
            Name = "Assignment2";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSubmit;
        private TextBox TxtOutput;
    }
}