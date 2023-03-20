namespace PseudoRandom
{
    partial class FrmPseudo
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
            this.BtnPseudo = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnPseudo
            // 
            this.BtnPseudo.Location = new System.Drawing.Point(276, 64);
            this.BtnPseudo.Name = "BtnPseudo";
            this.BtnPseudo.Size = new System.Drawing.Size(238, 45);
            this.BtnPseudo.TabIndex = 0;
            this.BtnPseudo.Text = "Determine Pseudo Random Number Length";
            this.BtnPseudo.UseVisualStyleBackColor = true;
            this.BtnPseudo.Click += new System.EventHandler(this.BtnPseudo_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(179, 145);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(430, 253);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmPseudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnPseudo);
            this.Name = "FrmPseudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pseudo Random Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPseudo;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

