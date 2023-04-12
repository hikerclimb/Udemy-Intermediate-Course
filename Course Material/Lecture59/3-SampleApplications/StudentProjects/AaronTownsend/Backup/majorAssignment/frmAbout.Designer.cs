namespace majorAssignment
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelAuthor = new System.Windows.Forms.LinkLabel();
            this.linkLabelHomePage = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Home Page:";
            // 
            // linkLabelAuthor
            // 
            this.linkLabelAuthor.AutoSize = true;
            this.linkLabelAuthor.Location = new System.Drawing.Point(211, 8);
            this.linkLabelAuthor.Name = "linkLabelAuthor";
            this.linkLabelAuthor.Size = new System.Drawing.Size(88, 13);
            this.linkLabelAuthor.TabIndex = 2;
            this.linkLabelAuthor.TabStop = true;
            this.linkLabelAuthor.Text = "Aaron Townsend";
            // 
            // linkLabelHomePage
            // 
            this.linkLabelHomePage.AutoSize = true;
            this.linkLabelHomePage.Location = new System.Drawing.Point(233, 35);
            this.linkLabelHomePage.Name = "linkLabelHomePage";
            this.linkLabelHomePage.Size = new System.Drawing.Size(61, 13);
            this.linkLabelHomePage.TabIndex = 3;
            this.linkLabelHomePage.TabStop = true;
            this.linkLabelHomePage.Text = "whizard.net";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(194, 410);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.Color.Black;
            this.textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo.ForeColor = System.Drawing.Color.White;
            this.textBoxInfo.Location = new System.Drawing.Point(64, 56);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(312, 183);
            this.textBoxInfo.TabIndex = 5;
            this.textBoxInfo.Text = resources.GetString("textBoxInfo.Text");
            this.textBoxInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.textBoxInfo);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 337);
            this.panel1.TabIndex = 6;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(379, 415);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(72, 13);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "Version 1.002";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(463, 437);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linkLabelHomePage);
            this.Controls.Add(this.linkLabelAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelAuthor;
        private System.Windows.Forms.LinkLabel linkLabelHomePage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVersion;
    }
}