namespace DataAnalysis
{
    partial class FrmDataAnalysis
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
            this.BtnQuestionnaire = new System.Windows.Forms.Button();
            this.BtnCensus = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnQuestionnaire
            // 
            this.BtnQuestionnaire.Location = new System.Drawing.Point(70, 31);
            this.BtnQuestionnaire.Name = "BtnQuestionnaire";
            this.BtnQuestionnaire.Size = new System.Drawing.Size(130, 31);
            this.BtnQuestionnaire.TabIndex = 0;
            this.BtnQuestionnaire.Text = "Questionnaire Analysis";
            this.BtnQuestionnaire.UseVisualStyleBackColor = true;
            this.BtnQuestionnaire.Click += new System.EventHandler(this.BtnQuestionnaire_Click);
            // 
            // BtnCensus
            // 
            this.BtnCensus.Location = new System.Drawing.Point(279, 33);
            this.BtnCensus.Name = "BtnCensus";
            this.BtnCensus.Size = new System.Drawing.Size(133, 28);
            this.BtnCensus.TabIndex = 1;
            this.BtnCensus.Text = "Census Analysis";
            this.BtnCensus.UseVisualStyleBackColor = true;
            this.BtnCensus.Click += new System.EventHandler(this.BtnCensus_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(72, 89);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(339, 183);
            this.TxtDisplay.TabIndex = 2;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(206, 294);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(69, 21);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmDataAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 324);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnCensus);
            this.Controls.Add(this.BtnQuestionnaire);
            this.Name = "FrmDataAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnQuestionnaire;
        private System.Windows.Forms.Button BtnCensus;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnExit;
    }
}

