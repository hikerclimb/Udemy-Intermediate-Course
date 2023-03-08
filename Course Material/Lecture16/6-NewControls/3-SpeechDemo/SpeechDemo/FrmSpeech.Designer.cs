namespace SpeechDemo
{
    partial class FrmSpeech
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
            this.TxtSpeech = new System.Windows.Forms.TextBox();
            this.BtnSpeak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSpeech
            // 
            this.TxtSpeech.Location = new System.Drawing.Point(43, 28);
            this.TxtSpeech.Multiline = true;
            this.TxtSpeech.Name = "TxtSpeech";
            this.TxtSpeech.Size = new System.Drawing.Size(199, 142);
            this.TxtSpeech.TabIndex = 0;
            // 
            // BtnSpeak
            // 
            this.BtnSpeak.Location = new System.Drawing.Point(96, 209);
            this.BtnSpeak.Name = "BtnSpeak";
            this.BtnSpeak.Size = new System.Drawing.Size(93, 29);
            this.BtnSpeak.TabIndex = 1;
            this.BtnSpeak.Text = "Speak";
            this.BtnSpeak.UseVisualStyleBackColor = true;
            this.BtnSpeak.Click += new System.EventHandler(this.BtnSpeak_Click);
            // 
            // FrmSpeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.BtnSpeak);
            this.Controls.Add(this.TxtSpeech);
            this.Name = "FrmSpeech";
            this.Text = "Speech API Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSpeech;
        private System.Windows.Forms.Button BtnSpeak;
    }
}

