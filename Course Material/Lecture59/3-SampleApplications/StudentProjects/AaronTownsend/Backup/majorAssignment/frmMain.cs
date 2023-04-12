using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO; // allows files to be read from

namespace majorAssignment
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            // Create an instance of a ListView column sorter and assign it to the various ListView controls.
            lvwColumnSorter = new ListViewColumnSorter();
            this.LstViewTV.ListViewItemSorter = lvwColumnSorter;
            this.LstViewSpk.ListViewItemSorter = lvwColumnSorter;
            this.LstViewRec.ListViewItemSorter = lvwColumnSorter;
            this.LstViewPeriph.ListViewItemSorter = lvwColumnSorter;
        }
        // parameters for each tab
        TVparameters[] TVpam = new TVparameters[200];
        SpeakerParameters[] SPKRpam = new SpeakerParameters[200];
        ReceiverParameters[] RECpam = new ReceiverParameters[200];
        peripheralParameters[] PERIPHpam = new peripheralParameters[200];

        int N;
        string f;
        bool fileLoad;

        /*//////////////////////
        //Variable Dictionary://
        ////////////////////////
        TVpam - used to store all of the television's parameters. 200 Max Televisions can be stored.
        SPKRpam - used to store all of the speaker's parameters. 200 Max Televisions can be stored.
        RECpam - used to store all of the receiver's parameters. 200 Max Televisions can be stored.
        PERIPHpam - used to store all of the peripherals's parameters. 200 Max Televisions can be stored.
        N - used when loading in data by opening a file or clicking new file. Represents the amount.
        f - used for saving ease of use. It represents the filename.
        fileLoad - a bool which shows wether a file is loaded or not. used for error messages and displays.
        */

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Makes all Parameters usable with their new instances, and sets them all blank.
            N = 0;
            while (N < 200)
            {
                TVpam[N] = new TVparameters();
                TVpam[N].Brand = "";
                TVpam[N].PartNumber = "";
                TVpam[N].AspectRatio = "";
                TVpam[N].DisplayCapabilities = "";
                TVpam[N].DisplayTechnology = "";
                TVpam[N].DynamicContrastRatio = "";
                TVpam[N].NativeResolution = "";
                TVpam[N].RefreshRate = "";
                TVpam[N].ResponseTime = "";
                TVpam[N].ScreenSize = "";
                TVpam[N].Max = 0;

                SPKRpam[N] = new SpeakerParameters();
                SPKRpam[N].Brand = "";
                SPKRpam[N].Model = "";
                SPKRpam[N].Type = "";
                SPKRpam[N].SpeakerFrequencyResponse = "";
                SPKRpam[N].SpeakerPower = "";
                SPKRpam[N].SubwooferPower = "";
                SPKRpam[N].SubwooferDriveComponents = "";
                SPKRpam[N].Max = 0;

                RECpam[N] = new ReceiverParameters();
                RECpam[N].Brand = "";
                RECpam[N].Model = "";
                RECpam[N].Channels = "";
                RECpam[N].WattsPerChannel = "";
                RECpam[N].HDMIinputs = "";
                RECpam[N].Max =0;

                PERIPHpam[N] = new peripheralParameters();
                PERIPHpam[N].Type = "";
                PERIPHpam[N].Brand = "";
                PERIPHpam[N].Name = "";
                PERIPHpam[N].Max = 0;

                N++;
            }
            // informs the user that the program is ready via a status strip message
            StatusLabelFile.Text = "Ready";
        }

        private void DataRead(string f)
        {
            StreamReader r = null;
            r = new StreamReader(f); //Allows us to read in data with r.
            string Line;
            N = 0;
            while ((Line = r.ReadLine()) != null)
            {
                if (tabControl.SelectedTab == tabPageTV)
                {
                    //Reads in all the data and stores it into TVpam
                    TVpam[N].Brand = Line;
                    TVpam[N].PartNumber = r.ReadLine();
                    TVpam[N].AspectRatio = r.ReadLine();
                    TVpam[N].DisplayCapabilities = r.ReadLine();
                    TVpam[N].DisplayTechnology = r.ReadLine();
                    TVpam[N].DynamicContrastRatio = r.ReadLine();
                    TVpam[N].NativeResolution = r.ReadLine();
                    TVpam[N].RefreshRate = r.ReadLine();
                    TVpam[N].ResponseTime = r.ReadLine();
                    TVpam[N].ScreenSize = r.ReadLine();
                }
                else if (tabControl.SelectedTab == tabPageSpk)
                {
                    SPKRpam[N].Brand = Line;
                    SPKRpam[N].Model = r.ReadLine();
                    SPKRpam[N].Type = r.ReadLine();
                    SPKRpam[N].SpeakerFrequencyResponse = r.ReadLine();
                    SPKRpam[N].SpeakerPower = r.ReadLine();
                    SPKRpam[N].SubwooferPower = r.ReadLine();
                    SPKRpam[N].SubwooferDriveComponents = r.ReadLine();
                }
                else if (tabControl.SelectedTab == tabPageRec)
                {
                    RECpam[N].Brand = Line;
                    RECpam[N].Model = r.ReadLine();
                    RECpam[N].Channels = r.ReadLine();
                    RECpam[N].WattsPerChannel = r.ReadLine();
                    RECpam[N].HDMIinputs = r.ReadLine();
                }
                else if (tabControl.SelectedTab == tabPagePeriph)
                {
                    PERIPHpam[N].Type = Line;
                    PERIPHpam[N].Brand = r.ReadLine();
                    PERIPHpam[N].Name = r.ReadLine();
                }
                // counts how many items have been added
                N++;
            }
            // sets the max to the amount of data counted
            TVpam[0].Max = N;
            SPKRpam[0].Max = N;
            RECpam[0].Max = N;
            PERIPHpam[0].Max = N;
        }

        private void DataLoad()
        {
            openFileDialog.Reset(); // resets the open file dialog to default location
            openFileDialog.InitialDirectory = Application.ExecutablePath; // sets open dialog's default position to executable path
            // sets filters so that files are only opened in their proper data type
            if (tabControl.SelectedTab == tabPageTV)
            {
                openFileDialog.Filter = "TV Data files|*.tvdata|" + "All files|*.*";
            }
            else if (tabControl.SelectedTab == tabPageSpk)
            {
                openFileDialog.Filter = "Speaker Data files|*.spkdata|" + "All files|*.*";
            }
            else if (tabControl.SelectedTab == tabPageRec)
            {
                openFileDialog.Filter = "Reciever Data files|*.recdata|" + "All files|*.*";
            }
            else if (tabControl.SelectedTab == tabPagePeriph)
            {
                openFileDialog.Filter = "Peripheral Data files|*.periphdata|" + "All files|*.*";
            }
            openFileDialog.FilterIndex = 1;
            StreamReader r = null;
            fileLoad = true;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataRead(openFileDialog.FileName);
                }
                else
                {
                    // displays no file chosen if the user doesnt open a file
                    MessageBox.Show("No File Chosen");
                    fileLoad = false;
                }
            }
            catch (Exception exp)
            {
                // displays an error message if the read fails
                MessageBox.Show("Error Occured during File IO " + exp.Message, "IO Error");
                fileLoad = false;
            }
            finally
            {
                if (r != null)
                {
                    r.Close(); // stops reading the file
                }
                if (fileLoad == true)
                {
                    StatusLabelFile.Text = f; //adds filename to statusbar
                }
                else
                {
                    // Clears the list views and tells the user that there has been an error via the status label
                    LstViewTV.Clear();
                    LstViewSpk.Clear();
                    LstViewRec.Clear();
                    LstViewPeriph.Clear();
                    StatusLabelFile.Text = "File Loading Error";
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
           {
               if (tabControl.SelectedTab == tabPageTV)
               {
                   for (int i = 0; i <= TVpam[0].Max; i++)
                   {
                       //Sets all values in the array blank
                       TVpam[i].Brand = "";
                       TVpam[i].PartNumber = "";
                       TVpam[i].AspectRatio = "";
                       TVpam[i].DisplayCapabilities = "";
                       TVpam[i].DisplayTechnology = "";
                       TVpam[i].DynamicContrastRatio = "";
                       TVpam[i].NativeResolution = "";
                       TVpam[i].RefreshRate = "";
                       TVpam[i].ResponseTime = "";
                       TVpam[i].ScreenSize = "";
                   }
                   TVpam[0].Max = 0; // resets the amount of TV's entered to 0
               }
               else if (tabControl.SelectedTab == tabPageSpk)
               {
                   for (int i = 0; i <= TVpam[0].Max; i++)
                   {
                       //Sets all values in the array blank
                       SPKRpam[N].Brand = "";
                       SPKRpam[N].Model = "";
                       SPKRpam[N].Type = "";
                       SPKRpam[N].SpeakerFrequencyResponse = "";
                       SPKRpam[N].SpeakerPower = "";
                       SPKRpam[N].SubwooferPower = "";
                       SPKRpam[N].SubwooferDriveComponents = "";
                   }
                   SPKRpam[0].Max = 0; // resets the amount of speakers entered to 0
               }
               else if (tabControl.SelectedTab == tabPageRec)
               {
                   for (int i = 0; i <= TVpam[0].Max; i++)
                   {
                       //Sets all values in the array blank
                       RECpam[N].Brand = "";
                       RECpam[N].Model = "";
                       RECpam[N].Channels = "";
                       RECpam[N].WattsPerChannel = "";
                       RECpam[N].HDMIinputs = "";
                   }
                   RECpam[0].Max = 0; // resets the amount of receivers entered to 0
               }
               else if (tabControl.SelectedTab == tabPagePeriph)
               {
                   for (int i = 0; i <= TVpam[0].Max; i++)
                   {
                       //Sets all values in the array blank
                       PERIPHpam[N].Type = "";
                       PERIPHpam[N].Brand = "";
                       PERIPHpam[N].Name = "";
                   }
                   PERIPHpam[0].Max = 0; // resets the amount of peripherals entered to 0
               }
                UpdateList(); //Updates the list and removes old values
                StatusLabelFile.Text = "New File Loaded"; // displays a status label notification that a new file is ready
            }
            catch (Exception exp)
            {
                // displays an error message if the read fails
                MessageBox.Show("Error: " + exp.Message,"Error");
                fileLoad = false;
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e) //Calls load data, then updates the list.
        {
            DataLoad();
            UpdateList();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the program.
        }
        private void aboutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // instantiate and show the about form
            frmAbout a = new frmAbout();
            a.ShowDialog();
        }

        private void editParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add(); // add a new item
            UpdateList(); // update the list
            StatusLabelFile.Text = "Item Added"; // display status label that data was Added
        }


        /////////////////
        // File Saving //
        /////////////////
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sets the filters so that files are only saved in their appropriate data type
            if (tabControl.SelectedTab == tabPageTV)
            {
                saveFileDialog.Filter = "TV Data files|*.tvdata|" + "All files|*.*";
            }
            else if (tabControl.SelectedTab == tabPageSpk)
            {
                saveFileDialog.Filter = "Speaker Data files|*.spkdata|" + "All files|*.*";
            }
            else if (tabControl.SelectedTab == tabPageRec)
            {
                saveFileDialog.Filter = "Reciever Data files|*.recdata|" + "All files|*.*";
            }
            else if (tabControl.SelectedTab == tabPagePeriph)
            {
                saveFileDialog.Filter = "Peripheral Data files|*.periphdata|" + "All files|*.*";
            }
            saveFileDialog.FileName = f;           //prompt with current filename
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                f = saveFileDialog.FileName;
                StreamWriter w = new StreamWriter(f); //Allows us to write to a data file

                if (tabControl.SelectedTab == tabPageTV)
                {
                    for (int i = 0; i < TVpam[0].Max; i++)
                    {
                        //Writes the data to the file
                        w.WriteLine(TVpam[i].Brand);
                        w.WriteLine(TVpam[i].PartNumber);
                        w.WriteLine(TVpam[i].AspectRatio);
                        w.WriteLine(TVpam[i].DisplayCapabilities);
                        w.WriteLine(TVpam[i].DisplayTechnology);
                        w.WriteLine(TVpam[i].DynamicContrastRatio);
                        w.WriteLine(TVpam[i].NativeResolution);
                        w.WriteLine(TVpam[i].RefreshRate);
                        w.WriteLine(TVpam[i].ResponseTime);
                        w.WriteLine(TVpam[i].ScreenSize);
                    }
                }
                else if (tabControl.SelectedTab == tabPageSpk)
                {
                    for (int i = 0; i < SPKRpam[0].Max; i++)
                    {
                        //Writes the data to the file
                        w.WriteLine(SPKRpam[N].Brand);
                        w.WriteLine(SPKRpam[N].Model);
                        w.WriteLine(SPKRpam[N].Type);
                        w.WriteLine(SPKRpam[N].SpeakerFrequencyResponse);
                        w.WriteLine(SPKRpam[N].SpeakerPower);
                        w.WriteLine(SPKRpam[N].SubwooferPower);
                        w.WriteLine(SPKRpam[N].SubwooferDriveComponents);
                    }
                }
                else if (tabControl.SelectedTab == tabPageRec)
                {
                    for (int i = 0; i < RECpam[0].Max; i++)
                    {
                        //Writes the data to the file
                        w.WriteLine(RECpam[N].Brand);
                        w.WriteLine(RECpam[N].Model);
                        w.WriteLine(RECpam[N].Channels);
                        w.WriteLine(RECpam[N].WattsPerChannel);
                        w.WriteLine(RECpam[N].HDMIinputs);
                    }
                }
                else if (tabControl.SelectedTab == tabPagePeriph)
                {
                    for (int i = 0; i < PERIPHpam[0].Max; i++)
                    {
                        //Writes the data to the file
                        w.WriteLine(PERIPHpam[N].Type);
                        w.WriteLine(PERIPHpam[N].Brand);
                        w.WriteLine(PERIPHpam[N].Name);
                    }
                }

                w.Close(); //Closes the file
                StatusLabelFile.Text = "File Saved"; // display status label that file was saved
            }
            else
            {
                //If the user does not click OK, no save is done, and we are unsuccessful.
                MessageBox.Show("There was an unsuccessful save please try again", "Saved Failure");
            }
        }

        //////////////////
        // File Editing //
        //////////////////
        private void Add()
        {
            frmAddDisplay x = new frmAddDisplay();

            if (x.ShowDialog() == DialogResult.OK)
            {
                //Shows the data entry form.
                TVpam[(TVpam[0].Max)].Brand = x.Brand;
                TVpam[(TVpam[0].Max)].PartNumber = x.PartNum;
                TVpam[(TVpam[0].Max)].AspectRatio = x.AspectRatio;
                TVpam[(TVpam[0].Max)].DisplayCapabilities = x.DispCap;
                TVpam[(TVpam[0].Max)].DisplayTechnology = x.DispTech;
                TVpam[(TVpam[0].Max)].DynamicContrastRatio = x.DCR;
                TVpam[(TVpam[0].Max)].NativeResolution = x.Resolution;
                TVpam[(TVpam[0].Max)].RefreshRate = x.RefreshRate;
                TVpam[(TVpam[0].Max)].ResponseTime = x.ResponseTime;
                TVpam[(TVpam[0].Max)].ScreenSize = x.ScreenSize;
                TVpam[0].Max += 1;
                //if OK clicked add all the data entered into the array.
            }
        }

        private void Edit(int Edit)
        {
            if (tabControl.SelectedTab == tabPageTV)
            {
                frmAddDisplay x = new frmAddDisplay();
                x.PartNum = TVpam[Edit].PartNumber;
                x.Brand = TVpam[Edit].Brand;
                x.AspectRatio = TVpam[Edit].AspectRatio;
                x.DispCap = TVpam[Edit].DisplayCapabilities;
                x.DispTech = TVpam[Edit].DisplayTechnology;
                x.DCR = TVpam[Edit].DynamicContrastRatio;
                x.Resolution = TVpam[Edit].NativeResolution;
                x.RefreshRate = TVpam[Edit].RefreshRate;
                x.ResponseTime = TVpam[Edit].ResponseTime;
                x.ScreenSize = TVpam[Edit].ScreenSize;
                if (x.ShowDialog() == DialogResult.OK)
                {
                    //Shows the data entry form, with data pre filled in for the selected patient to edit.
                    TVpam[Edit].PartNumber = x.PartNum;
                    TVpam[Edit].Brand = x.Brand;
                    TVpam[Edit].AspectRatio = x.AspectRatio;
                    TVpam[Edit].DisplayCapabilities = x.DispCap;
                    TVpam[Edit].DisplayTechnology = x.DispTech;
                    TVpam[Edit].DynamicContrastRatio = x.DCR;
                    TVpam[Edit].NativeResolution = x.Resolution;
                    TVpam[Edit].RefreshRate = x.RefreshRate;
                    TVpam[Edit].ResponseTime = x.ResponseTime;
                    TVpam[Edit].ScreenSize = x.ScreenSize;
                    //If user clicks okay, save the edited information.
                }
            }
            else if (tabControl.SelectedTab == tabPageSpk)
            {
                frmAddSpeakers x = new frmAddSpeakers();
                x.Brand = SPKRpam[Edit].Brand;
                x.Model = SPKRpam[Edit].Model;
                x.Type = SPKRpam[Edit].Type;
                x.SpeakerFrequencyResponse = SPKRpam[Edit].SpeakerFrequencyResponse;
                x.SpeakerPower = SPKRpam[Edit].SpeakerPower;
                x.SubwooferPower = SPKRpam[Edit].SubwooferPower;
                x.SubwooferDriveComponents = SPKRpam[Edit].SubwooferDriveComponents;
                if (x.ShowDialog() == DialogResult.OK)
                {
                    //Shows the data entry form, with data pre filled in for the selected patient to edit.
                    SPKRpam[Edit].Brand = x.Brand;
                    SPKRpam[Edit].Model = x.Model;
                    SPKRpam[Edit].Type = x.Type;
                    SPKRpam[Edit].SpeakerFrequencyResponse = x.SpeakerFrequencyResponse;
                    SPKRpam[Edit].SpeakerPower = x.SpeakerPower;
                    SPKRpam[Edit].SubwooferPower = x.SubwooferPower;
                    SPKRpam[Edit].SubwooferDriveComponents = x.SubwooferDriveComponents;
                    //If user clicks okay, save the edited information.
                }
            }
            else if (tabControl.SelectedTab == tabPageRec)
            {
                frmAddReceiver x = new frmAddReceiver();
                x.Brand = RECpam[Edit].Brand;
                x.Name = RECpam[Edit].Model;
                x.Brand = RECpam[Edit].Channels;
                x.Name = RECpam[Edit].WattsPerChannel;
                x.Name = RECpam[Edit].HDMIinputs;

                if (x.ShowDialog() == DialogResult.OK)
                {
                    //Shows the data entry form, with data pre filled in for the selected patient to edit.
                    RECpam[Edit].Brand = x.Brand;
                    RECpam[Edit].Model = x.Model;
                    RECpam[Edit].Channels = x.Channels;
                    RECpam[Edit].WattsPerChannel = x.WattsPerChannel;
                    RECpam[Edit].HDMIinputs = x.HDMIinputs;
                    //If user clicks okay, save the edited information.
                }
            }
            else if (tabControl.SelectedTab == tabPagePeriph)
            {
                frmAddPeripheral x = new frmAddPeripheral();
                x.Type = PERIPHpam[Edit].Type;
                x.Brand = PERIPHpam[Edit].Brand;
                x.Name = PERIPHpam[Edit].Name;

                if (x.ShowDialog() == DialogResult.OK)
                {
                    //Shows the data entry form, with data pre filled in for the selected patient to edit.
                    PERIPHpam[Edit].Type = x.Type;
                    PERIPHpam[Edit].Brand = x.Brand;
                    PERIPHpam[Edit].Name = x.Name;
                    //If user clicks okay, save the edited information.
                }
            }
            UpdateList(); // updates the list
            StatusLabelFile.Text = "Data Updated"; // display status label that data was updated
        }

        private void editDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab == tabPageTV)
                {
                    Edit(LstViewTV.SelectedIndices[0]);
                }
                else if (tabControl.SelectedTab == tabPageSpk)
                {
                    Edit(LstViewSpk.SelectedIndices[0]);
                }
                else if (tabControl.SelectedTab == tabPageRec)
                {
                    Edit(LstViewRec.SelectedIndices[0]);
                }
                else if (tabControl.SelectedTab == tabPagePeriph)
                {
                    Edit(LstViewPeriph.SelectedIndices[0]);
                }
            }
            catch (Exception exp)
            {
                // displays an error message if no file is selected
                MessageBox.Show("Error: Please select a file to edit","No File Selected");
            }
            StatusLabelFile.Text = "Item Edited";
        }

        ////////////////////////
        // List View Updating //
        ////////////////////////
        private void UpdateList()
        {
            if (tabControl.SelectedTab == tabPageTV)
            {
                LstViewTV.Clear(); // clear all data that may be in the list view
                //Adds all the List Box headings.
                LstViewTV.Columns.Add("Part Number");
                LstViewTV.Columns.Add("Brand");
                LstViewTV.Columns.Add("Aspect Ratio");
                LstViewTV.Columns.Add("Display Capabilities");
                LstViewTV.Columns.Add("Display Technology");
                LstViewTV.Columns.Add("Dynamic Contrast Ratio");
                LstViewTV.Columns.Add("Native Resolution");
                LstViewTV.Columns.Add("Refresh Rate");
                LstViewTV.Columns.Add("Response Time");
                LstViewTV.Columns.Add("Screen Size");
                for (int i = 0; i < TVpam[0].Max; i++)
                {
                    //Adds parameters to a row, then adds the next set to the next row..etc.
                    ListViewItem IT = new ListViewItem();
                    IT.Text = TVpam[i].PartNumber;
                    IT.SubItems.Add(TVpam[i].Brand);
                    IT.SubItems.Add(TVpam[i].AspectRatio);
                    IT.SubItems.Add(TVpam[i].DisplayCapabilities);
                    IT.SubItems.Add(TVpam[i].DisplayTechnology);
                    IT.SubItems.Add(TVpam[i].DynamicContrastRatio);
                    IT.SubItems.Add(TVpam[i].NativeResolution);
                    IT.SubItems.Add(TVpam[i].RefreshRate);
                    IT.SubItems.Add(TVpam[i].ResponseTime);
                    IT.SubItems.Add(TVpam[i].ScreenSize);
                    LstViewTV.Items.Add(IT);
                }
                // Loop through and size each column header to fit the column header text.
                foreach (ColumnHeader ch in this.LstViewTV.Columns)
                {
                    ch.Width = -2;
                }
            }
            else if (tabControl.SelectedTab == tabPageSpk)
            {
                LstViewSpk.Clear(); // clear all data that may be in the list view
                //Adds all the List Box headings.
                LstViewSpk.Columns.Add("Model");
                LstViewSpk.Columns.Add("Brand");
                LstViewSpk.Columns.Add("Type");
                LstViewSpk.Columns.Add("Speaker Freq Response");
                LstViewSpk.Columns.Add("Speaker Power");
                LstViewSpk.Columns.Add("Subwoofer Power");
                LstViewSpk.Columns.Add("Subwoofer Drive Components");
                for (int i = 0; i < SPKRpam[0].Max; i++)
                {
                    //Adds parameters to a row, then adds the next set to the next row..etc.
                    ListViewItem IT = new ListViewItem();
                    IT.Text = SPKRpam[i].Model;
                    IT.SubItems.Add(SPKRpam[i].Brand);
                    IT.SubItems.Add(SPKRpam[i].Type);
                    IT.SubItems.Add(SPKRpam[i].SpeakerFrequencyResponse);
                    IT.SubItems.Add(SPKRpam[i].SpeakerPower);
                    IT.SubItems.Add(SPKRpam[i].SubwooferPower);
                    IT.SubItems.Add(SPKRpam[i].SubwooferDriveComponents);
                    LstViewSpk.Items.Add(IT);
                }
                // Loop through and size each column header to fit the column header text.
                foreach (ColumnHeader ch in this.LstViewSpk.Columns)
                {
                    ch.Width = -2;
                }
            }
            else if (tabControl.SelectedTab == tabPageRec)
            {
                LstViewRec.Clear(); // clear all data that may be in the list view
                //Adds all the List Box headings.
                LstViewRec.Columns.Add("Brand");
                LstViewRec.Columns.Add("Model");
                LstViewRec.Columns.Add("Channels");
                LstViewRec.Columns.Add("Watts Per Channel");
                LstViewRec.Columns.Add("HDMI Inputs");
                for (int i = 0; i < RECpam[0].Max; i++)
                {
                    //Adds parameters to a row, then adds the next set to the next row..etc.
                    ListViewItem IT = new ListViewItem();
                    IT.Text = RECpam[i].Brand;
                    IT.SubItems.Add(RECpam[i].Model);
                    IT.SubItems.Add(RECpam[i].Channels);
                    IT.SubItems.Add(RECpam[i].WattsPerChannel);
                    IT.SubItems.Add(RECpam[i].HDMIinputs);
                    LstViewRec.Items.Add(IT);
                }
                // Loop through and size each column header to fit the column header text.
                foreach (ColumnHeader ch in this.LstViewRec.Columns)
                {
                    ch.Width = -2;
                }
            }
            else if (tabControl.SelectedTab == tabPagePeriph)
            {
                LstViewPeriph.Clear(); // clear all data that may be in the list view
                //Adds all the List Box headings.
                LstViewPeriph.Columns.Add("Type");
                LstViewPeriph.Columns.Add("Brand");
                LstViewPeriph.Columns.Add("Name");
                for (int i = 0; i < RECpam[0].Max; i++)
                {
                    //Adds parameters to a row, then adds the next set to the next row..etc.
                    ListViewItem IT = new ListViewItem();
                    IT.Text = PERIPHpam[i].Type;
                    IT.SubItems.Add(PERIPHpam[i].Brand);
                    IT.SubItems.Add(PERIPHpam[i].Name);
                    LstViewPeriph.Items.Add(IT);
                }
                // Loop through and size each column header to fit the column header text.
                foreach (ColumnHeader ch in this.LstViewPeriph.Columns)
                {
                    ch.Width = -2;
                }
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateList(); // updates the list
            StatusLabelFile.Text = "Data Refreshed"; // display status label that data was refreshed
        }

        private void tabControl_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateList(); // updates the list so that columns show
        }

        // load default files on click (relevant to what tab is selected)
        private void openDefaultDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageTV)
            {
                DataRead("K:\\ICS4M1\\Activities\\C#\\majorAssignment\\majorAssignment\\bin\\Debug\\MainData.tvdata");
            }
            else if (tabControl.SelectedTab == tabPageSpk)
            {
                DataRead("K:\\ICS4M1\\Activities\\C#\\majorAssignment\\majorAssignment\\bin\\Debug\\MainData.spkdata");
            }
            else if (tabControl.SelectedTab == tabPageRec)
            {
                DataRead("K:\\ICS4M1\\Activities\\C#\\majorAssignment\\majorAssignment\\bin\\Debug\\MainData.recdata");
            }
            else if (tabControl.SelectedTab == tabPagePeriph)
            {
                DataRead("K:\\ICS4M1\\Activities\\C#\\majorAssignment\\majorAssignment\\bin\\Debug\\MainData.periphdata");
            }
            UpdateList();
        }

        // delete focused item in the list view on click and display status label that data deleted (relevant to what tab is selected)
        private void itemRemoval()
        {
            if (tabControl.SelectedTab == tabPageTV)
            {
                LstViewTV.Items.Remove(LstViewTV.FocusedItem);
            }
            else if (tabControl.SelectedTab == tabPageSpk)
            {
                LstViewSpk.Items.Remove(LstViewSpk.FocusedItem);
                
            }
            else if (tabControl.SelectedTab == tabPageRec)
            {
                LstViewRec.Items.Remove(LstViewRec.FocusedItem);
            }
            else if (tabControl.SelectedTab == tabPagePeriph)
            {
                LstViewPeriph.Items.Remove(LstViewPeriph.FocusedItem);
            }
            StatusLabelFile.Text = "Item Deleted";
        }

        private void removeOldDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemRemoval();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemRemoval();
        }

        ////////////////////
        // Column Sorting //
        ////////////////////
        private void LstViewTV_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try
            {
                //lvwColumnSorter = new ListViewColumnSorter();
                // Determine if clicked column is already the column that is being sorted.
                if (e.Column == lvwColumnSorter.SortColumn)
                {
                    // Reverse the current sort direction for this column.
                    if (lvwColumnSorter.Order == SortOrder.Ascending)
                    {
                        lvwColumnSorter.Order = SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorter.Order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // Set the column number that is to be sorted; default to ascending.
                    lvwColumnSorter.SortColumn = e.Column;
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }

                // Perform the sort with these new sort options.
                this.LstViewTV.Sort();
            }
            catch (Exception exp) // just incase lvwColumnSorter fails
            {
                MessageBox.Show("Error Occured during List Sorting: " + exp.Message, "Error");
            }
        }

        private void LstViewSpk_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try
            {
                //lvwColumnSorter = new ListViewColumnSorter();
                // Determine if clicked column is already the column that is being sorted.
                if (e.Column == lvwColumnSorter.SortColumn)
                {
                    // Reverse the current sort direction for this column.
                    if (lvwColumnSorter.Order == SortOrder.Ascending)
                    {
                        lvwColumnSorter.Order = SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorter.Order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // Set the column number that is to be sorted; default to ascending.
                    lvwColumnSorter.SortColumn = e.Column;
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }

                // Perform the sort with these new sort options.
                this.LstViewSpk.Sort();
            }
            catch (Exception exp) // just incase lvwColumnSorter fails
            {
                MessageBox.Show("Error Occured during List Sorting: " + exp.Message, "Error");
            }
        }

        private void LstViewRec_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try
            {
                //lvwColumnSorter = new ListViewColumnSorter();
                // Determine if clicked column is already the column that is being sorted.
                if (e.Column == lvwColumnSorter.SortColumn)
                {
                    // Reverse the current sort direction for this column.
                    if (lvwColumnSorter.Order == SortOrder.Ascending)
                    {
                        lvwColumnSorter.Order = SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorter.Order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // Set the column number that is to be sorted; default to ascending.
                    lvwColumnSorter.SortColumn = e.Column;
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }

                // Perform the sort with these new sort options.
                this.LstViewRec.Sort();
            }
            catch (Exception exp) // just incase lvwColumnSorter fails
            {
                MessageBox.Show("Error Occured during List Sorting: " + exp.Message, "Error");
            }
        }

        private void LstViewPeriph_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try
            {
                //lvwColumnSorter = new ListViewColumnSorter();
                // Determine if clicked column is already the column that is being sorted.
                if (e.Column == lvwColumnSorter.SortColumn)
                {
                    // Reverse the current sort direction for this column.
                    if (lvwColumnSorter.Order == SortOrder.Ascending)
                    {
                        lvwColumnSorter.Order = SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorter.Order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // Set the column number that is to be sorted; default to ascending.
                    lvwColumnSorter.SortColumn = e.Column;
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }

                // Perform the sort with these new sort options.
                this.LstViewPeriph.Sort();
            }
            catch (Exception exp) // just incase lvwColumnSorter fails
            {
                MessageBox.Show("Error Occured during List Sorting: " + exp.Message, "Error");
            }
        }
    }
}