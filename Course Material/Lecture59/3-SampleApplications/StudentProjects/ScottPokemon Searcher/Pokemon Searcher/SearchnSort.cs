using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class SearchnSort
    {

        public static void QuickSort(Pokemon[] Pkmn, int lower, int upper, int operation)
        {
            //base case
            if (lower >= upper)
                return;

            //point of comparison
            string pivot;

            if (operation == 1 || operation == 2)
                pivot = Pkmn[lower].name;
            else
                pivot = Pkmn[lower].number;

            //point separating subsorts
            int mid = lower;

            for (int i = lower + 1; i <= upper; i++)
            {
                //operation 1 = sort by name
                if (operation == 1)
                {
                    if (Pkmn[i].name.CompareTo(pivot) < 0)
                    {
                        //moves subsort separator up one
                        mid++;
                        //move values on correct side of subsorts
                        Flip(Pkmn, mid, i);
                    }
                }
                //operation 2 = sort by name (reverse)
                else if (operation == 2)
                {
                    if (Pkmn[i].name.CompareTo(pivot) > 0)
                    {
                        //moves subsort separator up one
                        mid++;
                        //move values on correct side of subsorts
                        Flip(Pkmn, mid, i);
                    }
                }
                //operation 3 = sort by number
                else if (operation == 3)
                {
                    if (Pkmn[i].number.CompareTo(pivot) < 0)
                    {
                        //moves subsort separator up one
                        mid++;
                        //move values on correct side of subsorts
                        Flip(Pkmn, mid, i);
                    }
                }
            }

            //move pivot to correct spot
            Flip(Pkmn, lower, mid);

            //recursion; sport subsorts
            QuickSort(Pkmn, lower, mid - 1, operation);
            QuickSort(Pkmn, mid + 1, upper, operation);
        }

        private static void Flip(Pokemon[] Pkmn, int x, int y)
        {
            //switch Pkmn[x] with Pkmn[y]
            Pokemon temp;

            temp = Pkmn[x];
            Pkmn[x] = Pkmn[y];
            Pkmn[y] = temp;
        }

        public static int Search(Pokemon[] Pkmn, string name, int l, int h)
        {
            //binary search with recursion
            int j = (l + h) / 2;

            if (l > h)
                return -1;

            if (Pkmn[j].name == name)
                return Convert.ToInt32(Pkmn[j].number);
            else if (name.CompareTo(Pkmn[j].name) > 0)
                l = j + 1;
            else
                h = j - 1;

            int num = Search(Pkmn, name, l, h);
            return num;
        }

        public static int Restrict(Pokemon[] Pkmn, int numberfrom, int numberto, string name, string type1, string type2, bool byhave, bool have)
        {
            //show all, originally
            for (int i = 1; i <= 493; i++)
                Pkmn[i].enabled = true;

            //if from and to are in the wrong order, flip them
            if (numberfrom > numberto)
            {
                int temp = numberfrom;
                numberfrom = numberto;
                numberto = temp;
            }

            //if number from and to is within the number of pokemon
            if (numberfrom > 0 && numberto < 494)
            {
                //disable all numbers before number from
                for (int j = 1; j < numberfrom; j++)
                    Pkmn[j].enabled = false;

                //disable all numbers after number to
                for (int k = numberto + 1; k <= 493; k++)
                    Pkmn[k].enabled = false;
            }

            //if something is put in the search by name feature
            if (name != "")
            {
                //sort by name
                QuickSort(Pkmn, 1, 493, 1);
                int start = 0;
                int end = 0;

                //find group of pokemon that fit the string condition
                for (int l = numberfrom; l <= numberto; l++)
                {
                    if (name.Length <= Pkmn[l].name.Length && name == Pkmn[l].name.Substring(0, name.Length))
                    {
                        if (start == 0)
                            start = l;
                    }
                    else if (start > 0 && end == 0)
                        end = l - 1;
                }

                //disable all pokemon that are alphabetically above start position
                for (int m = 1; m < start; m++)
                    Pkmn[m].enabled = false;

                //disable all pokemon that are alphabetically below end position
                for (int n = end + 1; n <= 493; n++)
                    Pkmn[n].enabled = false;

                //sort back to numerical order
                QuickSort(Pkmn, 1, 493, 3);
            }

            //if a type is given
            if (type1 != "" || type2 != "")
            {
                for (int o = 1; o <= 493; o++)
                {
                    //no pokemon have 2 of the same types
                    if (type1 == type2)
                        Pkmn[o].enabled = false;
                    //if types do not match, not necessarily in correct order, disable pokemon
                    else if (Pkmn[o].type1 != type1 && Pkmn[o].type2 != type1 && type1 != "" ||
                        Pkmn[o].type1 != type2 && Pkmn[o].type2 != type2 && type2 != "")
                    {
                        Pkmn[o].enabled = false;
                    }
                }
            }

            //if search by have function is enabled
            if (byhave)
            {
                //disable all pokemon relative to have bool
                for (int p = 1; p <= 493; p++)
                {
                    if (Pkmn[p].have != have)
                        Pkmn[p].enabled = false;
                }
            }

            //counts number of results
            int count = 0;
            for (int q = 1; q <= 493; q++)
            {
                if (Pkmn[q].enabled)
                    count++;
            }

            //returns number of results
            return count;

            //enabled/diabled values returned by ref
        }
    }
}
