﻿namespace TelephoneHelper
{
    partial class FrmTelephone
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
            this.BtnTelephone = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnTelephone
            // 
            this.BtnTelephone.Location = new System.Drawing.Point(238, 52);
            this.BtnTelephone.Name = "BtnTelephone";
            this.BtnTelephone.Size = new System.Drawing.Size(172, 37);
            this.BtnTelephone.TabIndex = 0;
            this.BtnTelephone.Text = "Telephone Help";
            this.BtnTelephone.UseVisualStyleBackColor = true;
            this.BtnTelephone.Click += new System.EventHandler(this.BtnTelephone_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(100, 143);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(449, 200);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmTelephone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 437);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnTelephone);
            this.Name = "FrmTelephone";
            this.Text = "Telephone Helper Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTelephone;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

