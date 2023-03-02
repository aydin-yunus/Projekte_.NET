using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections___02___Dictionary___Worthaeufigkeit_02._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Worthäufigkeit(@"D:\TestOrdner\Froschkönig Unix Zeilenumbrüche.txt");
            //Lösung lösung = new Lösung();
            //lösung.Run();
            const string pfad = @"D:\TestOrdner\Froschkönig Unix Zeilenumbrüche.txt";
            StreamReader sr = new StreamReader(pfad);
            while (!sr.EndOfStream)
            {
                string zeile=sr.ReadLine().ToLower();
            }
            sr.Close();
            string ersteZeile = "Der Froschkönig oder der eiserne Heinrich";
            Dictionary<string, int> worthäufigkeit = new Dictionary<string, int>();
            string[] wörter = ersteZeile.Split();
            foreach (string einWort in wörter)
            {
                Console.WriteLine(einWort);
                if (worthäufigkeit.ContainsKey(einWort))
                {
                    //int häufigkeit = worthäufigkeit[einWort];
                    //häufigkeit++;
                    //worthäufigkeit[einWort] = häufigkeit;
                    
                    //oder

                    worthäufigkeit[einWort]++;
                }
                else
                {
                    worthäufigkeit.Add(einWort, 1);
                }
            }



        }
        //private static void Worthäufigkeit(string pfad)
        //{
        //    Dictionary<string, int> häufigkeit = new Dictionary<string, int>();
        //    StreamReader streamReader = new StreamReader(pfad);
        //    string[] wörter = new string[10000];

        //    while (streamReader.EndOfStream == false)
        //    {
        //        string zeile = streamReader.ReadLine();
        //        zeile = Regex.Replace(zeile, "[^\\w ]", string.Empty);
        //        wörter = zeile.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
                
        //    }
        //    foreach (var item in wörter)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    streamReader.Close();
        //}
    }
}
