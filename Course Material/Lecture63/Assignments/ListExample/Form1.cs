using System.Security.AccessControl;

namespace ListExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRepeat_Click(object sender, EventArgs e)
        {
            string list = "ijk";

            List<int> calculateRepeat = new List<int>();
            int index = 0;
            foreach (var item in list)
            {
                
                //MessageBox.Show(item.ToString());
                foreach (var s in calculateRepeat) 
                {
                    if(s.Equals(item))
                    {
                        MessageBox.Show("repeated character");
                        break;
                    }
                }
                calculateRepeat.Add(item);
            }
        }
    }
}