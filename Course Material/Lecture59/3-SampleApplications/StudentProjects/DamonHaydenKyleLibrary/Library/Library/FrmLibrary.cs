using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO; // Needed to use datafiles

namespace Library
{
    public partial class FrmLibrary : Form
    {
        public FrmLibrary()
        {
            InitializeComponent();
        }

        //******************************************************************************************//
        //*** Variable Dictionary ******************************************************************//
        //*** pointers is used to search and sort for data, Controls main part of program***********//
        //*** Lib is used to store all the books data read in from datafile. Can hold Max of 200****//
        //*** lines is used for delimitted textfile reading it splits apart data reading/writing****//
        //*** L is used when opening a file or making a new file, keeps a counter of data***********//
        //*** c, n are counters mainly used for reading in data and saving it***********************//
        //*** f is used when saving the application, remembers file name****************************//
        //*** fileOK checks and sees if there are errors when opening a file or saving one**********//
        //*** d is the variable used for FrmSelect**************************************************//
        //******************************************************************************************//

        // initialize variables

        FrmSelect d = new FrmSelect();

        LibraryInfo[] Lib = new LibraryInfo[200];
        int[] pointers = new int[200];
        string[] lines;

        int L=0;
        int c=0, n=0;

        string f = "";    //filename
        string fileOK;

        private void FrmLibrary_Load(object sender, EventArgs e)
        {
            // reset pointers[] values
            for (int i = 0; i < 200; i++)
                pointers[i] = i;

            c = 0; // reset counter

            // reset Lib[] property values
            while (c < 200)
            {
                Lib[c] = new LibraryInfo();
                Lib[c].BookName = "";
                Lib[c].Author = "";
                Lib[c].PublishDate = "";
                Lib[c].Genre = "";
                Lib[c].Status = "";
                Lib[c].Max = 0;
                c++;
            }

            // add options to the sort combo box
            CboSort.Text = "Book Name";
            CboSort.Items.Add("Book Name");
            CboSort.Items.Add("Author");
            CboSort.Items.Add("Publish Dates");
            CboSort.Items.Add("Genre");
            CboSort.Items.Add("Status");
        }

        private void New()
        {
            // reset Lib[] property values
            for (int i = 0; i <= Lib[1].Max; i++)
            {
                Lib[i].BookName = "";
                Lib[i].Author = "";
                Lib[i].PublishDate = "";
                Lib[i].Genre = "";
                Lib[i].Status = "";
                Lib[i].Counter = 0;
            }
            
            // reset counters
            Lib[1].Max = 0;
            L = 0;
        }

        private void Enable()
        {
            // enable all actions on the form
            BtnSort.Enabled = true;
            CboSort.Enabled = true;
            BtnSearch.Enabled = true;
            BtnAdmin.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
        }

        private void SaveFile()
        {
            if (fileOK == "yes") // if the file is proper and exists
            {
                StreamWriter w = null;

                try
                {
                    saveFileDialog1.Filter = "Text files (*.txt)|*.txt|" + "All files|*.*";
                    saveFileDialog1.FileName = f;           //prompt with current filename
                    saveFileDialog1.FilterIndex = 1;

                    // show saveFileDialog
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK) // if OK button pressed on file dialog
                    {
                        //string StartUpPath = Application.StartupPath;
                        //string f = StartUpPath + @"\albums.txt";

                        f = saveFileDialog1.FileName; // set f as chosen filename to save as
                        w = new StreamWriter(f); // w is streamwrite and will write to the filename

                        // write all data to texfile in proper format to be re-opened whenever needed
                        for (int i = 0; i < Lib[1].Max; i++)
                        {
                            w.Write(Lib[i].BookName);
                            w.Write("-");
                            w.Write(Lib[i].Author);
                            w.Write("-");
                            w.Write(Lib[i].PublishDate);
                            w.Write("-");
                            w.Write(Lib[i].Genre);
                            w.Write("-");
                            w.WriteLine(Lib[i].Status);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You pressed cancel."); // alert the user they cancelled their request
                    }
                }
                
                // handle exceptions
                catch (Exception exp)
                {
                    // display exception error message
                    MessageBox.Show("Error Occured during File IO " + exp.Message);
                }

                finally
                {
                    if (w != null) // if writing is complete
                    {
                        w.Close(); // close streamwriter
                        n = c; // set n as counter
                    }
                }
            }
            else
            {
                // display error message that file is not saved propertly
                MessageBox.Show("Cannot save this file " + "\n" + "program detected an error during loading" + "\n" + "try re-loading or create a new file");
            }
        }

