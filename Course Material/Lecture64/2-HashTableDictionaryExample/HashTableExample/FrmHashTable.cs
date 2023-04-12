using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace HashTableExample
{
    public partial class FrmHashTable : Form
    {
        public FrmHashTable()
        {
            InitializeComponent();
        }

        private void BtnHashTest_Click(object sender, EventArgs e)
        {

            //Hashtable and Dictionary are collection of data structures to hold data as key - value pairs.
            

            //The Hashtable is a loosely typed data structure because you can
            //add keys and values to the Hashtable of any type.
            //With the introduction of GENERICS , many of the built in data structures
            //have been updated to provide type-safe versions.

            Hashtable employees = new Hashtable();

            employees.Add("111", "Scott");
            employees.Add("222", "Sam");
            employees.Add("333", "Jisun");

            if (employees.ContainsKey("111"))
            {
                MessageBox.Show("Employee 111 is " + employees["111"]);
            }
            else
            {
                MessageBox.Show("Employee 111 is not in hash table");
            }

            //Step through all items in the Hashtable. 
            //The order with which the items are inserted and the order of the keys in the Keys collection
            //are not necessarily  the same. 
            //The ordering of the Keys collection is based on the slot the key's item was stored.
            //The slot an item is stored in  depends on the key's hash value and collision resolution strategy.
           
            
            foreach (string key in employees.Keys)
            {
                TxtDisplay.Text+= key + "-> " + employees[key].ToString() + Environment.NewLine;
            }

            TxtDisplay.Text += "---------------------------------------------" + Environment.NewLine;


            //Dictionary is generic type, hash table is not a generic type.
            //The Hashtable is a weakly typed data structure, 
            //so you can add keys and values of any Object Type to the Hashtable.

            //The Dictionary class is  strongly typed<T Key, T Value > 
            //and you must specify the data types for both the key and value.

            //The Dictionary class is a type-safe Hashtable implementation
            //When creating a dictionary instance, you must specify the 
            //data types for both the key and value

            Dictionary<int, string> employeeData = new Dictionary<int, string>();

            employeeData.Add(111, "Tom");
            employeeData.Add(222, "Karen");

            if (employeeData.ContainsKey(222))
            {
                MessageBox.Show("Employee 222 is " + employeeData[222]);
            }
            else
            {
                MessageBox.Show("Employee 222 is not in hash table");
            }

            // Use var keyword to enumerate dictionary.
            foreach (var pair in employeeData)
            {
                TxtDisplay.Text += pair.Key + "\t"+ pair.Value + Environment.NewLine;
            }

        }
    }
}