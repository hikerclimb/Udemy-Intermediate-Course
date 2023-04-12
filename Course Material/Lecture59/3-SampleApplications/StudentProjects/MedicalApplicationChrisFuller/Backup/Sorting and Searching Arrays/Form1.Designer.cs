namespace Sorting_and_Searching_Arrays
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.roomNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malesAtTheTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femalesAtTheTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnNP = new System.Windows.Forms.Button();
            this.LstDisplay = new System.Windows.Forms.ListView();
            this.BtnRP = new System.Windows.Forms.Button();
            this.BtnCP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CboNames = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.sortListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newFileToolStripMenuItem.Text = "New";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // sortListToolStripMenuItem
            // 
            this.sortListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.namesToolStripMenuItem,
            this.ageToolStripMenuItem,
            this.roomNumberToolStripMenuItem,
            this.sexToolStripMenuItem});
            this.sortListToolStripMenuItem.Enabled = false;
            this.sortListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sortListToolStripMenuItem.Name = "sortListToolStripMenuItem";
            this.sortListToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sortListToolStripMenuItem.Text = "Sort List";
            // 
            // namesToolStripMenuItem
            // 
            this.namesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.namesToolStripMenuItem.Name = "namesToolStripMenuItem";
            this.namesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.namesToolStripMenuItem.Text = "Names";
            // 
            // ascendingToolStripMenuItem
            // 
            this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ascendingToolStripMenuItem.Text = "Ascending";
            this.ascendingToolStripMenuItem.Click += new System.EventHandler(this.ascendingToolStripMenuItem_Click);
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.descendingToolStripMenuItem.Text = "Descending";
            this.descendingToolStripMenuItem.Click += new System.EventHandler(this.descendingToolStripMenuItem_Click);
            // 
            // ageToolStripMenuItem
            // 
            this.ageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem1,
            this.descendingToolStripMenuItem1});
            this.ageToolStripMenuItem.Name = "ageToolStripMenuItem";
            this.ageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ageToolStripMenuItem.Text = "Age";
            // 
            // ascendingToolStripMenuItem1
            // 
            this.ascendingToolStripMenuItem1.Name = "ascendingToolStripMenuItem1";
            this.ascendingToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.ascendingToolStripMenuItem1.Text = "Ascending";
            this.ascendingToolStripMenuItem1.Click += new System.EventHandler(this.ascendingToolStripMenuItem1_Click);
            // 
            // descendingToolStripMenuItem1
            // 
            this.descendingToolStripMenuItem1.Name = "descendingToolStripMenuItem1";
            this.descendingToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.descendingToolStripMenuItem1.Text = "Descending";
            this.descendingToolStripMenuItem1.Click += new System.EventHandler(this.descendingToolStripMenuItem1_Click);
            // 
            // roomNumberToolStripMenuItem
            // 
            this.roomNumberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem2,
            this.descendingToolStripMenuItem2});
            this.roomNumberToolStripMenuItem.Name = "roomNumberToolStripMenuItem";
            this.roomNumberToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.roomNumberToolStripMenuItem.Text = "Room Number";
            // 
            // ascendingToolStripMenuItem2
            // 
            this.ascendingToolStripMenuItem2.Name = "ascendingToolStripMenuItem2";
            this.ascendingToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.ascendingToolStripMenuItem2.Text = "Ascending";
            this.ascendingToolStripMenuItem2.Click += new System.EventHandler(this.ascendingToolStripMenuItem2_Click);
            // 
            // descendingToolStripMenuItem2
            // 
            this.descendingToolStripMenuItem2.Name = "descendingToolStripMenuItem2";
            this.descendingToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.descendingToolStripMenuItem2.Text = "Descending";
            this.descendingToolStripMenuItem2.Click += new System.EventHandler(this.descendingToolStripMenuItem2_Click);
            // 
            // sexToolStripMenuItem
            // 
            this.sexToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.malesAtTheTopToolStripMenuItem,
            this.femalesAtTheTopToolStripMenuItem});
            this.sexToolStripMenuItem.Name = "sexToolStripMenuItem";
            this.sexToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sexToolStripMenuItem.Text = "Sex";
            // 
            // malesAtTheTopToolStripMenuItem
            // 
            this.malesAtTheTopToolStripMenuItem.Name = "malesAtTheTopToolStripMenuItem";
            this.malesAtTheTopToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.malesAtTheTopToolStripMenuItem.Text = "Males at the top";
            this.malesAtTheTopToolStripMenuItem.Click += new System.EventHandler(this.malesAtTheTopToolStripMenuItem_Click);
            // 
            // femalesAtTheTopToolStripMenuItem
            // 
            this.femalesAtTheTopToolStripMenuItem.Name = "femalesAtTheTopToolStripMenuItem";
            this.femalesAtTheTopToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.femalesAtTheTopToolStripMenuItem.Text = "Females at the top";
            this.femalesAtTheTopToolStripMenuItem.Click += new System.EventHandler(this.femalesAtTheTopToolStripMenuItem_Click);
            // 
            // BtnNP
            // 
            this.BtnNP.Enabled = false;
            this.BtnNP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNP.Location = new System.Drawing.Point(12, 27);
            this.BtnNP.Name = "BtnNP";
            this.BtnNP.Size = new System.Drawing.Size(205, 20);
            this.BtnNP.TabIndex = 1;
            this.BtnNP.Text = "Administer a new patient";
            this.BtnNP.UseVisualStyleBackColor = true;
            this.BtnNP.Click += new System.EventHandler(this.button1_Click);
            // 
            // LstDisplay
            // 
            this.LstDisplay.BackColor = System.Drawing.Color.White;
            this.LstDisplay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstDisplay.FullRowSelect = true;
            this.LstDisplay.Location = new System.Drawing.Point(15, 76);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(774, 326);
            this.LstDisplay.TabIndex = 2;
            this.LstDisplay.UseCompatibleStateImageBehavior = false;
            this.LstDisplay.View = System.Windows.Forms.View.Details;
            // 
            // BtnRP
            // 
            this.BtnRP.Enabled = false;
            this.BtnRP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRP.Location = new System.Drawing.Point(584, 27);
            this.BtnRP.Name = "BtnRP";
            this.BtnRP.Size = new System.Drawing.Size(205, 20);
            this.BtnRP.TabIndex = 3;
            this.BtnRP.Text = "Release Patient";
            this.BtnRP.UseVisualStyleBackColor = true;
            this.BtnRP.Click += new System.EventHandler(this.BtnRP_Click);
            // 
            // BtnCP
            // 
            this.BtnCP.Enabled = false;
            this.BtnCP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCP.Location = new System.Drawing.Point(373, 27);
            this.BtnCP.Name = "BtnCP";
            this.BtnCP.Size = new System.Drawing.Size(205, 20);
            this.BtnCP.TabIndex = 4;
            this.BtnCP.Text = "Change Patient Information";
            this.BtnCP.UseVisualStyleBackColor = true;
            this.BtnCP.Click += new System.EventHandler(this.BtnCP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search for Patient:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(130, 50);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(178, 20);
            this.TxtSearch.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(320, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 19);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CboNames
            // 
            this.CboNames.DropDownHeight = 300;
            this.CboNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboNames.DropDownWidth = 200;
            this.CboNames.FormattingEnabled = true;
            this.CboNames.IntegralHeight = false;
            this.CboNames.Location = new System.Drawing.Point(223, 27);
            this.CboNames.Name = "CboNames";
            this.CboNames.Size = new System.Drawing.Size(144, 21);
            this.CboNames.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(801, 416);
            this.Controls.Add(this.CboNames);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCP);
            this.Controls.Add(this.BtnRP);
            this.Controls.Add(this.LstDisplay);
            this.Controls.Add(this.BtnNP);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "St. Elizabeth\'s Hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button BtnNP;
        private System.Windows.Forms.ListView LstDisplay;
        private System.Windows.Forms.Button BtnRP;
        private System.Windows.Forms.Button BtnCP;
        private System.Windows.Forms.ToolStripMenuItem sortListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem namesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem roomNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malesAtTheTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femalesAtTheTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CboNames;
    }
}

