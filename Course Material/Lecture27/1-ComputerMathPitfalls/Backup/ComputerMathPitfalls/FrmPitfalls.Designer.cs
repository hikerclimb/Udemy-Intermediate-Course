namespace ComputerMathPitfalls
{
    partial class FrmPitfalls
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
            this.BtnExample1 = new System.Windows.Forms.Button();
            this.BtnExample2 = new System.Windows.Forms.Button();
            this.BtnExample3 = new System.Windows.Forms.Button();
            this.LstDisplay = new System.Windows.Forms.ListBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnExample1
            // 
            this.BtnExample1.Location = new System.Drawing.Point(175, 12);
            this.BtnExample1.Name = "BtnExample1";
            this.BtnExample1.Size = new System.Drawing.Size(159, 62);
            this.BtnExample1.TabIndex = 0;
            this.BtnExample1.Text = "    Example 1 \r\n(This is supposed to stop at 1)";
            this.BtnExample1.UseVisualStyleBackColor = true;
            this.BtnExample1.Click += new System.EventHandler(this.BtnExample1_Click);
            // 
            // BtnExample2
            // 
            this.BtnExample2.Location = new System.Drawing.Point(175, 80);
            this.BtnExample2.Name = "BtnExample2";
            this.BtnExample2.Size = new System.Drawing.Size(159, 72);
            this.BtnExample2.TabIndex = 1;
            this.BtnExample2.Text = "Example 2\r\n (This sort of fixes the problem)";
            this.BtnExample2.UseVisualStyleBackColor = true;
            this.BtnExample2.Click += new System.EventHandler(this.BtnExample2_Click);
            // 
            // BtnExample3
            // 
            this.BtnExample3.Location = new System.Drawing.Point(175, 158);
            this.BtnExample3.Name = "BtnExample3";
            this.BtnExample3.Size = new System.Drawing.Size(159, 65);
            this.BtnExample3.TabIndex = 2;
            this.BtnExample3.Text = "Example 3 \r\n(The best way - A tolerance Expression)";
            this.BtnExample3.UseVisualStyleBackColor = true;
            this.BtnExample3.Click += new System.EventHandler(this.BtnExample3_Click);
            // 
            // LstDisplay
            // 
            this.LstDisplay.FormattingEnabled = true;
            this.LstDisplay.Location = new System.Drawing.Point(155, 229);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(201, 199);
            this.LstDisplay.TabIndex = 3;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(406, 400);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(82, 28);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmPitfalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 440);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LstDisplay);
            this.Controls.Add(this.BtnExample3);
            this.Controls.Add(this.BtnExample2);
            this.Controls.Add(this.BtnExample1);
            this.Name = "FrmPitfalls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Hidden Pitfalls of Computer Arithmetic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExample1;
        private System.Windows.Forms.Button BtnExample2;
        private System.Windows.Forms.Button BtnExample3;
        private System.Windows.Forms.ListBox LstDisplay;
        private System.Windows.Forms.Button BtnExit;
    }
}

