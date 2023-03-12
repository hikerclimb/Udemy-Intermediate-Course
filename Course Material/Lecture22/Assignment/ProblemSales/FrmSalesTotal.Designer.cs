namespace ProblemSales
{
    partial class FrmSalesTotal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnLoad = new Button();
            TxtOutput = new TextBox();
            BtnExit = new Button();
            SuspendLayout();
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(37, 61);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(94, 29);
            BtnLoad.TabIndex = 0;
            BtnLoad.Text = "Load Data";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(190, 61);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.Size = new Size(563, 300);
            TxtOutput.TabIndex = 1;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(436, 401);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(94, 29);
            BtnExit.TabIndex = 2;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // FrmSalesTotal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnExit);
            Controls.Add(TxtOutput);
            Controls.Add(BtnLoad);
            Name = "FrmSalesTotal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLoad;
        private TextBox TxtOutput;
        private Button BtnExit;
    }
}