namespace SINProblem
{
    partial class FrmSINProblem
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
            this.BtnSIN = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSIN
            // 
            this.BtnSIN.Location = new System.Drawing.Point(101, 60);
            this.BtnSIN.Name = "BtnSIN";
            this.BtnSIN.Size = new System.Drawing.Size(98, 34);
            this.BtnSIN.TabIndex = 0;
            this.BtnSIN.Text = "Check for Valid SIN ";
            this.BtnSIN.UseVisualStyleBackColor = true;
            this.BtnSIN.Click += new System.EventHandler(this.BtnSIN_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(104, 179);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(94, 29);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmSINProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSIN);
            this.Name = "FrmSINProblem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIN Problem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSIN;
        private System.Windows.Forms.Button BtnExit;
    }
}

