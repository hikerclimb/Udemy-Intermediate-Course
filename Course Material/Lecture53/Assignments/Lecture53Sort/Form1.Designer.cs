namespace Lecture53Sort
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
            BtnSortSnowfall = new Button();
            TxtOutput = new TextBox();
            SuspendLayout();
            // 
            // BtnSortSnowfall
            // 
            BtnSortSnowfall.Location = new Point(85, 76);
            BtnSortSnowfall.Name = "BtnSortSnowfall";
            BtnSortSnowfall.Size = new Size(142, 29);
            BtnSortSnowfall.TabIndex = 0;
            BtnSortSnowfall.Text = "SortSnowfall";
            BtnSortSnowfall.UseVisualStyleBackColor = true;
            BtnSortSnowfall.Click += BtnSortSnowfall_Click;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(85, 130);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.ScrollBars = ScrollBars.Vertical;
            TxtOutput.Size = new Size(553, 260);
            TxtOutput.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtOutput);
            Controls.Add(BtnSortSnowfall);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSortSnowfall;
        private TextBox TxtOutput;
    }
}