namespace Acronyms
{
    partial class FrmAcronym
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
            this.BtnAcronyms = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAcronyms
            // 
            this.BtnAcronyms.Location = new System.Drawing.Point(327, 52);
            this.BtnAcronyms.Name = "BtnAcronyms";
            this.BtnAcronyms.Size = new System.Drawing.Size(135, 37);
            this.BtnAcronyms.TabIndex = 0;
            this.BtnAcronyms.Text = "Determine Acronyms";
            this.BtnAcronyms.UseVisualStyleBackColor = true;
            this.BtnAcronyms.Click += new System.EventHandler(this.BtnAcronyms_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(61, 143);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(673, 266);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmAcronym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnAcronyms);
            this.Name = "FrmAcronym";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acronyms Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAcronyms;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

