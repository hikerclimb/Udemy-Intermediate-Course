namespace Structured_Exception_Handling
{
    partial class frmExceptionHandlingExample
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
            this.btnCatchException = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCatchException
            // 
            this.btnCatchException.Location = new System.Drawing.Point(104, 128);
            this.btnCatchException.Name = "btnCatchException";
            this.btnCatchException.Size = new System.Drawing.Size(96, 23);
            this.btnCatchException.TabIndex = 0;
            this.btnCatchException.Text = "Catch Exception";
            this.btnCatchException.UseVisualStyleBackColor = true;
            this.btnCatchException.Click += new System.EventHandler(this.btnCatchException_Click);
            // 
            // frmExceptionHandlingExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btnCatchException);
            this.Name = "frmExceptionHandlingExample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Structured Error Handling";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCatchException;
    }
}

