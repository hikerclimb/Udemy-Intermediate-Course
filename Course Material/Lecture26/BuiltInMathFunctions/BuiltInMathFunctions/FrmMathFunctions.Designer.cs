namespace BuiltInMathFunctions
{
    partial class FrmMathFunctions
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
            this.BtnMath = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMath
            // 
            this.BtnMath.Location = new System.Drawing.Point(42, 23);
            this.BtnMath.Name = "BtnMath";
            this.BtnMath.Size = new System.Drawing.Size(103, 39);
            this.BtnMath.TabIndex = 0;
            this.BtnMath.Text = "Math Functions";
            this.BtnMath.UseVisualStyleBackColor = true;
            this.BtnMath.Click += new System.EventHandler(this.BtnMath_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(28, 92);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(277, 198);
            this.TxtDisplay.TabIndex = 1;
            // 
            // BtnApp
            // 
            this.BtnApp.Location = new System.Drawing.Point(183, 25);
            this.BtnApp.Name = "BtnApp";
            this.BtnApp.Size = new System.Drawing.Size(98, 36);
            this.BtnApp.TabIndex = 2;
            this.BtnApp.Text = "Sample Application";
            this.BtnApp.UseVisualStyleBackColor = true;
            this.BtnApp.Click += new System.EventHandler(this.BtnApp_Click);
            // 
            // FrmMathFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 325);
            this.Controls.Add(this.BtnApp);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnMath);
            this.Name = "FrmMathFunctions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Built In Math Functions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMath;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnApp;
    }
}

