using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates___02___Array_Min_Max_02._03
{
    internal class Program
    {
        delegate bool VergleichsHandler(int a, int b);
        static void Main(string[] args)
        {
            int[] zahlen = { 10, 15, 38, 11, 24,1254, 3, 345, 451, 2, 121 };
            VergleichsHandler größte = new VergleichsHandler(IstGrösser);
            VergleichsHandler kleinste=new VergleichsHandler(IstKleiner);
            Console.WriteLine("Zahlen");
            foreach (var item in zahlen)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            GetLimit(zahlen, größte );
            GetLimit(zahlen, kleinste);

        }
        private static void GetLimit(int[] zahlen, VergleichsHandler kleinOderGross)
        {
            int limit = zahlen[0];
            int index = 0;
            
            for (int i = 1;i<zahlen.Length;i++)
            {
                if (kleinOderGross(zahlen[i],limit))
                {
                    limit = zahlen[i];
                    index = i;
                }
            }
            Console.WriteLine($"\nIndex: {index} / Prozess: {kleinOderGross.Method.Name}");

        }
        private static void MaxLimit(int[] zahlen)
        {
            int max = zahlen[0];
            int index = 0;
            for(int i = 1; i < zahlen.Length; i++)
            {
                if (IstGrösser(zahlen[i],max))
                {
                    max = zahlen[i];
                    index = i;
                }
            }
            Console.WriteLine(index);
        }

        private static void MinLimit(int[] zahlen)
        {
            int min = zahlen[0];
            int index = 0;
            for (int i = 1; i < zahlen.Length; i++)
            {
                if (IstKleiner(zahlen[i], min))
                {
                    min = zahlen[i];
                    index = i;
                }
            }
            Console.WriteLine(index);
        }

        private static bool IstKleiner(int a, int b)
        {
            return a < b;
        }
        private static bool IstGrösser(int a, int b)
        {
            return a > b;
        }
    }
}
