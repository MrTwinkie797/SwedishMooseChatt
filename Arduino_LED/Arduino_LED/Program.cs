using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_LED
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            Console.WriteLine("Clicka enter för att skicka text");
            Console.ReadLine();
            Client cl = new Client();
            cl.SendMessage("Hejsan! detta är från clienten", "127.0.0.1", 8145);
        }

    }
}
