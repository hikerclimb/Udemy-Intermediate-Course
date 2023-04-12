namespace Sorting_and_Searching_Arrays
{
    partial class FrmData
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtRmNum = new System.Windows.Forms.TextBox();
            this.TxtXtraCons = new System.Windows.Forms.TextBox();
            this.TxtReason = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChkFemale = new System.Windows.Forms.RadioButton();
            this.ChkMale = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(195, 6);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(146, 20);
            this.TxtName.TabIndex = 0;
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.Location = new System.Drawing.Point(12, 170);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(152, 65);
            this.BtnOK.TabIndex = 7;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(189, 172);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(152, 63);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // TxtRmNum
            // 
            this.TxtRmNum.Location = new System.Drawing.Point(195, 92);
            this.TxtRmNum.Name = "TxtRmNum";
            this.TxtRmNum.Size = new System.Drawing.Size(146, 20);
            this.TxtRmNum.TabIndex = 4;
            this.TxtRmNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRmNum_KeyPress);
            // 
            // TxtXtraCons
            // 
            this.TxtXtraCons.Location = new System.Drawing.Point(195, 140);
            this.TxtXtraCons.Name = "TxtXtraCons";
            this.TxtXtraCons.Size = new System.Drawing.Size(146, 20);
            this.TxtXtraCons.TabIndex = 6;
            // 
            // TxtReason
            // 
            this.TxtReason.Location = new System.Drawing.Point(195, 115);
            this.TxtReason.Name = "TxtReason";
            this.TxtReason.Size = new System.Drawing.Size(146, 20);
            this.TxtReason.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Patient Name:";
            // 
            // TxtAge
            // 
            this.TxtAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtAge.FormattingEnabled = true;
            this.TxtAge.Location = new System.Drawing.Point(195, 36);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(146, 21);
            this.TxtAge.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sex:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Room Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Reason of Admittance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Additional Health Conditions:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChkFemale);
            this.panel1.Controls.Add(this.ChkMale);
            this.panel1.Location = new System.Drawing.Point(195, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 26);
            this.panel1.TabIndex = 17;
            // 
            // ChkFemale
            // 
            this.ChkFemale.AutoSize = true;
            this.ChkFemale.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkFemale.Location = new System.Drawing.Point(77, 3);
            this.ChkFemale.Name = "ChkFemale";
            this.ChkFemale.Size = new System.Drawing.Size(66, 17);
            this.ChkFemale.TabIndex = 1;
            this.ChkFemale.TabStop = true;
            this.ChkFemale.Text = "Female";
            this.ChkFemale.UseVisualStyleBackColor = true;
            // 
            // ChkMale
            // 
            this.ChkMale.AutoSize = true;
            this.ChkMale.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkMale.Location = new System.Drawing.Point(3, 4);
            this.ChkMale.Name = "ChkMale";
            this.ChkMale.Size = new System.Drawing.Size(52, 17);
            this.ChkMale.TabIndex = 0;
            this.ChkMale.TabStop = true;
            this.ChkMale.Text = "Male";
            this.ChkMale.UseVisualStyleBackColor = true;
            // 
            // FrmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(359, 239);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtReason);
            this.Controls.Add(this.TxtXtraCons);
            this.Controls.Add(this.TxtRmNum);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtName);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmData";
            this.Text = "Patient Info";
            this.Load += new System.EventHandler(this.FrmData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtRmNum;
        private System.Windows.Forms.TextBox TxtXtraCons;
        private System.Windows.Forms.TextBox TxtReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TxtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ChkFemale;
        private System.Windows.Forms.RadioButton ChkMale;
    }
}