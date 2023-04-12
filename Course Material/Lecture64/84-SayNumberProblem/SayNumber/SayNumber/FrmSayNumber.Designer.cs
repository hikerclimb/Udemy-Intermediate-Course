
namespace SayNumber
{
    partial class FrmSayNumber
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
            this.BtnSayNumber = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSayNumber
            // 
            this.BtnSayNumber.Location = new System.Drawing.Point(323, 46);
            this.BtnSayNumber.Name = "BtnSayNumber";
            this.BtnSayNumber.Size = new System.Drawing.Size(166, 41);
            this.BtnSayNumber.TabIndex = 0;
            this.BtnSayNumber.Text = "Say";
            this.BtnSayNumber.UseVisualStyleBackColor = true;
            this.BtnSayNumber.Click += new System.EventHandler(this.BtnSayNumber_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(38, 128);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(721, 284);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmSayNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnSayNumber);
            this.Name = "FrmSayNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Say Number Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSayNumber;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

