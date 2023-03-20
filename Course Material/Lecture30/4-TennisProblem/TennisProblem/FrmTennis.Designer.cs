namespace TennisProblem
{
    partial class FrmTennis
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
            this.BtnBegin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LstDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnBegin
            // 
            this.BtnBegin.Location = new System.Drawing.Point(185, 23);
            this.BtnBegin.Name = "BtnBegin";
            this.BtnBegin.Size = new System.Drawing.Size(96, 31);
            this.BtnBegin.TabIndex = 0;
            this.BtnBegin.Text = "Begin";
            this.BtnBegin.UseVisualStyleBackColor = true;
            this.BtnBegin.Click += new System.EventHandler(this.BtnBegin_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(205, 221);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(64, 24);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LstDisplay
            // 
            this.LstDisplay.FormattingEnabled = true;
            this.LstDisplay.HorizontalScrollbar = true;
            this.LstDisplay.Location = new System.Drawing.Point(31, 65);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(433, 134);
            this.LstDisplay.TabIndex = 2;
            // 
            // FrmTennis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 262);
            this.Controls.Add(this.LstDisplay);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnBegin);
            this.Name = "FrmTennis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tennis Simulation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBegin;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ListBox LstDisplay;
    }
}

