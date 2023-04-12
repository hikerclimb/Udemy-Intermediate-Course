namespace WindowsFormsApplication1
{
    partial class FrmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHelp));
            this.TabTab = new System.Windows.Forms.TabControl();
            this.TabDisplayer = new System.Windows.Forms.TabPage();
            this.LblDisplayercontent = new System.Windows.Forms.Label();
            this.LblDisplayertitle = new System.Windows.Forms.Label();
            this.PicDisplayer = new System.Windows.Forms.PictureBox();
            this.TabSearch = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.LblSearchtitle = new System.Windows.Forms.Label();
            this.PicSearch = new System.Windows.Forms.PictureBox();
            this.TabSelector = new System.Windows.Forms.TabPage();
            this.LblSelectorcontent = new System.Windows.Forms.Label();
            this.LblSelectortitle = new System.Windows.Forms.Label();
            this.PicSelector = new System.Windows.Forms.PictureBox();
            this.TabTeam = new System.Windows.Forms.TabPage();
            this.LblTeamcontent = new System.Windows.Forms.Label();
            this.LblTeamTitle = new System.Windows.Forms.Label();
            this.PicTeam = new System.Windows.Forms.PictureBox();
            this.TabStats = new System.Windows.Forms.TabPage();
            this.LblStatscontent = new System.Windows.Forms.Label();
            this.LblStatstitle = new System.Windows.Forms.Label();
            this.PicStats = new System.Windows.Forms.PictureBox();
            this.TabAbout = new System.Windows.Forms.TabPage();
            this.LblAboutcontent = new System.Windows.Forms.Label();
            this.LblAbouttitle = new System.Windows.Forms.Label();
            this.TabTab.SuspendLayout();
            this.TabDisplayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicDisplayer)).BeginInit();
            this.TabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearch)).BeginInit();
            this.TabSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSelector)).BeginInit();
            this.TabTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTeam)).BeginInit();
            this.TabStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicStats)).BeginInit();
            this.TabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabTab
            // 
            this.TabTab.Controls.Add(this.TabDisplayer);
            this.TabTab.Controls.Add(this.TabSearch);
            this.TabTab.Controls.Add(this.TabSelector);
            this.TabTab.Controls.Add(this.TabTeam);
            this.TabTab.Controls.Add(this.TabStats);
            this.TabTab.Controls.Add(this.TabAbout);
            this.TabTab.Location = new System.Drawing.Point(12, 12);
            this.TabTab.Name = "TabTab";
            this.TabTab.SelectedIndex = 0;
            this.TabTab.Size = new System.Drawing.Size(820, 368);
            this.TabTab.TabIndex = 0;
            // 
            // TabDisplayer
            // 
            this.TabDisplayer.Controls.Add(this.LblDisplayercontent);
            this.TabDisplayer.Controls.Add(this.LblDisplayertitle);
            this.TabDisplayer.Controls.Add(this.PicDisplayer);
            this.TabDisplayer.Location = new System.Drawing.Point(4, 22);
            this.TabDisplayer.Name = "TabDisplayer";
            this.TabDisplayer.Padding = new System.Windows.Forms.Padding(3);
            this.TabDisplayer.Size = new System.Drawing.Size(812, 342);
            this.TabDisplayer.TabIndex = 0;
            this.TabDisplayer.Text = "Displayer";
            this.TabDisplayer.UseVisualStyleBackColor = true;
            // 
            // LblDisplayercontent
            // 
            this.LblDisplayercontent.AutoSize = true;
            this.LblDisplayercontent.Location = new System.Drawing.Point(361, 76);
            this.LblDisplayercontent.Name = "LblDisplayercontent";
            this.LblDisplayercontent.Size = new System.Drawing.Size(436, 247);
            this.LblDisplayercontent.TabIndex = 2;
            this.LblDisplayercontent.Text = resources.GetString("LblDisplayercontent.Text");
            // 
            // LblDisplayertitle
            // 
            this.LblDisplayertitle.AutoSize = true;
            this.LblDisplayertitle.Location = new System.Drawing.Point(554, 29);
            this.LblDisplayertitle.Name = "LblDisplayertitle";
            this.LblDisplayertitle.Size = new System.Drawing.Size(72, 13);
            this.LblDisplayertitle.TabIndex = 1;
            this.LblDisplayertitle.Text = "The Displayer";
            // 
            // PicDisplayer
            // 
            this.PicDisplayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicDisplayer.Image = ((System.Drawing.Image)(resources.GetObject("PicDisplayer.Image")));
            this.PicDisplayer.Location = new System.Drawing.Point(6, 6);
            this.PicDisplayer.Name = "PicDisplayer";
            this.PicDisplayer.Size = new System.Drawing.Size(349, 329);
            this.PicDisplayer.TabIndex = 0;
            this.PicDisplayer.TabStop = false;
            // 
            // TabSearch
            // 
            this.TabSearch.Controls.Add(this.label1);
            this.TabSearch.Controls.Add(this.LblSearchtitle);
            this.TabSearch.Controls.Add(this.PicSearch);
            this.TabSearch.Location = new System.Drawing.Point(4, 22);
            this.TabSearch.Name = "TabSearch";
            this.TabSearch.Size = new System.Drawing.Size(812, 342);
            this.TabSearch.TabIndex = 5;
            this.TabSearch.Text = "Search";
            this.TabSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 195);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // LblSearchtitle
            // 
            this.LblSearchtitle.AutoSize = true;
            this.LblSearchtitle.Location = new System.Drawing.Point(99, 33);
            this.LblSearchtitle.Name = "LblSearchtitle";
            this.LblSearchtitle.Size = new System.Drawing.Size(107, 13);
            this.LblSearchtitle.TabIndex = 1;
            this.LblSearchtitle.Text = "The Search Function";
            // 
            // PicSearch
            // 
            this.PicSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicSearch.Image = ((System.Drawing.Image)(resources.GetObject("PicSearch.Image")));
            this.PicSearch.Location = new System.Drawing.Point(562, 47);
            this.PicSearch.Name = "PicSearch";
            this.PicSearch.Size = new System.Drawing.Size(247, 251);
            this.PicSearch.TabIndex = 0;
            this.PicSearch.TabStop = false;
            // 
            // TabSelector
            // 
            this.TabSelector.Controls.Add(this.LblSelectorcontent);
            this.TabSelector.Controls.Add(this.LblSelectortitle);
            this.TabSelector.Controls.Add(this.PicSelector);
            this.TabSelector.Location = new System.Drawing.Point(4, 22);
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Padding = new System.Windows.Forms.Padding(3);
            this.TabSelector.Size = new System.Drawing.Size(812, 342);
            this.TabSelector.TabIndex = 1;
            this.TabSelector.Text = "Selector";
            this.TabSelector.UseVisualStyleBackColor = true;
            // 
            // LblSelectorcontent
            // 
            this.LblSelectorcontent.AutoSize = true;
            this.LblSelectorcontent.Location = new System.Drawing.Point(6, 74);
            this.LblSelectorcontent.Name = "LblSelectorcontent";
            this.LblSelectorcontent.Size = new System.Drawing.Size(461, 221);
            this.LblSelectorcontent.TabIndex = 2;
            this.LblSelectorcontent.Text = resources.GetString("LblSelectorcontent.Text");
            // 
            // LblSelectortitle
            // 
            this.LblSelectortitle.AutoSize = true;
            this.LblSelectortitle.Location = new System.Drawing.Point(173, 29);
            this.LblSelectortitle.Name = "LblSelectortitle";
            this.LblSelectortitle.Size = new System.Drawing.Size(68, 13);
            this.LblSelectortitle.TabIndex = 1;
            this.LblSelectortitle.Text = "The Selector";
            // 
            // PicSelector
            // 
            this.PicSelector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicSelector.Image = ((System.Drawing.Image)(resources.GetObject("PicSelector.Image")));
            this.PicSelector.Location = new System.Drawing.Point(471, 6);
            this.PicSelector.Name = "PicSelector";
            this.PicSelector.Size = new System.Drawing.Size(335, 333);
            this.PicSelector.TabIndex = 0;
            this.PicSelector.TabStop = false;
            // 
            // TabTeam
            // 
            this.TabTeam.Controls.Add(this.LblTeamcontent);
            this.TabTeam.Controls.Add(this.LblTeamTitle);
            this.TabTeam.Controls.Add(this.PicTeam);
            this.TabTeam.Location = new System.Drawing.Point(4, 22);
            this.TabTeam.Name = "TabTeam";
            this.TabTeam.Size = new System.Drawing.Size(812, 342);
            this.TabTeam.TabIndex = 2;
            this.TabTeam.Text = "Team";
            this.TabTeam.UseVisualStyleBackColor = true;
            // 
            // LblTeamcontent
            // 
            this.LblTeamcontent.AutoSize = true;
            this.LblTeamcontent.Location = new System.Drawing.Point(3, 62);
            this.LblTeamcontent.Name = "LblTeamcontent";
            this.LblTeamcontent.Size = new System.Drawing.Size(806, 130);
            this.LblTeamcontent.TabIndex = 2;
            this.LblTeamcontent.Text = resources.GetString("LblTeamcontent.Text");
            // 
            // LblTeamTitle
            // 
            this.LblTeamTitle.AutoSize = true;
            this.LblTeamTitle.Location = new System.Drawing.Point(373, 24);
            this.LblTeamTitle.Name = "LblTeamTitle";
            this.LblTeamTitle.Size = new System.Drawing.Size(56, 13);
            this.LblTeamTitle.TabIndex = 1;
            this.LblTeamTitle.Text = "The Team";
            // 
            // PicTeam
            // 
            this.PicTeam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicTeam.Image = ((System.Drawing.Image)(resources.GetObject("PicTeam.Image")));
            this.PicTeam.Location = new System.Drawing.Point(6, 206);
            this.PicTeam.Name = "PicTeam";
            this.PicTeam.Size = new System.Drawing.Size(803, 133);
            this.PicTeam.TabIndex = 0;
            this.PicTeam.TabStop = false;
            // 
            // TabStats
            // 
            this.TabStats.Controls.Add(this.LblStatscontent);
            this.TabStats.Controls.Add(this.LblStatstitle);
            this.TabStats.Controls.Add(this.PicStats);
            this.TabStats.Location = new System.Drawing.Point(4, 22);
            this.TabStats.Name = "TabStats";
            this.TabStats.Size = new System.Drawing.Size(812, 342);
            this.TabStats.TabIndex = 3;
            this.TabStats.Text = "Stats Visualizer";
            this.TabStats.UseVisualStyleBackColor = true;
            // 
            // LblStatscontent
            // 
            this.LblStatscontent.AutoSize = true;
            this.LblStatscontent.Location = new System.Drawing.Point(435, 85);
            this.LblStatscontent.Name = "LblStatscontent";
            this.LblStatscontent.Size = new System.Drawing.Size(379, 234);
            this.LblStatscontent.TabIndex = 2;
            this.LblStatscontent.Text = resources.GetString("LblStatscontent.Text");
            // 
            // LblStatstitle
            // 
            this.LblStatstitle.AutoSize = true;
            this.LblStatstitle.Location = new System.Drawing.Point(368, 35);
            this.LblStatstitle.Name = "LblStatstitle";
            this.LblStatstitle.Size = new System.Drawing.Size(78, 13);
            this.LblStatstitle.TabIndex = 1;
            this.LblStatstitle.Text = "Stats Visualizer";
            // 
            // PicStats
            // 
            this.PicStats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicStats.Image = ((System.Drawing.Image)(resources.GetObject("PicStats.Image")));
            this.PicStats.Location = new System.Drawing.Point(3, 85);
            this.PicStats.Name = "PicStats";
            this.PicStats.Size = new System.Drawing.Size(426, 235);
            this.PicStats.TabIndex = 0;
            this.PicStats.TabStop = false;
            // 
            // TabAbout
            // 
            this.TabAbout.Controls.Add(this.LblAboutcontent);
            this.TabAbout.Controls.Add(this.LblAbouttitle);
            this.TabAbout.Location = new System.Drawing.Point(4, 22);
            this.TabAbout.Name = "TabAbout";
            this.TabAbout.Size = new System.Drawing.Size(812, 342);
            this.TabAbout.TabIndex = 4;
            this.TabAbout.Text = "About";
            this.TabAbout.UseVisualStyleBackColor = true;
            // 
            // LblAboutcontent
            // 
            this.LblAboutcontent.AutoSize = true;
            this.LblAboutcontent.Location = new System.Drawing.Point(179, 109);
            this.LblAboutcontent.Name = "LblAboutcontent";
            this.LblAboutcontent.Size = new System.Drawing.Size(436, 156);
            this.LblAboutcontent.TabIndex = 1;
            this.LblAboutcontent.Text = resources.GetString("LblAboutcontent.Text");
            this.LblAboutcontent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAbouttitle
            // 
            this.LblAbouttitle.AutoSize = true;
            this.LblAbouttitle.Location = new System.Drawing.Point(381, 30);
            this.LblAbouttitle.Name = "LblAbouttitle";
            this.LblAbouttitle.Size = new System.Drawing.Size(35, 13);
            this.LblAbouttitle.TabIndex = 0;
            this.LblAbouttitle.Text = "About";
            // 
            // FrmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 390);
            this.Controls.Add(this.TabTab);
            this.Name = "FrmHelp";
            this.Text = "Help";
            this.TabTab.ResumeLayout(false);
            this.TabDisplayer.ResumeLayout(false);
            this.TabDisplayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicDisplayer)).EndInit();
            this.TabSearch.ResumeLayout(false);
            this.TabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearch)).EndInit();
            this.TabSelector.ResumeLayout(false);
            this.TabSelector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSelector)).EndInit();
            this.TabTeam.ResumeLayout(false);
            this.TabTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTeam)).EndInit();
            this.TabStats.ResumeLayout(false);
            this.TabStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicStats)).EndInit();
            this.TabAbout.ResumeLayout(false);
            this.TabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabTab;
        private System.Windows.Forms.TabPage TabDisplayer;
        private System.Windows.Forms.TabPage TabSelector;
        private System.Windows.Forms.TabPage TabTeam;
        private System.Windows.Forms.TabPage TabStats;
        private System.Windows.Forms.TabPage TabAbout;
        private System.Windows.Forms.PictureBox PicDisplayer;
        private System.Windows.Forms.PictureBox PicSelector;
        private System.Windows.Forms.TabPage TabSearch;
        private System.Windows.Forms.PictureBox PicSearch;
        private System.Windows.Forms.PictureBox PicTeam;
        private System.Windows.Forms.PictureBox PicStats;
        private System.Windows.Forms.Label LblDisplayercontent;
        private System.Windows.Forms.Label LblDisplayertitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSearchtitle;
        private System.Windows.Forms.Label LblSelectorcontent;
        private System.Windows.Forms.Label LblSelectortitle;
        private System.Windows.Forms.Label LblTeamcontent;
        private System.Windows.Forms.Label LblTeamTitle;
        private System.Windows.Forms.Label LblStatscontent;
        private System.Windows.Forms.Label LblStatstitle;
        private System.Windows.Forms.Label LblAboutcontent;
        private System.Windows.Forms.Label LblAbouttitle;
    }
}