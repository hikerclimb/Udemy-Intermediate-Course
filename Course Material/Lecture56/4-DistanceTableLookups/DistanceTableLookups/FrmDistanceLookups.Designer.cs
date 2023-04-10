namespace DistanceTableLookups
{
    partial class FrmDistanceLookups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDistanceLookups));
            this.CboFrom = new System.Windows.Forms.ComboBox();
            this.CboTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLookup = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CboFrom
            // 
            this.CboFrom.FormattingEnabled = true;
            this.CboFrom.Location = new System.Drawing.Point(36, 43);
            this.CboFrom.Name = "CboFrom";
            this.CboFrom.Size = new System.Drawing.Size(130, 21);
            this.CboFrom.TabIndex = 0;
            // 
            // CboTo
            // 
            this.CboTo.FormattingEnabled = true;
            this.CboTo.Location = new System.Drawing.Point(198, 43);
            this.CboTo.Name = "CboTo";
            this.CboTo.Size = new System.Drawing.Size(130, 21);
            this.CboTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // BtnLookup
            // 
            this.BtnLookup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLookup.Location = new System.Drawing.Point(127, 148);
            this.BtnLookup.Name = "BtnLookup";
            this.BtnLookup.Size = new System.Drawing.Size(108, 24);
            this.BtnLookup.TabIndex = 4;
            this.BtnLookup.Text = "Perform Distance Lookup";
            this.BtnLookup.UseVisualStyleBackColor = true;
            this.BtnLookup.Click += new System.EventHandler(this.BtnLookup_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Location = new System.Drawing.Point(151, 207);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(58, 20);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmDistanceLookups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 262);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLookup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboTo);
            this.Controls.Add(this.CboFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmDistanceLookups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distance Table Lookups";
            this.Load += new System.EventHandler(this.FrmDistanceLookups_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboFrom;
        private System.Windows.Forms.ComboBox CboTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLookup;
        private System.Windows.Forms.Button BtnExit;
    }
}

