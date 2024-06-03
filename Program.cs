using LibraryGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Library.ImportFromDatabase();
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

        // NOT MY CODE, Found on stackoverflow forgot to get link
        public static void CloseApplication()
        {

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (sender2, e2) =>
            {
                Library.ExportForDatabase(true);
            };
            worker.RunWorkerCompleted += (sender3, e3) =>
            {
                if (e3.Error != null)
                {
                    Console.WriteLine("An error occurred: " + e3.Error.Message);
                }
                else
                {
                    Application.Exit();
                }
            };
            worker.RunWorkerAsync();
        }
    }
}
