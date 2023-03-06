namespace Commission
{
    partial class FrmCommision
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
            BtnCommision = new Button();
            SuspendLayout();
            // 
            // BtnCommision
            // 
            BtnCommision.Location = new Point(208, 72);
            BtnCommision.Name = "BtnCommision";
            BtnCommision.Size = new Size(218, 29);
            BtnCommision.TabIndex = 0;
            BtnCommision.Text = "Calculate Commision";
            BtnCommision.UseVisualStyleBackColor = true;
            BtnCommision.Click += BtnCommision_Click;
            // 
            // FrmCommision
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCommision);
            Name = "FrmCommision";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCommision;
    }
}