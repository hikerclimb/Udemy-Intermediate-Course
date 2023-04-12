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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTracker));
            System.Windows.Forms.Label listingIdLabel;
            System.Windows.Forms.Label colorIdLabel;
            System.Windows.Forms.Label makeIdLabel;
            System.Windows.Forms.Label carTypeIdLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label priceLabel;
            this.carTrackerDataSet = new CarTracker.CarTrackerDataSet();
            this.listingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listingTableAdapter = new CarTracker.CarTrackerDataSetTableAdapters.ListingTableAdapter();
            this.tableAdapterManager = new CarTracker.CarTrackerDataSetTableAdapters.TableAdapterManager();
            this.listingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listingIdTextBox = new System.Windows.Forms.TextBox();
            this.colorIdComboBox = new System.Windows.Forms.ComboBox();
            this.makeIdComboBox = new System.Windows.Forms.ComboBox();
            this.carTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorTableAdapter = new CarTracker.CarTrackerDataSetTableAdapters.ColorTableAdapter();
            this.makeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makeTableAdapter = new CarTracker.CarTrackerDataSetTableAdapters.MakeTableAdapter();
            this.carTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTypeTableAdapter = new CarTracker.CarTrackerDataSetTableAdapters.CarTypeTableAdapter();
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
            this.SuspendLayout();
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
            // listingBindingNavigator
            // 
            this.listingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listingBindingNavigator.BindingSource = this.listingBindingSource;
            this.listingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.listingBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.listingBindingNavigator.TabIndex = 0;
            this.listingBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // listingBindingNavigatorSaveItem
            // 
            this.listingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listingBindingNavigatorSaveItem.Image")));
            this.listingBindingNavigatorSaveItem.Name = "listingBindingNavigatorSaveItem";
            this.listingBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.listingBindingNavigatorSaveItem.Text = "Save Data";
            this.listingBindingNavigatorSaveItem.Click += new System.EventHandler(this.listingBindingNavigatorSaveItem_Click);
            // 
            // listingIdLabel
            // 
            listingIdLabel.AutoSize = true;
            listingIdLabel.Location = new System.Drawing.Point(24, 75);
            listingIdLabel.Name = "listingIdLabel";
            listingIdLabel.Size = new System.Drawing.Size(52, 13);
            listingIdLabel.TabIndex = 1;
            listingIdLabel.Text = "Listing Id:";
            // 
            // listingIdTextBox
            // 
            this.listingIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "ListingId", true));
            this.listingIdTextBox.Location = new System.Drawing.Point(105, 75);
            this.listingIdTextBox.Name = "listingIdTextBox";
            this.listingIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.listingIdTextBox.TabIndex = 2;
            // 
            // colorIdLabel
            // 
            colorIdLabel.AutoSize = true;
            colorIdLabel.Location = new System.Drawing.Point(362, 78);
            colorIdLabel.Name = "colorIdLabel";
            colorIdLabel.Size = new System.Drawing.Size(46, 13);
            colorIdLabel.TabIndex = 3;
            colorIdLabel.Text = "Color Id:";
            // 
            // colorIdComboBox
            // 
            this.colorIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listingBindingSource, "ColorId", true));
            this.colorIdComboBox.DataSource = this.colorBindingSource;
            this.colorIdComboBox.DisplayMember = "ColorName";
            this.colorIdComboBox.FormattingEnabled = true;
            this.colorIdComboBox.Location = new System.Drawing.Point(438, 75);
            this.colorIdComboBox.Name = "colorIdComboBox";
            this.colorIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorIdComboBox.TabIndex = 4;
            this.colorIdComboBox.ValueMember = "ColorId";
            // 
            // makeIdLabel
            // 
            makeIdLabel.AutoSize = true;
            makeIdLabel.Location = new System.Drawing.Point(359, 153);
            makeIdLabel.Name = "makeIdLabel";
            makeIdLabel.Size = new System.Drawing.Size(49, 13);
            makeIdLabel.TabIndex = 5;
            makeIdLabel.Text = "Make Id:";
            // 
            // makeIdComboBox
            // 
            this.makeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listingBindingSource, "MakeId", true));
            this.makeIdComboBox.DataSource = this.makeBindingSource;
            this.makeIdComboBox.DisplayMember = "MakeName";
            this.makeIdComboBox.FormattingEnabled = true;
            this.makeIdComboBox.Location = new System.Drawing.Point(438, 145);
            this.makeIdComboBox.Name = "makeIdComboBox";
            this.makeIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.makeIdComboBox.TabIndex = 6;
            this.makeIdComboBox.ValueMember = "MakeId";
            // 
            // carTypeIdLabel
            // 
            carTypeIdLabel.AutoSize = true;
            carTypeIdLabel.Location = new System.Drawing.Point(24, 183);
            carTypeIdLabel.Name = "carTypeIdLabel";
            carTypeIdLabel.Size = new System.Drawing.Size(65, 13);
            carTypeIdLabel.TabIndex = 7;
            carTypeIdLabel.Text = "Car Type Id:";
            // 
            // carTypeIdComboBox
            // 
            this.carTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listingBindingSource, "CarTypeId", true));
            this.carTypeIdComboBox.DataSource = this.carTypeBindingSource;
            this.carTypeIdComboBox.DisplayMember = "CarTypeName";
            this.carTypeIdComboBox.FormattingEnabled = true;
            this.carTypeIdComboBox.Location = new System.Drawing.Point(107, 175);
            this.carTypeIdComboBox.Name = "carTypeIdComboBox";
            this.carTypeIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.carTypeIdComboBox.TabIndex = 8;
            this.carTypeIdComboBox.ValueMember = "CarTypeId";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(354, 236);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 9;
            yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(438, 229);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(121, 20);
            this.yearTextBox.TabIndex = 10;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(194, 322);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 11;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(265, 319);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 20);
            this.priceTextBox.TabIndex = 12;
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataMember = "Color";
            this.colorBindingSource.DataSource = this.carTrackerDataSet;
            // 
            // colorTableAdapter
            // 
            this.colorTableAdapter.ClearBeforeFill = true;
            // 
            // makeBindingSource
            // 
            this.makeBindingSource.DataMember = "Make";
            this.makeBindingSource.DataSource = this.carTrackerDataSet;
            // 
            // makeTableAdapter
            // 
            this.makeTableAdapter.ClearBeforeFill = true;
            // 
            // carTypeBindingSource
            // 
            this.carTypeBindingSource.DataMember = "CarType";
            this.carTypeBindingSource.DataSource = this.carTrackerDataSet;
            // 
            // carTypeTableAdapter
            // 
            this.carTypeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

