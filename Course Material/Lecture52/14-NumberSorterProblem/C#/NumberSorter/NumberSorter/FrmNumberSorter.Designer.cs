namespace NumberSorter
{
    partial class FrmNumberSorter
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
            this.BtnSorter = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSorter
            // 
            this.BtnSorter.Location = new System.Drawing.Point(151, 48);
            this.BtnSorter.Name = "BtnSorter";
            this.BtnSorter.Size = new System.Drawing.Size(147, 31);
            this.BtnSorter.TabIndex = 0;
            this.BtnSorter.Text = "Sort";
            this.BtnSorter.UseVisualStyleBackColor = true;
            this.BtnSorter.Click += new System.EventHandler(this.BtnSorter_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(77, 139);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(299, 177);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmNumberSorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 383);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnSorter);
            this.Name = "FrmNumberSorter";
            this.Text = "Number Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSorter;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

