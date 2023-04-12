namespace CarTracker
{
    partial class FrmTracker
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label listingIdLabel;
            System.Windows.Forms.Label colorIdLabel;
            System.Windows.Forms.Label makeIdLabel;
            System.Windows.Forms.Label carTypeIdLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTracker));
            this.carTrackerDataSet = new CarTracker.CarTrackerDataSet();
            this.listingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listingTableAdapter = new CarTracker.CarTrackerDataSetTableAdapters.ListingTableAdapter();
            this.tableAdapterManager = new CarTracker.CarTrackerDataSetTableAdapters.TableAdapterManager();
            this.carTypeTableAdapter = new CarTracker.CarTrackerDataSetTableAdapters.CarTypeTableAdapter();
            this.colorTableAdapter = new CarTracker.CarTrackerDataSetTableAdapters.ColorTableAdapter();
            this.makeTableAdapter = new CarTracker.CarTrackerDataSetTableAdapters.MakeTableAdapter();
            this.listingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listingIdTextBox = new System.Windows.Forms.TextBox();
            this.colorIdComboBox = new System.Windows.Forms.ComboBox();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makeIdComboBox = new System.Windows.Forms.ComboBox();
            this.makeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.carTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.colorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            listingIdLabel = new System.Windows.Forms.Label();
            colorIdLabel = new System.Windows.Forms.Label();
            makeIdLabel = new System.Windows.Forms.Label();
            carTypeIdLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingNavigator)).BeginInit();
            this.listingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listingIdLabel
            // 
            listingIdLabel.AutoSize = true;
            listingIdLabel.Location = new System.Drawing.Point(32, 92);
            listingIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            listingIdLabel.Name = "listingIdLabel";
            listingIdLabel.Size = new System.Drawing.Size(62, 16);
            listingIdLabel.TabIndex = 1;
            listingIdLabel.Text = "Listing Id:";
            // 
            // colorIdLabel
            // 
            colorIdLabel.AutoSize = true;
            colorIdLabel.Location = new System.Drawing.Point(483, 96);
            colorIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            colorIdLabel.Name = "colorIdLabel";
            colorIdLabel.Size = new System.Drawing.Size(56, 16);
            colorIdLabel.TabIndex = 3;
            colorIdLabel.Text = "Color Id:";
            // 
            // makeIdLabel
            // 
            makeIdLabel.AutoSize = true;
            makeIdLabel.Location = new System.Drawing.Point(479, 188);
            makeIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            makeIdLabel.Name = "makeIdLabel";
            makeIdLabel.Size = new System.Drawing.Size(58, 16);
            makeIdLabel.TabIndex = 5;
            makeIdLabel.Text = "Make Id:";
            // 
            // carTypeIdLabel
            // 
            carTypeIdLabel.AutoSize = true;
            carTypeIdLabel.Location = new System.Drawing.Point(32, 225);
            carTypeIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            carTypeIdLabel.Name = "carTypeIdLabel";
            carTypeIdLabel.Size = new System.Drawing.Size(80, 16);
            carTypeIdLabel.TabIndex = 7;
            carTypeIdLabel.Text = "Car Type Id:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(472, 290);
            yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(39, 16);
            yearLabel.TabIndex = 9;
            yearLabel.Text = "Year:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(259, 396);
            priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(41, 16);
            priceLabel.TabIndex = 11;
            priceLabel.Text = "Price:";
            // 
            // carTrackerDataSet
            // 
            this.carTrackerDataSet.DataSetName = "CarTrackerDataSet";
            this.carTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listingBindingSource
            // 
            this.listingBindingSource.DataMember = "Listing";
            this.listingBindingSource.DataSource = this.carTrackerDataSet;
            // 
            // listingTableAdapter
            // 
            this.listingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarTypeTableAdapter = this.carTypeTableAdapter;
            this.tableAdapterManager.ColorTableAdapter = this.colorTableAdapter;
            this.tableAdapterManager.ListingTableAdapter = this.listingTableAdapter;
            this.tableAdapterManager.MakeTableAdapter = this.makeTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarTracker.CarTrackerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carTypeTableAdapter
            // 
            this.carTypeTableAdapter.ClearBeforeFill = true;
            // 
            // colorTableAdapter
            // 
            this.colorTableAdapter.ClearBeforeFill = true;
            // 
            // makeTableAdapter
            // 
            this.makeTableAdapter.ClearBeforeFill = true;
            // 
            // listingBindingNavigator
            // 
            this.listingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listingBindingNavigator.BindingSource = this.listingBindingSource;
            this.listingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listingBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listingBindingNavigatorSaveItem});
            this.listingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listingBindingNavigator.Name = "listingBindingNavigator";
            this.listingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listingBindingNavigator.Size = new System.Drawing.Size(1067, 27);
            this.listingBindingNavigator.TabIndex = 0;
            this.listingBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // listingBindingNavigatorSaveItem
            // 
            this.listingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listingBindingNavigatorSaveItem.Image")));
            this.listingBindingNavigatorSaveItem.Name = "listingBindingNavigatorSaveItem";
            this.listingBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.listingBindingNavigatorSaveItem.Text = "Save Data";
            this.listingBindingNavigatorSaveItem.Click += new System.EventHandler(this.listingBindingNavigatorSaveItem_Click);
            // 
            // listingIdTextBox
            // 
            this.listingIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "ListingId", true));
            this.listingIdTextBox.Location = new System.Drawing.Point(140, 92);
            this.listingIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listingIdTextBox.Name = "listingIdTextBox";
            this.listingIdTextBox.Size = new System.Drawing.Size(160, 22);
            this.listingIdTextBox.TabIndex = 2;
            // 
            // colorIdComboBox
            // 
            this.colorIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listingBindingSource, "ColorId", true));
            this.colorIdComboBox.DataSource = this.colorBindingSource1;
            this.colorIdComboBox.DisplayMember = "ColorName";
            this.colorIdComboBox.FormattingEnabled = true;
            this.colorIdComboBox.Location = new System.Drawing.Point(584, 92);
            this.colorIdComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorIdComboBox.Name = "colorIdComboBox";
            this.colorIdComboBox.Size = new System.Drawing.Size(160, 24);
            this.colorIdComboBox.TabIndex = 4;
            this.colorIdComboBox.ValueMember = "ColorId";
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataMember = "Color";
            this.colorBindingSource.DataSource = this.carTrackerDataSet;
            // 
            // makeIdComboBox
            // 
            this.makeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listingBindingSource, "MakeId", true));
            this.makeIdComboBox.DataSource = this.makeBindingSource;
            this.makeIdComboBox.DisplayMember = "MakeName";
            this.makeIdComboBox.FormattingEnabled = true;
            this.makeIdComboBox.Location = new System.Drawing.Point(584, 178);
            this.makeIdComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.makeIdComboBox.Name = "makeIdComboBox";
            this.makeIdComboBox.Size = new System.Drawing.Size(160, 24);
            this.makeIdComboBox.TabIndex = 6;
            this.makeIdComboBox.ValueMember = "MakeId";
            // 
            // makeBindingSource
            // 
            this.makeBindingSource.DataMember = "Make";
            this.makeBindingSource.DataSource = this.carTrackerDataSet;
            // 
            // carTypeIdComboBox
            // 
            this.carTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listingBindingSource, "CarTypeId", true));
            this.carTypeIdComboBox.DataSource = this.carTypeBindingSource;
            this.carTypeIdComboBox.DisplayMember = "CarTypeName";
            this.carTypeIdComboBox.FormattingEnabled = true;
            this.carTypeIdComboBox.Location = new System.Drawing.Point(143, 215);
            this.carTypeIdComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carTypeIdComboBox.Name = "carTypeIdComboBox";
            this.carTypeIdComboBox.Size = new System.Drawing.Size(160, 24);
            this.carTypeIdComboBox.TabIndex = 8;
            this.carTypeIdComboBox.ValueMember = "CarTypeId";
            // 
            // carTypeBindingSource
            // 
            this.carTypeBindingSource.DataMember = "CarType";
            this.carTypeBindingSource.DataSource = this.carTrackerDataSet;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(584, 282);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(160, 22);
            this.yearTextBox.TabIndex = 10;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(353, 393);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(160, 22);
            this.priceTextBox.TabIndex = 12;
            // 
            // colorBindingSource1
            // 
            this.colorBindingSource1.DataMember = "Color";
            this.colorBindingSource1.DataSource = this.carTrackerDataSet;
            // 
            // FrmTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(listingIdLabel);
            this.Controls.Add(this.listingIdTextBox);
            this.Controls.Add(colorIdLabel);
            this.Controls.Add(this.colorIdComboBox);
            this.Controls.Add(makeIdLabel);
            this.Controls.Add(this.makeIdComboBox);
            this.Controls.Add(carTypeIdLabel);
            this.Controls.Add(this.carTypeIdComboBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.listingBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Tracker App";
            this.Load += new System.EventHandler(this.FrmTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingNavigator)).EndInit();
            this.listingBindingNavigator.ResumeLayout(false);
            this.listingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CarTrackerDataSet carTrackerDataSet;
        private System.Windows.Forms.BindingSource listingBindingSource;
        private CarTrackerDataSetTableAdapters.ListingTableAdapter listingTableAdapter;
        private CarTrackerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator listingBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listingBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox listingIdTextBox;
        private System.Windows.Forms.ComboBox colorIdComboBox;
        private System.Windows.Forms.ComboBox makeIdComboBox;
        private System.Windows.Forms.ComboBox carTypeIdComboBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private CarTrackerDataSetTableAdapters.ColorTableAdapter colorTableAdapter;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private CarTrackerDataSetTableAdapters.MakeTableAdapter makeTableAdapter;
        private System.Windows.Forms.BindingSource makeBindingSource;
        private CarTrackerDataSetTableAdapters.CarTypeTableAdapter carTypeTableAdapter;
        private System.Windows.Forms.BindingSource carTypeBindingSource;
        private System.Windows.Forms.BindingSource colorBindingSource1;
    }
}

