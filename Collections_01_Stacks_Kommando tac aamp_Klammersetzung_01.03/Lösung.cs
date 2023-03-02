using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_01_Stacks_Kommando_tac_aamp_Klammersetzung_01._03
{
    internal class Lösung
    {

        //static void Main(string[] args)
        //{
        //    //Tac($"D:\\TestOrdner\\Personen.txt");

        //    string berechnung = " 3+6*((7-4)* 9)";

        //    PrüfeKlammerSetzung(berechnung);
        //    Console.ReadKey();
        //}


        private static void Tac(string pfad)
        {
            Stack<string> alleZeilen = new Stack<string>();
            try
            {
                StreamReader streamReader = new StreamReader(pfad);
                while (streamReader.EndOfStream == false)
                {
                    alleZeilen.Push(streamReader.ReadLine());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            foreach (string zeile in alleZeilen)
            {

                Console.WriteLine(zeile);
                Console.ReadLine();
            }
            while (alleZeilen.Count > 0)
            {
                Console.WriteLine(alleZeilen.Pop());
            }
        }
        private static void PrüfeKlammerSetzung(string ausdruckMitKlammern)
        {
            Stack<char> alleKlammern = new Stack<char>();

            for (int i = 0; i < ausdruckMitKlammern.Length; i++)
            {
                if (ausdruckMitKlammern[i] == '(')
                {
                    alleKlammern.Push('(');

                }
                else if (ausdruckMitKlammern[i] == ')')
                {
                    try
                    {
                        alleKlammern.Pop();

                    }
                    catch
                    {

                        Console.WriteLine("Es fehlt eine öffnende Klammer !!!");
                    }
                }

                if (alleKlammern.Count != 0)
                {
                    Console.WriteLine("Schließende Klammer zu wenig !!!!");

                }
            }
        }
    }
}
