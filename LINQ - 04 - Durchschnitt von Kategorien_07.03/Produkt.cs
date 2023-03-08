using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ___04___Durchschnitt_von_Kategorien_07._03
{
    internal class Produkt
    {
        public string Bezeichnung { get; set; }

        public double Preis { get; set; }

        public string Kategorie { get; set; }

        public Produkt(string bezeichnung, double preis, string kategorie)
        {
            this.Bezeichnung = bezeichnung;
            this.Preis = preis;
            this.Kategorie = kategorie;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Bezeichnung, Preis, Kategorie);
        }
    }
}
