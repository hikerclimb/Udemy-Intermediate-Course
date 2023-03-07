namespace SimpleTextFileDemo
{
    partial class FrmSimpleTextFile
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
            this.BtnDisplayFriends = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnMarks = new System.Windows.Forms.Button();
            this.BtnNewFriends = new System.Windows.Forms.Button();
            this.BtnDisplayNewFriends = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDisplayFriends
            // 
            this.BtnDisplayFriends.Location = new System.Drawing.Point(23, 37);
            this.BtnDisplayFriends.Name = "BtnDisplayFriends";
            this.BtnDisplayFriends.Size = new System.Drawing.Size(89, 24);
            this.BtnDisplayFriends.TabIndex = 0;
            this.BtnDisplayFriends.Text = "Display Friends";
            this.BtnDisplayFriends.UseVisualStyleBackColor = true;
            this.BtnDisplayFriends.Click += new System.EventHandler(this.BtnDisplayFriends_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(170, 25);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(171, 196);
            this.TxtDisplay.TabIndex = 1;
            // 
            // BtnMarks
            // 
            this.BtnMarks.Location = new System.Drawing.Point(23, 76);
            this.BtnMarks.Name = "BtnMarks";
            this.BtnMarks.Size = new System.Drawing.Size(86, 34);
            this.BtnMarks.TabIndex = 2;
            this.BtnMarks.Text = "Display Mark Info";
            this.BtnMarks.UseVisualStyleBackColor = true;
            this.BtnMarks.Click += new System.EventHandler(this.BtnMarks_Click);
            // 
            // BtnNewFriends
            // 
            this.BtnNewFriends.Location = new System.Drawing.Point(23, 161);
            this.BtnNewFriends.Name = "BtnNewFriends";
            this.BtnNewFriends.Size = new System.Drawing.Size(85, 37);
            this.BtnNewFriends.TabIndex = 3;
            this.BtnNewFriends.Text = "Create New Friends";
            this.BtnNewFriends.UseVisualStyleBackColor = true;
            this.BtnNewFriends.Click += new System.EventHandler(this.BtnNewFriends_Click);
            // 
            // BtnDisplayNewFriends
            // 
            this.BtnDisplayNewFriends.Location = new System.Drawing.Point(23, 204);
            this.BtnDisplayNewFriends.Name = "BtnDisplayNewFriends";
            this.BtnDisplayNewFriends.Size = new System.Drawing.Size(84, 40);
            this.BtnDisplayNewFriends.TabIndex = 4;
            this.BtnDisplayNewFriends.Text = "Load In New Friends";
            this.BtnDisplayNewFriends.UseVisualStyleBackColor = true;
            this.BtnDisplayNewFriends.Click += new System.EventHandler(this.BtnDisplayNewFriends_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(204, 229);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(88, 21);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmSimpleTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 262);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnDisplayNewFriends);
            this.Controls.Add(this.BtnNewFriends);
            this.Controls.Add(this.BtnMarks);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnDisplayFriends);
            this.Name = "FrmSimpleTextFile";
            this.Text = "Simple Text File Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDisplayFriends;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnMarks;
        private System.Windows.Forms.Button BtnNewFriends;
        private System.Windows.Forms.Button BtnDisplayNewFriends;
        private System.Windows.Forms.Button BtnExit;
    }
}

