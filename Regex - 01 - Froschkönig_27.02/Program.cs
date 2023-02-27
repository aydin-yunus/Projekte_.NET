using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex___01___Froschkönig_27._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Umlaut_Finder umlaut_Find = new Umlaut_Finder();
            //umlaut_Find.Read_Find();
            //der_Anfange der_Anfange = new der_Anfange();
            //der_Anfange.der_Finder();
            //Groß_Buchstabe groß = new Groß_Buchstabe();
            //groß.GroßBuchstabe();
            //Frosch frosch = new Frosch();
            //frosch.Frosch_Froschkönig();
            //EndPunkt endPunkt = new EndPunkt();
            //endPunkt.PunktEnde();
            //Endß endß = new Endß();
            //endß.EndWithß();
            LeerZeile leerZeile = new LeerZeile();
            leerZeile.LeereZeilen();

            Console.ReadLine();


        }

    }
    class Umlaut_Finder
    {
        public void Read_Find()
        {
            List<string> list = new List<string>();
            int index = 0;
            string path = "D:\\TestOrdner\\Froschkönig Unix Zeilenumbrüche.txt";
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                string zeile = sr.ReadLine();
                if (Regex.IsMatch(zeile, @"[ÄÜÖäüö]"))
                {
                    list.Add(zeile);
                    index++;
                    Console.WriteLine($"{index}: {zeile}");
                }
            }

            ////Ohne index nummer

            //foreach (string zeile in list)
            //{
            //    Console.WriteLine($"{index}:{zeile}");
            //}
            //Console.WriteLine($"Insgesamt in {index} Zeilen");

        }
    }
    class der_Anfange
    {
        public void der_Finder()
        {
            List<string> list = new List<string>();
            int index = 0;
            string path = "D:\\TestOrdner\\Froschkönig Unix Zeilenumbrüche.txt";
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                string zeile = sr.ReadLine();
                //List<string> words = new List <string>(zeile.Split(' '));//Kelimeleri ayirmaya calismistim ama gerek yok...
                if (Regex.IsMatch(zeile, @"\b[Dd]er\b"))
                {
                    list.Add(zeile);
                    index++;
                    Console.WriteLine($"{index}: {zeile}");
                }
            }

        }
    }
    class Groß_Buchstabe
    {
        public void GroßBuchstabe()
        {
            List<string> list = new List<string>();
            int zähler = 0;
            int index = 0;
            string path = "D:\\TestOrdner\\Froschkönig Unix Zeilenumbrüche.txt";
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                string zeile = sr.ReadLine();
                index++;
                if (Regex.IsMatch(zeile, @"^[A-Z]"))
                {
                    list.Add(zeile);
                    zähler++;
                    Console.WriteLine($"{zähler}- Index:{index} {zeile}");
                }
            }
        }
    }
    class Frosch
    {
        public void Frosch_Froschkönig()
        {
            List<string> listfrosch = new List<string>();
            int zähler = 0;
            int index = 0;
            string path = @"D:\TestOrdner\Froschkönig Unix Zeilenumbrüche.txt";
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                index++;
                string zeile = sr.ReadLine();
                if (Regex.IsMatch(zeile, @"\bFrosch\b|\bFroschkönig\b"))
                {
                    listfrosch.Add(zeile);
                    zähler++;
                    Console.WriteLine($"{zähler}- Index:{index} {zeile}");
                }
            }
        }
    }
    class EndPunkt
    {
        public void PunktEnde()
        {
            List<string> listePunktende = new List<string>();
            int zähler = 0;
            int index = 0;
            string path = @"D:\TestOrdner\Froschkönig Unix Zeilenumbrüche.txt";
            StreamReader sr = new StreamReader(path);
            while (sr.EndOfStream == false)
            {
                index++;
                string zeile = sr.ReadLine();
                if (Regex.IsMatch(zeile, @"[.]$"))//oder @"\.$" oder @"\.\Z"
                {
                    listePunktende.Add(zeile);
                    zähler++;
                    Console.WriteLine($"{zähler}- Index:{index} {zeile}");
                }
            }
        }
    }
    class Endß
    {
        public void EndWithß()
        {
            List<string> list_ß = new List<string>();
            int zähler = 0;
            int index = 0;
            StreamReader sr = new StreamReader(@"D:\TestOrdner\Froschkönig Unix Zeilenumbrüche.txt");
            while (!sr.EndOfStream)
            {
                index++;
                string zeile = sr.ReadLine();
                if (Regex.IsMatch(zeile, @"ß\b"))
                {
                    list_ß.Add(zeile);
                    zähler++;
                    Console.WriteLine($"{zähler}- Index:{index} {zeile}");
                }
            }
        }
    }
    class LeerZeile
    {
        public void LeereZeilen()
        {
            List<string> list_leerezeile = new List<string>();
            int zähler = 0;
            int index = 0;
            StreamReader sr = new StreamReader(@"D:\TestOrdner\Froschkönig Unix Zeilenumbrüche.txt");
            while (!sr.EndOfStream)
            {
                index++;
                string zeile = sr.ReadLine();
                if (Regex.IsMatch(zeile, @"^$")) // oder @"\A\Z"
                {
                    list_leerezeile.Add(zeile);
                    zähler++;
                    Console.WriteLine($"{zähler}- Index:{index} {zeile}");
                }
            }
        }
    }

}
