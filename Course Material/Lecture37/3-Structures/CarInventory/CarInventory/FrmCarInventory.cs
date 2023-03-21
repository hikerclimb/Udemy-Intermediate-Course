using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class FrmCarInventory : Form
    {
        public FrmCarInventory()
        {
            InitializeComponent();
        }

        struct CListOfCars
        {
            public String Make;
            public String Model;
            public int CarYear;
            public int Doors;
            public String CarPicture;
        }

        CListOfCars[] Car = new CListOfCars[11];

        private void FrmCarInventory_Load(object sender, EventArgs e)
        {
            string p = Application.StartupPath;
            
            Car[1].Make = "Honda";
            Car[1].Model = "Civic";
            Car[1].CarYear = 1998;
            Car[1].Doors = 4;
            Car[1].CarPicture = p + @"\Civic1.bmp";

            Car[2].Make = "Hyundai";
            Car[2].Model = "Elantra";
            Car[2].CarYear = 1996;
            Car[2].Doors = 4;
            Car[2].CarPicture = p+ @"\Elantra.bmp";

            Car[3].Make = "Ford";
            Car[3].Model = "Escape";
            Car[3].CarYear = 2003;
            Car[3].Doors = 5;
            Car[3].CarPicture = p+ @"\FordEscape1.bmp";

            Car[4].Make = "Ford";
            Car[4].Model = "Escort";
            Car[4].CarYear = 1997;
            Car[4].Doors = 2;
            Car[4].CarPicture = p+ @"\FordEscort1.bmp";

            Car[5].Make = "Mercury";
            Car[5].Model = "Grand Marquis";
            Car[5].CarYear = 2001;
            Car[5].Doors = 4;
            Car[5].CarPicture = p+ @"\GrandMarquis.bmp";

            Car[6].Make = "Mercury";
            Car[6].Model = "Mystique";
            Car[6].CarYear = 2000;
            Car[6].Doors = 4;
            Car[6].CarPicture = p+ @"\Mystique.bmp";

            Car[7].Make = "Lincoln";
            Car[7].Model = "Navigator";
            Car[7].CarYear = 2003;
            Car[7].Doors = 5;
            Car[7].CarPicture = p+ @"\Navigator1.bmp";

            Car[8].Make = "Nissan";
            Car[8].Model = "Sentra";
            Car[8].CarYear = 1997;
            Car[8].Doors = 2;
            Car[8].CarPicture = p+ @"\Sentra.bmp";

            Car[9].Make = "Ford";
            Car[9].Model = "Focus";
            Car[9].CarYear = 2002;
            Car[9].Doors = 4;
            Car[9].CarPicture =p+ @"\Focus.bmp";

            Car[10].Make = "Kia";
            Car[10].Model = "Sephia";
            Car[10].CarYear = 2003;
            Car[10].Doors = 4;
            Car[10].CarPicture = p+ @"\Sephia.bmp";

            TxtMake.Text = Car[1].Make;
            TxtModel.Text = Car[1].Model;
            TxtYear.Text = Car[1].CarYear.ToString();
            TxtDoors.Text = Car[1].Doors.ToString();
            PicCarPicture.Image = Image.FromFile(Car[1].CarPicture);

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrbSlider_Scroll(object sender, EventArgs e)
        {
            // Get the index of the current value of the track bar - 1
	        int CurPos = this.TrbSlider.Value ;

	        // Based on the current index, retrieve the values of the
	        // current car and assign each to the corresponding control 
	        TxtMake.Text	= Car[CurPos].Make;
	        TxtModel.Text	= Car[CurPos].Model;
	        TxtYear.Text	= Car[CurPos].CarYear.ToString();
	        TxtDoors.Text	= Car[CurPos].Doors.ToString();
            PicCarPicture.Image = Image.FromFile(Car[CurPos].CarPicture);
        }

        
    }
}