        private void Search(string Text, int Need)
        {
            bool found = false; // set boolean to determine if book is found

            //Text is used for searching for the name, to get an index value.
            //Need is used to see if we need to remove or edit.
            //Edit and a search will send Need = 0.

            for (int i = 0; i < Lib[1].Max; i++)
            {
                // put both values in lowercase to make search not case sensitive
                string tempbook = Lib[pointers[i]].BookName.ToLower();
                string temptext = Text.ToLower();

                if (tempbook == temptext) // if there is a found match
                {
                    FoundSearch(pointers[i]); // call foundsearch method
                    UpdateList(); // update display list

                    found = true; // set boolean as true; match has been found
                }
            }

            // if there is no match found, display error message
            if (found == false)
                MessageBox.Show("Sorry that book does exist, perhaps you mistyped it!");
        }

        private void FoundSearch(int pos)
        {
            // set values on FrmSelect based on the position in the array
            // found in the search

            d.MainPanel = true.ToString();

            d.BookName = Lib[pos].BookName;
            d.BookAuthor = Lib[pos].Author;
            d.BookGenre = Lib[pos].Genre;
            d.BookStatus = Lib[pos].Status;
            d.BookPublishDate = Lib[pos].PublishDate;

            d.Search = 1.ToString();

            d.ShowDialog(); // show frmselect
        }

        private void NameSort(string Sorter)
        {
            // Your temp variable
            int temp;

            // sets all the pointers
            for (int i = 0; i < Lib[1].Max; i++)
                pointers[i] = i;

            // goes through array
            for (int j = 0; j < Lib[1].Max - 1; j++)
            {
                for (int k = j + 1; k < Lib[1].Max; k++)
                {
                    switch (Sorter)
                    {
                        //Switch case for what we are sorting.
                        case "Name": // sort by name
                            if (Lib[pointers[j]].BookName.CompareTo(Lib[pointers[k]].BookName) > 0)
                            {
                                temp = pointers[j];
                                pointers[j] = pointers[k];
                                pointers[k] = temp;
                            }
                            break;
                        case "Author": // sort by author
                            if (Lib[pointers[j]].Author.CompareTo(Lib[pointers[k]].Author) > 0)
                            {
                                temp = pointers[j];
                                pointers[j] = pointers[k];
                                pointers[k] = temp;
                            }
                            break;
                        case "PublishDate": // sort by publishdate
                            if (int.Parse(Lib[pointers[j]].PublishDate) > int.Parse((Lib[pointers[k]].PublishDate)))
                            {
                                temp = pointers[j];
                                pointers[j] = pointers[k];
                                pointers[k] = temp;
                            }
                            break;
                        case "Genre": // sort by genre
                            if (Lib[pointers[j]].Genre.CompareTo(Lib[pointers[k]].Genre) > 0)
                            {
                                temp = pointers[j];
                                pointers[j] = pointers[k];
                                pointers[k] = temp;
                            }
                            break;
                        case "Status": // sort by status
                            if (Lib[pointers[j]].Status.CompareTo(Lib[pointers[k]].Status) > 0)
                            {
                                temp = pointers[j];
                                pointers[j] = pointers[k];
                                pointers[k] = temp;
                            }
                            break;
                        //Checks for what we are sorting.
                        //It compares the two variables needed, then checks if we are doing ascending.
                        //Also checks two variables and if we are doing ascending.
                        //We see if the value is greater or less than zero, for ascending and descending.
                    }
                }
            }

            UpdateList();
            //Now we are done sorting, we update the list with sorted values.

        }

