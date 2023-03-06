using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            //var sortAufsteig = numbers.OrderBy(x => x);
            //foreach (var number in sortAufsteig)
            //{
            //    Console.Write($"{number} ");
            //}

            //Console.WriteLine("\n*****************");

            //var sortAbsteig = numbers.OrderByDescending(x => x);
            //foreach(var number in sortAbsteig)
            //{
            //    Console.Write($"{number} ");
            //}

            //Console.WriteLine("\n*****************");

            //var geradeSortAuf = from x in numbers
            //                    where x % 2 == 0
            //                    orderby x ascending
            //                    select x;
            //foreach (int number in geradeSortAuf)
            //{
            //    Console.Write($"{number} ");
            //}

            //Console.WriteLine("\n*****************");

            #endregion

            #region Aufgabe 2.2

            //var sortLenght = numberss.OrderBy(x => x.Length);
            //foreach (var number in sortLenght)
            //{
            //    Console.Write($"{number} ");
            //}

            //Console.WriteLine("\n*****************");

            //var sortMix = numberss.OrderBy(x => x.Length).ThenByDescending(x => x);
            //foreach (var number in sortMix)
            //{
            //    Console.Write($"{number} ");
            //}

            //Console.WriteLine("\n*****************");

            //var reverse=numberss.Reverse();
            //foreach (var number in reverse)
            //{
            //    Console.Write($"{number} ");
            //}

            //Console.WriteLine("\n*****************");

            DirectoryInfo fileDir = new DirectoryInfo(@"D:\TestOrdner");                    

            List<string> datalist = fileDir.GetFiles("*.*")
                .Where(f => f.Name != null)
                .OrderBy(f => f.Name)
                .Select(f => f.Name).ToList();
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




            #endregion
            Console.ReadKey();
        }
    }
}
