namespace WindowsFormsApplication1
{
    partial class FrmSearchparameters
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
            this.BtnSearch = new System.Windows.Forms.Button();
            this.ChkHave = new System.Windows.Forms.CheckBox();
            this.LblNumber = new System.Windows.Forms.Label();
            this.LblAnd = new System.Windows.Forms.Label();
            this.CboNumber1 = new System.Windows.Forms.ComboBox();
            this.CboNumber2 = new System.Windows.Forms.ComboBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.CboType2 = new System.Windows.Forms.ComboBox();
            this.CboType1 = new System.Windows.Forms.ComboBox();
            this.LblAnd2 = new System.Windows.Forms.Label();
            this.LblTypes = new System.Windows.Forms.Label();
            this.ChkByhave = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(146, 168);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(106, 23);
            this.BtnSearch.TabIndex = 18;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // ChkHave
            // 
            this.ChkHave.AutoSize = true;
            this.ChkHave.Enabled = false;
            this.ChkHave.Location = new System.Drawing.Point(15, 174);
            this.ChkHave.Name = "ChkHave";
            this.ChkHave.Size = new System.Drawing.Size(52, 17);
            this.ChkHave.TabIndex = 17;
            this.ChkHave.Text = "Have";
            this.ChkHave.UseVisualStyleBackColor = true;
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Location = new System.Drawing.Point(11, 26);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(88, 13);
            this.LblNumber.TabIndex = 21;
            this.LblNumber.Text = "Number between";
            // 
            // LblAnd
            // 
            this.LblAnd.AutoSize = true;
            this.LblAnd.Location = new System.Drawing.Point(164, 26);
            this.LblAnd.Name = "LblAnd";
            this.LblAnd.Size = new System.Drawing.Size(25, 13);
            this.LblAnd.TabIndex = 22;
            this.LblAnd.Text = "and";
            // 
            // CboNumber1
            // 
            this.CboNumber1.FormattingEnabled = true;
            this.CboNumber1.Location = new System.Drawing.Point(105, 22);
            this.CboNumber1.Name = "CboNumber1";
            this.CboNumber1.Size = new System.Drawing.Size(53, 21);
            this.CboNumber1.TabIndex = 23;
            this.CboNumber1.Text = "001";
            // 
            // CboNumber2
            // 
            this.CboNumber2.FormattingEnabled = true;
            this.CboNumber2.Location = new System.Drawing.Point(195, 22);
            this.CboNumber2.Name = "CboNumber2";
            this.CboNumber2.Size = new System.Drawing.Size(53, 21);
            this.CboNumber2.TabIndex = 24;
            this.CboNumber2.Text = "493";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(11, 73);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(94, 13);
            this.LblName.TabIndex = 25;
            this.LblName.Text = "Name starting with";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(111, 70);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(137, 20);
            this.TxtName.TabIndex = 26;
            // 
            // CboType2
            // 
            this.CboType2.FormattingEnabled = true;
            this.CboType2.Location = new System.Drawing.Point(167, 115);
            this.CboType2.Name = "CboType2";
            this.CboType2.Size = new System.Drawing.Size(81, 21);
            this.CboType2.TabIndex = 30;
            // 
            // CboType1
            // 
            this.CboType1.FormattingEnabled = true;
            this.CboType1.Location = new System.Drawing.Point(54, 115);
            this.CboType1.Name = "CboType1";
            this.CboType1.Size = new System.Drawing.Size(79, 21);
            this.CboType1.TabIndex = 29;
            // 
            // LblAnd2
            // 
            this.LblAnd2.AutoSize = true;
            this.LblAnd2.Location = new System.Drawing.Point(139, 118);
            this.LblAnd2.Name = "LblAnd2";
            this.LblAnd2.Size = new System.Drawing.Size(25, 13);
            this.LblAnd2.TabIndex = 28;
            this.LblAnd2.Text = "and";
            // 
            // LblTypes
            // 
            this.LblTypes.AutoSize = true;
            this.LblTypes.Location = new System.Drawing.Point(12, 118);
            this.LblTypes.Name = "LblTypes";
            this.LblTypes.Size = new System.Drawing.Size(36, 13);
            this.LblTypes.TabIndex = 27;
            this.LblTypes.Text = "Types";
            // 
            // ChkByhave
            // 
            this.ChkByhave.AutoSize = true;
            this.ChkByhave.Location = new System.Drawing.Point(15, 151);
            this.ChkByhave.Name = "ChkByhave";
            this.ChkByhave.Size = new System.Drawing.Size(101, 17);
            this.ChkByhave.TabIndex = 31;
            this.ChkByhave.Text = "Search by have";
            this.ChkByhave.UseVisualStyleBackColor = true;
            this.ChkByhave.CheckedChanged += new System.EventHandler(this.ChkByhave_CheckedChanged);
            // 
            // FrmSearchparameters
            // 
            this.AcceptButton = this.BtnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 203);
            this.Controls.Add(this.ChkByhave);
            this.Controls.Add(this.CboType2);
            this.Controls.Add(this.CboType1);
            this.Controls.Add(this.LblAnd2);
            this.Controls.Add(this.LblTypes);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.CboNumber2);
            this.Controls.Add(this.CboNumber1);
            this.Controls.Add(this.LblAnd);
            this.Controls.Add(this.LblNumber);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.ChkHave);
            this.Name = "FrmSearchparameters";
            this.Text = "Search Parameters";
            this.Load += new System.EventHandler(this.FrmSearchparameters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.CheckBox ChkHave;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.Label LblAnd;
        private System.Windows.Forms.ComboBox CboNumber1;
        private System.Windows.Forms.ComboBox CboNumber2;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ComboBox CboType2;
        private System.Windows.Forms.ComboBox CboType1;
        private System.Windows.Forms.Label LblAnd2;
        private System.Windows.Forms.Label LblTypes;
        private System.Windows.Forms.CheckBox ChkByhave;
    }
}