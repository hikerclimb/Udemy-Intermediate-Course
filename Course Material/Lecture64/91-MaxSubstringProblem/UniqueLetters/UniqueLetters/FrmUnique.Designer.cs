namespace UniqueLetters
{
    partial class FrmUnique
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
            this.BtnUnique = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnUnique
            // 
            this.BtnUnique.Location = new System.Drawing.Point(318, 58);
            this.BtnUnique.Name = "BtnUnique";
            this.BtnUnique.Size = new System.Drawing.Size(163, 40);
            this.BtnUnique.TabIndex = 0;
            this.BtnUnique.Text = "Determine Max Length of Unique Letters";
            this.BtnUnique.UseVisualStyleBackColor = true;
            this.BtnUnique.Click += new System.EventHandler(this.BtnUnique_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(47, 147);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(697, 248);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmUnique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnUnique);
            this.Name = "FrmUnique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maximum Length of Unique Letters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUnique;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

