namespace PercentageMarkup
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
            BtnPercentageMarkup = new Button();
            SuspendLayout();
            // 
            // BtnPercentageMarkup
            // 
            BtnPercentageMarkup.Location = new Point(303, 108);
            BtnPercentageMarkup.Name = "BtnPercentageMarkup";
            BtnPercentageMarkup.Size = new Size(153, 29);
            BtnPercentageMarkup.TabIndex = 0;
            BtnPercentageMarkup.Text = "Percentage Markup";
            BtnPercentageMarkup.UseVisualStyleBackColor = true;
            BtnPercentageMarkup.Click += BtnPercentageMarkup_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnPercentageMarkup);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnPercentageMarkup;
    }
}