namespace FirstApp
{
    partial class FrmFirstApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirstApp));
            lblTitle = new Label();
            txtName = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnHello = new Button();
            btnExit = new Button();
            grpMood = new GroupBox();
            rdoSad = new RadioButton();
            rdoHappy = new RadioButton();
            grpOther = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            picHappy = new PictureBox();
            picSad = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            grpMood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHappy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSad).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(177, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(269, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome to my first program";
            // 
            // txtName
            // 
            txtName.Location = new Point(241, 114);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.HANDSHAK;
            pictureBox1.Location = new Point(134, 189);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(348, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnHello
            // 
            btnHello.Location = new Point(139, 286);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(94, 29);
            btnHello.TabIndex = 4;
            btnHello.Text = "Hello";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(353, 285);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // grpMood
            // 
            grpMood.Controls.Add(rdoSad);
            grpMood.Controls.Add(rdoHappy);
            grpMood.Location = new Point(547, 57);
            grpMood.Name = "grpMood";
            grpMood.Size = new Size(250, 125);
            grpMood.TabIndex = 6;
            grpMood.TabStop = false;
            grpMood.Text = "Moods";
            // 
            // rdoSad
            // 
            rdoSad.AutoSize = true;
            rdoSad.Location = new Point(13, 64);
            rdoSad.Name = "rdoSad";
            rdoSad.Size = new Size(55, 24);
            rdoSad.TabIndex = 1;
            rdoSad.TabStop = true;
            rdoSad.Text = "Sad";
            rdoSad.UseVisualStyleBackColor = true;
            rdoSad.CheckedChanged += rdoSad_CheckedChanged;
            // 
            // rdoHappy
            // 
            rdoHappy.AutoSize = true;
            rdoHappy.Location = new Point(15, 27);
            rdoHappy.Name = "rdoHappy";
            rdoHappy.Size = new Size(74, 24);
            rdoHappy.TabIndex = 0;
            rdoHappy.TabStop = true;
            rdoHappy.Text = "Happy";
            rdoHappy.UseVisualStyleBackColor = true;
            rdoHappy.CheckedChanged += rdoHappy_CheckedChanged;
            // 
            // grpOther
            // 
            grpOther.Location = new Point(548, 237);
            grpOther.Name = "grpOther";
            grpOther.Size = new Size(250, 125);
            grpOther.TabIndex = 7;
            grpOther.TabStop = false;
            grpOther.Text = "groupBox2";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(558, 269);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(556, 305);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(117, 24);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // picHappy
            // 
            picHappy.Image = Properties.Resources.FACE02;
            picHappy.Location = new Point(820, 73);
            picHappy.Name = "picHappy";
            picHappy.Size = new Size(76, 35);
            picHappy.SizeMode = PictureBoxSizeMode.StretchImage;
            picHappy.TabIndex = 10;
            picHappy.TabStop = false;
            picHappy.Visible = false;
            // 
            // picSad
            // 
            picSad.Image = Properties.Resources.FACE04;
            picSad.Location = new Point(820, 121);
            picSad.Name = "picSad";
            picSad.Size = new Size(76, 35);
            picSad.SizeMode = PictureBoxSizeMode.StretchImage;
            picSad.TabIndex = 11;
            picSad.TabStop = false;
            picSad.Visible = false;
            // 
            // FrmFirstApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(921, 450);
            Controls.Add(picSad);
            Controls.Add(picHappy);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(grpOther);
            Controls.Add(grpMood);
            Controls.Add(btnExit);
            Controls.Add(btnHello);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtName);
            Controls.Add(lblTitle);
            Name = "FrmFirstApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "First App";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            grpMood.ResumeLayout(false);
            grpMood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHappy).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtName;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnHello;
        private Button btnExit;
        private GroupBox grpMood;
        private RadioButton rdoSad;
        private RadioButton rdoHappy;
        private GroupBox grpOther;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private PictureBox picHappy;
        private PictureBox picSad;
    }
}