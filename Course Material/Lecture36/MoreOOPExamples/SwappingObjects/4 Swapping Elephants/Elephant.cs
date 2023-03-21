using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace __Swapping_Elephants
{

    class Elephant
    {
        public int EarSize;
        public String Name;

        public Elephant(int e, string n)
        {
            EarSize = e;
            Name = n;
        }

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + " inches tall.",
               Name + " says…");
        }
    }
}
