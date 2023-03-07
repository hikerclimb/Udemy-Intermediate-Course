namespace Selection
{
    partial class UserInput
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
            LblAge = new Label();
            LblHeight = new Label();
            TxtAge = new TextBox();
            TxtHeight = new TextBox();
            BtnOk = new Button();
            BtnCancel = new Button();
            SuspendLayout();
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(166, 101);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(74, 20);
            LblAge.TabIndex = 0;
            LblAge.Text = "Enter Age";
            // 
            // LblHeight
            // 
            LblHeight.AutoSize = true;
            LblHeight.Location = new Point(404, 101);
            LblHeight.Name = "LblHeight";
            LblHeight.Size = new Size(92, 20);
            LblHeight.TabIndex = 1;
            LblHeight.Text = "Enter Height";
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(142, 166);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(125, 27);
            TxtAge.TabIndex = 2;
            // 
            // TxtHeight
            // 
            TxtHeight.Location = new Point(392, 166);
            TxtHeight.Name = "TxtHeight";
            TxtHeight.Size = new Size(125, 27);
            TxtHeight.TabIndex = 3;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(167, 254);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(94, 29);
            BtnOk.TabIndex = 4;
            BtnOk.Text = "Ok";
            BtnOk.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(399, 250);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 29);
            BtnCancel.TabIndex = 5;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // UserInput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCancel);
            Controls.Add(BtnOk);
            Controls.Add(TxtHeight);
            Controls.Add(TxtAge);
            Controls.Add(LblHeight);
            Controls.Add(LblAge);
            Name = "UserInput";
            Text = "UserInput";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAge;
        private Label LblHeight;
        private TextBox TxtAge;
        private TextBox TxtHeight;
        private Button BtnOk;
        private Button BtnCancel;
    }
}