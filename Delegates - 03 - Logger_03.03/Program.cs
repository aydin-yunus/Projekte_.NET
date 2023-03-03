using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates___03___Logger_03._03
{
    internal class Program
    {
        //TODO Hocanin cözümü, bu ödevi yapmaya vaktim olmadi
        static void Main(string[] args)
        {
            Logger meinLogger = new Logger(@"c:\daten\log.txt");

            LogHandler logDelegate;

            // Log Methode des Loggers
            logDelegate = new LogHandler(meinLogger.LogToFile);

            // Ausgabe Methode
            logDelegate += LogToConsole;

            // Anonyme Methode
            logDelegate += delegate (string s)
            {
                // Ausgabe in großen Buchstaben
                Console.WriteLine(s.ToUpper());
            };

            logDelegate("Nachricht 1");
            logDelegate("Nachricht 2");
            logDelegate("Nachricht 3");

            meinLogger.Close();
        }
        private static void LogToConsole(string logText)
        {
            Console.WriteLine(logText);
        }
    }
    

}
