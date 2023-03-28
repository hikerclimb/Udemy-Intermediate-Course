namespace HarshadNumbers
{
    partial class FrmHarshad
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
            this.BtnHarshad = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnHarshad
            // 
            this.BtnHarshad.Location = new System.Drawing.Point(305, 52);
            this.BtnHarshad.Name = "BtnHarshad";
            this.BtnHarshad.Size = new System.Drawing.Size(159, 43);
            this.BtnHarshad.TabIndex = 0;
            this.BtnHarshad.Text = "Largest consecutive sequence of Harshad numbers";
            this.BtnHarshad.UseVisualStyleBackColor = true;
            this.BtnHarshad.Click += new System.EventHandler(this.BtnHarshad_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(60, 131);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(678, 285);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmHarshad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnHarshad);
            this.Name = "FrmHarshad";
            this.Text = "Hardshad Numbers Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHarshad;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

