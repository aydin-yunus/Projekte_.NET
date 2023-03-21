using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First___02___Schneckenrennen_20._03
{
    public class Wette
    {
        public int Id { get; set; }
        public string SpielerName { get; set; }
        public double Einsatz { get; set; }
        public string SchneckenName { get; set; }

        public override string ToString()
        {
            return string.Format("Schneckenname: {0} Spieler: {1} Einsatz: {2:N0} Euro", SchneckenName, SpielerName, Einsatz);
        }
    }
}
