namespace Repetition
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
            BtnRepeat = new Button();
            txtBxOutput = new TextBox();
            SuspendLayout();
            // 
            // BtnRepeat
            // 
            BtnRepeat.Location = new Point(164, 76);
            BtnRepeat.Name = "BtnRepeat";
            BtnRepeat.Size = new Size(94, 29);
            BtnRepeat.TabIndex = 0;
            BtnRepeat.Text = "Repeat";
            BtnRepeat.UseVisualStyleBackColor = true;
            BtnRepeat.Click += BtnRepeat_Click;
            // 
            // txtBxOutput
            // 
            txtBxOutput.Location = new Point(410, 126);
            txtBxOutput.Multiline = true;
            txtBxOutput.Name = "txtBxOutput";
            txtBxOutput.Size = new Size(224, 156);
            txtBxOutput.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBxOutput);
            Controls.Add(BtnRepeat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRepeat;
        private TextBox txtBxOutput;
    }
}