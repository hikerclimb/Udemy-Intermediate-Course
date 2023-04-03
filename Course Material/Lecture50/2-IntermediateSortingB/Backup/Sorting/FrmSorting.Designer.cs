namespace Sorting
{
    partial class FrmSorting
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
            this.BtnSelection = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSelection
            // 
            this.BtnSelection.Location = new System.Drawing.Point(233, 33);
            this.BtnSelection.Name = "BtnSelection";
            this.BtnSelection.Size = new System.Drawing.Size(106, 32);
            this.BtnSelection.TabIndex = 1;
            this.BtnSelection.Text = "Selection";
            this.BtnSelection.UseVisualStyleBackColor = true;
            this.BtnSelection.Click += new System.EventHandler(this.BtnSelection_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(100, 116);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(375, 207);
            this.TxtDisplay.TabIndex = 3;
            // 
            // FrmSorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 399);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnSelection);
            this.Name = "FrmSorting";
            this.Text = "Sorting Techniques";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelection;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

