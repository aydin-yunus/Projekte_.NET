using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections___02___Dictionary___Worthaeufigkeit_02._03
{
    internal class Lösung
    {
        public void Run()//main sinifta olmasi gerekenler 
        {
            const string pfad = @"D:\TestOrdner\Froschkönig Unix Zeilenumbrüche.txt";

            WorthäufigkeitErmitteln(pfad);

            Console.ReadLine();
            Console.WriteLine();

            WorthäufigkeitSortiertErmitteln(pfad);

            Console.ReadLine();
        }
        private static void WorthäufigkeitErmitteln(string dateiname)
        {
            Dictionary<string, int> häufigkeit = new Dictionary<string, int>();

            DateiAuslesen(dateiname, häufigkeit);

            Ausgabe(häufigkeit);
        }

        private static void WorthäufigkeitSortiertErmitteln(string pfad)
        {
            // Verwendet SortedDictionary anstelle des Dictionary
            SortedDictionary<string, int> häufigkeit = new SortedDictionary<string, int>();

            DateiAuslesen(pfad, häufigkeit);

            Ausgabe(häufigkeit);
        }

        private static void DateiAuslesen(string pfad, IDictionary<string, int> häufigkeit)
        {
            try
            {
                StreamReader streamReader = new StreamReader(pfad);

                while (streamReader.EndOfStream == false)
                {
                    // Zeile lesen und in kleine Buchstaben umwandeln
                    string zeile = streamReader.ReadLine().ToLower();

                    // Sonderzeichen entfernen
                    zeile = Regex.Replace(zeile, "[^\\w ]", string.Empty);

                    // Zeile am Leerzeichen zerlegen, leere Einträge entfernen
                    string[] wörterDerZeile = zeile.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < wörterDerZeile.Length; i++)
                    {
                        // Ist das Wort bereits im Dictionary vorhanden?
                        if (häufigkeit.ContainsKey(wörterDerZeile[i]))
                        {
                            // Anzahl am Index des Wortes um 1 erhöhen
                            häufigkeit[wörterDerZeile[i]]++;
                        }
                        else
                        {
                            // Neues Wort mit der Häufigkeit 1 einfügen
                            häufigkeit.Add(wörterDerZeile[i], 1);
                        }
                    }
                }

                streamReader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Ausgabe(IDictionary<string, int> häufigkeit)
        {
            int index = 0;

            // Ausgabe aller Häufigkeiten
            foreach (KeyValuePair<string, int> wort in häufigkeit)
            {
                index++;
                Console.Write("{0,-20} Anzahl: {1,2}  ", wort.Key, wort.Value);

                if (index % 2 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
    }
}
