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
            BtnAverages = new Button();
            SuspendLayout();
            // 
            // BtnAverages
            // 
            BtnAverages.Location = new Point(218, 89);
            BtnAverages.Name = "BtnAverages";
            BtnAverages.Size = new Size(94, 29);
            BtnAverages.TabIndex = 0;
            BtnAverages.Text = "Averages";
            BtnAverages.UseVisualStyleBackColor = true;
            BtnAverages.Click += BtnAverages_Click;
            // 
            // FrmAverages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAverages);
            Name = "FrmAverages";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAverages;
    }
}