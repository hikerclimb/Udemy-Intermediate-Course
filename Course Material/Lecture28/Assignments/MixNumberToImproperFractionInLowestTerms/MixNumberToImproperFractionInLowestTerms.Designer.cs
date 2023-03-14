namespace MixNumberToImproperFractionInLowestTerms
{
    partial class MixNumberToImproperFractionInLowestTerms
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
            BtnConvert = new Button();
            SuspendLayout();
            // 
            // BtnConvert
            // 
            BtnConvert.Location = new Point(242, 72);
            BtnConvert.Name = "BtnConvert";
            BtnConvert.Size = new Size(94, 29);
            BtnConvert.TabIndex = 0;
            BtnConvert.Text = "Convert";
            BtnConvert.UseVisualStyleBackColor = true;
            BtnConvert.Click += BtnConvert_Click;
            // 
            // MixNumberToImproperFractionInLowestTerms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnConvert);
            Name = "MixNumberToImproperFractionInLowestTerms";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnConvert;
    }
}