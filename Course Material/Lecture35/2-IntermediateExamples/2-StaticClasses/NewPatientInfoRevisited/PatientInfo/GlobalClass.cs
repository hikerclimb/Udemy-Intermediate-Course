using System;
using System.Collections.Generic;
using System.Text;

namespace PatientInfo
{
    static class GlobalClass
    {

        private static string globalVar = "";

        //This will allow us to access the variable 
        //from any form
        public static string GlobalVar
        {
            get { return globalVar; }
            set { globalVar = value; }
        }

    }
}
