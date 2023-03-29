namespace CreditCardValidation
{
    partial class FrmCreditCardValidation
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
            this.BtnCredit = new System.Windows.Forms.Button();
            this.BtnSchneider = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCredit
            // 
            this.BtnCredit.Location = new System.Drawing.Point(125, 37);
            this.BtnCredit.Name = "BtnCredit";
            this.BtnCredit.Size = new System.Drawing.Size(118, 37);
            this.BtnCredit.TabIndex = 0;
            this.BtnCredit.Text = "Check Credit Card";
            this.BtnCredit.UseVisualStyleBackColor = true;
            this.BtnCredit.Click += new System.EventHandler(this.BtnCredit_Click);
            // 
            // BtnSchneider
            // 
            this.BtnSchneider.Location = new System.Drawing.Point(125, 107);
            this.BtnSchneider.Name = "BtnSchneider";
            this.BtnSchneider.Size = new System.Drawing.Size(115, 40);
            this.BtnSchneider.TabIndex = 1;
            this.BtnSchneider.Text = "Check Schneider Code";
            this.BtnSchneider.UseVisualStyleBackColor = true;
            this.BtnSchneider.Click += new System.EventHandler(this.BtnSchneider_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(128, 194);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(115, 39);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmCreditCardValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 262);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSchneider);
            this.Controls.Add(this.BtnCredit);
            this.Name = "FrmCreditCardValidation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Card Validation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCredit;
        private System.Windows.Forms.Button BtnSchneider;
        private System.Windows.Forms.Button BtnExit;
    }
}

