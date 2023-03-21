namespace SupplementaryOOPproblems
{
    partial class FrmOOP
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
            this.BtnProblem1 = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnStructure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProblem1
            // 
            this.BtnProblem1.Location = new System.Drawing.Point(144, 12);
            this.BtnProblem1.Name = "BtnProblem1";
            this.BtnProblem1.Size = new System.Drawing.Size(105, 62);
            this.BtnProblem1.TabIndex = 0;
            this.BtnProblem1.Text = "Problem 2 Difference Between Two Dates";
            this.BtnProblem1.UseVisualStyleBackColor = true;
            this.BtnProblem1.Click += new System.EventHandler(this.BtnProblem1_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(52, 297);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(278, 115);
            this.TxtDisplay.TabIndex = 1;
            // 
            // BtnStructure
            // 
            this.BtnStructure.Location = new System.Drawing.Point(154, 94);
            this.BtnStructure.Name = "BtnStructure";
            this.BtnStructure.Size = new System.Drawing.Size(91, 70);
            this.BtnStructure.TabIndex = 2;
            this.BtnStructure.Text = "Problem 1 Nested Structure";
            this.BtnStructure.UseVisualStyleBackColor = true;
            this.BtnStructure.Click += new System.EventHandler(this.BtnStructure_Click);
            // 
            // FrmOOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 445);
            this.Controls.Add(this.BtnStructure);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnProblem1);
            this.Name = "FrmOOP";
            this.Text = "Supplementary OOP Problems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProblem1;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnStructure;
    }
}

