namespace majorAssignment
{
    partial class frmAddReceiver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddReceiver));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.UpDownHDMIinputs = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWPC = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxChannels = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownHDMIinputs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(40, 177);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(170, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // UpDownHDMIinputs
            // 
            this.UpDownHDMIinputs.Location = new System.Drawing.Point(142, 145);
            this.UpDownHDMIinputs.Name = "UpDownHDMIinputs";
            this.UpDownHDMIinputs.Size = new System.Drawing.Size(30, 20);
            this.UpDownHDMIinputs.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "HDMI Inputs:";
            // 
            // txtWPC
            // 
            this.txtWPC.Location = new System.Drawing.Point(142, 107);
            this.txtWPC.Mask = "000";
            this.txtWPC.Name = "txtWPC";
            this.txtWPC.Size = new System.Drawing.Size(34, 20);
            this.txtWPC.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Watts per Channel:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(142, 12);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(130, 20);
            this.txtBrand.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Brand:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(142, 41);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(130, 20);
            this.txtModel.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Model:";
            // 
            // comboBoxChannels
            // 
            this.comboBoxChannels.FormattingEnabled = true;
            this.comboBoxChannels.Items.AddRange(new object[] {
            "5.1",
            "6.1",
            "7.1"});
            this.comboBoxChannels.Location = new System.Drawing.Point(142, 67);
            this.comboBoxChannels.Name = "comboBoxChannels";
            this.comboBoxChannels.Size = new System.Drawing.Size(56, 21);
            this.comboBoxChannels.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Channels:";
            // 
            // frmAddReceiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 217);
            this.Controls.Add(this.comboBoxChannels);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWPC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UpDownHDMIinputs);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddReceiver";
            this.Text = "Receiver Parameters";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownHDMIinputs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown UpDownHDMIinputs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtWPC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxChannels;
        private System.Windows.Forms.Label label5;
    }
}