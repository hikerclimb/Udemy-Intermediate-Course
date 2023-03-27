namespace ParselTongue
{
    partial class FrmParsel
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
            this.BtnParsel = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnParsel
            // 
            this.BtnParsel.Location = new System.Drawing.Point(314, 45);
            this.BtnParsel.Name = "BtnParsel";
            this.BtnParsel.Size = new System.Drawing.Size(156, 45);
            this.BtnParsel.TabIndex = 0;
            this.BtnParsel.Text = "Translate to Parseltongue";
            this.BtnParsel.UseVisualStyleBackColor = true;
            this.BtnParsel.Click += new System.EventHandler(this.BtnParsel_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(44, 132);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(715, 275);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmParsel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnParsel);
            this.Name = "FrmParsel";
            this.Text = "Parseltongue Conundrum Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnParsel;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

