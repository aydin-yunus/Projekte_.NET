using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_01_Stacks_Kommando_tac_aamp_Klammersetzung_01._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pfad = @"D:\TestOrdner\Personen.txt";
            Tac(pfad);
            Console.ReadKey();

        }
        private static void Tac(string pfad)
        {
            Stack<string> zeilen = new Stack<string>();
            StreamReader streamReader = new StreamReader(pfad);
            while (streamReader.EndOfStream == false)
            {
                zeilen.Push(streamReader.ReadLine());
            }
            foreach (string line in zeilen)
            {
                Console.WriteLine(line);
                Console.ReadKey();
            }
            while (zeilen.Count > 0)
            {
                zeilen.Pop();
            }
        }
        
        
    }



}

