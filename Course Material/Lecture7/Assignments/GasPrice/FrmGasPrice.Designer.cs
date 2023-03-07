namespace GasPrice
{
    partial class FrmGasPrice
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
            BtnGas = new Button();
            SuspendLayout();
            // 
            // BtnGas
            // 
            BtnGas.AllowDrop = true;
            BtnGas.Location = new Point(195, 80);
            BtnGas.Name = "BtnGas";
            BtnGas.Size = new Size(188, 29);
            BtnGas.TabIndex = 0;
            BtnGas.Text = "Calculate Gas Amount";
            BtnGas.UseVisualStyleBackColor = true;
            BtnGas.Click += BtnGas_Click;
            // 
            // FrmGasPrice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnGas);
            Name = "FrmGasPrice";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnGas;
    }
}