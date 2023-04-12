namespace WindowsFormsApplication1
{
    partial class GenericDialogBox
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
            this.BtnYes = new System.Windows.Forms.Button();
            this.BtnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnYes
            // 
            this.BtnYes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnYes.Location = new System.Drawing.Point(12, 23);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(149, 49);
            this.BtnYes.TabIndex = 0;
            this.BtnYes.Text = "Yes";
            this.BtnYes.UseVisualStyleBackColor = true;
            // 
            // BtnNo
            // 
            this.BtnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnNo.Location = new System.Drawing.Point(189, 23);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(153, 49);
            this.BtnNo.TabIndex = 1;
            this.BtnNo.Text = "No";
            this.BtnNo.UseVisualStyleBackColor = true;
            // 
            // GenericDialogBox
            // 
            this.AcceptButton = this.BtnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnNo;
            this.ClientSize = new System.Drawing.Size(354, 84);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Name = "GenericDialogBox";
            this.Text = "GenericDialogBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Button BtnNo;
    }
}