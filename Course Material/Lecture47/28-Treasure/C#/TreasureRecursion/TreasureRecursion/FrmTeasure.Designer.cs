namespace TreasureRecursion
{
    partial class FrmTeasure
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
            this.BtnTreasure = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnTreasure
            // 
            this.BtnTreasure.Location = new System.Drawing.Point(406, 40);
            this.BtnTreasure.Name = "BtnTreasure";
            this.BtnTreasure.Size = new System.Drawing.Size(115, 32);
            this.BtnTreasure.TabIndex = 0;
            this.BtnTreasure.Text = "Find Treasure";
            this.BtnTreasure.UseVisualStyleBackColor = true;
            this.BtnTreasure.Click += new System.EventHandler(this.BtnTreasure_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay.Location = new System.Drawing.Point(53, 95);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(830, 481);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmTeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 606);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnTreasure);
            this.Name = "FrmTeasure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treasure Recursion Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTreasure;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

