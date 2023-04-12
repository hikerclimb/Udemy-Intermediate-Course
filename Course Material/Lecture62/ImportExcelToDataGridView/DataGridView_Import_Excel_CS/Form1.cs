using System;
using System.Windows.Forms;
using System.IO;
using System.Data;      //need to add these namespaces
using System.Data.OleDb;//so we can connect EXCEL to C# DB

namespace DataGridView_Import_Excel
{
    public partial class Form1 : Form
    {
        //Connection Strings to Excel
        //Excel versions 97-2003 and Excel 2007 (and higher) use different providers 
        //I have declared two connection strings of which one uses Microsoft Jet Engine
        //for older versions and the other one uses Microsoft Ace for newer versions.
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //When the Select File button is clicked, 
            //it shows the Open File Dialog, using which we need to select 
            //the Excel file we want to import to DataGridView control.
            openFileDialog1.ShowDialog();

            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //...
            //place all the code below here ... or create a new event handler located below
        }

    //This was created by choosing the OpenFileDialog1 at the bottom of the Visual Studio UI
    //Then going over to properties ... clicking on the Events (lightening bolt) and choosing FileOk
    private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {

            //As soon as the Excel File is selected the following event handler is executed.              

            //Here first the path of the Excel file is determined and then its extension.
            string filePath = openFileDialog1.FileName;
            string extension = Path.GetExtension(filePath);
            string header = rbHeaderYes.Checked ? "YES" : "NO";
            string conStr, sheetName;

            //Using the extension of the Excel file, appropriate connection string variable is chosen 
            //and the connection string is built using the path of the file and value of the RadioButtons 
            //which determine whether the Excel file has header or not.

            conStr = string.Empty;
            switch (extension)
            {

                case ".xls": //Excel 97-03
                    conStr = string.Format(Excel03ConString, filePath, header);
                    break;

                case ".xlsx": //Excel 07
                    conStr = string.Format(Excel07ConString, filePath, header);
                    break;
            }

            //Get the name of the First Sheet.
            //Next the name of the first sheet is determined and then the sheet data is read into a 
            //DataTable which ultimately is bound to the DataGridView control.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                    con.Close();
                }
            }

            //Read Data from the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {
                        DataTable dt = new DataTable();
                        cmd.CommandText = "SELECT * From [" + sheetName + "]";
                        cmd.Connection = con;
                        con.Open();
                        oda.SelectCommand = cmd;
                        oda.Fill(dt);
                        con.Close();

                        //Populate DataGridView.
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
    }
}
