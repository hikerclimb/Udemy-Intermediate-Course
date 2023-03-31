namespace TriangleProblem
{
    partial class FrmTriangleProblem
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LstTriangles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(87, 38);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(161, 31);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate  Triangle Numbers";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // LstTriangles
            // 
            this.LstTriangles.FormattingEnabled = true;
            this.LstTriangles.Location = new System.Drawing.Point(44, 115);
            this.LstTriangles.Name = "LstTriangles";
            this.LstTriangles.Size = new System.Drawing.Size(244, 82);
            this.LstTriangles.TabIndex = 1;
            // 
            // FrmTriangleProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 262);
            this.Controls.Add(this.LstTriangles);
            this.Controls.Add(this.BtnGenerate);
            this.Name = "FrmTriangleProblem";
            this.Text = "The Triangle Problem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.ListBox LstTriangles;
    }
}