        private void OpenData()
        {
            // reset counters
            c = 0;
            n = 0;
            fileOK = "yes";

            StreamReader r = null;

            try
            {

                openFileDialog1.Reset();
                openFileDialog1.InitialDirectory = Application.ExecutablePath;
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|" + "All files|*.*";
                openFileDialog1.FilterIndex = 1;

                // if datafile has been selected
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //string s = Application.StartupPath;
                    //string f = s + @"\albums.txt";

                    f = openFileDialog1.FileName; // set f as filename to open
                    r = new StreamReader(f); // set streamreader to read found file

                    string WholeLine;

                    L = 0; // reset counter

                    // read in data
                    while ((WholeLine = r.ReadLine()) != null)
                    {
                        c++;
                        lines = WholeLine.Split('-'); // splits the line at every "-"
                        Lib[L].BookName = lines[0];
                        Lib[L].Author = lines[1];
                        Lib[L].PublishDate = lines[2];
                        Lib[L].Genre = lines[3];
                        Lib[L].Status = lines[4];
                        L++;

                    }
                    Enable(); // call enable method
                    Lib[1].Max = L; // set max for lib[] as counter

                    //add filename to statusbar
                    StrpStatusLabel.Text = "File Loaded";
                }
                else
                {
                    MessageBox.Show("No File Chosen"); // messagebox for not choosing a file
                }
            }
            
            // find exception
            catch (Exception exp)
            {
                // display error message
                MessageBox.Show("Error Occured during File IO " + exp.Message);
                fileOK = "no";
            }

            finally
            {
                if (r != null)
                {
                    r.Close(); // close streamreader
                }

                if (fileOK == "yes") // if file is found and is ok
                {
                    n = c; // set n as counter
                    StrpStatusLabel.Text = "File Loaded";//add filename to statusbar
                }
                else // if file is not properly executed
                {
                    // reset counters
                    c = 0;
                    n = 0;
                    StrpStatusLabel.Text = "File Loading Error"; // notify of error

                }
            }
        }

