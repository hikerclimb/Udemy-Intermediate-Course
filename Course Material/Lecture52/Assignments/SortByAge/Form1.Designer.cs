namespace SortByAge
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
            BtnSortByAge = new Button();
            TxtOutput = new TextBox();
            SuspendLayout();
            // 
            // BtnSortByAge
            // 
            BtnSortByAge.Location = new Point(96, 55);
            BtnSortByAge.Name = "BtnSortByAge";
            BtnSortByAge.Size = new Size(94, 29);
            BtnSortByAge.TabIndex = 0;
            BtnSortByAge.Text = "SortByAge";
            BtnSortByAge.UseVisualStyleBackColor = true;
            BtnSortByAge.Click += BtnSortByAge_Click;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(188, 139);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.ScrollBars = ScrollBars.Vertical;
            TxtOutput.Size = new Size(394, 232);
            TxtOutput.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtOutput);
            Controls.Add(BtnSortByAge);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSortByAge;
        private TextBox TxtOutput;
    }
}