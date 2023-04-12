namespace Personal_Library_Catalogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibrary));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.CreateNwStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LstDisplay = new System.Windows.Forms.ListView();
            this.PicBook = new System.Windows.Forms.PictureBox();
            this.GrpInfo = new System.Windows.Forms.GroupBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TlBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.TlBtnSave = new System.Windows.Forms.ToolStripButton();
            this.TlBtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TlBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.TlBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.TlBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TlBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tlHelpBtn = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBook)).BeginInit();
            this.GrpInfo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.SaveAsStripMenuItem2,
            this.toolStripTextBox1,
            this.CreateNwStripMenuItem1,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // SaveAsStripMenuItem2
            // 
            this.SaveAsStripMenuItem2.Name = "SaveAsStripMenuItem2";
            this.SaveAsStripMenuItem2.Size = new System.Drawing.Size(192, 22);
            this.SaveAsStripMenuItem2.Text = "Save As";
            this.SaveAsStripMenuItem2.Click += new System.EventHandler(this.SaveAsStripMenuItem2_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Help";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // CreateNwStripMenuItem1
            // 
            this.CreateNwStripMenuItem1.Name = "CreateNwStripMenuItem1";
            this.CreateNwStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.CreateNwStripMenuItem1.Text = "Create New Catalogue";
            this.CreateNwStripMenuItem1.Click += new System.EventHandler(this.CreateNwStripMenuItem1_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LstDisplay
            // 
            this.LstDisplay.FullRowSelect = true;
            this.LstDisplay.GridLines = true;
            this.LstDisplay.Location = new System.Drawing.Point(53, 35);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(735, 343);
            this.LstDisplay.TabIndex = 2;
            this.LstDisplay.UseCompatibleStateImageBehavior = false;
            this.LstDisplay.View = System.Windows.Forms.View.Details;
            this.LstDisplay.SelectedIndexChanged += new System.EventHandler(this.LstDisplay_SelectedIndexChanged);
            this.LstDisplay.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LstDisplay_ColumnClick);
            // 
            // PicBook
            // 
            this.PicBook.Location = new System.Drawing.Point(852, 35);
            this.PicBook.Name = "PicBook";
            this.PicBook.Size = new System.Drawing.Size(129, 185);
            this.PicBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBook.TabIndex = 3;
            this.PicBook.TabStop = false;
            // 
            // GrpInfo
            // 
            this.GrpInfo.Controls.Add(this.txtSum);
            this.GrpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpInfo.Location = new System.Drawing.Point(794, 234);
            this.GrpInfo.Name = "GrpInfo";
            this.GrpInfo.Size = new System.Drawing.Size(232, 193);
            this.GrpInfo.TabIndex = 4;
            this.GrpInfo.TabStop = false;
            this.GrpInfo.Text = "Information";
            this.GrpInfo.Visible = false;
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(6, 19);
            this.txtSum.Multiline = true;
            this.txtSum.Name = "txtSum";
            this.txtSum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSum.Size = new System.Drawing.Size(220, 169);
            this.txtSum.TabIndex = 0;
            // 
            // BtnNew
            // 
            this.BtnNew.Enabled = false;
            this.BtnNew.Location = new System.Drawing.Point(54, 397);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(97, 30);
            this.BtnNew.TabIndex = 5;
            this.BtnNew.Text = "Add New Record";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(260, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(157, 397);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 30);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit Record Info";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlBtnOpen,
            this.TlBtnSave,
            this.TlBtnNew,
            this.toolStripSeparator1,
            this.TlBtnEdit,
            this.TlBtnAdd,
            this.TlBtnDelete,
            this.toolStripSeparator2,
            this.TlBtnSearch,
            this.tlHelpBtn});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(45, 409);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TlBtnOpen
            // 
            this.TlBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TlBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("TlBtnOpen.Image")));
            this.TlBtnOpen.ImageTransparentColor = System.Drawing.Color.White;
            this.TlBtnOpen.Name = "TlBtnOpen";
            this.TlBtnOpen.Size = new System.Drawing.Size(43, 44);
            this.TlBtnOpen.Text = "toolStripButton1";
            this.TlBtnOpen.Click += new System.EventHandler(this.TlBtnOpen_Click);
            // 
            // TlBtnSave
            // 
            this.TlBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TlBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("TlBtnSave.Image")));
            this.TlBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlBtnSave.Name = "TlBtnSave";
            this.TlBtnSave.Size = new System.Drawing.Size(43, 44);
            this.TlBtnSave.Text = "toolStripButton1";
            this.TlBtnSave.Click += new System.EventHandler(this.TlBtnSave_Click);
            // 
            // TlBtnNew
            // 
            this.TlBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TlBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("TlBtnNew.Image")));
            this.TlBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlBtnNew.Name = "TlBtnNew";
            this.TlBtnNew.Size = new System.Drawing.Size(43, 44);
            this.TlBtnNew.Text = "toolStripButton1";
            this.TlBtnNew.Click += new System.EventHandler(this.TlBtnNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(43, 6);
            // 
            // TlBtnEdit
            // 
            this.TlBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TlBtnEdit.Enabled = false;
            this.TlBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("TlBtnEdit.Image")));
            this.TlBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlBtnEdit.Name = "TlBtnEdit";
            this.TlBtnEdit.Size = new System.Drawing.Size(43, 44);
            this.TlBtnEdit.Text = "Edit";
            this.TlBtnEdit.ToolTipText = "Add New Record";
            this.TlBtnEdit.Click += new System.EventHandler(this.TlBtnEdit_Click);
            // 
            // TlBtnAdd
            // 
            this.TlBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TlBtnAdd.Enabled = false;
            this.TlBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("TlBtnAdd.Image")));
            this.TlBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlBtnAdd.Name = "TlBtnAdd";
            this.TlBtnAdd.Size = new System.Drawing.Size(43, 44);
            this.TlBtnAdd.Text = "toolStripButton1";
            this.TlBtnAdd.Click += new System.EventHandler(this.TlBtnAdd_Click);
            // 
            // TlBtnDelete
            // 
            this.TlBtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TlBtnDelete.Enabled = false;
            this.TlBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("TlBtnDelete.Image")));
            this.TlBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlBtnDelete.Name = "TlBtnDelete";
            this.TlBtnDelete.Size = new System.Drawing.Size(43, 44);
            this.TlBtnDelete.Text = "toolStripButton1";
            this.TlBtnDelete.Click += new System.EventHandler(this.TlBtnDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(43, 6);
            // 
            // TlBtnSearch
            // 
            this.TlBtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TlBtnSearch.Enabled = false;
            this.TlBtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("TlBtnSearch.Image")));
            this.TlBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlBtnSearch.Name = "TlBtnSearch";
            this.TlBtnSearch.Size = new System.Drawing.Size(43, 44);
            this.TlBtnSearch.Text = "toolStripButton1";
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(691, 397);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 30);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(523, 397);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(162, 26);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1038, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\Diana";
            // 
            // tlHelpBtn
            // 
            this.tlHelpBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlHelpBtn.Enabled = false;
            this.tlHelpBtn.Image = ((System.Drawing.Image)(resources.GetObject("tlHelpBtn.Image")));
            this.tlHelpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlHelpBtn.Name = "tlHelpBtn";
            this.tlHelpBtn.Size = new System.Drawing.Size(43, 44);
            this.tlHelpBtn.Text = "toolStripButton1";
            this.tlHelpBtn.Click += new System.EventHandler(this.tlHelpBtn_Click);
            // 
            // FrmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 459);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.GrpInfo);
            this.Controls.Add(this.PicBook);
            this.Controls.Add(this.LstDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmLibrary";
            this.Text = "Personal Library Catalogue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLibrary_FormClosing);
            this.Load += new System.EventHandler(this.FrmLibrary_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBook)).EndInit();
            this.GrpInfo.ResumeLayout(false);
            this.GrpInfo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView LstDisplay;
        private System.Windows.Forms.PictureBox PicBook;
        private System.Windows.Forms.GroupBox GrpInfo;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolStripMenuItem CreateNwStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveAsStripMenuItem2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TlBtnEdit;
        private System.Windows.Forms.ToolStripButton TlBtnSearch;
        private System.Windows.Forms.ToolStripButton TlBtnAdd;
        private System.Windows.Forms.ToolStripButton TlBtnDelete;
        private System.Windows.Forms.ToolStripButton TlBtnOpen;
        private System.Windows.Forms.ToolStripButton TlBtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TlBtnNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripButton tlHelpBtn;
    }
}

