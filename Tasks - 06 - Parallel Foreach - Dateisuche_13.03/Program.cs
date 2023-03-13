using System.Collections.Concurrent;

namespace Tasks___06___Parallel_Foreach___Dateisuche_13._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Verzeichniname: ");
            var verzeichniseiname = Console.ReadLine();

            Console.Write("Suchbegriff: ");
            var suchbegriff = Console.ReadLine();

            if (verzeichniseiname != null && Directory.Exists(verzeichniseiname) &&
                !String.IsNullOrEmpty(suchbegriff))
            {
                DurchsucheVerzeichnis(verzeichniseiname, suchbegriff);
            }
            else
            {
                Console.WriteLine("Leerer oder ungültiger Vereuchnisname");
            }

        }

        private static void DurchsucheVerzeichnis(string verzeichniseiname, string suchbegriff)
        {
            var dateiNamen = Directory.GetFiles(verzeichniseiname);

            ConcurrentStack<String> stack = new ConcurrentStack<String>();

            Parallel.ForEach(dateiNamen, file =>
            {
                if (File.ReadAllText(file).Contains(suchbegriff))
                {
                    stack.Push($"{file} enthält Suchbegriff '{suchbegriff}'");
                }
            });

            while (stack.Count > 0)
            {
                bool ok = stack.TryPop(out string? filename);
                if (filename != null && ok)
                {
                    Console.WriteLine(filename);
                }
            }
        }
    }
}