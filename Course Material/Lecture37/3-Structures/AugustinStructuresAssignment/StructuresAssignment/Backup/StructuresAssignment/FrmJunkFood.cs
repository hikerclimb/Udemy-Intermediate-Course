using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO; //needed to load information from data file
using SpeechLib; //needed for speech


namespace StructuresAssignment
{
    public partial class FrmJunkFood : Form
    {
        public FrmJunkFood()
        {
            InitializeComponent();
        }
        SpVoice voice = new SpVoice();

        struct ListOfJunkFood
        {
            public string name; //defines name of food
            public string InventedIn; //defines where food is invented in
            public string Description; //defines the description of food
            public string Ingredients; //defines the ingredients of food
            public string FoodPicture; //defines picture of food
        }

        ListOfJunkFood[] Junk = new ListOfJunkFood[13];

        private void FrmJunkFood_Load(object sender, EventArgs e)
        {
            //prepare data file variables
            string p = Application.StartupPath;
            //Tells computer where the data file is and what it is called
            string f = p + @"\food.txt";
            StreamReader r = new StreamReader(f);

            //This for loop does everything in one step: It cycles through each food,
            //adding four bits of info to the correct locations, then the picture from where it is located
            //This saves a considerable amount of lines of code: better structure than writing everything all out
            for (int i = 1; i <= 12; i++)
            {
                Junk[i].name = r.ReadLine();
                Junk[i].InventedIn = r.ReadLine();
                Junk[i].Description = r.ReadLine();
                Junk[i].Ingredients = r.ReadLine();
                Junk[i].FoodPicture = p + @"\Junk Food Pictures\food" + i + ".jpg";
            }

            //Initialize starting text and image when program is loaded
            LblName.Text = Junk[1].name;
            LblPlaceofInvention.Text = Junk[1].InventedIn;
            LblDescription.Text = Junk[1].Description;
            LblIngredient.Text = Junk[1].Ingredients;
            PicJunkFood.Image = Image.FromFile(Junk[1].FoodPicture);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrbJunkFoodTypes_Scroll(object sender, EventArgs e)
        {
            // Get the index of the current value of the track bar - 1
            int CurPos = this.TrbJunkFoodTypes.Value;

            // Based on the current index, retrieve the values of the
            // current car and assign each to the corresponding control 
            LblName.Text = Junk[CurPos].name;
            LblPlaceofInvention.Text = Junk[CurPos].InventedIn;
            LblDescription.Text = Junk[CurPos].Description;
            LblIngredient.Text = Junk[CurPos].Ingredients;
            PicJunkFood.Image = Image.FromFile(Junk[CurPos].FoodPicture);
        }

        private void BtnSpeakIngredients_Click(object sender, EventArgs e)
        {
            //this tells the program to speak everything in the following labels:
            voice.Speak("Name: " + LblName.Text, SpeechVoiceSpeakFlags.SVSFDefault);
            voice.Speak("Invented in " + LblPlaceofInvention.Text, SpeechVoiceSpeakFlags.SVSFDefault);
            voice.Speak("Description: " + LblDescription.Text, SpeechVoiceSpeakFlags.SVSFDefault);
            voice.Speak("Ingredients" + LblIngredient.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }
    }
}