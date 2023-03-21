using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First___02___Schneckenrennen_20._03
{
    public class Rennen
    {
        public int Id { get; set; }

        public virtual ICollection<Rennschnecke> AlleSchnecken { get; set; }

        public string Name { get; set; }
        public int MaxAnzahlTeilnehmer { get; set; }
        public int StreckenLänge { get; set; }

        public Rennen()
        {
            AlleSchnecken = new List<Rennschnecke>();
        }

        public void AddRennschnecke(Rennschnecke neueSchnecke)
        {
            if (AlleSchnecken.Count < MaxAnzahlTeilnehmer)
            {
                AlleSchnecken.Add(neueSchnecke);
            }
            else
            {
                Console.WriteLine("Das Rennen ist voll");
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} Länge: {1} cm Anzahl Teilnehmer: {2}", Name, StreckenLänge, AlleSchnecken.Count);
        }

        public Rennschnecke ErmittleGewinner()
        {
            return AlleSchnecken.FirstOrDefault(s => s.Distanz > StreckenLänge);
        }

        public void LasseSchneckenKriechen()
        {
            foreach (Rennschnecke rennschnecke in AlleSchnecken)
            {
                rennschnecke.Krieche();
                Console.WriteLine(rennschnecke);
            }
        }

        public void Durchführen()
        {
            Console.WriteLine("Rennen läuft");
            do
            {
                LasseSchneckenKriechen();
                Console.WriteLine();
            }
            while (this.ErmittleGewinner() == null);

            Console.WriteLine("Rennen beendet");
        }

        public bool IstRennTeilnehmer(string name)
        {
            return AlleSchnecken.Any(s => s.Name == name);
        }
    }
}
