namespace FailingDivision
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.dividendBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.divisorBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.divideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dividendBox
            // 
            this.dividendBox.Location = new System.Drawing.Point(13, 13);
            this.dividendBox.Name = "dividendBox";
            this.dividendBox.Size = new System.Drawing.Size(100, 20);
            this.dividendBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "divide by";
            // 
            // divisorBox
            // 
            this.divisorBox.Location = new System.Drawing.Point(176, 16);
            this.divisorBox.Name = "divisorBox";
            this.divisorBox.Size = new System.Drawing.Size(100, 20);
            this.divisorBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "The result is";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(120, 58);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(100, 20);
            this.resultBox.TabIndex = 4;
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(201, 104);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 5;
            this.divideButton.Text = "Divide";
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(405, 159);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.divisorBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dividendBox);
            this.Name = "Form1";
            this.Text = "What is an Exception ?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dividendBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox divisorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button divideButton;
    }
}

