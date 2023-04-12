namespace Arithmetic
{
    partial class FrmArithmetic
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
            this.BtnArithmetic = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnArithmetic
            // 
            this.BtnArithmetic.Location = new System.Drawing.Point(164, 39);
            this.BtnArithmetic.Name = "BtnArithmetic";
            this.BtnArithmetic.Size = new System.Drawing.Size(121, 33);
            this.BtnArithmetic.TabIndex = 0;
            this.BtnArithmetic.Text = "Perform Arithmetic";
            this.BtnArithmetic.UseVisualStyleBackColor = true;
            this.BtnArithmetic.Click += new System.EventHandler(this.BtnArithmetic_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(55, 101);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(345, 126);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmArithmetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 262);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnArithmetic);
            this.Name = "FrmArithmetic";
            this.Text = "Arithmetic Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnArithmetic;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

