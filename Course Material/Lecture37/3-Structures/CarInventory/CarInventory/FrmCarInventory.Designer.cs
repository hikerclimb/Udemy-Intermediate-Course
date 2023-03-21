namespace CarInventory
{
    partial class FrmCarInventory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMake = new System.Windows.Forms.TextBox();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.TxtDoors = new System.Windows.Forms.TextBox();
            this.PicCarPicture = new System.Windows.Forms.PictureBox();
            this.TrbSlider = new System.Windows.Forms.TrackBar();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtDoors);
            this.groupBox1.Controls.Add(this.TxtYear);
            this.groupBox1.Controls.Add(this.TxtModel);
            this.groupBox1.Controls.Add(this.TxtMake);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doors";
            // 
            // TxtMake
            // 
            this.TxtMake.Location = new System.Drawing.Point(88, 32);
            this.TxtMake.Name = "TxtMake";
            this.TxtMake.Size = new System.Drawing.Size(100, 20);
            this.TxtMake.TabIndex = 4;
            // 
            // TxtModel
            // 
            this.TxtModel.Location = new System.Drawing.Point(89, 81);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(98, 20);
            this.TxtModel.TabIndex = 5;
            // 
            // TxtYear
            // 
            this.TxtYear.Location = new System.Drawing.Point(88, 120);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(98, 20);
            this.TxtYear.TabIndex = 6;
            // 
            // TxtDoors
            // 
            this.TxtDoors.Location = new System.Drawing.Point(88, 155);
            this.TxtDoors.Name = "TxtDoors";
            this.TxtDoors.Size = new System.Drawing.Size(97, 20);
            this.TxtDoors.TabIndex = 7;
            // 
            // PicCarPicture
            // 
            this.PicCarPicture.Location = new System.Drawing.Point(278, 69);
            this.PicCarPicture.Name = "PicCarPicture";
            this.PicCarPicture.Size = new System.Drawing.Size(202, 149);
            this.PicCarPicture.TabIndex = 1;
            this.PicCarPicture.TabStop = false;
            // 
            // TrbSlider
            // 
            this.TrbSlider.Location = new System.Drawing.Point(32, 249);
            this.TrbSlider.Minimum = 1;
            this.TrbSlider.Name = "TrbSlider";
            this.TrbSlider.Size = new System.Drawing.Size(214, 50);
            this.TrbSlider.TabIndex = 2;
            this.TrbSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrbSlider.Value = 1;
            this.TrbSlider.Scroll += new System.EventHandler(this.TrbSlider_Scroll);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(315, 251);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(107, 25);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmCarInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 311);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TrbSlider);
            this.Controls.Add(this.PicCarPicture);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCarInventory";
            this.Text = "Car Inventory";
            this.Load += new System.EventHandler(this.FrmCarInventory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtDoors;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.TextBox TxtMake;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicCarPicture;
        private System.Windows.Forms.TrackBar TrbSlider;
        private System.Windows.Forms.Button BtnClose;
    }
}

