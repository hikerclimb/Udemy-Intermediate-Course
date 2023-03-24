namespace LetterCount
{
    partial class FrmLetterCount
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
            this.BtnNormal = new System.Windows.Forms.Button();
            this.BtnReverse = new System.Windows.Forms.Button();
            this.BtnLetterCount = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.TxtProblem1 = new System.Windows.Forms.Button();
            this.TxtProblem2 = new System.Windows.Forms.Button();
            this.BtnProblem3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNormal
            // 
            this.BtnNormal.Location = new System.Drawing.Point(33, 68);
            this.BtnNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(116, 41);
            this.BtnNormal.TabIndex = 0;
            this.BtnNormal.Text = "Regular";
            this.BtnNormal.UseVisualStyleBackColor = true;
            this.BtnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // BtnReverse
            // 
            this.BtnReverse.Location = new System.Drawing.Point(35, 135);
            this.BtnReverse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnReverse.Name = "BtnReverse";
            this.BtnReverse.Size = new System.Drawing.Size(113, 38);
            this.BtnReverse.TabIndex = 1;
            this.BtnReverse.Text = "Reverse";
            this.BtnReverse.UseVisualStyleBackColor = true;
            this.BtnReverse.Click += new System.EventHandler(this.BtnReverse_Click);
            // 
            // BtnLetterCount
            // 
            this.BtnLetterCount.Location = new System.Drawing.Point(33, 198);
            this.BtnLetterCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLetterCount.Name = "BtnLetterCount";
            this.BtnLetterCount.Size = new System.Drawing.Size(115, 37);
            this.BtnLetterCount.TabIndex = 2;
            this.BtnLetterCount.Text = "Letter Count";
            this.BtnLetterCount.UseVisualStyleBackColor = true;
            this.BtnLetterCount.Click += new System.EventHandler(this.BtnLetterCount_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(257, 39);
            this.TxtResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResult.Size = new System.Drawing.Size(203, 224);
            this.TxtResult.TabIndex = 3;
            // 
            // TxtProblem1
            // 
            this.TxtProblem1.Location = new System.Drawing.Point(35, 276);
            this.TxtProblem1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtProblem1.Name = "TxtProblem1";
            this.TxtProblem1.Size = new System.Drawing.Size(100, 28);
            this.TxtProblem1.TabIndex = 4;
            this.TxtProblem1.Text = "Problem1";
            this.TxtProblem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TxtProblem1.UseVisualStyleBackColor = true;
            this.TxtProblem1.Click += new System.EventHandler(this.TxtProblem1_Click);
            // 
            // TxtProblem2
            // 
            this.TxtProblem2.Location = new System.Drawing.Point(201, 274);
            this.TxtProblem2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtProblem2.Name = "TxtProblem2";
            this.TxtProblem2.Size = new System.Drawing.Size(100, 28);
            this.TxtProblem2.TabIndex = 5;
            this.TxtProblem2.Text = "Problem2";
            this.TxtProblem2.UseVisualStyleBackColor = true;
            this.TxtProblem2.Click += new System.EventHandler(this.TxtProblem2_Click);
            // 
            // BtnProblem3
            // 
            this.BtnProblem3.Location = new System.Drawing.Point(362, 280);
            this.BtnProblem3.Name = "BtnProblem3";
            this.BtnProblem3.Size = new System.Drawing.Size(98, 23);
            this.BtnProblem3.TabIndex = 6;
            this.BtnProblem3.Text = "Problem3";
            this.BtnProblem3.UseVisualStyleBackColor = true;
            this.BtnProblem3.Click += new System.EventHandler(this.BtnProblem3_Click);
            // 
            // FrmLetterCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 364);
            this.Controls.Add(this.BtnProblem3);
            this.Controls.Add(this.TxtProblem2);
            this.Controls.Add(this.TxtProblem1);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnLetterCount);
            this.Controls.Add(this.BtnReverse);
            this.Controls.Add(this.BtnNormal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLetterCount";
            this.Text = "Simple String Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNormal;
        private System.Windows.Forms.Button BtnReverse;
        private System.Windows.Forms.Button BtnLetterCount;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button TxtProblem1;
        private System.Windows.Forms.Button TxtProblem2;
        private System.Windows.Forms.Button BtnProblem3;
    }
}

