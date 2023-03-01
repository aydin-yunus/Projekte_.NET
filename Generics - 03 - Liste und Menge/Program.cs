using Generics___03___Liste_und_Menge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generics___03___Liste_und_Menge_01_._03

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aufgabe1();
            Console.ReadKey();
            Aufgabe2();
            Console.ReadKey();            
        }
        private static void Aufgabe1()
        {
            SimpleList<int> liste = new SimpleList<int>();

            liste.Einfügen(10);
            liste.Einfügen(20);
            liste.Einfügen(30);
            liste.Einfügen(40);
            liste.Einfügen(10);

            Console.WriteLine(string.Join(",", liste.ToArray()));

            liste.Löschen(10);

            Console.WriteLine(string.Join(",", liste.ToArray()));

            liste.Löschen(10);

            Console.WriteLine(string.Join(",", liste.ToArray()));

            liste.Löschen(20);
            liste.Löschen(10);
            liste.Löschen(30);
            liste.Löschen(40);

            Console.WriteLine(string.Join(",", liste.ToArray()));
        }
        private static void Aufgabe2()
        {
            Set<int> menge1 = new Set<int>();
            menge1.Einfügen(10);
            menge1.Einfügen(20);
            menge1.Einfügen(30);
            menge1.Einfügen(10);
            Console.Write("Menge 1:\t ");
            Console.WriteLine(string.Join(", ", menge1.ToArray()));
            Console.ReadLine();

            Set<int> menge2 = new Set<int>();
            menge2.Einfügen(30);
            menge2.Einfügen(40);
            menge2.Einfügen(50);
            menge2.Einfügen(50);
            Console.Write("Menge 2:\t ");
            Console.WriteLine(string.Join(", ", menge2.ToArray()));
            Console.ReadLine();

            // Vereinigung

            Console.Write("Vereinigung:\t ");
            Set<int> union = menge1.Union(menge2);
            Console.WriteLine(string.Join(", ", union.ToArray()));
            Console.ReadLine();

            // Schnittmenge
            Console.Write("Schnittmenge:\t ");
            Set<int> intersection = menge1.Intersection(menge2);
            Console.WriteLine(string.Join(", ", intersection.ToArray()));
            Console.ReadLine();
        }
    }
}
