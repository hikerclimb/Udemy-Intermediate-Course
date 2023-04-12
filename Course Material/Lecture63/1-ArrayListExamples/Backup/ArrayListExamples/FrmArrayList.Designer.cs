namespace ArrayListExamples
{
    partial class FrmArrayList
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
            this.BtnOne = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOne
            // 
            this.BtnOne.Location = new System.Drawing.Point(157, 44);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(106, 32);
            this.BtnOne.TabIndex = 0;
            this.BtnOne.Text = "Problem 1";
            this.BtnOne.UseVisualStyleBackColor = true;
            this.BtnOne.Click += new System.EventHandler(this.BtnOne_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(105, 165);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(447, 124);
            this.TxtDisplay.TabIndex = 1;
            // 
            // BtnTwo
            // 
            this.BtnTwo.Location = new System.Drawing.Point(285, 44);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(106, 32);
            this.BtnTwo.TabIndex = 2;
            this.BtnTwo.Text = "Problem 2";
            this.BtnTwo.UseVisualStyleBackColor = true;
            this.BtnTwo.Click += new System.EventHandler(this.BtnTwo_Click);
            // 
            // FrmArrayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 347);
            this.Controls.Add(this.BtnTwo);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnOne);
            this.Name = "FrmArrayList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnTwo;
    }
}

