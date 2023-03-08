using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SpaceAge
{
    public partial class FrmSpaceAge : Form
    {
        public FrmSpaceAge()
        {
            InitializeComponent();
        }

        //Here we store the key values in arrays for easier more efficient access during our calculations
        string[] planet = new string[] { "Mercury", "Venus","Earth","Mars","Jupiter","Saturn","Uranus","Neptune" };
        double[] factor = new double[] { 0.2408467, 0.61519726, 1.0, 1.8808158, 11.862615, 29.447498, 84.016846, 164.79132 };
        
        const long SECONDS_PER_YEAR = 31557600;        

        private void BtnSpace_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\space.txt";

            StreamReader r = new StreamReader(f);

            string line;
            long age;
            bool finished = false;

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    age = long.Parse(line);
                    TxtDisplay.Text += DetermineAges(age) + Environment.NewLine;
                    
                }
            }
        }

        //Notice I decided to use long rather than int just in case
        //we have a particularly large 'seconds' age in our data
        //int is 32 bit ... can hold numbers up to -2^31 to 2^31-1
        //long is 64 bit ... can hold numbers up to -2^63 to 2^63-1
        private string DetermineAges(long s)
        {
            string result = "";
            double age;

            result += "An age of " + s.ToString() + " seconds  represents ..." + Environment.NewLine;
            for (int i=0;i<=7;i++)
            {
                age = s / (SECONDS_PER_YEAR * factor[i]);
                result += age.ToString("n2") + " years on " + planet[i] + Environment.NewLine;
            }

            return result;
        }
    }
}
