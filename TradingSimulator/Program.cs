using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TradingSimulator.Classes;

namespace TradingSimulator
{
    static class Program
    {
        public static AppContext dataBase;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            dataBase = new AppContext();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
