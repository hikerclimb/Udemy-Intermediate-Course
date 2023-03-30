namespace StrFry
{
    partial class FrmStrFry
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
            this.BtnStrFry = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnStrFry
            // 
            this.BtnStrFry.Location = new System.Drawing.Point(318, 47);
            this.BtnStrFry.Name = "BtnStrFry";
            this.BtnStrFry.Size = new System.Drawing.Size(157, 42);
            this.BtnStrFry.TabIndex = 0;
            this.BtnStrFry.Text = "Perform Scrambled Word Check";
            this.BtnStrFry.UseVisualStyleBackColor = true;
            this.BtnStrFry.Click += new System.EventHandler(this.BtnStrFry_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(56, 143);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(690, 271);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmStrFry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnStrFry);
            this.Name = "FrmStrFry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "strfry Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStrFry;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

