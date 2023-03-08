namespace Pangram
{
    partial class FrmPan
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
            this.BtnPan = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnPan2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPan
            // 
            this.BtnPan.Location = new System.Drawing.Point(170, 54);
            this.BtnPan.Name = "BtnPan";
            this.BtnPan.Size = new System.Drawing.Size(145, 39);
            this.BtnPan.TabIndex = 0;
            this.BtnPan.Text = "Determine Pangrams Method 1";
            this.BtnPan.UseVisualStyleBackColor = true;
            this.BtnPan.Click += new System.EventHandler(this.BtnPan_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(59, 131);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(673, 273);
            this.TxtDisplay.TabIndex = 1;
            // 
            // BtnPan2
            // 
            this.BtnPan2.Location = new System.Drawing.Point(457, 51);
            this.BtnPan2.Name = "BtnPan2";
            this.BtnPan2.Size = new System.Drawing.Size(127, 41);
            this.BtnPan2.TabIndex = 2;
            this.BtnPan2.Text = "Determine Pangrams Method 2";
            this.BtnPan2.UseVisualStyleBackColor = true;
            this.BtnPan2.Click += new System.EventHandler(this.BtnPan2_Click);
            // 
            // FrmPan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPan2);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnPan);
            this.Name = "FrmPan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pangram Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPan;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnPan2;
    }
}

