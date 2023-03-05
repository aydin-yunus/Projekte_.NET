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
            int[] zahlen =new int[10];
            Zufall(zahlen);
            VergleichsHandler vhGrößte = new VergleichsHandler(IstGrösser);
            VergleichsHandler vhKleinste=new VergleichsHandler(IstKleiner);
            //Zufall(zahlen);

            Console.WriteLine();
            GetLimit(zahlen, vhGrößte);
            GetLimit(zahlen, vhKleinste);
            Console.ReadKey();

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

        private static void Zufall(int[] zahlen)
        {
            int zahl;
            Random random = new Random();
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahl=random.Next(1,1000);
                zahlen[i] = zahl;
                Console.Write($"{zahl}  ");
            }
        }
        /// <summary>
        /// /Hoca koymus ama gerek yok, ayni islemi GetLimit() fonksiyonu icinde de yapiyoruz
        /// </summary>
        /// 
        //private static void MaxLimit(int[] zahlen)
        //{
        //    int max = zahlen[0];
        //    int index = 0;
        //    for (int i = 1; i < zahlen.Length; i++)
        //    {
        //        if (IstGrösser(zahlen[i], max))
        //        {
        //            max = zahlen[i];
        //            index = i;
        //        }
        //    }
        //    Console.WriteLine(index);
        //}



        //private static void MinLimit(int[] zahlen)
        //{
        //    int min = zahlen[0];
        //    int index = 0;
        //    for (int i = 1; i < zahlen.Length; i++)
        //    {
        //        if (IstKleiner(zahlen[i], min))
        //        {
        //            min = zahlen[i];
        //            index = i;
        //        }
        //    }
        //    Console.WriteLine(index);
        //}

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
