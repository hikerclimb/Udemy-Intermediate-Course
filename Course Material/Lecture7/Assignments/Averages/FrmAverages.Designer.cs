namespace Averages
{
    partial class FrmAverages
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
            BtnAverage = new Button();
            SuspendLayout();
            // 
            // BtnAverage
            // 
            BtnAverage.Location = new Point(276, 158);
            BtnAverage.Name = "BtnAverage";
            BtnAverage.Size = new Size(180, 23);
            BtnAverage.TabIndex = 0;
            BtnAverage.Text = "Calculate Average";
            BtnAverage.UseVisualStyleBackColor = true;
            BtnAverage.Click += BtnAverage_Click;
            // 
            // FrmAverages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAverage);
            Name = "FrmAverages";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAverage;
    }
}