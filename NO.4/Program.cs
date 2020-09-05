using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//GitHub test line 

namespace NO._4
{
    static class Program
    {
        public static void StartSplashScreen()
        {
            Application.Run(new SplashScreen());
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //threading used for handling the slashcreen form
            Thread t = new Thread(new ThreadStart(StartSplashScreen));
            t.Start();
            Thread.Sleep(2500);
            t.Abort();
            
            Application.Run(new Form1());
        }
    }
}
