namespace Add2FractionsAndPutInLowestTerms
{
    partial class Add2FractionsAndPutInLowestTerm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnConvert = new Button();
            SuspendLayout();
            // 
            // BtnConvert
            // 
            BtnConvert.Location = new Point(363, 92);
            BtnConvert.Name = "BtnConvert";
            BtnConvert.Size = new Size(75, 23);
            BtnConvert.TabIndex = 0;
            BtnConvert.Text = "Convert";
            BtnConvert.UseVisualStyleBackColor = true;
            BtnConvert.Click += BtnConvert_Click;
            // 
            // Add2FractionsAndPutInLowestTerm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnConvert);
            Name = "Add2FractionsAndPutInLowestTerm";
            Text = "Add2FractionsAndPutInLowestTerm";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnConvert;
    }
}