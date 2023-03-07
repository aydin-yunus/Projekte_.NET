using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ___02___Sortieren_aamp__Partitionieren_07._03._23
{
    internal class Program
    {
        static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };
        static string[] numberss = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };
        static void Main(string[] args)
        {
            #region Aufgabe 2.1
            Console.WriteLine("Geben Sie das obigeArray aufsteigend sortiert aus");

            var sortAufsteig = numbers.OrderBy(x => x);
            foreach (var number in sortAufsteig)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine("\n*****************");
            Console.WriteLine("Geben Sie das obige Array absteigend sortiert aus");

            var sortAbsteig = numbers.OrderByDescending(x => x);
            foreach (var number in sortAbsteig)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine("\n*****************");
            Console.WriteLine("Geben Sie aus dem obigen Array alle graden Zahlen aufsteigend sortiert aus");
            var geradeSortAuf = from x in numbers
                                where x % 2 == 0
                                orderby x ascending
                                select x;
            foreach (int number in geradeSortAuf)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine("\n*****************");

            #endregion

            #region Aufgabe 2.2

            Console.WriteLine("1.Geben Sie das obige Array nach der Länge derWorte aufsteigend sortiert aus");
            var sortLenght = numberss.OrderBy(x => x.Length);
            foreach (var number in sortLenght)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine("\n*****************");

            Console.WriteLine("2.Geben Sie das obige Array nach der Länge der Worte aufsteigend sortiert aus, bei gleicher Länge soll alphabetisch absteigend sortiert werden");
            var sortMix = numberss.OrderBy(x => x.Length).ThenByDescending(x => x);
            foreach (var number in sortMix)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine("\n*****************");

            Console.WriteLine("Drehen Sie die Reihenfolge der Elemente im Array um");
            var reverse = numberss.Reverse();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Reversed Line of Numbers");
            Console.WriteLine("----------------------------");
            foreach (var number in reverse)
            {
                Console.Write($"{number} ");
            }


            DirectoryInfo fileDir = new DirectoryInfo(@"D:\TestOrdner");
            Console.WriteLine("4.ListenSie alle Dateien in dem Verzeichnis, absteigend nach Namen sortiert auf");
            var datalist = fileDir.GetFiles()
                .OrderByDescending(f => f.Name)
                .Select(f => f.Name).ToList();
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("Absteigend Sortiement nach Name:");
            Console.WriteLine("----------------------------");
            foreach (string d in datalist)
            {
                Console.WriteLine(d);
            }

            ////um Verzeichnisse zu zeigen

            //var sortDirectories = from directories in directoryInfo.GetDirectories()
            //                      orderby directories.Name
            //                      select directories;
            //foreach (var directory in sortDirectories)
            //{
            //    Console.WriteLine($"{directory}");
            //}

            ////Um Dateien zu zeigen

            //var files = from file in fileDir.GetFiles()
            //            select new { FileName = file.Name };
            //foreach ( var file in files)
            //{
            //    Console.WriteLine(file.FileName);
            //}

            Console.WriteLine("5.ListenSie alle Dateien in dem Verzeichnis, nach Größe aufsteigend sortiert auf");
            var sortToSize = from files in fileDir.GetFiles()
                             orderby files.Length
                             select files;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Sortiement nach Dateigröße:");
            Console.WriteLine("----------------------------");
            foreach ( var file in sortToSize )
            {
                Console.WriteLine($"{file}");
            }

            Console.WriteLine("6.ListenSie alle Dateien in dem Verzeichnis, nach dem Datum des letzten Zugriffs auf, jüngste Dateien zuerst");
            var sortToDate= from files in fileDir.GetFiles()
                            orderby files.LastAccessTime
                            select files;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Sortiement nach ZugriffInfo:");
            Console.WriteLine("----------------------------");
            foreach ( var file in sortToDate)
            {
                Console.WriteLine(file);
            }



            #endregion

            #region Aufgabe 2.3
            var ersteFünf = numbers.Take(5);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Erste Fünf Elemente im Array:");
            Console.WriteLine("----------------------------");
            Console.WriteLine(string.Join(" ", ersteFünf)); // foreach yerine bunu kullanmak cok daha mantikli ve kolay...
            //foreach (int item in ersteFünf)
            //{
            //    Console.Write($"{item} ");
            //}

            var letzteFünf = numbers.Reverse().Take(5);
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("Letzte Fünf Elemente im Array:");
            Console.WriteLine("----------------------------");
            //foreach (var item in letzteFünf)
            //{
            //    Console.Write($"{item} ");
            //}
            Console.WriteLine(string.Join(" ", letzteFünf));// foreach yerine bunu kullanmak cok daha mantikli ve kolay...

            var außerdrei=numbers.Skip(3).Reverse().Skip(3).Reverse();
            Console.WriteLine("----------------------------");
            Console.WriteLine(string.Join(" ",außerdrei));
            Console.WriteLine("----------------------------");

            var y = numbers.Where(x => x > 0);
            Console.WriteLine("----------------------------");
            Console.WriteLine(string.Join(" ", y));
            Console.WriteLine("----------------------------");

            Console.WriteLine("----------------------------");
            Console.WriteLine(string.Join(" ", numbers.SkipWhile(n => n != 12).Skip(1)));
            Console.WriteLine(string.Join(" ", numbers.Skip(Array.IndexOf(numbers, 12) + 1)));
            Console.WriteLine("----------------------------");
            #endregion

            Console.ReadKey();
        }
    }
}
