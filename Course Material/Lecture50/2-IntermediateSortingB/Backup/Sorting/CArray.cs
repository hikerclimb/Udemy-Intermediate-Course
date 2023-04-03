using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class CArray
    {

        //fields
        public int[] arr;
        private int numElements;

        //constructor
        public CArray(int size)
        {
            arr = new int[size];
            numElements = 0;
        }

        //properties
        public int NumElements
        {
            get { return numElements; }
            set { numElements = value; }
        }
        
        //methods
        public void Insert(int item)
        {
            numElements++;
            arr[numElements] = item;            
        }                 
        
        //A combination of the Exchange Sort and the Replacement Sort

        //This technique reduces the number of values being moved
        //On each pass we find the smallest or largest number
        //(like the replacement technique) BUT we only place
        //it in its proper position at the top of the list exchanging it
        //with the item that was originally there at the end of the
        //entire inner loop.
        //Now, however once it has been placed in its correct position
        //it is never moved again. 
        //Now our outer loop now moves up one and we start looking for
        //the next smallest value 
        //We now start our comparing at the 2nd value (outer loop)as our base 
        //where now the inner loop goes from the 3rd,4th,....

        public void SelectionSort()
        {

            int temp, minLoc;
            
            for (int j = 1; j <= numElements - 1; j++)
            {
                minLoc = j;
                
                for (int k = j + 1; k <= numElements; k++)
                {
                    if (arr[k] < arr[minLoc])
                    {
                        minLoc=k;
                    }

                }

                //Only swap once at the very
                //end of the search for the smallest
                //number
                temp = arr[j];
                arr[j] = arr[minLoc];
                arr[minLoc] = temp;

            }   

        }        

    }
}