using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Xml;

class FormWithManyControls : Form
{
    TreeView treeView1;
    Panel panel1;
    CheckBox checkBox1, checkBox2;
    RadioButton radiobutton1, radioButton2;
    ListBox listBox1;

    // The constructor method for our class
    public FormWithManyControls()
    {
        // Set window title and size

        this.Text = "A form dealing with many types of controls";
        this.Width = 700;
        this.Height = 500;

        // Add a tree view as a kind of menu

        treeView1 = new TreeView();
        treeView1.BackColor = Color.BurlyWood;
        treeView1.Dock = DockStyle.Left;
        treeView1.AfterSelect += 
            new System.Windows.Forms.TreeViewEventHandler(treeView1_AfterSelect);

        TreeNode tn = new TreeNode("Controls");
        tn.Expand();

        tn.Nodes.Add(new TreeNode("[Wipe clean]"));
        tn.Nodes.Add(new TreeNode("Label"));
        tn.Nodes.Add(new TreeNode("Button"));
        tn.Nodes.Add(new TreeNode("CheckBox"));
        tn.Nodes.Add(new TreeNode("RadioButton"));
        tn.Nodes.Add(new TreeNode("ListBox"));
        tn.Nodes.Add(new TreeNode("TextBox"));
        tn.Nodes.Add(new TreeNode("TabControl"));
        tn.Nodes.Add(new TreeNode("DataGridView"));
        tn.Nodes.Add(new TreeNode("MainMenu"));
        tn.Nodes.Add(new TreeNode("ToolBar"));
        tn.Nodes.Add(new TreeNode("PictureBox"));
        tn.Nodes.Add(new TreeNode("RichTextBox"));

        treeView1.Nodes.Add(tn);

        this.Controls.Add(treeView1);

        // Add a panel to put all the other controls on

        panel1 = new Panel();
        panel1.Dock = DockStyle.Right;
        panel1.BorderStyle = BorderStyle.Fixed3D;
        panel1.Width = this.Width - treeView1.Width;

        this.Controls.Add(panel1);
    }

    // An eventhandler that runs when something in the treeview is selected
    private void treeView1_AfterSelect
        (object sender, System.Windows.Forms.TreeViewEventArgs e)
    {
        // Do something appropriate for whichever node was clicked

        if (e.Node.Text == "[Wipe clean]")
        {
            // Wipe the panel clean of any controls
            panel1.Controls.Clear();
        }
        else if (e.Node.Text == "Button")
        {
            // Add a button to the panel

            Button button1 = new Button();
            button1.Text = "I'm a button";
            button1.Location = new Point(150, 80);
            button1.Click += new EventHandler(button1_Click);

            panel1.Controls.Add(button1);
        }
        else if (e.Node.Text == "Label")
        {
            // Add a label to the panel

            Label label1 = new Label();
            label1.Text = 
                "This is a label. Labels are simply used " + 
                "to write text at a point on the screen";
            label1.Location = new Point(150, 10);
            label1.Width = 400;
            label1.Click += new EventHandler(label1_Click);

            panel1.Controls.Add(label1);
        }
        else if (e.Node.Text == "CheckBox")
        {
            // Add some checkboxes to the panel 

            checkBox1 = new CheckBox();
            checkBox1.Text = "I am sharp";
            checkBox1.Location = new Point(10, 50);
            checkBox1.CheckedChanged += 
                new EventHandler(CheckBox_CheckedChanged);
            panel1.Controls.Add(checkBox1);

            checkBox2 = new CheckBox();
            checkBox2.Text = "I am modest";
            checkBox2.Location = new Point(10, 70);
            checkBox2.CheckedChanged += 
                new EventHandler(CheckBox_CheckedChanged);
            panel1.Controls.Add(checkBox2);
        }
        else if (e.Node.Text == "RadioButton")
        {
            // Add some radio buttons to the panel

            radiobutton1 = new RadioButton();
            radiobutton1.Text = "I am sharp";
            radiobutton1.Location = new Point(370, 210);
            radiobutton1.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);

            panel1.Controls.Add(radiobutton1);

            radioButton2 = new RadioButton();
            radioButton2.Text = "I am dim-witted";
            radioButton2.Location = new Point(370, 230);
            radiobutton1.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);

