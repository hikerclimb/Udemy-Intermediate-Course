using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //*********************VARIABLES*********************
        //Pokemon[494] ConstPkmn = stores constant values for each pokemon
        //Pokemon[494] Pkmn = used for sorting, searching and displaying
        //TeamMember[7] Team = stores info for the current team
        //int members = number of members in current team (6 max)
        //int active = active pokemon number
        //int activemember = active team member number
        //int sort = type of sorts
        //***************************************************


        Pokemon[] ConstPkmn = new Pokemon[494];
        Pokemon[] Pkmn = new Pokemon[494];
        TeamMember[] Team = new TeamMember[7];
        int members = 0;
        int active = 1;
        int activemember = 0;
        int sort = 3;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //sets up form
            ReadData();
            FillComboBox();
            UpdateList();
        }

        private void ReadData()
        {
            //read from file with all pokemon information
            StreamReader read = new StreamReader(Application.StartupPath + @"\pkmn.txt");

            for (int i = 1; i <= 493; i++)
            {
                //read a line an split into parts at %s
                string line = read.ReadLine();
                string[] parts = line.Split('%');

                //create instance
                ConstPkmn[i] = new Pokemon();

                //stores info into Pokemon objects
                ConstPkmn[i].number = parts[0];
                ConstPkmn[i].have = Convert.ToBoolean(Convert.ToInt32(parts[1]));
                ConstPkmn[i].name = parts[2];
                ConstPkmn[i].type1 = parts[3];
                ConstPkmn[i].type2 = parts[4];
                ConstPkmn[i].atk = Convert.ToInt32(parts[5]);
                ConstPkmn[i].def = Convert.ToInt32(parts[6]);
                ConstPkmn[i].spd = Convert.ToInt32(parts[7]);
                ConstPkmn[i].enabled = true;

                //copies constant value to changing class array
                Pkmn[i] = ConstPkmn[i];
            }

            read.Close();

            //creates instance of team objects
            for (int i = 1; i <= 6; i++)
                Team[i] = new TeamMember();
        }

        private void FillComboBox()
        {
            //fills in combo boxes
            for (int i = 1; i <= 493; i++)
            {
                CboNumber.Items.Add(ConstPkmn[i].number);
                CboName.Items.Add(ConstPkmn[i].name);
            }

            //check "have" box if first pokemon is owned
            ChkHave.Checked = ConstPkmn[1].have;
        }

        private void UpdateList()
        {
            //clears list
            LstDisplayer.Items.Clear();

            for (int i = 1; i <= 493; i++)
            {
                if (Pkmn[i].enabled)
                {
                    //changes have bool into text
                    string have = "Have";

                    if (!Pkmn[i].have)
                        have = "Need";

                    //display pokemon info into each column
                    string[] line = { Pkmn[i].name, Pkmn[i].type1, Pkmn[i].type2, have };
                    LstDisplayer.Items.Add(Pkmn[i].number).SubItems.AddRange(line);
                }
            }
        }

        private void TstNew_Click(object sender, EventArgs e)
        {
            //verify action
            GenericDialogBox g = new GenericDialogBox();
            g.Text = "Are you sure you want to clear team?";
            g.ShowDialog();

            //if yes, then reset team
            if (g.DialogResult == DialogResult.OK)
                Reset();
        }

        private void TstSave_Click(object sender, EventArgs e)
        {
            //save team
            SaveFile();
        }

        private void TstOpen_Click(object sender, EventArgs e)
        {
            //open team
            OpenFile();
        }

        private void TstSearch_Click(object sender, EventArgs e)
        {
            //search function
            Search();
        }

        private void TstAdd_Click(object sender, EventArgs e)
        {
            //puts active pokemon into team
            AddToTeam();
        }

        private void TstRemove_Click(object sender, EventArgs e)
        {
            //removes active member from team, if one exists
            if (Team[activemember].enabled)
                RemoveMember();
        }

        private void TstHelp_Click(object sender, EventArgs e)
        {
            //displays help
            FrmHelp help = new FrmHelp();
            help.ShowDialog();
        }

        private void TstClose_Click(object sender, EventArgs e)
        {
            //verify action
            GenericDialogBox g = new GenericDialogBox();

            g.Text = "Are you sure you want to quit?";
            g.ShowDialog();

            //close
            if (g.DialogResult == DialogResult.OK)
                this.Close();
        }

        private void Reset()
        {
            //reset team values
            for (int r = 1; r <= 6; r++)
            {
                members = 0;
                activemember = 0;
                Team[r] = new TeamMember();
                Team[r].enabled = false;
            }

            //change form stuff
            AdjustButtons(false);
            ResetMembers(1, 6);
            DisplayMembers();
            StsLabel.Text = "Team cleared";

        }

        private void SaveFile()
        {
            //save file dialog properties
            SfdSave.Title = "Save Team";
            SfdSave.FileName = "";
            SfdSave.Filter = "Text files (*.txt)|*.txt";
            SfdSave.FilterIndex = 1;
            SfdSave.InitialDirectory = Application.StartupPath + @"\teams\";

            //save team
            if (SfdSave.ShowDialog() == DialogResult.OK)
                WriteSaveFile(SfdSave.FileName);
        }

        private void WriteSaveFile(string dir)
        {
            string text = "";

            //puts number of members in first line
            text = members.ToString() + Environment.NewLine;

            //puts info into string
            for (int i = 1; i <= members; i++)
            {
                text += Team[i].number + "%";
                text += Team[i].name + "%" + Team[i].nickname + "%";
                text += Team[i].type1 + "%" + Team[i].type2 + "%";
                text += (Convert.ToInt32(Team[i].shiny)).ToString() + "%";
                text += Team[i].atk.ToString() + "%" + Team[i].def.ToString() + "%";
                text += Team[i].spd.ToString() + Environment.NewLine;
            }

            //encrypts string
            Encrypter.Encrypt(ref text);

            //writes file to save location
            StreamWriter write = new StreamWriter(dir);

            write.Write(text);

            write.Close();

            StsLabel.Text = "Team Saved";
        }

        private void OpenFile()
        {
            //open file dialog properties
            OfdOpen.Title = "Open Team";
            OfdOpen.FileName = "";
            OfdOpen.Filter = "Text files (*.txt)|*.txt";
            OfdOpen.FilterIndex = 1;
            OfdOpen.InitialDirectory = Application.StartupPath + @"\teams\";

            //opens file
            if (OfdOpen.ShowDialog() == DialogResult.OK)
                ReadSaveFile(OfdOpen.FileName);
        }

        private void ReadSaveFile(string dir)
        {
            //reads from file at open location
            StreamReader reader = new StreamReader(dir);

            //puts whole file into string
            string text = reader.ReadToEnd();

            reader.Close();

            //checks if file is a text file with a team in it
            if (Encrypter.Validate(text))
            {
                StreamReader read = new StreamReader(dir);

                //extracts number of members
                members = Convert.ToInt32(Encrypter.Decrypt(read.ReadLine()).Substring(0, 1));

                //creates new instance
                for (int r = 1; r <= 6; r++)
                {
                    Team[r] = new TeamMember();
                    Team[r].enabled = false;
                }

                //stores team info into objects
                for (int i = 1; i <= members; i++)
                {
                    Team[i].enabled = true;

                    string line = Encrypter.Decrypt(read.ReadLine());
                    string[] parts = line.Split('%');

                    Team[i].number = parts[0];
                    Team[i].name = parts[1];
                    Team[i].nickname = parts[2];
                    Team[i].type1 = parts[3];
                    Team[i].type2 = parts[4];
                    Team[i].shiny = Convert.ToBoolean(Convert.ToInt32(parts[5]));
                    Team[i].atk = Convert.ToInt32(parts[6]);
                    Team[i].def = Convert.ToInt32(parts[7]);
                    Team[i].spd = Convert.ToInt32(parts[8]);
                }

                //if file is blank, show nothing
                if (members == 0)
                    Reset();

                read.Close();

                //update form
                AdjustButtons(false);
                DisplayMembers();
                StsLabel.Text = "Team opened";
            }
            //if text file is changed or not a team file
            else
                MessageBox.Show("There was an error reading file. File may be corrupt. Is file a team file?");
        }

        private void CboNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change active pokemon
            ChangePkmn(Convert.ToInt32(CboNumber.Text));
        }

        private void CboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //stores current sorted style in temp variable
            int temp = sort;

            //sorts by name, finds pokemon, sorts back to original sorted style
            SearchnSort.QuickSort(Pkmn, 1, 493, 1);
            int num = SearchnSort.Search(Pkmn, CboName.Text, 1, 493);
            SearchnSort.QuickSort(Pkmn, 1, 493, temp);

            //change active pokemon
            ChangePkmn(num);
        }

        private void ChangePkmn(int num)
        {
            //updates form
            active = num;
            CboNumber.Text = ConstPkmn[num].number;
            CboName.Text = ConstPkmn[num].name;
            TxtType1.Text = ConstPkmn[num].type1;
            TxtType2.Text = ConstPkmn[num].type2;
            ChkHave.Checked = ConstPkmn[num].have;
            PicType1.ImageLocation = Application.StartupPath + @"\types\" + ConstPkmn[num].type1 + @".png";
            PicType2.ImageLocation = Application.StartupPath + @"\types\" + ConstPkmn[num].type2 + @".png";
            PicPkmn.ImageLocation = Application.StartupPath + @"\sprites\" + ConstPkmn[num].number + @".png";

            StsLabel.Text = ConstPkmn[num].name.ToString() + " selected";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //add pokemon to team
            AddToTeam();
        }

        private void AddToTeam()
        {
            //if there is room
            if (members < 6)
            {
                //show nickname form
                FrmNickname f = new FrmNickname();
                f.ShowDialog();

                //if nickname over 10 characters
                if (f.Use && f.Nickname.Length >= 10)
                {
                    MessageBox.Show("Keep nickname below 10 characters");
                }
                else
                {
                    //stores info into member objects
                    members++;
                    Team[members] = new TeamMember();

                    Team[members].enabled = true;
                    Team[members].name = ConstPkmn[active].name;
                    Team[members].nickname = Team[members].name;
                    Team[members].number = ConstPkmn[active].number;
                    Team[members].type1 = ConstPkmn[active].type1;
                    Team[members].type2 = ConstPkmn[active].type2;
                    Team[members].atk = ConstPkmn[active].atk;
                    Team[members].def = ConstPkmn[active].def;
                    Team[members].spd = ConstPkmn[active].spd;

                    //if there is a nickname, use it
                    if (f.Use && f.Nickname != "")
                        Team[members].nickname = f.Nickname;

                    Team[members].shiny = f.Shiny;


                    //update form
                    AdjustButtons(false);
                    DisplayMembers();
                    StsLabel.Text = Team[members].nickname + " added to team";
                }
            }
            //if team already has 6 members
            else
                MessageBox.Show("Team full. Remove a member if you want to add another one.");
        }

        private void ResetMembers(int low, int high)
        {
            //if high != low, update all members
            //if low = high, update only one member

            //resets form control settings to default values
            if (low == 1 || high != low)
            {
                LblMember1.Text = "Open Slot";
                PicMember1.ImageLocation = null;
                PicM1T1.ImageLocation = Application.StartupPath + @"\types\-.png";
                PicM1T2.ImageLocation = Application.StartupPath + @"\types\-.png";
                PicSmallmember1.Image = null;
                RdoMember1.Checked = false;
            }
            if (low == 2 || high != low)
            {
                LblMember2.Text = "Open Slot";
                PicMember2.ImageLocation = null;
                PicM2T1.ImageLocation = Application.StartupPath + @"\types\-.png";
                PicM2T2.ImageLocation = Application.StartupPath + @"\types\-.png";
                PicSmallmember2.Image = null;
                RdoMember2.Checked = false;
            }
            if (low == 3 || high != low)
            {
                LblMember3.Text = "Open Slot";
                PicMember3.ImageLocation = null;
                PicM3T1.ImageLocation = Application.StartupPath + @"\types\-.png";
                PicM3T2.ImageLocation = Application.StartupPath + @"\types\-.png";
                PicSmallmember3.Image = null;
                RdoMember3.Checked = false;
            }
            if (low == 4 || high != low)
            {
                LblMember4.Text = "Open Slot";
                PicMember4.ImageLocation = null;
                PicM4T1.ImageLocation = Application.StartupPath + @"\types\-.png";
                PicM4T2.ImageLocation = Application.StartupPath + @"\types\-.png";
                PicSmallmember4.Image = null;
                RdoMember4.Checked = false;
            }
            if (low == 5 || high != low)
            {
                LblMember5.Text = "Open Slot";
                PicMember5.ImageLocation = null;
                PicM5T1.ImageLocation = Application.StartupPath + @"\types\-.png";
                PicM5T2.ImageLocation = Application.StartupPath + @"\types\-.png";
                PicSmallmember5.Image = null;
                RdoMember5.Checked = false;
            }
            if (low == 6 || high != low)
            {
                LblMember6.Text = "Open Slot";
                PicMember6.ImageLocation = null;
                PicM6T1.ImageLocation = Application.StartupPath + @"\types\-.png";
                PicM6T2.ImageLocation = Application.StartupPath + @"\types\-.png";
                PicSmallmember6.Image = null;
                RdoMember6.Checked = false;
            }
        }

        private void DisplayMembers()
        {
            string file = @"\sprites\";

            //updates form control settings for team members
            //only updates places where members exist
            if (members > 0)
            {
                LblMember1.Text = Team[1].name + " / " + Team[1].nickname;
                if (Team[1].shiny)
                    file += @"shiny\";
                PicMember1.ImageLocation = Application.StartupPath + file + Team[1].number + @".png";
                PicM1T1.ImageLocation = Application.StartupPath + @"\types\" + Team[1].type1 + @".png";
                PicM1T2.ImageLocation = Application.StartupPath + @"\types\" + Team[1].type2 + @".png";
                PicSmallmember1.ImageLocation = Application.StartupPath + @"\sprites\icons\dpicon" + Team[1].number + @".png";

                file = @"\sprites\";
            }
            if (members > 1)
            {
                LblMember2.Text = Team[2].name + " / " + Team[2].nickname;
                if (Team[2].shiny)
                    file += @"shiny\";
                PicMember2.ImageLocation = Application.StartupPath + file + Team[2].number + @".png";
                PicM2T1.ImageLocation = Application.StartupPath + @"\types\" + Team[2].type1 + @".png";
                PicM2T2.ImageLocation = Application.StartupPath + @"\types\" + Team[2].type2 + @".png";
                PicSmallmember2.ImageLocation = Application.StartupPath + @"\sprites\icons\dpicon" + Team[2].number + @".png";

                file = @"\sprites\";
            }
            if (members > 2)
            {
                LblMember3.Text = Team[3].name + " / " + Team[3].nickname;
                if (Team[3].shiny)
                    file += @"shiny\";
                PicMember3.ImageLocation = Application.StartupPath + file + Team[3].number + @".png";
                PicM3T1.ImageLocation = Application.StartupPath + @"\types\" + Team[3].type1 + @".png";
                PicM3T2.ImageLocation = Application.StartupPath + @"\types\" + Team[3].type2 + @".png";
                PicSmallmember3.ImageLocation = Application.StartupPath + @"\sprites\icons\dpicon" + Team[3].number + @".png";

                file = @"\sprites\";
            }
            if (members > 3)
            {
                LblMember4.Text = Team[4].name + " / " + Team[4].nickname;
                if (Team[4].shiny)
                    file += @"shiny\";
                PicMember4.ImageLocation = Application.StartupPath + file + Team[4].number + @".png";
                PicM4T1.ImageLocation = Application.StartupPath + @"\types\" + Team[4].type1 + @".png";
                PicM4T2.ImageLocation = Application.StartupPath + @"\types\" + Team[4].type2 + @".png";
                PicSmallmember4.ImageLocation = Application.StartupPath + @"\sprites\icons\dpicon" + Team[4].number + @".png";

                file = @"\sprites\";
            }
            if (members > 4)
            {
                LblMember5.Text = Team[5].name + " / " + Team[5].nickname;
                if (Team[5].shiny)
                    file += @"shiny\";
                PicMember5.ImageLocation = Application.StartupPath + file + Team[5].number + @".png";
                PicM5T1.ImageLocation = Application.StartupPath + @"\types\" + Team[5].type1 + @".png";
                PicM5T2.ImageLocation = Application.StartupPath + @"\types\" + Team[5].type2 + @".png";
                PicSmallmember5.ImageLocation = Application.StartupPath + @"\sprites\icons\dpicon" + Team[5].number + @".png";

                file = @"\sprites\";
            }
            if (members > 5)
            {
                LblMember6.Text = Team[6].name + " / " + Team[6].nickname;
                if (Team[6].shiny)
                    file += @"shiny\";
                PicMember6.ImageLocation = Application.StartupPath + file + Team[6].number + @".png";
                PicM6T1.ImageLocation = Application.StartupPath + @"\types\" + Team[6].type1 + @".png";
                PicM6T2.ImageLocation = Application.StartupPath + @"\types\" + Team[6].type2 + @".png";
                PicSmallmember6.ImageLocation = Application.StartupPath + @"\sprites\icons\dpicon" + Team[6].number + @".png";

                file = @"\sprites\";
            }
        }

        private void LstDisplayer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string num = "";

            //catches exception if multiple pokemon are selected
            try
            {
                //takes selected pokemon number
                num = LstDisplayer.FocusedItem.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Select only one Pokemon at a time");
                LstDisplayer.FocusedItem.Focused = false;
            }

            //if number taken, change active pokemon
            if (num != "")
                ChangePkmn(Convert.ToInt32(num));
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //stores current sorted style in temp variable
            int temp = sort;

            //stores have value into objects
            ConstPkmn[active].have = ChkHave.Checked;
            Pkmn[active].have = ChkHave.Checked;

            //updates whole list including have value
            UpdateList();

            StsLabel.Text = "Saved";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //search function
            Search();
        }

        private void Search()
        {
            //opens search dialog
            FrmSearchparameters f = new FrmSearchparameters();
            f.ShowDialog();

            //to avoid ConstPkmn being passed by ref, it's info is put into Pkmn
            //if a direct Pkmn = ConstPkmn is used, then all values changed in Pkmn will affect ConstPkmn
            //therefore, each element of the array is changed one by one
            for (int i = 1; i <= 493; i++)
                Pkmn[i] = ConstPkmn[i];

            //search function
            int count = SearchnSort.Restrict(Pkmn, f.NumberFrom, f.NumberTo, f.PkmnName, f.Type1, f.Type2, f.ByHave, f.Have);

            //sort back to original style
            SearchnSort.QuickSort(Pkmn, 1, 493, sort);

            //updates search result
            UpdateList();

            StsLabel.Text = count.ToString() + " result(s)";
        }

        private void RdoName_CheckedChanged(object sender, EventArgs e)
        {
            //sort by name and show
            sort = 1;
            SearchnSort.QuickSort(Pkmn, 1, 493, sort);
            UpdateList();

            StsLabel.Text = "Sorted by name";
        }

        private void RdoReversename_CheckedChanged(object sender, EventArgs e)
        {
            //sort by reverse name and show
            sort = 2;
            SearchnSort.QuickSort(Pkmn, 1, 493, sort);
            UpdateList();

            StsLabel.Text = "Sorted by name (reverse)";
        }
        private void RdoNumber_CheckedChanged(object sender, EventArgs e)
        {
            //sort by number and show
            sort = 3;
            SearchnSort.QuickSort(Pkmn, 1, 493, sort);
            UpdateList();

            StsLabel.Text = "Sorted by number";
        }

        private void RdoMember1_CheckedChanged(object sender, EventArgs e)
        {
            //make member 1 active member
            activemember = 1;
            AdjustButtons(false);
        }

        private void RdoMember2_CheckedChanged(object sender, EventArgs e)
        {
            //make member 2 active member
            activemember = 2;
            AdjustButtons(false);
        }

        private void RdoMember3_CheckedChanged(object sender, EventArgs e)
        {
            //make member 3 active member
            activemember = 3;
            AdjustButtons(false);
        }

        private void RdoMember4_CheckedChanged(object sender, EventArgs e)
        {
            //make member 4 active member
            activemember = 4;
            AdjustButtons(false);
        }

        private void RdoMember5_CheckedChanged(object sender, EventArgs e)
        {
            //make member 5 active member
            activemember = 5;
            AdjustButtons(false);
        }

        private void RdoMember6_CheckedChanged(object sender, EventArgs e)
        {
            //make member 6 active member
            activemember = 6;
            AdjustButtons(false);
        }

        private void AdjustButtons(bool operation)
        {
            //if no member is selected
            if (activemember == 0 || !Team[activemember].enabled)
            {
                //don't let any buttons be pressed
                BtnMoveleft.Enabled = false;
                BtnMoveright.Enabled = false;
                BtnRemove.Enabled = false;
            }
            //if only one member on team
            else if (activemember == 1 && members == activemember)
            {
                //enable only remove button
                BtnMoveleft.Enabled = false;
                BtnMoveright.Enabled = false;
                BtnRemove.Enabled = true;
            }
            //if far left member is chosen
            else if (activemember == 1)
            {
                //disable move left button
                BtnMoveleft.Enabled = false;
                BtnMoveright.Enabled = true;
                BtnRemove.Enabled = true;
            }
            //if far right member is selected
            else if (activemember == 6 || members == activemember)
            {
                //disable move right button
                BtnMoveleft.Enabled = true;
                BtnMoveright.Enabled = false;
                BtnRemove.Enabled = true;
            }
            //otherwise
            else
            {
                //enable all buttons
                BtnMoveleft.Enabled = true;
                BtnMoveright.Enabled = true;
                BtnRemove.Enabled = true;
            }

            //if special operation is true, make the active member's radio button checked
            if (operation)
            {
                if (activemember == 1)
                    RdoMember1.Checked = true;
                if (activemember == 2)
                    RdoMember2.Checked = true;
                if (activemember == 3)
                    RdoMember3.Checked = true;
                if (activemember == 4)
                    RdoMember4.Checked = true;
                if (activemember == 5)
                    RdoMember5.Checked = true;
                if (activemember == 6)
                    RdoMember6.Checked = true;
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when program is closed, rewrite text file
            StreamWriter write = new StreamWriter(Application.StartupPath + @"\pkmn.txt");

            //saves the have value for next time the program is opened            
            for (int i = 1; i <= 493; i++)
            {
                write.Write(ConstPkmn[i].number + "%");
                write.Write(Convert.ToInt32(ConstPkmn[i].have) + "%");
                write.Write(ConstPkmn[i].name + "%");
                write.Write(ConstPkmn[i].type1 + "%");
                write.Write(ConstPkmn[i].type2 + "%");
                write.Write(ConstPkmn[i].atk + "%");
                write.Write(ConstPkmn[i].def + "%");
                write.WriteLine(ConstPkmn[i].spd);
            }

            write.Close();
        }

        private void BtnMoveleft_Click(object sender, EventArgs e)
        {
            //switch member places
            TeamMember temp = Team[activemember];
            Team[activemember] = Team[activemember - 1];
            Team[activemember - 1] = temp;

            //adjust active member
            activemember--;

            //update form
            AdjustButtons(true);
            DisplayMembers();
            StsLabel.Text = Team[activemember].nickname + " moved left.";
        }

        private void BtnMoveright_Click(object sender, EventArgs e)
        {
            //switch member places
            TeamMember temp = Team[activemember];
            Team[activemember] = Team[activemember + 1];
            Team[activemember + 1] = temp;

            //adjust active member
            activemember++;

            //update form
            AdjustButtons(true);
            DisplayMembers();
            StsLabel.Text = Team[activemember].nickname + " moved right.";
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            //verify action
            GenericDialogBox g = new GenericDialogBox();
            g.Text = "Are you sure you want to remove " + Team[activemember].nickname + "?";
            g.ShowDialog();

            //remove member
            if (g.DialogResult == DialogResult.OK)
                RemoveMember();
        }

        private void RemoveMember()
        {
            //if there is more than 0 members
            if (activemember != 0)
            {
                StsLabel.Text = Team[activemember].nickname + " removed from team";

                //take out member and move all other members left
                for (int i = activemember; i <= 5; i++)
                {
                    TeamMember temp = Team[i];
                    Team[i] = Team[i + 1];
                    Team[i + 1] = temp;
                }

                //reset removed member
                Team[6] = new TeamMember();
                ResetMembers(members, 6);

                //change active member/members
                activemember--;
                members--;

                //update form
                AdjustButtons(true);
                DisplayMembers();
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            //if there are members on the team
            if (members > 0)
            {
                //create new stats form
                FrmStats game = new FrmStats();

                //send info
                game.GetInfo(Team, members);

                //show form
                game.ShowDialog();
            }
            //otherwise, display error message
            else
                MessageBox.Show("Make a team first!");
        }
    }

    //double buffered panel
    public class DoubleBufferPanel : Panel
    {
        public DoubleBufferPanel()
            : base()
        {
            this.DoubleBuffered = true;
        }
    }
}
