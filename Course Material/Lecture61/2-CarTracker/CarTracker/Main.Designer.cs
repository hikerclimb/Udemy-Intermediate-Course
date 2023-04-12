namespace CarTracker
{
    partial class Main
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
            System.Windows.Forms.Label colorIDLabel;
            System.Windows.Forms.Label makeIDLabel;
            System.Windows.Forms.Label carTypeIDLabel;
            System.Windows.Forms.Label dateSeenLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label cyclinderLabel;
            System.Windows.Forms.Label hPLabel;
            System.Windows.Forms.Label uRLLabel;
            System.Windows.Forms.Label ePGCityLabel;
            System.Windows.Forms.Label ePGHighwayLabel;
            System.Windows.Forms.Label notesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            this.colorIDComboBox = new System.Windows.Forms.ComboBox();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makeIDComboBox = new System.Windows.Forms.ComboBox();
            this.makeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.carTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateSeenDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.cyclinderTextBox = new System.Windows.Forms.TextBox();
            this.hPTextBox = new System.Windows.Forms.TextBox();
            this.uRLTextBox = new System.Windows.Forms.TextBox();
            this.ePGCityTextBox = new System.Windows.Forms.TextBox();
            this.ePGHighwayTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.fillByColorNameNewToolStrip = new System.Windows.Forms.ToolStrip();
            this.colorNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.colorNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByColorNameNewToolStripButton = new System.Windows.Forms.ToolStripButton();
            colorIDLabel = new System.Windows.Forms.Label();
            makeIDLabel = new System.Windows.Forms.Label();
            carTypeIDLabel = new System.Windows.Forms.Label();
            dateSeenLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            cyclinderLabel = new System.Windows.Forms.Label();
            hPLabel = new System.Windows.Forms.Label();
            uRLLabel = new System.Windows.Forms.Label();
            ePGCityLabel = new System.Windows.Forms.Label();
            ePGHighwayLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingNavigator)).BeginInit();
            this.listingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).BeginInit();
            this.fillByColorNameNewToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorIDLabel
            // 
            colorIDLabel.AutoSize = true;
            colorIDLabel.Location = new System.Drawing.Point(41, 60);
            colorIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            colorIDLabel.Name = "colorIDLabel";
            colorIDLabel.Size = new System.Drawing.Size(45, 16);
            colorIDLabel.TabIndex = 3;
            colorIDLabel.Text = "Color :";
            // 
            // makeIDLabel
            // 
            makeIDLabel.AutoSize = true;
            makeIDLabel.Location = new System.Drawing.Point(471, 64);
            makeIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            makeIDLabel.Name = "makeIDLabel";
            makeIDLabel.Size = new System.Drawing.Size(44, 16);
            makeIDLabel.TabIndex = 5;
            makeIDLabel.Text = "Make:";
            // 
            // carTypeIDLabel
            // 
            carTypeIDLabel.AutoSize = true;
            carTypeIDLabel.Location = new System.Drawing.Point(884, 68);
            carTypeIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            carTypeIDLabel.Name = "carTypeIDLabel";
            carTypeIDLabel.Size = new System.Drawing.Size(69, 16);
            carTypeIDLabel.TabIndex = 7;
            carTypeIDLabel.Text = "Car Type :";
            // 
            // dateSeenLabel
            // 
            dateSeenLabel.AutoSize = true;
            dateSeenLabel.Location = new System.Drawing.Point(41, 123);
            dateSeenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateSeenLabel.Name = "dateSeenLabel";
            dateSeenLabel.Size = new System.Drawing.Size(74, 16);
            dateSeenLabel.TabIndex = 9;
            dateSeenLabel.Text = "Date Seen:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(41, 192);
            yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(39, 16);
            yearLabel.TabIndex = 11;
            yearLabel.Text = "Year:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(471, 196);
            priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(41, 16);
            priceLabel.TabIndex = 13;
            priceLabel.Text = "Price:";
            // 
            // cyclinderLabel
            // 
            cyclinderLabel.AutoSize = true;
            cyclinderLabel.Location = new System.Drawing.Point(41, 256);
            cyclinderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cyclinderLabel.Name = "cyclinderLabel";
            cyclinderLabel.Size = new System.Drawing.Size(66, 16);
            cyclinderLabel.TabIndex = 15;
            cyclinderLabel.Text = "Cyclinder:";
            // 
            // hPLabel
            // 
            hPLabel.AutoSize = true;
            hPLabel.Location = new System.Drawing.Point(471, 260);
            hPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hPLabel.Name = "hPLabel";
            hPLabel.Size = new System.Drawing.Size(29, 16);
            hPLabel.TabIndex = 17;
            hPLabel.Text = "HP:";
            // 
            // uRLLabel
            // 
            uRLLabel.AutoSize = true;
            uRLLabel.Location = new System.Drawing.Point(573, 127);
            uRLLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uRLLabel.Name = "uRLLabel";
            uRLLabel.Size = new System.Drawing.Size(37, 16);
            uRLLabel.TabIndex = 19;
            uRLLabel.Text = "URL:";
            // 
            // ePGCityLabel
            // 
            ePGCityLabel.AutoSize = true;
            ePGCityLabel.Location = new System.Drawing.Point(41, 352);
            ePGCityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ePGCityLabel.Name = "ePGCityLabel";
            ePGCityLabel.Size = new System.Drawing.Size(60, 16);
            ePGCityLabel.TabIndex = 21;
            ePGCityLabel.Text = "EPGCity:";
            // 
            // ePGHighwayLabel
            // 
            ePGHighwayLabel.AutoSize = true;
            ePGHighwayLabel.Location = new System.Drawing.Point(41, 384);
            ePGHighwayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ePGHighwayLabel.Name = "ePGHighwayLabel";
            ePGHighwayLabel.Size = new System.Drawing.Size(90, 16);
            ePGHighwayLabel.TabIndex = 23;
            ePGHighwayLabel.Text = "EPGHighway:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(472, 352);
            notesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(46, 16);
            notesLabel.TabIndex = 25;
            notesLabel.Text = "Notes:";
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
            this.listingBindingNavigator.Size = new System.Drawing.Size(1605, 39);
            this.listingBindingNavigator.TabIndex = 0;
            this.listingBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // listingBindingNavigatorSaveItem
            // 
            this.listingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listingBindingNavigatorSaveItem.Image")));
            this.listingBindingNavigatorSaveItem.Name = "listingBindingNavigatorSaveItem";
            this.listingBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 36);
            this.listingBindingNavigatorSaveItem.Text = "Save Data";
            this.listingBindingNavigatorSaveItem.Click += new System.EventHandler(this.listingBindingNavigatorSaveItem_Click);
            // 
            // colorIDComboBox
            // 
            this.colorIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listingBindingSource, "ColorID", true));
            this.colorIDComboBox.DataSource = this.colorBindingSource;
            this.colorIDComboBox.DisplayMember = "ColorName";
            this.colorIDComboBox.FormattingEnabled = true;
            this.colorIDComboBox.Location = new System.Drawing.Point(147, 57);
            this.colorIDComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorIDComboBox.Name = "colorIDComboBox";
            this.colorIDComboBox.Size = new System.Drawing.Size(265, 24);
            this.colorIDComboBox.TabIndex = 4;
            this.colorIDComboBox.ValueMember = "ColorID";
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataMember = "Color";
            this.colorBindingSource.DataSource = this.carTrackerDataSet;
            // 
            // makeIDComboBox
            // 
            this.makeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listingBindingSource, "MakeID", true));
            this.makeIDComboBox.DataSource = this.makeBindingSource;
            this.makeIDComboBox.DisplayMember = "MakeName";
            this.makeIDComboBox.FormattingEnabled = true;
            this.makeIDComboBox.Location = new System.Drawing.Point(576, 60);
            this.makeIDComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.makeIDComboBox.Name = "makeIDComboBox";
            this.makeIDComboBox.Size = new System.Drawing.Size(265, 24);
            this.makeIDComboBox.TabIndex = 6;
            this.makeIDComboBox.ValueMember = "MakeID";
            // 
            // makeBindingSource
            // 
            this.makeBindingSource.DataMember = "Make";
            this.makeBindingSource.DataSource = this.carTrackerDataSet;
            // 
            // carTypeIDComboBox
            // 
            this.carTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listingBindingSource, "CarTypeID", true));
            this.carTypeIDComboBox.DataSource = this.carTypeBindingSource;
            this.carTypeIDComboBox.DisplayMember = "CarTypeName";
            this.carTypeIDComboBox.FormattingEnabled = true;
            this.carTypeIDComboBox.Location = new System.Drawing.Point(989, 64);
            this.carTypeIDComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carTypeIDComboBox.Name = "carTypeIDComboBox";
            this.carTypeIDComboBox.Size = new System.Drawing.Size(265, 24);
            this.carTypeIDComboBox.TabIndex = 8;
            this.carTypeIDComboBox.ValueMember = "CarTypeID";
            // 
            // carTypeBindingSource
            // 
            this.carTypeBindingSource.DataMember = "CarType";
            this.carTypeBindingSource.DataSource = this.carTrackerDataSet;
            // 
            // dateSeenDateTimePicker
            // 
            this.dateSeenDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listingBindingSource, "DateSeen", true));
            this.dateSeenDateTimePicker.Location = new System.Drawing.Point(147, 118);
            this.dateSeenDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateSeenDateTimePicker.Name = "dateSeenDateTimePicker";
            this.dateSeenDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dateSeenDateTimePicker.TabIndex = 10;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(147, 188);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(265, 22);
            this.yearTextBox.TabIndex = 12;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(576, 192);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(265, 22);
            this.priceTextBox.TabIndex = 14;
            // 
            // cyclinderTextBox
            // 
            this.cyclinderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "Cyclinder", true));
            this.cyclinderTextBox.Location = new System.Drawing.Point(147, 252);
            this.cyclinderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cyclinderTextBox.Name = "cyclinderTextBox";
            this.cyclinderTextBox.Size = new System.Drawing.Size(265, 22);
            this.cyclinderTextBox.TabIndex = 16;
            // 
            // hPTextBox
            // 
            this.hPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "HP", true));
            this.hPTextBox.Location = new System.Drawing.Point(576, 256);
            this.hPTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hPTextBox.Name = "hPTextBox";
            this.hPTextBox.Size = new System.Drawing.Size(265, 22);
            this.hPTextBox.TabIndex = 18;
            // 
            // uRLTextBox
            // 
            this.uRLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "URL", true));
            this.uRLTextBox.Location = new System.Drawing.Point(679, 123);
            this.uRLTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uRLTextBox.Name = "uRLTextBox";
            this.uRLTextBox.Size = new System.Drawing.Size(265, 22);
            this.uRLTextBox.TabIndex = 20;
            // 
            // ePGCityTextBox
            // 
            this.ePGCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "EPGCity", true));
            this.ePGCityTextBox.Location = new System.Drawing.Point(147, 348);
            this.ePGCityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ePGCityTextBox.Name = "ePGCityTextBox";
            this.ePGCityTextBox.Size = new System.Drawing.Size(265, 22);
            this.ePGCityTextBox.TabIndex = 22;
            // 
            // ePGHighwayTextBox
            // 
            this.ePGHighwayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "EPGHighway", true));
            this.ePGHighwayTextBox.Location = new System.Drawing.Point(147, 380);
            this.ePGHighwayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ePGHighwayTextBox.Name = "ePGHighwayTextBox";
            this.ePGHighwayTextBox.Size = new System.Drawing.Size(265, 22);
            this.ePGHighwayTextBox.TabIndex = 24;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listingBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(577, 348);
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesTextBox.Size = new System.Drawing.Size(265, 134);
            this.notesTextBox.TabIndex = 26;
            // 
            // fillByColorNameNewToolStrip
            // 
            this.fillByColorNameNewToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByColorNameNewToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorNameToolStripLabel,
            this.colorNameToolStripTextBox,
            this.fillByColorNameNewToolStripButton});
            this.fillByColorNameNewToolStrip.Location = new System.Drawing.Point(0, 49);
            this.fillByColorNameNewToolStrip.Name = "fillByColorNameNewToolStrip";
            this.fillByColorNameNewToolStrip.Size = new System.Drawing.Size(1605, 39);
            this.fillByColorNameNewToolStrip.TabIndex = 27;
            this.fillByColorNameNewToolStrip.Text = "fillByColorNameNewToolStrip";
            // 
            // colorNameToolStripLabel
            // 
            this.colorNameToolStripLabel.Name = "colorNameToolStripLabel";
            this.colorNameToolStripLabel.Size = new System.Drawing.Size(88, 36);
            this.colorNameToolStripLabel.Text = "ColorName:";
            // 
            // colorNameToolStripTextBox
            // 
            this.colorNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colorNameToolStripTextBox.Name = "colorNameToolStripTextBox";
            this.colorNameToolStripTextBox.Size = new System.Drawing.Size(132, 39);
            // 
            // fillByColorNameNewToolStripButton
            // 
            this.fillByColorNameNewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByColorNameNewToolStripButton.Name = "fillByColorNameNewToolStripButton";
            this.fillByColorNameNewToolStripButton.Size = new System.Drawing.Size(154, 36);
            this.fillByColorNameNewToolStripButton.Text = "FillByColorNameNew";
            this.fillByColorNameNewToolStripButton.Click += new System.EventHandler(this.fillByColorNameNewToolStripButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 603);
            this.Controls.Add(this.fillByColorNameNewToolStrip);
            this.Controls.Add(colorIDLabel);
            this.Controls.Add(this.colorIDComboBox);
            this.Controls.Add(makeIDLabel);
            this.Controls.Add(this.makeIDComboBox);
            this.Controls.Add(carTypeIDLabel);
            this.Controls.Add(this.carTypeIDComboBox);
            this.Controls.Add(dateSeenLabel);
            this.Controls.Add(this.dateSeenDateTimePicker);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(cyclinderLabel);
            this.Controls.Add(this.cyclinderTextBox);
            this.Controls.Add(hPLabel);
            this.Controls.Add(this.hPTextBox);
            this.Controls.Add(uRLLabel);
            this.Controls.Add(this.uRLTextBox);
            this.Controls.Add(ePGCityLabel);
            this.Controls.Add(this.ePGCityTextBox);
            this.Controls.Add(ePGHighwayLabel);
            this.Controls.Add(this.ePGHighwayTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.listingBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Car Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingNavigator)).EndInit();
            this.listingBindingNavigator.ResumeLayout(false);
            this.listingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).EndInit();
            this.fillByColorNameNewToolStrip.ResumeLayout(false);
            this.fillByColorNameNewToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CarTrackerDataSet carTrackerDataSet;
        private System.Windows.Forms.BindingSource listingBindingSource;
        private CarTracker.CarTrackerDataSetTableAdapters.ListingTableAdapter listingTableAdapter;
        private CarTracker.CarTrackerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.ComboBox colorIDComboBox;
        private System.Windows.Forms.ComboBox makeIDComboBox;
        private System.Windows.Forms.ComboBox carTypeIDComboBox;
        private System.Windows.Forms.DateTimePicker dateSeenDateTimePicker;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox cyclinderTextBox;
        private System.Windows.Forms.TextBox hPTextBox;
        private System.Windows.Forms.TextBox uRLTextBox;
        private System.Windows.Forms.TextBox ePGCityTextBox;
        private System.Windows.Forms.TextBox ePGHighwayTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private CarTracker.CarTrackerDataSetTableAdapters.ColorTableAdapter colorTableAdapter;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private CarTracker.CarTrackerDataSetTableAdapters.MakeTableAdapter makeTableAdapter;
        private System.Windows.Forms.BindingSource makeBindingSource;
        private CarTracker.CarTrackerDataSetTableAdapters.CarTypeTableAdapter carTypeTableAdapter;
        private System.Windows.Forms.BindingSource carTypeBindingSource;
        private System.Windows.Forms.ToolStrip fillByColorNameNewToolStrip;
        private System.Windows.Forms.ToolStripLabel colorNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox colorNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByColorNameNewToolStripButton;
    }
}

