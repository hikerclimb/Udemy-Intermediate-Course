namespace Decode
{
    partial class FrmDecode
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
            this.BtnDecode = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDecode
            // 
            this.BtnDecode.Location = new System.Drawing.Point(238, 41);
            this.BtnDecode.Name = "BtnDecode";
            this.BtnDecode.Size = new System.Drawing.Size(156, 26);
            this.BtnDecode.TabIndex = 0;
            this.BtnDecode.Text = "Decode";
            this.BtnDecode.UseVisualStyleBackColor = true;
            this.BtnDecode.Click += new System.EventHandler(this.BtnDecode_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(90, 108);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(462, 168);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmDecode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 362);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnDecode);
            this.Name = "FrmDecode";
            this.Text = "Decode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDecode;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

