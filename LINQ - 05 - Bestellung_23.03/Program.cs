using LINQ___05___Bestellung_23._03.Models;
using System.Text.Json;

namespace LINQ___05___Bestellung_23._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"D:\TestOrdner\bestellung.json");
            Bestellung eineBestellung =JsonSerializer.Deserialize<Bestellung>(reader.ReadToEnd());

            StreamReader readerArti = new StreamReader(@"D:\TestOrdner\alleArtikel.json");
            Artikel[] artikel=JsonSerializer.Deserialize<Artikel[]>(readerArti.ReadToEnd());

            var query = from etwas in eineBestellung.AllePositionen
                        join etwas2 in artikel
                        on etwas.Artikelnummer equals etwas2.Artikelnummer
                        select new
                        {
                            Nr=etwas.Artikelnummer,
                            Name=etwas2.Name,
                            Anzahl=etwas.Anzahl,
                            Summe=etwas2.Preis*etwas.Anzahl
                        };
            foreach (var item in query)
            {
                Console.WriteLine(item.Nr+" "+item.Name+" "+item.Anzahl+" "+item.Summe);
            }
        }
    }
}