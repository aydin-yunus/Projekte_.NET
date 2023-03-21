using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First___02___Schneckenrennen_20._03
{
    public class Wettbüro
    {
        public int Id { get; set; }

        public virtual ICollection<Wette> AlleWetten { get; set; }

        public double Faktor { get; set; }
        public Rennen DasRennen { get; set; }

        public Wettbüro()
        {
            AlleWetten = new List<Wette>();
        }

        public void WetteAnnehmen(string rennschnecke, double wetteinsatz, string spieler)
        {
            if (DasRennen.IstRennTeilnehmer(rennschnecke))
            {
                AlleWetten.Add(new Wette() { SchneckenName = rennschnecke, Einsatz = wetteinsatz, SpielerName = spieler });
            }
        }

        public void RennenDurchführen()
        {
            DasRennen?.Durchführen();
        }

        public override string ToString()
        {
            string gewinnerName = DasRennen?.ErmittleGewinner()?.Name;
            double gewinn = 0;
            string spieler = "";

            foreach (Wette wette in AlleWetten)
            {
                if (wette.SchneckenName == gewinnerName)
                {
                    gewinn = wette.Einsatz * Faktor;
                    spieler = wette.SpielerName;
                }
            }

            return string.Format("Gewinnerschnecke: {0} Spieler: {1} Gewinn: {2}", gewinnerName, spieler, gewinn);
        }
    }
}
