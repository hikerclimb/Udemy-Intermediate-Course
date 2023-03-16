namespace AddTime
{
    partial class AddTime
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
            SumTime = new Button();
            TxtOutput = new TextBox();
            SuspendLayout();
            // 
            // SumTime
            // 
            SumTime.Location = new Point(83, 65);
            SumTime.Name = "SumTime";
            SumTime.Size = new Size(94, 29);
            SumTime.TabIndex = 0;
            SumTime.Text = "SumTime";
            SumTime.UseVisualStyleBackColor = true;
            SumTime.Click += SumTime_Click;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(83, 118);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.Size = new Size(264, 34);
            TxtOutput.TabIndex = 1;
            // 
            // AddTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtOutput);
            Controls.Add(SumTime);
            Name = "AddTime";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SumTime;
        private TextBox TxtOutput;
    }
}