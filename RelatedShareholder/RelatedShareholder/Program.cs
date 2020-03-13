using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RelatedShareholder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
           try
           {
               MyGlobal.GlobalAuthority = args[0];
               MyGlobal.GlobalUserID = args[1];
           }
            catch{}

            if (MyGlobal.GlobalAuthority == "") { MyGlobal.GlobalAuthority = "Admin"; }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (MyGlobal.GlobalAuthority == "Admin")
            {
                Application.Run(new Shareholder());
            }
            else
            {
                Application.Run(new ShowShareholder());
            }
        }
    }

    public static class MyGlobal
    {
         public static string GlobalUserID = "";
        public static string GlobalAuthority = "";
        public static string GlobalStatus = "";
        public static string GlobalShareholderID = "";
        public static string GlobalRelatedID = "";
        public static string GlobalRelatedPerson = "";
        public static string GlobalShareholderName = "";
        public static string GlobalRelatedIDA = "";
        public static string GlobalRelationType = "";

        public static string GlobalDataBase = "";
        public static string GlobalServer = "";
        public static string GlobalDataBaseUserID = "";
        public static string GlobalDataBasePassword = "";
    }
}
