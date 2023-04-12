using System;
using System.Collections.Generic;
using System.Text;

namespace Personal_Library_Catalogue
{
    class Search
    {
        public static int Linear(string[] a, string key, int u)
        {
            for (int i = 1; i <= u; i++)
            {
                if (a[i] != null)
                {
                    if (a[i] == key)
                        return i;
                }
            }
            return -1;
        }

        public static int Binary(string[] a, string key, int u)
        {
            int low = 1;
            int high = u;
            int middle;

            while (low <= high)
            {
                middle = (low + high) / 2;

                if (key == (a[middle]))
                    return middle;
                else if (key.CompareTo(a[middle]) < 0)
                    high = middle - 1;
                else
                    low = middle + 1;
            }
            return -1;

        }

        public static int RecursiveBinary(string[] a, int low, int high, string key)
        {
            int middle;

            if (low > high)
            {
                return -1;
            }
            else
            {
                middle = (low + high) / 2;

                if (key == (a[middle]))
                    return middle;
                else if (key.CompareTo(a[middle]) < 0)
                    return RecursiveBinary(a, low, middle - 1, key);
                else
                    return RecursiveBinary(a, middle + 1, high, key);
            }


        }

        public static void Shell(string[] bktitle, string[] borrown, int u)
        {

            int gap = u;
            int maximum, iplusg, ex;

            string temp = "";

            do
            {
                gap = gap / 2;
                maximum = u - gap;

                do
                {
                    ex = 0;

                    for (int i = 1; i <= maximum; i++)
                    {
                        iplusg = i + gap;

                        if (bktitle[i].CompareTo(bktitle[iplusg]) > 0)
                        {
                            temp = bktitle[i];
                            bktitle[i] = bktitle[iplusg];
                            bktitle[iplusg] = temp;
                            temp = borrown[i];
                            borrown[i] = borrown[iplusg];
                            borrown[iplusg] = temp;
                            ex = ex + 1;
                        }
                    }
                }
                while (ex != 0);

            }
            while (gap >= 1);
        }          
    }
}
