using System;
using System.Windows.Forms;

namespace NeedleFinder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static int Main(string[] args)
        {
            if (args.Length > 0)
            {
                // console code
                string text = args[0];
                
                string subtext = string.Empty;
                if (args.Length > 1)
                {
                    subtext = args[1];
                }

                string matchCase = string.Empty;
                if (args.Length > 2)
                {
                    matchCase = args[2];
                }

                if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(subtext))
                {
                    Console.WriteLine("Invalid arguments. NeedleFinder.exe text subtext [-i]");
                }
                else
                {
                    Console.WriteLine(Finder.GetMatchResult(text, subtext, matchCase == "-i"));
                }
            }
            else
            {
                // win form app
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FinderForm());
            }

            return 0;
        }
    }
}
