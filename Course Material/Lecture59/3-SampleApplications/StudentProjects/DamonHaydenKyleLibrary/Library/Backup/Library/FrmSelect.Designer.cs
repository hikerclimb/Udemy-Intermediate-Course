namespace Library
{
    partial class FrmSelect
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
            this.TxtBookName2 = new System.Windows.Forms.TextBox();
            this.TxtAuthor2 = new System.Windows.Forms.TextBox();
            this.TxtPublishDate2 = new System.Windows.Forms.TextBox();
            this.TxtGenre = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblpublish = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CboStatus = new System.Windows.Forms.ComboBox();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.PnlSelect = new System.Windows.Forms.Panel();
            this.cboNames = new System.Windows.Forms.ComboBox();
            this.PnlMain.SuspendLayout();
            this.PnlSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBookName2
            // 
            this.TxtBookName2.Location = new System.Drawing.Point(114, 5);
            this.TxtBookName2.Name = "TxtBookName2";
            this.TxtBookName2.Size = new System.Drawing.Size(100, 20);
            this.TxtBookName2.TabIndex = 2;
            this.TxtBookName2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBookName2_KeyPress);
            // 
            // TxtAuthor2
            // 
            this.TxtAuthor2.Location = new System.Drawing.Point(114, 31);
            this.TxtAuthor2.Name = "TxtAuthor2";
            this.TxtAuthor2.Size = new System.Drawing.Size(100, 20);
            this.TxtAuthor2.TabIndex = 3;
            this.TxtAuthor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAuthor2_KeyPress);
            // 
            // TxtPublishDate2
            // 
            this.TxtPublishDate2.Location = new System.Drawing.Point(114, 57);
            this.TxtPublishDate2.Name = "TxtPublishDate2";
            this.TxtPublishDate2.Size = new System.Drawing.Size(100, 20);
            this.TxtPublishDate2.TabIndex = 4;
            this.TxtPublishDate2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPublishDate2_KeyPress);
            // 
            // TxtGenre
            // 
            this.TxtGenre.Location = new System.Drawing.Point(114, 83);
            this.TxtGenre.Name = "TxtGenre";
            this.TxtGenre.Size = new System.Drawing.Size(100, 20);
            this.TxtGenre.TabIndex = 5;
            this.TxtGenre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGenre_KeyPress);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(42, 12);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(66, 13);
            this.lbltitle.TabIndex = 7;
            this.lbltitle.Text = "Book Name:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(67, 34);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Author:";
            // 
            // lblpublish
            // 
            this.lblpublish.AutoSize = true;
            this.lblpublish.Location = new System.Drawing.Point(38, 60);
            this.lblpublish.Name = "lblpublish";
            this.lblpublish.Size = new System.Drawing.Size(70, 13);
            this.lblpublish.TabIndex = 9;
            this.lblpublish.Text = "Publish Date:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(69, 88);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(39, 13);
            this.lblGenre.TabIndex = 10;
            this.lblGenre.Text = "Genre:";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(67, 112);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(40, 13);
            this.lblstatus.TabIndex = 11;
            this.lblstatus.Text = "Status:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(185, 138);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(52, 34);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // CboStatus
            // 
            this.CboStatus.FormattingEnabled = true;
            this.CboStatus.Location = new System.Drawing.Point(114, 110);
            this.CboStatus.Name = "CboStatus";
            this.CboStatus.Size = new System.Drawing.Size(99, 21);
            this.CboStatus.TabIndex = 14;
            this.CboStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboStatus_KeyPress);
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.TxtPublishDate2);
            this.PnlMain.Controls.Add(this.BtnDelete);
            this.PnlMain.Controls.Add(this.BtnCancel);
            this.PnlMain.Controls.Add(this.CboStatus);
            this.PnlMain.Controls.Add(this.BtnAdd);
            this.PnlMain.Controls.Add(this.BtnEdit);
            this.PnlMain.Controls.Add(this.TxtBookName2);
            this.PnlMain.Controls.Add(this.TxtAuthor2);
            this.PnlMain.Controls.Add(this.TxtGenre);
            this.PnlMain.Controls.Add(this.lblstatus);
            this.PnlMain.Controls.Add(this.lbltitle);
            this.PnlMain.Controls.Add(this.lblGenre);
            this.PnlMain.Controls.Add(this.lblAuthor);
            this.PnlMain.Controls.Add(this.lblpublish);
            this.PnlMain.Location = new System.Drawing.Point(31, 55);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(249, 178);
            this.PnlMain.TabIndex = 15;
            this.PnlMain.Visible = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnDelete.Location = new System.Drawing.Point(127, 139);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(52, 33);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAdd.Location = new System.Drawing.Point(11, 139);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(52, 33);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnEdit.Location = new System.Drawing.Point(69, 139);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(52, 33);
            this.BtnEdit.TabIndex = 17;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // PnlSelect
            // 
            this.PnlSelect.Controls.Add(this.cboNames);
            this.PnlSelect.Location = new System.Drawing.Point(31, 12);
            this.PnlSelect.Name = "PnlSelect";
            this.PnlSelect.Size = new System.Drawing.Size(249, 36);
            this.PnlSelect.TabIndex = 19;
            // 
            // cboNames
            // 
            this.cboNames.FormattingEnabled = true;
            this.cboNames.Location = new System.Drawing.Point(3, 9);
            this.cboNames.Name = "cboNames";
            this.cboNames.Size = new System.Drawing.Size(243, 21);
            this.cboNames.TabIndex = 0;
            this.cboNames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboNames_KeyPress);
            this.cboNames.TextChanged += new System.EventHandler(this.cboNames_TextChanged);
            // 
            // FrmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 248);
            this.Controls.Add(this.PnlSelect);
            this.Controls.Add(this.PnlMain);
            this.MaximizeBox = false;
            this.Name = "FrmSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify A Book";
            this.Load += new System.EventHandler(this.FrmSelect_Load);
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.PnlSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBookName2;
        private System.Windows.Forms.TextBox TxtAuthor2;
        private System.Windows.Forms.TextBox TxtPublishDate2;
        private System.Windows.Forms.TextBox TxtGenre;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblpublish;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CboStatus;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Panel PnlSelect;
        private System.Windows.Forms.ComboBox cboNames;
    }
}