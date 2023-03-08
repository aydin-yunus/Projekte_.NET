using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ___03___Gruppierung_aamp__Mengenoperationen_07._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teil1();

            //Teil2();

            //Teil3();
            Console.ReadKey();
        }


        private static void Teil1()
        {
            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };

            Console.WriteLine("1. Gruppieren Sie die Worte im obigen Array nach dem Anfangsbuchstaben");

            // ALTERNATIVE 1
            var nachAnfangsbuchstabenGruppiert1 = numbers.GroupBy(wort => wort[0]);

            Ausgabe(nachAnfangsbuchstabenGruppiert1, "Anfangsbuchstabe");

            // ALTERNATIVE 2
            Console.WriteLine("ALTERNATIVE 2");

            var nachAnfangsbuchstabenGruppiert2 = from x in numbers
                                                  group x by x[0];

            Ausgabe(nachAnfangsbuchstabenGruppiert2, "Anfangsbuchstabe");

            Console.WriteLine("\n2. Gruppieren Sie die Worte im obigen Array nach der Länge");

            var nachLängeGruppiert = numbers.GroupBy(n => n.Length);

            Ausgabe(nachLängeGruppiert, "Wortlänge");

            Console.WriteLine("\n3. Gruppieren Sie die Worte im obigen Array nach dem Anfangsbuchstaben und der Länge");

            // ALTERNATIVE 1
            var nachAnfangsbuchstabeUndLänge1 = numbers.GroupBy(x => new { Anfangsbuchstabe = x[0], x.Length });

            Ausgabe(nachAnfangsbuchstabeUndLänge1, "Anfangsbuchstabe & Wortlänge");

            // ALTERNATIVE 2
            var nachAnfangsbuchstabeUndLänge2 = from wort in numbers
                                                group wort by new { Anfangsbuchstabe = wort[0], wort.Length };

            Ausgabe(nachAnfangsbuchstabeUndLänge2, "Anfangsbuchstabe & Wortlänge");

            // ALTERNATIVE 3
            var nachAnfangsbuchstabeUndLänge3 = numbers.GroupBy(x => x[0] + x.Length.ToString());

            Ausgabe(nachAnfangsbuchstabeUndLänge3, "Anfangsbuchstabe & Wortlänge");
        }

        private static void Ausgabe<TKey, TElement>(IEnumerable<IGrouping<TKey, TElement>> groupingListe, string ausgabeText)
        {
            foreach (var gruppe in groupingListe)
            {
                Console.WriteLine("{0}: {1}", ausgabeText, gruppe.Key);

                foreach (var element in gruppe)
                {
                    Console.WriteLine(element);
                }

                Console.WriteLine();
            }

            Console.WriteLine("------");
        }

        private static void Teil2()
        {
            Process[] alleProzesse = Process.GetProcesses();

            Console.WriteLine("\n1. Geben Sie die Prozesse auf Ihrem System gruppiert nach der Anzahl der Threads aus");

            var nachAnzahlThreads = alleProzesse.GroupBy(prozess => prozess.Threads.Count, p => p.ProcessName);

            Ausgabe(nachAnzahlThreads, "Anzahl Threads");

            Console.WriteLine("\n2. Geben Sie die Prozesse auf Ihrem System gruppiert nach der Anzahl der Module aus");

            // ALTERNATIVE 1
            var nachAnzahlDerModule1 = alleProzesse.GroupBy(prozess =>
            {
                try
                {
                    return prozess.Modules.Count;
                }
                catch (Exception)
                {
                    return -1;
                }
            });

            //Ausgabe(nachAnzahlDerModule1, "Anzahl Module");

            // ALTERNATIVE 2
            var nachAnzahlDerModule2 = alleProzesse.GroupBy(AnzahlModuleProProzess);
            //var nachAnzahlDerModule3 = alleProzesse.GroupBy(x => AnzahlModuleProProzess(x));

            //Ausgabe(nachAnzahlDerModule2, "Anzahl Module");

            // ALTERNATIVE 3
            var nachAnzahlDerModule3 = from prozess in alleProzesse
                                       group prozess by AnzahlModuleProProzess(prozess);

            //Ausgabe(nachAnzahlDerModule3, "Anzahl Module");

            Console.WriteLine("\n3. Geben Sie die Prozesse auf Ihrem System gruppiert nach der Anzahl der Module aus," +
                                "in der Ausgabe sollen die Namen der Prozesse alphabetisch aufsteigend sortiert sein");

            var nachAnzahlDerModuleUndAlphabetisch = alleProzesse.OrderBy(p => p.ProcessName).GroupBy(AnzahlModuleProProzess);

            //Ausgabe(nachAnzahlDerModuleUndAlphabetisch, "Anzahl Module");
        }

        private static string AnzahlModuleProProzess(Process einProzess)
        {
            try
            {
                return einProzess.Modules.Count.ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private static void Teil3()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            Console.WriteLine("\n1. Welche einzelnen Faktoren sind in factorsOf300 vertreten?");

            Console.WriteLine(string.Join(" ", factorsOf300.Distinct()));

            Console.WriteLine("\n2. Wie ist die Vereinigungsmenge der beiden Arrays numbersA und numbersB?");

            Console.WriteLine(string.Join(" ", numbersA.Union(numbersB)));

            Console.WriteLine("\n3. Haben die beiden Arrays numbersA und numbersB eine Schnittmenge?");

            Console.WriteLine(string.Join(" ", numbersA.Intersect(numbersB)));

            Console.WriteLine("\n4. Welche Elemente kommen nur in numbersB vor, aber nicht in numbersA?");

            Console.WriteLine(string.Join(" ", numbersB.Except(numbersA)));
        }
    }
}
