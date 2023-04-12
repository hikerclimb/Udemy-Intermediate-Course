namespace HashTableExample
{
    partial class FrmHashTable
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
            this.BtnHashTest = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnHashTest
            // 
            this.BtnHashTest.Location = new System.Drawing.Point(120, 55);
            this.BtnHashTest.Name = "BtnHashTest";
            this.BtnHashTest.Size = new System.Drawing.Size(103, 37);
            this.BtnHashTest.TabIndex = 0;
            this.BtnHashTest.Text = "Test";
            this.BtnHashTest.UseVisualStyleBackColor = true;
            this.BtnHashTest.Click += new System.EventHandler(this.BtnHashTest_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(53, 129);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(248, 84);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmHashTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 262);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnHashTest);
            this.Name = "FrmHashTable";
            this.Text = "Hash Table Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHashTest;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

