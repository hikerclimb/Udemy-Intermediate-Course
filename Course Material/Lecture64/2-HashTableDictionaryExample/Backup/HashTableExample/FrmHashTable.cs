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

            //step through all itmes in the Hashtable
            //the order with which the items are inserted
            //and the order of the keys in the Keys collection
            //are not necessarily  the same. 
            //The ordering of the Keys collection is based on
            //the slot the key's item was stored.
            //The slot an item is stored depends on the key's
            //hash value and collision resolution strategy.
            //If you run the code below you can see that the order
            //the items are enumerated doesn't necessarily match
            //with the order with which the items were added to
            //the Hashtable.
            foreach (string key in employees.Keys)
            {
                TxtDisplay.Text+= key + "-> " + employees[key].ToString() + Environment.NewLine;
            }

            //The Hashtable is a loosely typed data structure because you can
            //add keys and values to the Hashtable of any type.
            //With the introduction of GENERICS , many of the built in data structures
            //have been updated to provide type-safe versions.

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

        }
    }
}