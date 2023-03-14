namespace PrettyAverages
{
    partial class FrmPretty
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
            this.BtnPretty = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnPretty
            // 
            this.BtnPretty.Location = new System.Drawing.Point(295, 51);
            this.BtnPretty.Name = "BtnPretty";
            this.BtnPretty.Size = new System.Drawing.Size(190, 42);
            this.BtnPretty.TabIndex = 0;
            this.BtnPretty.Text = "Determine Pretty Average Primes";
            this.BtnPretty.UseVisualStyleBackColor = true;
            this.BtnPretty.Click += new System.EventHandler(this.BtnPretty_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(41, 139);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(713, 272);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmPretty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnPretty);
            this.Name = "FrmPretty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretty Average Primes Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPretty;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

