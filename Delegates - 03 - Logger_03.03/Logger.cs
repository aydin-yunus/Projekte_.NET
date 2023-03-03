using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates___03___Logger_03._03
{
    delegate void LogHandler(string message);
    class Logger
    {
        private readonly StreamWriter streamWriter;

        public Logger(string path)
        {
            try
            {
                // Mit dem Parameter append = true wird an eine bestehende Datei angehängt
                streamWriter = new StreamWriter(path, append: true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void LogToFile(string message)
        {
            streamWriter?.WriteLine(message);
        }

        public void Close()
        {
            streamWriter?.Close();
        }
    }
}
