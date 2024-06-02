using LibraryGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryGUI
{
    internal static class Program
    {
        internal static string[] isbnArray = { "0063088142", "1503280780", "0486282112" };
        internal static ErrorHandler errorHandler = new ErrorHandler();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            DatabaseHandler.InitializeDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AddLibrary();
            Application.Run(new Loading());
            
        }

        static async void AddLibrary()
        {
            foreach (string isbn in isbnArray)
            {
                if (!Library.ContainsMediaInfo(isbn)) Library.AddMediaInfo(new MediaInfo(isbn));
                Library.AddMedia(isbn, false);
            }
        }
    }
}
