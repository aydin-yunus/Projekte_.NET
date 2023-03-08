using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ___04___Durchschnitt_von_Kategorien_07._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string pfad = @"D:\TestOrdner\Produkte.txt";

            List<Produkt> alleProdukte = new List<Produkt>();

            try
            {
                ProdukteAusDateiEinlesen(pfad, alleProdukte);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            ProdukteAuswerten(alleProdukte);
            Console.ReadKey();
        }

        private static void ProdukteAusDateiEinlesen(string pfad, List<Produkt> alleProdukte)
        {
            using (StreamReader reader = new StreamReader(pfad))
            {
                while (reader.EndOfStream == false)
                {
                    string zeile = reader.ReadLine();

                    string[] inhalte = zeile.Split(';');

                    // Punkt im Preis durch Komma ersetzen
                    inhalte[1] = inhalte[1].Replace('.', ',');

                    Produkt einProdukt = new Produkt(inhalte[0], double.Parse(inhalte[1]), inhalte[2].Trim());

                    alleProdukte.Add(einProdukt);
                }
            }
        }

        private static void ProdukteAuswerten(List<Produkt> alleProdukte)
        {
            // Gruppieren
            var produkteNachKategorie = alleProdukte.GroupBy(p => p.Kategorie);

            foreach (IGrouping<string, Produkt> kategorie in produkteNachKategorie)
            {
                Console.WriteLine("Kategorie: {0,-11}", kategorie.Key);

                foreach (Produkt produkt in kategorie)
                {
                    Console.WriteLine("{0,-19} {1,10:N} Euro", produkt.Bezeichnung, produkt.Preis);
                    Console.ReadLine();
                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Durchschnitt: {0,16:F} Euro", kategorie.Average(p => p.Preis));
                Console.ReadLine();
            }
        }

    }
}
