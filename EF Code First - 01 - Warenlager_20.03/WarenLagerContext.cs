using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EF_Code_First___01___Warenlager_20._03
{
    public class WarenlagerContext : DbContext
    {
        public DbSet<Artikel> Artikel { get; set; }

        public WarenlagerContext()
        {
            Database.EnsureDeleted();
            if (Database.EnsureCreated() == true)
            {
                Dateieinlesen();
                Console.WriteLine("Datenbank erstellt");
            }

            Console.WriteLine(this);
            Console.WriteLine("Warenwert: {0:N} Euro", WarenwertBerechnen());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PC0471;Database=WareHouseDB;Integrated Security=True;");
        }

        public void Dateieinlesen()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader("D:\\TestOrdner\\Warehouse.txt"))
                {
                    while (streamReader.EndOfStream == false)
                    {
                        // Eine Zeile aus der Datei einlesen
                        string zeile = streamReader.ReadLine();

                        // Zeile am ; zerlegen
                        string[] teile = zeile.Split(':');

                        int artikelnummer = int.Parse(teile[0]);
                        string bezeichnung = teile[1];
                        int istbestand = int.Parse(teile[2]);
                        int höchstbestand = int.Parse(teile[3]);
                        decimal preis = decimal.Parse(teile[4]);
                        int verbrauch = int.Parse(teile[5]);
                        int bestelldauer = int.Parse(teile[6]);

                        // Artikel dem DB-Set hinzufügen
                        Artikel.Add(new Artikel() { Nummer = artikelnummer, Bezeichnung = bezeichnung, IstBestand = istbestand, MaxBestand = höchstbestand, Preis = preis, VerbrauchProTag = verbrauch, BestellDauerinTagen = bestelldauer });
                    }
                }

                SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public decimal WarenwertBerechnen()
        {
            return Artikel.Sum(a => a.Preis * a.IstBestand);
        }

        public override string ToString()
        {
            // Kopfzeile
            string text = "A-Nr.\tBez.\tIstB.\tMax.\tPreis\tVproT\tBinT\tMel.\tVors." + Environment.NewLine;

            text += string.Join(Environment.NewLine, Artikel);

            return text;
        }
    }

}
