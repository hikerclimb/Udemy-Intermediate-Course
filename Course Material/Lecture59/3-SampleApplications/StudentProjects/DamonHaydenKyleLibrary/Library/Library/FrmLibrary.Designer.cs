namespace Library
{
    partial class FrmLibrary
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
            this.LstDisplay = new System.Windows.Forms.ListView();
            this.StrpStatus = new System.Windows.Forms.StatusStrip();
            this.StrpStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.CboSort = new System.Windows.Forms.ComboBox();
            this.LblSort = new System.Windows.Forms.Label();
            this.BtnSort = new System.Windows.Forms.Button();
            this.LblSearch = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.grpDisplay = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnfont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.StrpStatus.SuspendLayout();
            this.MnuStrip.SuspendLayout();
            this.grpDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstDisplay
            // 
            this.LstDisplay.BackColor = System.Drawing.Color.White;
            this.LstDisplay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstDisplay.FullRowSelect = true;
            this.LstDisplay.Location = new System.Drawing.Point(23, 66);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(723, 326);
            this.LstDisplay.TabIndex = 3;
            this.LstDisplay.UseCompatibleStateImageBehavior = false;
            this.LstDisplay.View = System.Windows.Forms.View.Details;
            // 
            // StrpStatus
            // 
            this.StrpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StrpStatusLabel});
            this.StrpStatus.Location = new System.Drawing.Point(0, 511);
            this.StrpStatus.Name = "StrpStatus";
            this.StrpStatus.Size = new System.Drawing.Size(772, 22);
            this.StrpStatus.TabIndex = 5;
            this.StrpStatus.Text = "statusStrip1";
            // 
            // StrpStatusLabel
            // 
            this.StrpStatusLabel.Name = "StrpStatusLabel";
            this.StrpStatusLabel.Size = new System.Drawing.Size(89, 17);
            this.StrpStatusLabel.Text = "No files loaded.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(772, 24);
            this.MnuStrip.TabIndex = 6;
            this.MnuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // CboSort
            // 
            this.CboSort.Enabled = false;
            this.CboSort.FormattingEnabled = true;
            this.CboSort.Location = new System.Drawing.Point(100, 41);
            this.CboSort.Name = "CboSort";
            this.CboSort.Size = new System.Drawing.Size(121, 21);
            this.CboSort.TabIndex = 7;
            // 
            // LblSort
            // 
            this.LblSort.AutoSize = true;
            this.LblSort.Location = new System.Drawing.Point(21, 43);
            this.LblSort.Name = "LblSort";
            this.LblSort.Size = new System.Drawing.Size(76, 13);
            this.LblSort.TabIndex = 8;
            this.LblSort.Text = "Sort Books by:";
            // 
            // BtnSort
            // 
            this.BtnSort.Enabled = false;
            this.BtnSort.Location = new System.Drawing.Point(228, 39);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(42, 24);
            this.BtnSort.TabIndex = 9;
            this.BtnSort.Text = "Sort!";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(518, 45);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(44, 13);
            this.LblSearch.TabIndex = 13;
            this.LblSearch.Text = "Search:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(562, 42);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(123, 20);
            this.TxtSearch.TabIndex = 14;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Enabled = false;
            this.BtnSearch.Location = new System.Drawing.Point(691, 39);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(53, 24);
            this.BtnSearch.TabIndex = 15;
            this.BtnSearch.Text = "Search!";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Location = new System.Drawing.Point(628, 413);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(116, 75);
            this.BtnAdmin.TabIndex = 18;
            this.BtnAdmin.Text = "Launch Administration Panel";
            this.BtnAdmin.UseVisualStyleBackColor = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // grpDisplay
            // 
            this.grpDisplay.Controls.Add(this.btnColor);
            this.grpDisplay.Controls.Add(this.btnfont);
            this.grpDisplay.Location = new System.Drawing.Point(24, 410);
            this.grpDisplay.Name = "grpDisplay";
            this.grpDisplay.Size = new System.Drawing.Size(107, 85);
            this.grpDisplay.TabIndex = 21;
            this.grpDisplay.TabStop = false;
            this.grpDisplay.Text = "Display Settings";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(15, 52);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Colour";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnfont
            // 
            this.btnfont.Location = new System.Drawing.Point(15, 20);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(75, 23);
            this.btnfont.TabIndex = 0;
            this.btnfont.Text = "Font";
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // FrmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 533);
            this.Controls.Add(this.grpDisplay);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.LblSort);
            this.Controls.Add(this.CboSort);
            this.Controls.Add(this.StrpStatus);
            this.Controls.Add(this.MnuStrip);
            this.Controls.Add(this.LstDisplay);
            this.MainMenuStrip = this.MnuStrip;
            this.MaximizeBox = false;
            this.Name = "FrmLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Application";
            this.Load += new System.EventHandler(this.FrmLibrary_Load);
            this.StrpStatus.ResumeLayout(false);
            this.StrpStatus.PerformLayout();
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.grpDisplay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LstDisplay;
        private System.Windows.Forms.StatusStrip StrpStatus;
        private System.Windows.Forms.ToolStripStatusLabel StrpStatusLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox CboSort;
        private System.Windows.Forms.Label LblSort;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.GroupBox grpDisplay;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

