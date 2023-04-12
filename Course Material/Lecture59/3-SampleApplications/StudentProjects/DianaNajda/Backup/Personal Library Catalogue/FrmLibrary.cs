//Diana Najda
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Personal_Library_Catalogue
{
    public partial class FrmLibrary : Form
    {
        public FrmLibrary()
        {
            InitializeComponent();
        }

        //****VARIABLE DICTIONARY****
        //pointers -> where the information is in the same spot while the book[]array gets sorted
        //Book -> the book class which holds all of the information for the book entry (title, author, year, genre and info)
        //Image -> class that contains cover[] images for all of the books
        //lines -> needed to read in the information
        //f -> name of the file that is now opened
        //fileOK -> inform if the file is proper and exists
        //pass -> flag to see if the password entered is correct
        //c,n,B -> all counters
        //tries -> keeps track of how many times the user has entered the wrong password
        //selected -> keeps track of what item is selected in the listview

        int[] pointers = new int[200];
        Book [] book = new Book[200];
        Image[] cover = new Image[200];

        string[] lines;
        string f;
        string fileOK;
        bool pass;


        int c,n,B, tries;
        int selected;
        
        private void FrmLibrary_Load(object sender, EventArgs e)
        {
            Initialize();            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Initialize();
            LoadData();
            LoadImages();
            ActivateObjects();
            Display();
        }

        private void LoadData()
        {
            //sets the counters to zero
            c = 0;
            n = 0;

            StreamReader read = null;
            fileOK = "yes";

            try
            {
                openFileDialog1.Reset();
                openFileDialog1.InitialDirectory = Application.ExecutablePath;
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|" + "All files|*.*"; //limits to showing only text files
                openFileDialog1.FilterIndex = 1;

                //if the user has selected a file
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //the variable f is set as filename to open
                    //will help with ease of access when saving
                    f = openFileDialog1.FileName;
                    read = new StreamReader(f);

                    string wholeline;
                    B = 0; //sets the counter to 0

                    while ((wholeline = read.ReadLine()) != null)
                    {
                        {
                            c++;
                            lines = wholeline.Split('*'); //splits the line every "*"
                            book[c].title = lines[0];
                            book[c].author = lines[1];
                            book[c].year = lines[2];
                            book[c].genre = lines[3];
                            book[c].info = lines[4];
                            B++;
                        }
                    }
                    //set max for the book[] counter
                    book[1].Max = B;
                }
                
                //if no file is chosen an error message is displayed
                else
                {
                    MessageBox.Show("Please Load a File");
                }
            }
            
            //find exception (error)
            catch (Exception exp)
            {
                //an error message in Messagebox
                MessageBox.Show("Error Occured during File IO " + exp.Message);
                fileOK = "no"; //therefore file is not "OK"
            }

            finally
            {
                if (read != null)
                {
                    read.Close(); 
                }
            }

            //if file exists and has no problems
            if (fileOK == "yes")
            {
                n = c; //set n as counter
                statusStrip1.Text = "File Loaded";
            }

            else //if there is an error executing the file
            {
                c = 0;
                n = 0;

                statusStrip1.Text = "File Loading Error";
            }            
        }

        private void LoadImages()
        {
            string response;

            //what is happening here is that the user can just open the set folder that came with the program
            //or if they want to open their own images than they can do so by searching their computer
            //and then choosing the file that contains the images
            while (true)
            {
                response = Microsoft.VisualBasic.Interaction.InputBox("Would you like to open the set image folder? y/n", "", "", 400, 400);

                if (response == "y" || response == "n")
                    break;
            }

            if (response == "y")
            {
                for (int i = 1; i <= book[1].Max; i++)
                {                                           //images end in three digits with preceding 0's (LibDiana012.jpg, LibDiana009.jpg)
                    cover[i] = Image.FromFile(Application.StartupPath + @"\Images\" + "LibDiana" + i.ToString("0##") + ".jpg");
                }
            }

            else
            {
                //opens a folderBrowserDialog
                DialogResult result = folderBrowserDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    //opens the folderchosen and then uploads all of the images to the array
                    string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);

                    for (int i = 0; i < book[1].Max + 1; i++)
                    {
                        cover[i] = Image.FromFile(files[i]);
                    }
                }
            }
                
        }

        private void ActivateObjects()
        {
            //if there is no file open then many of the 
            //components on the main screen are not enabled 
            //or visible, once a file is opened everything
            //becomes enabled

            if (f != null)
            {
                BtnNew.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnSearch.Enabled = true;
                txtSum.Visible = true;
                GrpInfo.Visible = true;
                TlBtnAdd.Enabled = true;
                TlBtnDelete.Enabled = true;
                TlBtnSearch.Enabled = true;
                TlBtnEdit.Enabled = true;
                tlHelpBtn.Enabled = true;
                txtSearch.Enabled = true;
            }
        }

        private void Display()
        {
            if (f != null)
            {
                //creates listview columns
                //I found this code in one of the example programs
                LstDisplay.Clear();
                LstDisplay.Columns.Add("Title", 300, HorizontalAlignment.Center);
                LstDisplay.Columns.Add("Author", 150, HorizontalAlignment.Center);
                LstDisplay.Columns.Add("Year", 100, HorizontalAlignment.Center);
                LstDisplay.Columns.Add("Genre", 150, HorizontalAlignment.Center);

                //adds the subitems to each of the columns
                for (int i = 1; i <= book[1].Max; i++)
                {
                    ListViewItem item = new ListViewItem();

                    item.Text = book[pointers[i]].title;
                    item.SubItems.Add(book[pointers[i]].author);
                    item.SubItems.Add(book[pointers[i]].year);
                    item.SubItems.Add(book[pointers[i]].genre);
                    LstDisplay.Items.Add(item);
                }
            }
        }        

        private void LstDisplay_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //if a column title head is clicked then
            //the column number (starts at 0) is passed 
            //down to the Sort method

            int sortnum = e.Column;
            Sort(sortnum);            
        }

        private void Sort (int b)
        {
            //pointers are initialize
            for (int i = 0; i < book[1].Max; i++)
                pointers[i] = i;

            //data is sorted using the pointer sort
            for (int j = 0; j < book[1].Max - 1; j++)
            {
                for (int k = j + 1; k < book[1].Max; k++)
                {                                                                   //b = the column #
                    if (book[pointers[j]].title.CompareTo(book[pointers[k]].title) > 0 && b == 0)
                    {
                        Rearrange(j, k);
                    }

                    if (book[pointers[j]].author.CompareTo(book[pointers[k]].author) > 0 && b == 1)
                    {
                        Rearrange(j, k);
                    }
 
                    if (book[pointers[j]].year.CompareTo(book[pointers[k]].year) > 0 && b == 2)
                    {
                        Rearrange(j, k);
                    }

                    if (book[pointers[j]].genre.CompareTo(book[pointers[k]].genre) > 0 && b == 3)
                    {
                        Rearrange(j, k);
                    }
                }
           }

           Display();
        }

        private void Rearrange(int j, int k)
        {
            //pointer values are rearranged
            //according to what they are being sorted by
            int temp = pointers[j];
            pointers[j] = pointers[k];
            pointers[k] = temp;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Add();
            Display(); 
        }

        private void Add()
        {
            //Asks for the password
            Password();

            //if the password is correct than the operation continues
            if (pass == true)
            {
                //DataEntry form is displayed
                FrmDataEntry d = new FrmDataEntry();

                //once the info if filled in and the user
                //presses OK the new entry is added to book[]
                if (d.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Entry to Add: " + d.Title);

                    n++;
                    book[1].Max = n + 1;

                    book[n].title = d.Title;
                    book[n].author = d.Author;
                    book[n].year = d.Year;
                    book[n].genre = d.Genre;

                }

                pass = false; //intializes the pass flag back to false
            }

            else
                MessageBox.Show("Incorrect password");
        }

        private void SaveAsStripMenuItem2_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            //opens the saveFileDialog and limits the accepted fields to text files
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|" + "All files|*.*";
                saveFileDialog1.FileName = f;
                saveFileDialog1.FilterIndex = 1;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //saves the information under the appropriately given name
                    f = saveFileDialog1.FileName;
                    StreamWriter write = new StreamWriter(f);

                    for (int i = 1; i < book[1].Max; i++)
                    {
                        write.WriteLine((book[i].title) + "*" + (book[i].author) + "*" + (book[i].year) + "*" + (book[i].genre) + "*" + (book[i].info));
                    }

                    write.Close(); //close StreamWriter
                }                
            
        }

        private void Password()
        {
            //entry is inputted by the user into an input box
            int entry = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter Password", "", "", 400, 400));
            entry = (entry * 5) + 123; //some simple math is done to the entry

            //if the statement is true then the password is true (password is 1005)
            if (entry == 5148)
            {
                pass = true;
                tries = 0;
            }

            else
            {
                pass = false;
                tries++;

                //if the person tries more than 2 times
                //to input the incorrect password the program shuts down
                if (tries > 2)
                {
                    MessageBox.Show("Program Shutting Down");
                    this.Close();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
            Display();            
        }

        private void LstDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checks to see what the focused item on the listview is
            selected = (LstDisplay.FocusedItem.Index) + 1;

            //information on the selected item is shown in the textbox
            txtSum.Text = book[pointers[selected]].info;

            //also an image of the item is shown
            PicBook.Image = cover[pointers[selected]];
            
        }

        private void Edit()
        {
            //asks for the password
            Password();

            if (pass == true)
            {
                //an entry must be selected in order to continue
                if (selected < 0)
                {
                    MessageBox.Show("Please make a selection before editing");
                }

                else
                {
                    //DataEntry form is displayed
                    FrmDataEntry d = new FrmDataEntry();
                    d.Title = "Make Changes:";

                    //the information for the selected item is
                    //displayed in the appropriately titled textboxes
                    d.Title = book[pointers[selected]].title;
                    d.Author = book[pointers[selected]].author;
                    d.Year = book[pointers[selected]].year;
                    d.Genre = book[pointers[selected]].genre;
                    d.Info = book[pointers[selected]].info;

                    if (d.ShowDialog() == DialogResult.OK)
                    {
                        //when the user selects OK the information is changed but not saved
                        book[pointers[selected]].title = d.Title;
                        book[pointers[selected]].author = d.Author;
                        book[pointers[selected]].year = d.Year;
                        book[pointers[selected]].genre = d.Genre;
                        book[pointers[selected]].info = d.Info;

                        MessageBox.Show("Changes have been made to: " + book[pointers[selected]].title);
                    }
                }

                pass = false;
            }

            else
                MessageBox.Show("Incorrect password");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            Display();
        }

        private void Delete()
        {
            //asks for password
            Password();

            if (pass == true)
            {
                if (selected < 0)
                {
                    MessageBox.Show("Please make a selection before continuing");
                }

                else
                {
                    //double checks that the user is sure about deleting the entry
                    DialogResult r = MessageBox.Show("Book Entry to Delete: " + book[pointers[selected]].title, "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (r == DialogResult.OK)
                    {
                        n--;

                        for (int i = selected; i <= n; i++)
                        {
                            book[pointers[i]].title = book[pointers[i + 1]].title;
                            book[pointers[i]].author = book[pointers[i + 1]].author;
                            book[pointers[i]].year = book[pointers[i + 1]].year;
                            book[pointers[i]].genre = book[pointers[i + 1]].genre;
                            cover[i] = cover[i + 1];
                        }
                    }

                    //book Max is changed
                    book[1].Max--;
                }

                pass = false;
            }

            else
                MessageBox.Show("Incorrect password");
            
            
        }
        
        private void CreateNwStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            LstDisplay.Clear();
            Initialize();
            New();
            Save();
        }

        private void FrmLibrary_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if the user tries to exit the form in anyway they will be asked if they
            //would like to save their file
            if (f != null)
            {
                DialogResult r = MessageBox.Show("Would you like to save before exiting?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                    Save();
            }
        }

        private void New()
        {
            //this method is used when the user wants to create a new catalogue

            int i = 0;

            while (true)
            {
                DialogResult r = MessageBox.Show("Would you like to make an entry?", "Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    FrmDataEntry d = new FrmDataEntry();

                    i++;

                    if (d.ShowDialog() == DialogResult.OK)
                    {
                        book[i].title = d.Title;
                        book[i].author = d.Author;
                        book[i].year = d.Year;
                        book[i].genre = d.Genre;
                    }

                }

                else
                    break;
            }

            book[1].Max = i + 1;

            //Reminds to save the file under a new name so that they will not accidentely replace anything
            MessageBox.Show("Save your file under a new name", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information); 

        }

        private void Initialize()
        {            
            for (int i = 0; i < 200; i++)
                pointers[i] = i;

            //all counters set to zero
            n = 0;
            c = 0;
            tries = 0;
            selected = -1;
            pass = false;

            //the parts of book[] are set to ""
            while (n < 200)
            {
                book[n] = new Book();
                book[n].title = "";
                book[n].author = "";
                book[n].year = "";
                book[n].genre = "";

                n++;
            }

            book[1].Max = 0;
        }

        private void TlBtnOpen_Click(object sender, EventArgs e)
        {
            Initialize();
            LoadData();
            LoadImages();
            ActivateObjects();
            Display();
        }

        private void TlBtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void TlBtnNew_Click(object sender, EventArgs e)
        {
            LstDisplay.Clear();
            Initialize();
            New();
            Save();
        }

        private void tlHelpBtn_Click(object sender, EventArgs e)
        {
            FrmHelp x = new FrmHelp();
            x.Show();
        }

        private void TlBtnEdit_Click(object sender, EventArgs e)
        {
            Edit();
            Display();
        }

        private void TlBtnAdd_Click(object sender, EventArgs e)
        {
            Add();
            Display();

        }

        private void TlBtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            Display();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if there is text in the search box 
            //the SearchBook method is called
            if (txtSearch.Text != null)
            {
                string bksearch = txtSearch.Text;
                
                SearchBook(bksearch);
                
                //Search.Linear(book[].title,bksearch,book[1].Max);
                //I tried to send it to a class but it didn't work
            } 
        }

        private void SearchBook(string bks)
        {
            //I found part of this linear search in one of the examples
            //but I modified it a bit 
            bool found = false;

            //since the data is not sorted 
            for (int i = 0; i < book[1].Max; i++)
            {
                string tempbook = book[pointers[i]].title.ToLower();
                string temptext = bks.ToLower();

                if (tempbook == temptext)
                {
                    //if found the FoundSearch method is called
                    FoundSearch(pointers[i]);
                    found = true;
                }
            }

            if (found == false)
                MessageBox.Show("Sorry that does not exist, please try again"); 
        }

        private void FoundSearch(int pos)
        {
            //info for the found item is shown in the data entry
            //form where changes can be made to it
            FrmDataEntry d = new FrmDataEntry();

            d.Title = book[pointers[pos]].title;
            d.Author = book[pointers[pos]].author;
            d.Year = book[pointers[pos]].year;
            d.Genre = book[pointers[pos]].genre;
            d.Info = book[pointers[pos]].info;

            d.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            //opens the help form
            FrmHelp x = new FrmHelp();
            x.Show();
        }

        

    }

}