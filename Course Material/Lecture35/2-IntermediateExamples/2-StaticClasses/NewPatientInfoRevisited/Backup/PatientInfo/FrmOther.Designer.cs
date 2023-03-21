namespace PatientInfo
{
    partial class FrmOther
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
            this.BtnName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnName
            // 
            this.BtnName.Location = new System.Drawing.Point(94, 63);
            this.BtnName.Name = "BtnName";
            this.BtnName.Size = new System.Drawing.Size(104, 29);
            this.BtnName.TabIndex = 0;
            this.BtnName.Text = "Show Name";
            this.BtnName.UseVisualStyleBackColor = true;
            this.BtnName.Click += new System.EventHandler(this.BtnName_Click);
            // 
            // FrmOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.BtnName);
            this.Name = "FrmOther";
            this.Text = "FrmOther";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnName;
    }
}