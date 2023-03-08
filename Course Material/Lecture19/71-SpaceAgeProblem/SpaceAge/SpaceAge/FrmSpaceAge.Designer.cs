
namespace SpaceAge
{
    partial class FrmSpaceAge
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
            this.BtnSpace = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSpace
            // 
            this.BtnSpace.Location = new System.Drawing.Point(333, 62);
            this.BtnSpace.Name = "BtnSpace";
            this.BtnSpace.Size = new System.Drawing.Size(170, 38);
            this.BtnSpace.TabIndex = 0;
            this.BtnSpace.Text = "Determine Space Ages";
            this.BtnSpace.UseVisualStyleBackColor = true;
            this.BtnSpace.Click += new System.EventHandler(this.BtnSpace_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(49, 141);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(690, 265);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmSpaceAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnSpace);
            this.Name = "FrmSpaceAge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Age Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSpace;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

