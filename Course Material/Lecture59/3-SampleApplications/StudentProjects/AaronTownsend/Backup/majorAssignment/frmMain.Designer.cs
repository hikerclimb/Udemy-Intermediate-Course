namespace majorAssignment
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDefaultDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeOldItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.LstViewTV = new System.Windows.Forms.ListView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabelFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTV = new System.Windows.Forms.TabPage();
            this.tabPageSpk = new System.Windows.Forms.TabPage();
            this.LstViewSpk = new System.Windows.Forms.ListView();
            this.tabPageRec = new System.Windows.Forms.TabPage();
            this.LstViewRec = new System.Windows.Forms.ListView();
            this.tabPagePeriph = new System.Windows.Forms.TabPage();
            this.LstViewPeriph = new System.Windows.Forms.ListView();
            this.editDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageTV.SuspendLayout();
            this.tabPageSpk.SuspendLayout();
            this.tabPageRec.SuspendLayout();
            this.tabPagePeriph.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.refreshToolStripMenuItem,
            this.openDefaultDataFileToolStripMenuItem,
            this.addNewItemToolStripMenuItem,
            this.removeOldItemToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(592, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.editDataFileToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.ShowShortcutKeys = false;
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.newToolStripMenuItem.Text = "&New Data File";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openToolStripMenuItem.Text = "&Open Data File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(191, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.deleteToolStripMenuItem.Text = "&Delete Data File";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveToolStripMenuItem.Text = "&Save Data File";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem1.Image")));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // openDefaultDataFileToolStripMenuItem
            // 
            this.openDefaultDataFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openDefaultDataFileToolStripMenuItem.Image")));
            this.openDefaultDataFileToolStripMenuItem.Name = "openDefaultDataFileToolStripMenuItem";
            this.openDefaultDataFileToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.openDefaultDataFileToolStripMenuItem.Text = "Open Default Data File";
            this.openDefaultDataFileToolStripMenuItem.Click += new System.EventHandler(this.openDefaultDataFileToolStripMenuItem_Click);
            // 
            // addNewItemToolStripMenuItem
            // 
            this.addNewItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewItemToolStripMenuItem.Image")));
            this.addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.addNewItemToolStripMenuItem.Text = "&Add New Item";
            this.addNewItemToolStripMenuItem.Click += new System.EventHandler(this.editParametersToolStripMenuItem_Click);
            // 
            // removeOldItemToolStripMenuItem
            // 
            this.removeOldItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeOldItemToolStripMenuItem.Image")));
            this.removeOldItemToolStripMenuItem.Name = "removeOldItemToolStripMenuItem";
            this.removeOldItemToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.removeOldItemToolStripMenuItem.Text = "&Remove Old Item";
            this.removeOldItemToolStripMenuItem.Click += new System.EventHandler(this.removeOldDisplayToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem2});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem2.Image")));
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem2.Text = "&About...";
            this.aboutToolStripMenuItem2.Click += new System.EventHandler(this.aboutToolStripMenuItem2_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // LstViewTV
            // 
            this.LstViewTV.AllowColumnReorder = true;
            this.LstViewTV.BackColor = System.Drawing.Color.White;
            this.LstViewTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstViewTV.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstViewTV.FullRowSelect = true;
            this.LstViewTV.GridLines = true;
            this.LstViewTV.Location = new System.Drawing.Point(3, 3);
            this.LstViewTV.Name = "LstViewTV";
            this.LstViewTV.Size = new System.Drawing.Size(578, 188);
            this.LstViewTV.TabIndex = 3;
            this.LstViewTV.UseCompatibleStateImageBehavior = false;
            this.LstViewTV.View = System.Windows.Forms.View.Details;
            this.LstViewTV.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LstViewTV_ColumnClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelFile});
            this.statusStrip.Location = new System.Drawing.Point(0, 244);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(592, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // StatusLabelFile
            // 
            this.StatusLabelFile.Name = "StatusLabelFile";
            this.StatusLabelFile.Size = new System.Drawing.Size(25, 17);
            this.StatusLabelFile.Text = "File";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTV);
            this.tabControl.Controls.Add(this.tabPageSpk);
            this.tabControl.Controls.Add(this.tabPageRec);
            this.tabControl.Controls.Add(this.tabPagePeriph);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(592, 220);
            this.tabControl.TabIndex = 5;
            this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseClick);
            // 
            // tabPageTV
            // 
            this.tabPageTV.Controls.Add(this.LstViewTV);
            this.tabPageTV.Location = new System.Drawing.Point(4, 22);
            this.tabPageTV.Name = "tabPageTV";
            this.tabPageTV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTV.Size = new System.Drawing.Size(584, 194);
            this.tabPageTV.TabIndex = 0;
            this.tabPageTV.Text = "Televisions";
            this.tabPageTV.UseVisualStyleBackColor = true;
            // 
            // tabPageSpk
            // 
            this.tabPageSpk.Controls.Add(this.LstViewSpk);
            this.tabPageSpk.Location = new System.Drawing.Point(4, 22);
            this.tabPageSpk.Name = "tabPageSpk";
            this.tabPageSpk.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpk.Size = new System.Drawing.Size(584, 194);
            this.tabPageSpk.TabIndex = 1;
            this.tabPageSpk.Text = "Speakers";
            this.tabPageSpk.UseVisualStyleBackColor = true;
            // 
            // LstViewSpk
            // 
            this.LstViewSpk.AllowColumnReorder = true;
            this.LstViewSpk.BackColor = System.Drawing.Color.White;
            this.LstViewSpk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstViewSpk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstViewSpk.FullRowSelect = true;
            this.LstViewSpk.GridLines = true;
            this.LstViewSpk.Location = new System.Drawing.Point(3, 3);
            this.LstViewSpk.Name = "LstViewSpk";
            this.LstViewSpk.Size = new System.Drawing.Size(578, 188);
            this.LstViewSpk.TabIndex = 4;
            this.LstViewSpk.UseCompatibleStateImageBehavior = false;
            this.LstViewSpk.View = System.Windows.Forms.View.Details;
            this.LstViewSpk.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LstViewSpk_ColumnClick);
            // 
            // tabPageRec
            // 
            this.tabPageRec.Controls.Add(this.LstViewRec);
            this.tabPageRec.Location = new System.Drawing.Point(4, 22);
            this.tabPageRec.Name = "tabPageRec";
            this.tabPageRec.Size = new System.Drawing.Size(584, 194);
            this.tabPageRec.TabIndex = 2;
            this.tabPageRec.Text = "Receivers";
            this.tabPageRec.UseVisualStyleBackColor = true;
            // 
            // LstViewRec
            // 
            this.LstViewRec.AllowColumnReorder = true;
            this.LstViewRec.BackColor = System.Drawing.Color.White;
            this.LstViewRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstViewRec.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstViewRec.FullRowSelect = true;
            this.LstViewRec.GridLines = true;
            this.LstViewRec.Location = new System.Drawing.Point(0, 0);
            this.LstViewRec.Name = "LstViewRec";
            this.LstViewRec.Size = new System.Drawing.Size(584, 194);
            this.LstViewRec.TabIndex = 4;
            this.LstViewRec.UseCompatibleStateImageBehavior = false;
            this.LstViewRec.View = System.Windows.Forms.View.Details;
            this.LstViewRec.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LstViewRec_ColumnClick);
            // 
            // tabPagePeriph
            // 
            this.tabPagePeriph.Controls.Add(this.LstViewPeriph);
            this.tabPagePeriph.Location = new System.Drawing.Point(4, 22);
            this.tabPagePeriph.Name = "tabPagePeriph";
            this.tabPagePeriph.Size = new System.Drawing.Size(584, 194);
            this.tabPagePeriph.TabIndex = 3;
            this.tabPagePeriph.Text = "Peripherals";
            this.tabPagePeriph.UseVisualStyleBackColor = true;
            // 
            // LstViewPeriph
            // 
            this.LstViewPeriph.AllowColumnReorder = true;
            this.LstViewPeriph.BackColor = System.Drawing.Color.White;
            this.LstViewPeriph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstViewPeriph.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstViewPeriph.FullRowSelect = true;
            this.LstViewPeriph.GridLines = true;
            this.LstViewPeriph.Location = new System.Drawing.Point(0, 0);
            this.LstViewPeriph.Name = "LstViewPeriph";
            this.LstViewPeriph.Size = new System.Drawing.Size(584, 194);
            this.LstViewPeriph.TabIndex = 4;
            this.LstViewPeriph.UseCompatibleStateImageBehavior = false;
            this.LstViewPeriph.View = System.Windows.Forms.View.Details;
            this.LstViewPeriph.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LstViewPeriph_ColumnClick);
            // 
            // editDataFileToolStripMenuItem
            // 
            this.editDataFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editDataFileToolStripMenuItem.Image")));
            this.editDataFileToolStripMenuItem.Name = "editDataFileToolStripMenuItem";
            this.editDataFileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.editDataFileToolStripMenuItem.Text = "&Edit Data File";
            this.editDataFileToolStripMenuItem.Click += new System.EventHandler(this.editDataFileToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 266);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "Home Theater Planner";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageTV.ResumeLayout(false);
            this.tabPageSpk.ResumeLayout(false);
            this.tabPageRec.ResumeLayout(false);
            this.tabPagePeriph.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListView LstViewTV;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelFile;
        private ListViewColumnSorter lvwColumnSorter;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTV;
        private System.Windows.Forms.TabPage tabPageSpk;
        private System.Windows.Forms.TabPage tabPageRec;
        private System.Windows.Forms.TabPage tabPagePeriph;
        private System.Windows.Forms.ListView LstViewSpk;
        private System.Windows.Forms.ListView LstViewRec;
        private System.Windows.Forms.ListView LstViewPeriph;
        private System.Windows.Forms.ToolStripMenuItem addNewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeOldItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDefaultDataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDataFileToolStripMenuItem;
    }
}

