
namespace SecretInstructions
{
    partial class FrmSecret
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
            this.BtnSecret = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSecret
            // 
            this.BtnSecret.Location = new System.Drawing.Point(304, 54);
            this.BtnSecret.Name = "BtnSecret";
            this.BtnSecret.Size = new System.Drawing.Size(168, 48);
            this.BtnSecret.TabIndex = 0;
            this.BtnSecret.Text = "Determine Secret Directions";
            this.BtnSecret.UseVisualStyleBackColor = true;
            this.BtnSecret.Click += new System.EventHandler(this.BtnSecret_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(46, 127);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(694, 285);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmSecret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnSecret);
            this.Name = "FrmSecret";
            this.Text = "Secret Instructions Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSecret;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

