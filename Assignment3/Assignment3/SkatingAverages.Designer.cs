namespace Assignment3
{
    partial class SkatingAverages
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
            TxtProcess = new Button();
            TxtOutput = new TextBox();
            SuspendLayout();
            // 
            // TxtProcess
            // 
            TxtProcess.Location = new Point(130, 46);
            TxtProcess.Name = "TxtProcess";
            TxtProcess.Size = new Size(94, 29);
            TxtProcess.TabIndex = 0;
            TxtProcess.Text = "Process";
            TxtProcess.UseVisualStyleBackColor = true;
            TxtProcess.Click += TxtProcess_Click;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(130, 108);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.Size = new Size(327, 193);
            TxtOutput.TabIndex = 1;
            // 
            // SkatingAverages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtOutput);
            Controls.Add(TxtProcess);
            Name = "SkatingAverages";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TxtProcess;
        private TextBox TxtOutput;
    }
}