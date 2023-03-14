namespace CallingAllCars
{
    partial class FrmCalling
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
            this.BtnCalling = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCalling
            // 
            this.BtnCalling.Location = new System.Drawing.Point(123, 39);
            this.BtnCalling.Name = "BtnCalling";
            this.BtnCalling.Size = new System.Drawing.Size(158, 31);
            this.BtnCalling.TabIndex = 0;
            this.BtnCalling.Text = "Determine Police Car To Call";
            this.BtnCalling.UseVisualStyleBackColor = true;
            this.BtnCalling.Click += new System.EventHandler(this.BtnCalling_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(38, 118);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(322, 178);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmCalling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 343);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnCalling);
            this.Name = "FrmCalling";
            this.Text = "Calling All Cars Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalling;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

