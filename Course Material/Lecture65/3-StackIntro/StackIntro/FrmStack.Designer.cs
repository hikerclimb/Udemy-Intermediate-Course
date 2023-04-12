namespace StackIntro
{
    partial class FrmStack
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
            this.BtnStack = new System.Windows.Forms.Button();
            this.BtnStackApp = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnStack
            // 
            this.BtnStack.Location = new System.Drawing.Point(47, 41);
            this.BtnStack.Name = "BtnStack";
            this.BtnStack.Size = new System.Drawing.Size(350, 53);
            this.BtnStack.TabIndex = 0;
            this.BtnStack.Text = "Mathematically Calculating ... string expression = \"5 + 10 + 15 + 20\" ... parsing" +
    " using Stacks";
            this.BtnStack.UseVisualStyleBackColor = true;
            this.BtnStack.Click += new System.EventHandler(this.BtnStack_Click);
            // 
            // BtnStackApp
            // 
            this.BtnStackApp.Location = new System.Drawing.Point(83, 112);
            this.BtnStackApp.Name = "BtnStackApp";
            this.BtnStackApp.Size = new System.Drawing.Size(254, 33);
            this.BtnStackApp.TabIndex = 1;
            this.BtnStackApp.Text = "Converting a Decimal Number to Binary";
            this.BtnStackApp.UseVisualStyleBackColor = true;
            this.BtnStackApp.Click += new System.EventHandler(this.BtnStackApp_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(127, 176);
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(158, 20);
            this.TxtDisplay.TabIndex = 2;
            // 
            // FrmStack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 307);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnStackApp);
            this.Controls.Add(this.BtnStack);
            this.Name = "FrmStack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stack Intro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStack;
        private System.Windows.Forms.Button BtnStackApp;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

