using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Checker;
using UserInfo;

//STEAMAPI thing not working

namespace stm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(Checker.EsentialFileCheck.SteamFileCheck() == true) Application.Run(new MainW.MainWindow());
            else Application.Run(new Error());
        }
    }
}
