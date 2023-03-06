using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LINQ___01___Filter_Operationen_aamp__Aggregationen_06._03._23

{
    internal class Program
    {
        static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };
        static string[] numberss = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };
        static void Main(string[] args)
        {
            #region Aufgabe 1.1
            ////Alternative

            //var zahlen = from eineZahl in numbers
            //             where eineZahl < 7
            //             select new { eineZahl };
            //foreach (var zahl in zahlen)
            //{
            //    Console.WriteLine(zahl);
            //}

            ////ODER

            //var kleinerSieben =numbers.Where(x => x < 7);
            //foreach (int item in kleinerSieben)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n********************");

            //var geradeZahlen=numbers.Where(x => x %2==0);
            //foreach (int item in geradeZahlen)
            //{
            //    Console.WriteLine($"gerade: {item}");
            //}
            //Console.WriteLine("********************");

            //var einstelligeUngerade=numbers.Where(x => x %2!=0&&x<10);
            //foreach (int item in einstelligeUngerade)
            //{
            //    Console.WriteLine($"einstellige ungerade:{item}");
            //}
            //Console.WriteLine("********************");

            //int[] geradeAbSechs=numbers.Skip(6).ToArray();
            //foreach (int item in geradeAbSechs)
            //{
            //    Console.Write(item+" ");
            //}
            //Console.WriteLine("\n********************");
            #endregion

            #region Aufgabe 1.2

            //var drei_Zeichen = numberss.Where(x => x.Length<4);
            //foreach (string item in drei_Zeichen)
            //{
            //    Console.WriteLine(item);
            //}

            //var enthalten_o= numberss.Where(x => x.Contains('o'));
            //foreach (string o in enthalten_o)
            //{
            //    Console.WriteLine(o);
            //}

            var endet_Teen = numberss.Where(x => Regex.IsMatch(x, @"teen"));
            foreach (string t in endet_Teen)
            {
                Console.WriteLine(t);
            }
            


            #endregion

            Console.ReadKey();

        }
    }
}
