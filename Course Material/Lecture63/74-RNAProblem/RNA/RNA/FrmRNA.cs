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

namespace RNA
{
    public partial class FrmRNA : Form
    {
        public FrmRNA()
        {
            InitializeComponent();
        }

        string[] ProteinResults;

        private void BtnRNA_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\rna.txt";

            StreamReader r = new StreamReader(f);

            string line;
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
                    //Translate method returns an string Array
                    ProteinResults = Translate(line) ;

                    TxtDisplay.Text +=  line + "-> " + "Protein: ";
                    

                    for (int i=0;i<ProteinResults.Length;i++)
                    {
                          TxtDisplay.Text += ProteinResults[i] + " ";
                    }

                    TxtDisplay.Text += Environment.NewLine;
                }
            }
        }

        private string [] Translate(string codon)
        {
            //results List will hold all the protein names we decipher
            var results = new List<string>();
            string protein = "";

            //extract 3 letters at a time
            for (int i=0;i<codon.Length/3;i++)
            {
                protein = ConvertToProtein(codon.Substring(3 * i, 3));

                if (protein=="STOP")
                {
                    break;
                }

                results.Add(protein);
            }

            return results.ToArray(); //convert List to regular array
        }

        private string ConvertToProtein(string input)
        {
            switch(input)
            {
                case "AUG":
                    return "Methionine";
                case "UUU":
                case "UUC":
                    return "Phenylalanine";
                case "UUA":
                case "UUG":
                    return "Leucine";
                case "UCU":
                case "UCC":
                case "UCA":
                case "UCG":
                    return "Serine";
                case "UAU":
                case "UAC":
                    return "Tyrosine";
                case "UGU":
                case "UGC":
                    return "Cysteine";
                case "UGG":
                    return "Tryptophan";
                case "UAA":
                case "UAG":
                case "UGA":
                    return "STOP";
                default:
                    throw new Exception("Invalid sequence");
            }
            
             
        }
    }
}
