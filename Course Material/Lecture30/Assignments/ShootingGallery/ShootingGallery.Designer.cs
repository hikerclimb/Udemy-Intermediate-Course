namespace ShootingGallery
{
    partial class ShootingGallery
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
            BtnCalculateAvg = new Button();
            TxtBoxCost = new TextBox();
            SuspendLayout();
            // 
            // BtnCalculateAvg
            // 
            BtnCalculateAvg.Location = new Point(191, 133);
            BtnCalculateAvg.Name = "BtnCalculateAvg";
            BtnCalculateAvg.Size = new Size(328, 29);
            BtnCalculateAvg.TabIndex = 0;
            BtnCalculateAvg.Text = "CalculateShotAveragePerPerson";
            BtnCalculateAvg.UseVisualStyleBackColor = true;
            BtnCalculateAvg.Click += BtnCalculateAvg_Click;
            // 
            // TxtBoxCost
            // 
            TxtBoxCost.Location = new Point(191, 210);
            TxtBoxCost.Multiline = true;
            TxtBoxCost.Name = "TxtBoxCost";
            TxtBoxCost.Size = new Size(328, 188);
            TxtBoxCost.TabIndex = 1;
            // 
            // ShootingGallery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtBoxCost);
            Controls.Add(BtnCalculateAvg);
            Name = "ShootingGallery";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCalculateAvg;
        private TextBox TxtBoxCost;
    }
}