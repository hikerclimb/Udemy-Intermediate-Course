namespace StringIntro
{
    partial class FrmStringIntro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtString = new System.Windows.Forms.TextBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.BtnLength = new System.Windows.Forms.Button();
            this.BtnSubstring1 = new System.Windows.Forms.Button();
            this.BtnSubstring2 = new System.Windows.Forms.Button();
            this.BtnStartsWith = new System.Windows.Forms.Button();
            this.BtnEndsWith = new System.Windows.Forms.Button();
            this.BtnIndexOf = new System.Windows.Forms.Button();
            this.BtnToUpper = new System.Windows.Forms.Button();
            this.BtnToLower = new System.Windows.Forms.Button();
            this.BtnReplace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your sample text here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "See the result here";
            // 
            // TxtString
            // 
            this.TxtString.Location = new System.Drawing.Point(142, 50);
            this.TxtString.Name = "TxtString";
            this.TxtString.Size = new System.Drawing.Size(129, 20);
            this.TxtString.TabIndex = 2;
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(142, 259);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(128, 20);
            this.TxtResult.TabIndex = 3;
            // 
            // BtnLength
            // 
            this.BtnLength.Location = new System.Drawing.Point(70, 81);
            this.BtnLength.Name = "BtnLength";
            this.BtnLength.Size = new System.Drawing.Size(64, 34);
            this.BtnLength.TabIndex = 4;
            this.BtnLength.Text = ".Length";
            this.BtnLength.UseVisualStyleBackColor = true;
            this.BtnLength.Click += new System.EventHandler(this.BtnLength_Click);
            // 
            // BtnSubstring1
            // 
            this.BtnSubstring1.Location = new System.Drawing.Point(171, 81);
            this.BtnSubstring1.Name = "BtnSubstring1";
            this.BtnSubstring1.Size = new System.Drawing.Size(78, 34);
            this.BtnSubstring1.TabIndex = 5;
            this.BtnSubstring1.Text = ".Substring(4)";
            this.BtnSubstring1.UseVisualStyleBackColor = true;
            this.BtnSubstring1.Click += new System.EventHandler(this.BtnSubstring1_Click);
            // 
            // BtnSubstring2
            // 
            this.BtnSubstring2.Location = new System.Drawing.Point(266, 81);
            this.BtnSubstring2.Name = "BtnSubstring2";
            this.BtnSubstring2.Size = new System.Drawing.Size(85, 34);
            this.BtnSubstring2.TabIndex = 6;
            this.BtnSubstring2.Text = ".Substring(3,5)";
            this.BtnSubstring2.UseVisualStyleBackColor = true;
            this.BtnSubstring2.Click += new System.EventHandler(this.BtnSubstring2_Click);
            // 
            // BtnStartsWith
            // 
            this.BtnStartsWith.Location = new System.Drawing.Point(59, 133);
            this.BtnStartsWith.Name = "BtnStartsWith";
            this.BtnStartsWith.Size = new System.Drawing.Size(95, 31);
            this.BtnStartsWith.TabIndex = 7;
            this.BtnStartsWith.Text = ".StartsWith(\"St\")";
            this.BtnStartsWith.UseVisualStyleBackColor = true;
            this.BtnStartsWith.Click += new System.EventHandler(this.BtnStartsWith_Click);
            // 
            // BtnEndsWith
            // 
            this.BtnEndsWith.Location = new System.Drawing.Point(167, 133);
            this.BtnEndsWith.Name = "BtnEndsWith";
            this.BtnEndsWith.Size = new System.Drawing.Size(91, 30);
            this.BtnEndsWith.TabIndex = 8;
            this.BtnEndsWith.Text = ".EndsWith(\"f\")";
            this.BtnEndsWith.UseVisualStyleBackColor = true;
            this.BtnEndsWith.Click += new System.EventHandler(this.BtnEndsWith_Click);
            // 
            // BtnIndexOf
            // 
            this.BtnIndexOf.Location = new System.Drawing.Point(271, 133);
            this.BtnIndexOf.Name = "BtnIndexOf";
            this.BtnIndexOf.Size = new System.Drawing.Size(95, 30);
            this.BtnIndexOf.TabIndex = 9;
            this.BtnIndexOf.Text = ".Indexof(\'J\')";
            this.BtnIndexOf.UseVisualStyleBackColor = true;
            this.BtnIndexOf.Click += new System.EventHandler(this.BtnIndexOf_Click);
            // 
            // BtnToUpper
            // 
            this.BtnToUpper.Location = new System.Drawing.Point(62, 178);
            this.BtnToUpper.Name = "BtnToUpper";
            this.BtnToUpper.Size = new System.Drawing.Size(91, 31);
            this.BtnToUpper.TabIndex = 10;
            this.BtnToUpper.Text = ".ToUpper()";
            this.BtnToUpper.UseVisualStyleBackColor = true;
            this.BtnToUpper.Click += new System.EventHandler(this.BtnToUpper_Click);
            // 
            // BtnToLower
            // 
            this.BtnToLower.Location = new System.Drawing.Point(170, 179);
            this.BtnToLower.Name = "BtnToLower";
            this.BtnToLower.Size = new System.Drawing.Size(87, 29);
            this.BtnToLower.TabIndex = 11;
            this.BtnToLower.Text = ".ToLower()";
            this.BtnToLower.UseVisualStyleBackColor = true;
            this.BtnToLower.Click += new System.EventHandler(this.BtnToLower_Click);
            // 
            // BtnReplace
            // 
            this.BtnReplace.Location = new System.Drawing.Point(273, 181);
            this.BtnReplace.Name = "BtnReplace";
            this.BtnReplace.Size = new System.Drawing.Size(101, 27);
            this.BtnReplace.TabIndex = 12;
            this.BtnReplace.Text = ".Replace(\"e\",\"x\")";
            this.BtnReplace.UseVisualStyleBackColor = true;
            this.BtnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
            // 
            // FrmStringIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 310);
            this.Controls.Add(this.BtnReplace);
            this.Controls.Add(this.BtnToLower);
            this.Controls.Add(this.BtnToUpper);
            this.Controls.Add(this.BtnIndexOf);
            this.Controls.Add(this.BtnEndsWith);
            this.Controls.Add(this.BtnStartsWith);
            this.Controls.Add(this.BtnSubstring2);
            this.Controls.Add(this.BtnSubstring1);
            this.Controls.Add(this.BtnLength);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.TxtString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmStringIntro";
            this.Text = "String Properties and Methods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtString;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button BtnLength;
        private System.Windows.Forms.Button BtnSubstring1;
        private System.Windows.Forms.Button BtnSubstring2;
        private System.Windows.Forms.Button BtnStartsWith;
        private System.Windows.Forms.Button BtnEndsWith;
        private System.Windows.Forms.Button BtnIndexOf;
        private System.Windows.Forms.Button BtnToUpper;
        private System.Windows.Forms.Button BtnToLower;
        private System.Windows.Forms.Button BtnReplace;
    }
}

