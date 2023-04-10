namespace Lectre56Assignments
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
            BtnDistanceBetween2Cities = new Button();
            TxtOutput = new TextBox();
            SuspendLayout();
            // 
            // BtnDistanceBetween2Cities
            // 
            BtnDistanceBetween2Cities.Location = new Point(260, 75);
            BtnDistanceBetween2Cities.Name = "BtnDistanceBetween2Cities";
            BtnDistanceBetween2Cities.Size = new Size(223, 29);
            BtnDistanceBetween2Cities.TabIndex = 0;
            BtnDistanceBetween2Cities.Text = "DistanceBetweenTwoCities";
            BtnDistanceBetween2Cities.UseVisualStyleBackColor = true;
            BtnDistanceBetween2Cities.Click += BtnDistanceBetween2Cities_Click;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(260, 151);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.ScrollBars = ScrollBars.Vertical;
            TxtOutput.Size = new Size(408, 245);
            TxtOutput.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtOutput);
            Controls.Add(BtnDistanceBetween2Cities);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnDistanceBetween2Cities;
        private TextBox TxtOutput;
    }
}