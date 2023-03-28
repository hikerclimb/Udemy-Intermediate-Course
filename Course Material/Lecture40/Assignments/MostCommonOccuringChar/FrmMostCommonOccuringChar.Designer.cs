namespace MostCommonOccuringChar
{
    partial class FrmMostCommonOccuringChar
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
            BtnCommonChar = new Button();
            SuspendLayout();
            // 
            // BtnCommonChar
            // 
            BtnCommonChar.Location = new Point(158, 65);
            BtnCommonChar.Name = "BtnCommonChar";
            BtnCommonChar.Size = new Size(174, 29);
            BtnCommonChar.TabIndex = 0;
            BtnCommonChar.Text = "CommonChar";
            BtnCommonChar.UseVisualStyleBackColor = true;
            BtnCommonChar.Click += BtnCommonChar_Click;
            // 
            // FrmMostCommonOccuringChar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCommonChar);
            Name = "FrmMostCommonOccuringChar";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCommonChar;
    }
}