        private void UpdateList()
        {
            LstDisplay.Clear(); // clear lstdisplay

            // format lstdisplay
            LstDisplay.Columns.Add("", 50, HorizontalAlignment.Center);
            LstDisplay.Columns.Add("Book Title", 150, HorizontalAlignment.Center);
            LstDisplay.Columns.Add("Author", 150, HorizontalAlignment.Center);
            LstDisplay.Columns.Add("Publish Date", 100, HorizontalAlignment.Center);
            LstDisplay.Columns.Add("Genre", 150, HorizontalAlignment.Center);
            LstDisplay.Columns.Add("Status", 100, HorizontalAlignment.Center);
            //Adds all the List Box headings.

            int rowcount = 0; // reset rowcount

            // read in all data in lib[] array
            for (int i = 0; i < Lib[1].Max; i++)
            {
                rowcount++;
                ListViewItem IT = new ListViewItem();
                IT.Text = rowcount.ToString();

                IT.SubItems.Add(Lib[pointers[i]].BookName);
                IT.SubItems.Add(Lib[pointers[i]].Author);
                IT.SubItems.Add(Lib[pointers[i]].PublishDate);
                IT.SubItems.Add(Lib[pointers[i]].Genre);
                IT.SubItems.Add(Lib[pointers[i]].Status);
                LstDisplay.Items.Add(IT);
                //Adds a book information to a row, then adds the next book to the next row..etc.
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New(); // call new method to start new data for library
            UpdateList(); // call updatelist method to refresh lstdisplay
            Enable(); // call enable method to enable all actions
            StrpStatusLabel.Text = "New file has been created."; //update statusbar
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenData(); // call opendata method to allow reading in of datafile
            UpdateList(); // call updatelist method to refresh lstdisplay
            StrpStatusLabel.Text = "Data has been opened."; //update statusbar
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(); // call savefile method to save the datafile
            StrpStatusLabel.Text = "File has been saved."; //update statusbar
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // close form
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            // sorting the data

            // invalid sort request
            if (CboSort.Text == "")
            {
                MessageBox.Show("Sorry that isn't a valid sort");
            }
            else if (CboSort.Text == "Book Name")
            {
                NameSort("Name"); // sort by name through namesort method
            }
            else if (CboSort.Text == "Author")
            {
                NameSort("Author"); // sort by author through namesort method
            }
            else if (CboSort.Text == "Publish Dates")
            {
                NameSort("PublishDate"); // sort by publishdate through namesort method
            }
            else if (CboSort.Text == "Genre")
            {
                NameSort("Genre"); // sort by genre through namesort method
            }
            else if (CboSort.Text == "Status")
            {
                NameSort("Status"); // sort by status through namesort method
            }

            StrpStatusLabel.Text = "Data has been sorted."; //update statusbar
        
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search(TxtSearch.Text, 1);
            // calls the Search method to search for the value inside TxtSearch
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display the About message for this application
            MessageBox.Show("This is an easy-to-use Library Application that will help you find books, information about them and whether they are checked in or out. It also has a password protected area for the staff to edit, add or remove entries." + Environment.NewLine + Environment.NewLine + "See the 'Help' menu for more information and how-to's.");
        }

        private void Add()
        {
            // add new entry submitted from frmselect
            Lib[L].BookName = d.BookName;
            Lib[L].Author = d.BookAuthor;
            Lib[L].PublishDate = d.BookPublishDate;
            Lib[L].Genre = d.BookGenre;
            Lib[L].Status = d.BookStatus;

            // increase counters by one
            Lib[1].Max++;
            L++;
        }

        private void Edit()
        {
            int temploc = int.Parse(d.EditLoc); // get location in array

            // set new values for edited entry submitted from frmselect
            Lib[temploc].BookName = d.BookName;
            Lib[temploc].Author = d.BookAuthor;
            Lib[temploc].PublishDate = d.BookPublishDate;
            Lib[temploc].Genre = d.BookGenre;
            Lib[temploc].Status = d.BookStatus;
        }

        private void Delete()
        {
            int temploc = int.Parse(d.EditLoc); // get location in array

            // replace the entry wished to be deleted by
            // moving each entry above it down by one
            for (int i = temploc; i <= L; i++)
            {
                Lib[i].BookName = Lib[i + 1].BookName;
                Lib[i].Author = Lib[i + 1].Author;
                Lib[i].PublishDate = Lib[i + 1].PublishDate;
                Lib[i].Genre = Lib[i + 1].Genre;
                Lib[i].Status = Lib[i + 1].Status;
            }

            // decrease counters
            Lib[1].Max--;
            L--;

            if (Lib[1].Max < 0) // if counter is now less than 0 then reset it at 0
            {
                Lib[1].Max = 0;
                L = 0;
            }
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            bool loginsuccess = false; // successful login boolean starts at false

            FrmAdminLogin l = new FrmAdminLogin(); // set l as FrmAdminLogin

            if (l.ShowDialog() == DialogResult.OK) // show admin login and return when submit is pressed
            {
                // if the login credentials are correct
                if (l.Username == "admin" && l.Password == "ics4m1-lib")
                {
                    loginsuccess = true; // success is true
                }
                else
                {
                    // invalid login error message
                    MessageBox.Show("Sorry, you've entered an incorrect username or password. Please try again.");
                }
            }

            if (loginsuccess == true) // if the login was a success
            {
                d.Clear = true.ToString(); // clear the values on FrmSelect

                // read in all the data from Lib[] array
                // to send to frmselect
                for (int i = 0; i <= L - 1; i++)
                {
                    d.Names = Lib[pointers[i]].BookName;
                    d.Author = Lib[pointers[i]].Author;
                    d.PublishDate = Lib[pointers[i]].PublishDate;
                    d.Genre = Lib[pointers[i]].Genre;
                    d.Status = Lib[pointers[i]].Status;
                }

                d.MainPanel = true.ToString(); // show PnlMain on frmselect

                if (d.ShowDialog() == DialogResult.OK) // if action is submitted from frmselect
                {
                    // set all blank entries as N/A

                    if (d.BookName == "")
                        d.BookName = "N/A";

                    if (d.BookAuthor == "")
                        d.BookAuthor = "N/A";

                    if (d.BookPublishDate == "")
                        d.BookPublishDate = "N/A";

                    if (d.BookGenre == "")
                        d.BookGenre = "N/A";

                    if (d.BookStatus == "")
                        d.BookStatus = "N/A";

                    // determine which action was made and call its respective method
                    if (d.Action == "Add")
                    {
                        Add();
                    }
                    else if (d.Action == "Edit")
                    {
                        Edit();
                    }
                    else
                    {
                        Delete();
                    }
                }

                UpdateList(); // update the display list
            }
        }

        private void btnfont_Click(object sender, EventArgs e)
        {
            // open the font dialog to edit font properties
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                LstDisplay.Font = fontDialog1.Font; // change font properties when returned
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // open font colour changing dialog
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                LstDisplay.ForeColor = colorDialog1.Color; // change font colour when returned
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open the help form
            FrmHelp h = new FrmHelp();
            h.Show();
        }
    }
}