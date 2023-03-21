namespace StructuresAssignment
{
    partial class FrmJunkFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJunkFood));
            this.GrpDescription = new System.Windows.Forms.GroupBox();
            this.BtnSpeakIngredients = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.LblNameCaption = new System.Windows.Forms.Label();
            this.LblIngredient = new System.Windows.Forms.Label();
            this.LblIngredients = new System.Windows.Forms.Label();
            this.LblPlaceofInvention = new System.Windows.Forms.Label();
            this.LblInventedIn = new System.Windows.Forms.Label();
            this.TrbJunkFoodTypes = new System.Windows.Forms.TrackBar();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PicJunkFood = new System.Windows.Forms.PictureBox();
            this.LblDescriptionCaption = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.GrpDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbJunkFoodTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicJunkFood)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpDescription
            // 
            this.GrpDescription.Controls.Add(this.LblDescription);
            this.GrpDescription.Controls.Add(this.LblDescriptionCaption);
            this.GrpDescription.Controls.Add(this.BtnSpeakIngredients);
            this.GrpDescription.Controls.Add(this.LblName);
            this.GrpDescription.Controls.Add(this.LblNameCaption);
            this.GrpDescription.Controls.Add(this.LblIngredient);
            this.GrpDescription.Controls.Add(this.LblIngredients);
            this.GrpDescription.Controls.Add(this.LblPlaceofInvention);
            this.GrpDescription.Controls.Add(this.LblInventedIn);
            this.GrpDescription.Location = new System.Drawing.Point(2, 25);
            this.GrpDescription.Name = "GrpDescription";
            this.GrpDescription.Size = new System.Drawing.Size(260, 241);
            this.GrpDescription.TabIndex = 0;
            this.GrpDescription.TabStop = false;
            this.GrpDescription.Text = "Junk Food Description";
            // 
            // BtnSpeakIngredients
            // 
            this.BtnSpeakIngredients.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnSpeakIngredients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSpeakIngredients.BackgroundImage")));
            this.BtnSpeakIngredients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSpeakIngredients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSpeakIngredients.Location = new System.Drawing.Point(10, 190);
            this.BtnSpeakIngredients.Name = "BtnSpeakIngredients";
            this.BtnSpeakIngredients.Size = new System.Drawing.Size(45, 42);
            this.BtnSpeakIngredients.TabIndex = 10;
            this.BtnSpeakIngredients.UseVisualStyleBackColor = false;
            this.BtnSpeakIngredients.Click += new System.EventHandler(this.BtnSpeakIngredients_Click);
            // 
            // LblName
            // 
            this.LblName.Location = new System.Drawing.Point(74, 36);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(161, 31);
            this.LblName.TabIndex = 11;
            // 
            // LblNameCaption
            // 
            this.LblNameCaption.AutoSize = true;
            this.LblNameCaption.Location = new System.Drawing.Point(7, 36);
            this.LblNameCaption.Name = "LblNameCaption";
            this.LblNameCaption.Size = new System.Drawing.Size(38, 13);
            this.LblNameCaption.TabIndex = 10;
            this.LblNameCaption.Text = "Name:";
            // 
            // LblIngredient
            // 
            this.LblIngredient.Location = new System.Drawing.Point(74, 168);
            this.LblIngredient.Name = "LblIngredient";
            this.LblIngredient.Size = new System.Drawing.Size(180, 70);
            this.LblIngredient.TabIndex = 3;
            // 
            // LblIngredients
            // 
            this.LblIngredients.AutoSize = true;
            this.LblIngredients.Location = new System.Drawing.Point(7, 168);
            this.LblIngredients.Name = "LblIngredients";
            this.LblIngredients.Size = new System.Drawing.Size(62, 13);
            this.LblIngredients.TabIndex = 2;
            this.LblIngredients.Text = "Ingredients:";
            // 
            // LblPlaceofInvention
            // 
            this.LblPlaceofInvention.AutoSize = true;
            this.LblPlaceofInvention.Location = new System.Drawing.Point(74, 67);
            this.LblPlaceofInvention.Name = "LblPlaceofInvention";
            this.LblPlaceofInvention.Size = new System.Drawing.Size(0, 13);
            this.LblPlaceofInvention.TabIndex = 1;
            // 
            // LblInventedIn
            // 
            this.LblInventedIn.AutoSize = true;
            this.LblInventedIn.Location = new System.Drawing.Point(6, 67);
            this.LblInventedIn.Name = "LblInventedIn";
            this.LblInventedIn.Size = new System.Drawing.Size(67, 13);
            this.LblInventedIn.TabIndex = 0;
            this.LblInventedIn.Text = "Invented In: ";
            // 
            // TrbJunkFoodTypes
            // 
            this.TrbJunkFoodTypes.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.TrbJunkFoodTypes.Location = new System.Drawing.Point(12, 272);
            this.TrbJunkFoodTypes.Maximum = 12;
            this.TrbJunkFoodTypes.Minimum = 1;
            this.TrbJunkFoodTypes.Name = "TrbJunkFoodTypes";
            this.TrbJunkFoodTypes.Size = new System.Drawing.Size(182, 64);
            this.TrbJunkFoodTypes.TabIndex = 1;
            this.TrbJunkFoodTypes.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrbJunkFoodTypes.Value = 1;
            this.TrbJunkFoodTypes.Scroll += new System.EventHandler(this.TrbJunkFoodTypes_Scroll);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnClose.Location = new System.Drawing.Point(365, 291);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(106, 36);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PicJunkFood
            // 
            this.PicJunkFood.Location = new System.Drawing.Point(287, 42);
            this.PicJunkFood.Name = "PicJunkFood";
            this.PicJunkFood.Size = new System.Drawing.Size(200, 200);
            this.PicJunkFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicJunkFood.TabIndex = 3;
            this.PicJunkFood.TabStop = false;
            // 
            // LblDescriptionCaption
            // 
            this.LblDescriptionCaption.AutoSize = true;
            this.LblDescriptionCaption.Location = new System.Drawing.Point(6, 95);
            this.LblDescriptionCaption.Name = "LblDescriptionCaption";
            this.LblDescriptionCaption.Size = new System.Drawing.Size(66, 13);
            this.LblDescriptionCaption.TabIndex = 12;
            this.LblDescriptionCaption.Text = "Description: ";
            // 
            // LblDescription
            // 
            this.LblDescription.Location = new System.Drawing.Point(74, 95);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(180, 73);
            this.LblDescription.TabIndex = 13;
            // 
            // FrmJunkFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(499, 342);
            this.Controls.Add(this.PicJunkFood);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TrbJunkFoodTypes);
            this.Controls.Add(this.GrpDescription);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJunkFood";
            this.Text = "Junk Foods...";
            this.Load += new System.EventHandler(this.FrmJunkFood_Load);
            this.GrpDescription.ResumeLayout(false);
            this.GrpDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbJunkFoodTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicJunkFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpDescription;
        private System.Windows.Forms.TrackBar TrbJunkFoodTypes;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PictureBox PicJunkFood;
        private System.Windows.Forms.Label LblPlaceofInvention;
        private System.Windows.Forms.Label LblInventedIn;
        private System.Windows.Forms.Label LblIngredients;
        private System.Windows.Forms.Label LblIngredient;
        private System.Windows.Forms.Button BtnSpeakIngredients;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblNameCaption;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblDescriptionCaption;
    }
}

