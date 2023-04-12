namespace majorAssignment
{
    partial class frmAddDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDisplay));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.comboBoxTech = new System.Windows.Forms.ComboBox();
            this.txtDCR = new System.Windows.Forms.MaskedTextBox();
            this.txtRes = new System.Windows.Forms.MaskedTextBox();
            this.txtRate = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAspect = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCap = new System.Windows.Forms.ComboBox();
            this.UpDownTime = new System.Windows.Forms.NumericUpDown();
            this.UpDownSize = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(155, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(25, 318);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Part Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aspect Ratio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Display Capabilities:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Display Technology:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dynamic Contrast Ratio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Native Resolution:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Refresh Rate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Response Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Screen Size:";
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Items.AddRange(new object[] {
            "LG",
            "Samsung",
            "Sharp",
            "Panasonic",
            "Viewsonic",
            "Pioneer",
            "Sony"});
            this.comboBoxBrand.Location = new System.Drawing.Point(66, 37);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBrand.TabIndex = 12;
            // 
            // comboBoxTech
            // 
            this.comboBoxTech.FormattingEnabled = true;
            this.comboBoxTech.Items.AddRange(new object[] {
            "LCD",
            "Plasma",
            "OLED",
            "Rear Projection",
            "CRT"});
            this.comboBoxTech.Location = new System.Drawing.Point(121, 130);
            this.comboBoxTech.Name = "comboBoxTech";
            this.comboBoxTech.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTech.TabIndex = 13;
            // 
            // txtDCR
            // 
            this.txtDCR.Location = new System.Drawing.Point(139, 161);
            this.txtDCR.Name = "txtDCR";
            this.txtDCR.Size = new System.Drawing.Size(48, 20);
            this.txtDCR.TabIndex = 14;
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(112, 192);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(46, 20);
            this.txtRes.TabIndex = 16;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(91, 223);
            this.txtRate.Mask = "000";
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(34, 20);
            this.txtRate.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Hz";
            // 
            // txtAspect
            // 
            this.txtAspect.Location = new System.Drawing.Point(89, 68);
            this.txtAspect.Name = "txtAspect";
            this.txtAspect.Size = new System.Drawing.Size(34, 20);
            this.txtAspect.TabIndex = 24;
            // 
            // comboBoxCap
            // 
            this.comboBoxCap.FormattingEnabled = true;
            this.comboBoxCap.Items.AddRange(new object[] {
            "480i",
            "480p",
            "720i",
            "720p",
            "1080i",
            "1080p"});
            this.comboBoxCap.Location = new System.Drawing.Point(119, 102);
            this.comboBoxCap.Name = "comboBoxCap";
            this.comboBoxCap.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCap.TabIndex = 27;
            // 
            // UpDownTime
            // 
            this.UpDownTime.Location = new System.Drawing.Point(102, 255);
            this.UpDownTime.Name = "UpDownTime";
            this.UpDownTime.Size = new System.Drawing.Size(30, 20);
            this.UpDownTime.TabIndex = 28;
            // 
            // UpDownSize
            // 
            this.UpDownSize.Location = new System.Drawing.Point(85, 286);
            this.UpDownSize.Name = "UpDownSize";
            this.UpDownSize.Size = new System.Drawing.Size(30, 20);
            this.UpDownSize.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(138, 257);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "ms";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(121, 288);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Inches";
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(87, 6);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(130, 20);
            this.txtPN.TabIndex = 32;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(256, 351);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.UpDownSize);
            this.Controls.Add(this.UpDownTime);
            this.Controls.Add(this.comboBoxCap);
            this.Controls.Add(this.txtAspect);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtDCR);
            this.Controls.Add(this.comboBoxTech);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdd";
            this.Text = "Display Parameters";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxTech;
        private System.Windows.Forms.MaskedTextBox txtDCR;
        private System.Windows.Forms.MaskedTextBox txtRes;
        private System.Windows.Forms.MaskedTextBox txtRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtAspect;
        private System.Windows.Forms.ComboBox comboBoxCap;
        private System.Windows.Forms.NumericUpDown UpDownTime;
        private System.Windows.Forms.NumericUpDown UpDownSize;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPN;
    }
}