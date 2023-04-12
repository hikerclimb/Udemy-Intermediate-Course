using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Sorting_and_Searching_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] pointers = new int[200];
        PatientInfo[] Pat = new PatientInfo[200];
        int N;
        string f;
        /////////////////////////////////////////////////////////////////////////////////////////
        //Variable Dictionary:///////////////////////////////////////////////////////////////////
        //Pointers is used to control my Patient Info. For sorting and searching.////////////////
        //N is used when loading in data, either by opening a file or clicking new file./////////
        //Pat is used to store all of the patients information. 200 Max patients can be stored.//
        //f is used for saving ease of use. It allows me to remember the file name.//////////////
        /////////////////////////////////////////////////////////////////////////////////////////

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
            CboNames.Items.Add(Pat[Pat[1].Max - 1].Name);
            UpdateList();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
            UpdateList();
            //Calls load data, then updates the list.
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //Closes the program.
        }

        private void BtnRP_Click(object sender, EventArgs e)
        {
            if (CboNames.Text != "")
            {
                Search(CboNames.Text,1); 
                UpdateList();
                //Calls remove, then updates the list.
            }
            else
            {
                MessageBox.Show("You must select a name from the drop down list!");
            }
         }

        private void BtnCP_Click(object sender, EventArgs e)
        {
            Search(CboNames.Text,0);
            //Edit(1);
            UpdateList();
            //Calls Search function to find the name index and then updates the list.
        }
        private void ascendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameSort("Asc", "Name");
            //Calls sort with appropriate order, and what to sort.
        }
        private void descendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameSort("Des", "Name");
            //Calls sort with appropriate order, and what to sort.
        }

        private void ascendingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NameSort("Asc", "Age");
            //Calls sort with appropriate order, and what to sort.
        }

        private void descendingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NameSort("Des", "Age");
            //Calls sort with appropriate order, and what to sort.
        }

        private void ascendingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NameSort("Asc", "Room");
            //Calls sort with appropriate order, and what to sort.
        }

        private void descendingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NameSort("Des", "Room");
            //Calls sort with appropriate order, and what to sort.
        }

        private void malesAtTheTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameSort("Des", "Sex");
            //Calls sort with appropriate order, and what to sort.
        }

        private void femalesAtTheTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameSort("Asc", "Sex");
            //Calls sort with appropriate order, and what to sort.
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Search(TxtSearch.Text,0);
            //Calls the Search method.
        }

        private void Add()
        {
            FrmData x = new FrmData();

            if (x.ShowDialog() == DialogResult.OK)
            {
                //Shows the data entry form.
                Pat[(Pat[1].Max)].Name = x.PatName;
                Pat[(Pat[1].Max)].Age = x.Age;
                Pat[(Pat[1].Max)].Sex = x.Sex;
                Pat[(Pat[1].Max)].RmNum = x.RmNum;
                Pat[(Pat[1].Max)].Reason = x.Reason;
                Pat[(Pat[1].Max)].XtraCons = x.XtraCons;
                Pat[1].Max += 1;
                //And if I clicked okay, add all the data entered into the array.
            }
            SetCboNames();
        }


        private void Edit(int Edit)
        {
            FrmData x = new FrmData();
            x.PatName = Pat[Edit].Name;
            x.Age = Pat[Edit].Age;
            x.Sex = Pat[Edit].Sex;
            x.RmNum = Pat[Edit].RmNum;
            x.Reason = Pat[Edit].Reason;
            x.XtraCons = Pat[Edit].XtraCons;
            if (x.ShowDialog() == DialogResult.OK)
            {
                //Shows the data entry form, with data pre filled in for the selected patient to edit.
                Pat[Edit].Name = x.PatName;
                Pat[Edit].Age = x.Age;
                Pat[Edit].Sex = x.Sex;
                Pat[Edit].RmNum = x.RmNum;
                Pat[Edit].Reason = x.Reason;
                Pat[Edit].XtraCons = x.XtraCons;
                //If user clicks okay, save the edited information.
            }
            SetCboNames();
        }

        private void Remove(int Remove)
        {
            
            //Sets remove to the index of patient we wish to remove.
            for (int i = Remove; i < Pat[1].Max; i++)
            {
                Pat[pointers[i]].Name = Pat[pointers[i] + 1].Name;
                Pat[pointers[i]].Age = Pat[pointers[i] + 1].Age;
                Pat[pointers[i]].Sex = Pat[pointers[i] + 1].Sex;
                Pat[pointers[i]].RmNum = Pat[pointers[i] + 1].RmNum;
                Pat[pointers[i]].Reason = Pat[pointers[i] + 1].Reason;
                Pat[pointers[i]].XtraCons = Pat[pointers[i] + 1].XtraCons;
                //Does a simple delete theory, deleting the item of the index the user chose.
            }
            Pat[1].Max = Pat[1].Max - 1;
            if (Pat[1].Max < 0)
            {
                Pat[1].Max = 0;
            }
            SetCboNames();
            //Subtracts one from the number of patients, and if it is less than zero, we make it zero.
        }
        private void UpdateList()
        {
            LstDisplay.Clear();
            LstDisplay.Columns.Add("Patient", 100, HorizontalAlignment.Center);
            LstDisplay.Columns.Add("Age", 100, HorizontalAlignment.Center);
            LstDisplay.Columns.Add("Sex", 100, HorizontalAlignment.Center);
            LstDisplay.Columns.Add("Room Number", 100, HorizontalAlignment.Center);
            LstDisplay.Columns.Add("Reason", 150, HorizontalAlignment.Center);
            LstDisplay.Columns.Add("Extra Conditions", 200, HorizontalAlignment.Center);
           //Adds all the List Box headings.
            for (int i = 0; i < Pat[1].Max; i++)
            {

                ListViewItem IT = new ListViewItem();
                IT.Text = Pat[pointers[i]].Name;
                IT.SubItems.Add(Pat[pointers[i]].Age);
                IT.SubItems.Add(Pat[pointers[i]].Sex);
                IT.SubItems.Add(Pat[pointers[i]].RmNum);
                IT.SubItems.Add(Pat[pointers[i]].Reason);
                IT.SubItems.Add(Pat[pointers[i]].XtraCons);
                LstDisplay.Items.Add(IT);
                //Adds a patients information to a row, then adds the next patients to the next row..etc.
            }
        }
        private void LoadData()
        {
            openFileDialog1.Reset();
            openFileDialog1.InitialDirectory = Application.ExecutablePath;
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|" + "All files|*.*";
            openFileDialog1.FilterIndex = 1;
            //Used for ease of use, and allowing text files.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                f = openFileDialog1.FileName;
                //Stores the selected file name into f for ease of use saving purposes.
                StreamReader Read = new StreamReader(f);
                //Allows us to read in data with Read.
                string Line;
                N = 0;
                while ((Line = Read.ReadLine()) != null)
                {
                    Pat[N].Name = Line;
                    Pat[N].Age = Read.ReadLine();
                    Pat[N].Sex = Read.ReadLine();
                    Pat[N].RmNum = Read.ReadLine();
                    Pat[N].Reason = Read.ReadLine();
                    Pat[N].XtraCons = Read.ReadLine();
                    Pat[N].Picture = Read.ReadLine();
                   
                    N++;
                    //Reads in all the data, and stores it into Pat.
                    //Also adds the name to the combo box.
                }
                Pat[1].Max = N;
                SetCboNames();
                //Calls the function to put names into the combo box.
                //Makes Pat[1].Max equal to the amount of patients + 1;
                //Used in almost all For/Next loops.
                Read.Close();
                //Closes the file.
                Enable();
                //Enables buttons and tool strip items.
            }
            else
            {
                MessageBox.Show("No file was loaded!");
                //Says no file was loaded if user did not click OK.
            }
        }

        private void NameSort(string Sort, string Sorter)
        {
            int temp;
            //Used for temporarily storing names.

            for (int i = 0; i < Pat[1].Max; i++)
                pointers[i] = i;
            //Defaults all the pointers.

            for (int j = 0; j < Pat[1].Max - 1; j++)
            {
                for (int k = j + 1; k < Pat[1].Max; k++)
                {switch(Sorter){
                        //Switch case for what we are sorting.
                    case "Name":
                        if (Pat[pointers[j]].Name.CompareTo(Pat[pointers[k]].Name) > 0 && Sort == "Asc" || Pat[pointers[j]].Name.CompareTo(Pat[pointers[k]].Name) < 0 && Sort == "Des")
                        {
                            temp = pointers[j];
                            pointers[j] = pointers[k];
                            pointers[k] = temp;
                        }
                        break;
                    case "Age":
                        if (Pat[pointers[j]].Age.CompareTo(Pat[pointers[k]].Age) > 0 && Sort == "Asc" || Pat[pointers[j]].Age.CompareTo(Pat[pointers[k]].Age) < 0 && Sort == "Des")
                        {
                            temp = pointers[j];
                            pointers[j] = pointers[k];
                            pointers[k] = temp;
                        }
                        break;
                    case "Room":
                        if (int.Parse(Pat[pointers[j]].RmNum)> int.Parse(Pat[pointers[k]].RmNum) && Sort == "Asc" || int.Parse(Pat[pointers[j]].RmNum) < int.Parse(Pat[pointers[k]].RmNum) && Sort == "Des")
                        {
                            temp = pointers[j];
                            pointers[j] = pointers[k];
                            pointers[k] = temp;
                        }
                        break;
                    case "Sex":
                        if (Pat[pointers[j]].Sex.CompareTo(Pat[pointers[k]].Sex) > 0 && Sort == "Asc" || Pat[pointers[j]].Sex.CompareTo(Pat[pointers[k]].Sex) < 0 && Sort == "Des")
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
            SetCboNames();
            //Now we are done sorting, we update the list with sorted values.

        }

        
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= Pat[1].Max; i++)
            {
                Pat[i].Name = "";
                Pat[i].Age = "";
                Pat[i].Sex = "";
                Pat[i].RmNum = "";
                Pat[i].Reason = "";
                Pat[i].XtraCons = "";
                Pat[i].Picture = "";
                //Sets all values in the array blank.
            }
            Pat[1].Max = 0;
            //Makes our patient amount 0.
            Enable();
            //Calls the enable function.
            UpdateList();
            //Updates the list, if we had names in there before, they will be gone now.
        }
        private void Enable()
        {
            BtnNP.Enabled = true;
            BtnCP.Enabled = true;
            BtnRP.Enabled = true;
            sortListToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
            //Enables needed buttons and toolstrip items.
            //This is only called after we start a new file or open a file.
            //So that the program is less susceptible to bugging up.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 200; i++)
                pointers[i] = i;
            //Loads, and sets all pointers to defaults.

            N = 0;
            while (N < 200)
            {
                Pat[N] = new PatientInfo();
                Pat[N].Name = "";
                Pat[N].Age = "";
                Pat[N].Sex = "";
                Pat[N].RmNum = "";
                Pat[N].Reason = "";
                Pat[N].XtraCons = "";
                Pat[N].Picture = "";
                Pat[N].Max = 0;
                N++;
            }
            //Makes all patient values usable with the new PatientInfo, and sets them all blank.
           }


        private void Search(string Text, int Need)
        {
            //Text is used for searching for the name, to get an index value.
            //Need is used to see if we need to remove or edit.
            //Edit and a search will send Need = 0.
            for (int i = 0; i < Pat[1].Max; i++)
            {
                if (Pat[pointers[i]].Name == Text)
                {
                     if (Need == 1)
                    {
                        Remove(pointers[i]);
                         //Calls the remove function with our found index.

                    }
                    else if (Need == 0)
                    {
                        Edit(pointers[i]);
                        //Calls the edit function with our found index.
                    }
                         UpdateList();
                    //And update the list in case they edited the data, or removed.

                }

            }

        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|" + "All files|*.*";
            saveFileDialog1.FileName = f;           //prompt with current filename
            saveFileDialog1.FilterIndex = 1;
            //Sets the filters to txt files, and the default name to the page they opened.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                f = saveFileDialog1.FileName;
                StreamWriter Read = new StreamWriter(f);
                //Allows us to write to a data file.
                //A variable named Write would have probably been more appropriate.
                //But I am used to using Read.

                for (int i = 0; i < Pat[1].Max; i++)
                {
                    Read.WriteLine(Pat[i].Name);
                    Read.WriteLine(Pat[i].Age);
                    Read.WriteLine(Pat[i].Sex);
                    Read.WriteLine(Pat[i].RmNum);
                    Read.WriteLine(Pat[i].Reason);
                    Read.WriteLine(Pat[i].XtraCons);
                    Read.WriteLine("NA");
                    //Writes the data to the file.
                    //NA is needed, as it was an unfinished opening to allow pictures.
                }

                Read.Close();
                //Closes the file.
            }
            else
            {
                MessageBox.Show("Save unsuccessful.");
                //If the user does not click OK, no save is done, and we are unsuccessful.
            }

        }
        private void SetCboNames()
        {
            CboNames.Items.Clear();
            for (int i = 0; i < Pat[1].Max; i++)
            {
                CboNames.Items.Add(Pat[pointers[i]].Name);
            }
            //This renews the names in the Combo Box.
            //It is called when we delete, add or change name information.
        }
    }
}