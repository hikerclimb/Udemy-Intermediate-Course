namespace Library
{
    partial class FrmAdminLogin
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
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSubmit.Location = new System.Drawing.Point(12, 89);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(222, 30);
            this.BtnSubmit.TabIndex = 0;
            this.BtnSubmit.Text = "LOGIN";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(10, 19);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(58, 13);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "Username:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(12, 61);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(56, 13);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Password:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(91, 16);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(143, 20);
            this.TxtUsername.TabIndex = 3;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(91, 54);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(143, 20);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // FrmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 131);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.BtnSubmit);
            this.MaximizeBox = false;
            this.Name = "FrmAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to Admin Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
    }
}