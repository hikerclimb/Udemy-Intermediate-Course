namespace Bingo
{
    partial class FrmBingo
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
            this.BtnBingo = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnBingo
            // 
            this.BtnBingo.Location = new System.Drawing.Point(221, 58);
            this.BtnBingo.Name = "BtnBingo";
            this.BtnBingo.Size = new System.Drawing.Size(161, 32);
            this.BtnBingo.TabIndex = 0;
            this.BtnBingo.Text = "Play Bingo";
            this.BtnBingo.UseVisualStyleBackColor = true;
            this.BtnBingo.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(37, 165);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(553, 281);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmBingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 504);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnBingo);
            this.Name = "FrmBingo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bingo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBingo;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

