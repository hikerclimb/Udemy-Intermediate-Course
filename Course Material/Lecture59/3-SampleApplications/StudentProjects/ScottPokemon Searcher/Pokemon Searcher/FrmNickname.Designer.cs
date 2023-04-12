namespace WindowsFormsApplication1
{
    partial class FrmNickname
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
            this.BtnOk = new System.Windows.Forms.Button();
            this.LblNickname = new System.Windows.Forms.Label();
            this.TxtNickname = new System.Windows.Forms.TextBox();
            this.ChkNickname = new System.Windows.Forms.CheckBox();
            this.ChkShiny = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(147, 62);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(79, 23);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LblNickname
            // 
            this.LblNickname.AutoSize = true;
            this.LblNickname.Location = new System.Drawing.Point(12, 15);
            this.LblNickname.Name = "LblNickname";
            this.LblNickname.Size = new System.Drawing.Size(82, 13);
            this.LblNickname.TabIndex = 3;
            this.LblNickname.Text = "Insert nickname";
            // 
            // TxtNickname
            // 
            this.TxtNickname.Location = new System.Drawing.Point(126, 12);
            this.TxtNickname.Name = "TxtNickname";
            this.TxtNickname.Size = new System.Drawing.Size(100, 20);
            this.TxtNickname.TabIndex = 4;
            // 
            // ChkNickname
            // 
            this.ChkNickname.AutoSize = true;
            this.ChkNickname.Location = new System.Drawing.Point(126, 39);
            this.ChkNickname.Name = "ChkNickname";
            this.ChkNickname.Size = new System.Drawing.Size(89, 17);
            this.ChkNickname.TabIndex = 5;
            this.ChkNickname.Text = "No nickname";
            this.ChkNickname.UseVisualStyleBackColor = true;
            this.ChkNickname.CheckedChanged += new System.EventHandler(this.ChkNickname_CheckedChanged);
            // 
            // ChkShiny
            // 
            this.ChkShiny.AutoSize = true;
            this.ChkShiny.Location = new System.Drawing.Point(15, 62);
            this.ChkShiny.Name = "ChkShiny";
            this.ChkShiny.Size = new System.Drawing.Size(58, 17);
            this.ChkShiny.TabIndex = 6;
            this.ChkShiny.Text = "Shiny?";
            this.ChkShiny.UseVisualStyleBackColor = true;
            // 
            // FrmNickname
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 97);
            this.Controls.Add(this.ChkShiny);
            this.Controls.Add(this.ChkNickname);
            this.Controls.Add(this.TxtNickname);
            this.Controls.Add(this.LblNickname);
            this.Controls.Add(this.BtnOk);
            this.Name = "FrmNickname";
            this.Text = "Nickname?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label LblNickname;
        private System.Windows.Forms.TextBox TxtNickname;
        private System.Windows.Forms.CheckBox ChkNickname;
        private System.Windows.Forms.CheckBox ChkShiny;
    }
}