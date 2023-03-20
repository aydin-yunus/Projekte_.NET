using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First___01___Warenlager_20._03
{
    public class Artikel
    {
        public int Id { get; set; }
        public int Nummer { get; set; }
        public string Bezeichnung { get; set; }
        public int IstBestand { get; set; }
        public int MaxBestand { get; set; }
        public decimal Preis { get; set; }
        public int VerbrauchProTag { get; set; }
        public int BestellDauerinTagen { get; set; }
        private int PufferinTagen = 2;
        public int GetMeldeBestand()
        {
            return VerbrauchProTag * (BestellDauerinTagen + PufferinTagen);
        }
        public int GetBestellVorschlag()
        {
            if (IstBestand<=GetMeldeBestand())
            {
                return GetMeldeBestand() - IstBestand;
            }
            return 0;
        }
        public override string ToString()
        {
            return string.Format($"{Nummer}\t{Bezeichnung}\t{IstBestand,3}\t{MaxBestand,3}\t{Preis,6}\t{VerbrauchProTag,3}\t{BestellDauerinTagen,3}\t{GetMeldeBestand(),3}\t{GetBestellVorschlag(),3}");
        }

    }
}
