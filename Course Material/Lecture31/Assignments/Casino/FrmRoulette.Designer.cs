namespace Casino
{
    partial class FrmRoulette
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
            BtnSpin = new Button();
            TxtBoxOutput = new TextBox();
            SuspendLayout();
            // 
            // BtnSpin
            // 
            BtnSpin.AccessibleRole = AccessibleRole.Border;
            BtnSpin.Location = new Point(285, 48);
            BtnSpin.Name = "BtnSpin";
            BtnSpin.Size = new Size(94, 29);
            BtnSpin.TabIndex = 0;
            BtnSpin.Text = "Spin";
            BtnSpin.UseVisualStyleBackColor = true;
            BtnSpin.Click += BtnSpin_Click;
            // 
            // TxtBoxOutput
            // 
            TxtBoxOutput.Location = new Point(149, 94);
            TxtBoxOutput.Multiline = true;
            TxtBoxOutput.Name = "TxtBoxOutput";
            TxtBoxOutput.Size = new Size(525, 296);
            TxtBoxOutput.TabIndex = 1;
            // 
            // FrmRoulette
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtBoxOutput);
            Controls.Add(BtnSpin);
            Name = "FrmRoulette";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSpin;
        private TextBox TxtBoxOutput;
    }
}