            panel1.Controls.Add(radioButton2);
        }
        else if (e.Node.Text == "ListBox")
        {
            // Add a listbox to the panel

            listBox1 = new ListBox();
            listBox1.Items.Add("Green");
            listBox1.Items.Add("Beige");
            listBox1.Items.Add("White");
            listBox1.Location = new Point(200, 180);
            listBox1.SelectedIndexChanged += 
                new EventHandler(listBox1_SelectedIndexChanged);

            panel1.Controls.Add(listBox1);
        }
        else if (e.Node.Text == "TextBox")
        {
            // Add a text box to the panel

            TextBox TextBox1 = new TextBox();
            TextBox1.Text = "You can type here";
            TextBox1.Location = new Point(10, 110);

            panel1.Controls.Add(TextBox1);
        }
        else if (e.Node.Text == "DataGridView")
        {
            // Add a datagrid, populated with data from an xml file, to the panel

            DataSet dataSet1 = new DataSet("A sample DataSet");
            dataSet1.ReadXml("../../data/grades.xml");

            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.Width = (panel1.Width / 2) - 10;
            dataGridView1.Height = 150;
            dataGridView1.Location = 
                new Point(2, panel1.Height - dataGridView1.Height - 5);

            dataGridView1.DataSource = dataSet1;
            dataGridView1.DataMember = "subject";
            panel1.Controls.Add(dataGridView1);

        }
        else if (e.Node.Text == "TabControl")
        {
            // Add a tab control to the panel 
            // and add some content to each tab page

            TabControl tabControl1 = new TabControl();
            tabControl1.Location = new Point(10, 150);
            tabControl1.Size = new Size(165, 146);

            TabPage tabPage1 = new TabPage("Robynne");
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = new Bitmap("../../images/robynne.jpg");
            pictureBox1.Size = new Size(160, 120);
            tabPage1.Controls.Add(pictureBox1);
            tabControl1.TabPages.Add(tabPage1);

            TabPage tabPage2 = new TabPage("Her Dog");
            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.Image = new Bitmap("../../images/chocolate.jpg");
            pictureBox2.Size = new Size(160, 120);
            tabPage2.Controls.Add(pictureBox2);
            tabControl1.TabPages.Add(tabPage2);

            TabPage tabPage3 = new TabPage("Info");
            tabPage3.BackColor = Color.White;
            Label label1 = new Label();
            label1.Text = 
                "Robynne lives in Cape Town, South Africa.\n\n" + 
                "She has a dog named Chocolate, from the planet Woof," + 
                " rapidly growing into her oversized ears.";
            label1.Dock = DockStyle.Fill;
            tabPage3.Controls.Add(label1);
            tabControl1.TabPages.Add(tabPage3);

            panel1.Controls.Add(tabControl1);
        }
        else if (e.Node.Text == "PictureBox")
        {
            // Add a picture to the panel

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = new Bitmap("../../images/ocean.jpg");
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(250, 25);
            pictureBox1.Size = new Size(300, 130);

            panel1.Controls.Add(pictureBox1);
        }
        else if (e.Node.Text == "RichTextBox")
        {
            // Add a box for typing rich text in
            // Load some data from an XML file into it

            RichTextBox richTextBox1 = new RichTextBox();
            richTextBox1.LoadFile("../../data/grades.xml", 
                RichTextBoxStreamType.PlainText);
            richTextBox1.WordWrap = false;
            richTextBox1.BorderStyle = BorderStyle.Fixed3D;
            richTextBox1.BackColor = Color.Beige;
            richTextBox1.Size = new Size((panel1.Width / 2) - 10, 150);
            richTextBox1.Location = 
                new Point((panel1.Width / 2) + 10, 
                panel1.Height - richTextBox1.Height - 5);

            panel1.Controls.Add(richTextBox1);
        }
        else if (e.Node.Text == "MainMenu")
        {
            // Add a classic "menu" (appears at the top of the window)
            MainMenu mainMenu1 = new MainMenu();

            MenuItem menuItem1 = new MenuItem("File");
            menuItem1.MenuItems.Add("Exit", 
                new EventHandler(mainMenu1_Exit_Select));
            mainMenu1.MenuItems.Add(menuItem1);

            MenuItem menuItem2 = new MenuItem("Background");
            menuItem2.MenuItems.Add("Choose", 
                new EventHandler(mainMenu1_ColorOwn_Select));
            menuItem2.MenuItems.Add("White", 
                new EventHandler(mainMenu1_ColorWhite_Select));
            mainMenu1.MenuItems.Add(menuItem2);

            this.Menu = mainMenu1;

            MessageBox.Show("A main menu has been added at the top " + 
                "left of the window. Try it out after clicking OK.");

        }
        else if (e.Node.Text == "ToolBar")
        {
            // Add a shortcuts toolbar to the panel

            ToolBar toolBar1 = new ToolBar();
            ImageList imageList1 = new ImageList();
            imageList1.Images.Add(new Bitmap("../../images/open.gif"));
            imageList1.Images.Add(new Bitmap("../../images/close.gif"));
            imageList1.Images.Add(new Bitmap("../../images/undo.gif"));
            toolBar1.ImageList = imageList1;

            ToolBarButton toolBarbutton1 = new ToolBarButton("Open");
            toolBarbutton1.ImageIndex = 0;
            toolBar1.Buttons.Add(toolBarbutton1);

            ToolBarButton toolBarbutton2 = new ToolBarButton("Close");
            toolBarbutton2.ImageIndex = 1;
            toolBar1.Buttons.Add(toolBarbutton2);

            ToolBarButton toolBarButton3 = new ToolBarButton("Huh");
            toolBarButton3.ImageIndex = 3;
            toolBar1.Buttons.Add(toolBarButton3);

            toolBar1.ButtonClick += 
                new ToolBarButtonClickEventHandler(toolBar1_Click);

            panel1.Controls.Add(toolBar1);
        }

    }

    /* All other event handlers - for the controls added above */

    // An eventhandler that will be run if the label is clicked
    void label1_Click(object sender, System.EventArgs e)
    {
        MessageBox.Show
            ("Yes, labels can be clicked, although it's not normal to do so.");
    }

    // An eventhandler that will be run if the button is clicked
    void button1_Click(object sender, System.EventArgs e)
    {
        MessageBox.Show("Yup, you were supposed to click me");
    }

    // An eventhandler that will be run if a checkbox is checked/unchecked
    void CheckBox_CheckedChanged(object sender, System.EventArgs e)
    {
        if (checkBox1.Checked && checkBox2.Checked)
        {
            MessageBox.Show("Good for you");
        }
        else if (checkBox1.Checked)
        {
            MessageBox.Show("It's not good to be sharp without being modest");
        }
        else if (checkBox2.Checked)
        {
            MessageBox.Show("Modesty is good. Pity you're not sharp too.");
        }
        else
        {
            MessageBox.Show("Oh dear, neither sharp nor modest eh?");
        }
    }

    // An eventhandler that will be run if a radiobutton is clicked
    void RadioButton_CheckedChanged(object sender, System.EventArgs e)
    {
        if (radiobutton1.Checked)
        {
           // MessageBox.Show("Glad to hear it", MessageBoxButtons.OK);
        }
        else if (radioButton2.Checked)
        {
            MessageBox.Show("What a shame");
        }
    }

    // An eventhandler that will be run if an item in the listbox is selected
    void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        if (listBox1.SelectedItem.ToString() == "Green")
        {
            treeView1.BackColor = Color.LightSeaGreen;
        }
        else if (listBox1.SelectedItem.ToString() == "Beige")
        {
            treeView1.BackColor = Color.Beige;
        }
        else if (listBox1.SelectedItem.ToString() == "White")
        {
            treeView1.BackColor = Color.White;
        }
    }

    // An eventhandler that will be run if "white" is selected at the menu
    void mainMenu1_ColorWhite_Select(object sender, System.EventArgs e)
    {
        treeView1.BackColor = Color.White;
    }

    // An eventhandler that will be run if a color is selected at the menu
    void mainMenu1_ColorOwn_Select(object sender, System.EventArgs e)
    {
        ColorDialog colorDialog1 = new ColorDialog();
        colorDialog1.Color = treeView1.BackColor;
        colorDialog1.ShowDialog();
        treeView1.BackColor = colorDialog1.Color;
    }

    // An eventhandler that will be run if the user chooses "exit" at the menu
    void mainMenu1_Exit_Select(object sender, System.EventArgs e)
    {
        if (
                MessageBox.Show("Are you sure you want to exit?", 
                "Exit confirmation", MessageBoxButtons.YesNo) 
                == DialogResult.Yes
            )
        {
            this.Dispose();
        }
    }

    // An eventhandler that will be run if a toolbar shortcut is selected
    void toolBar1_Click
        (object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
    {
        if (e.Button.Text == "Open")
        {
            MessageBox.Show("This could have opened a file, for example");
        }
        else if (e.Button.Text == "Close")
        {
            MessageBox.Show("This could have closed a file, for example");
        }
        else if (e.Button.Text == "Huh")
        {
            MessageBox.Show("Huh?");
        }
    }

    static void Main()
    {
        // Start a new instance of a forms application, using our class above
        Application.Run(new FormWithManyControls());
    }
}