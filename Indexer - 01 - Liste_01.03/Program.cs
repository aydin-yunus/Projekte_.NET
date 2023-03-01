using Generics___03___Liste_und_Menge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer___01___Liste_01._03
{
    internal class Program
    {
        static void Main(string[] args)
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
    }

}
