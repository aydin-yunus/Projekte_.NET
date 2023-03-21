using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First___02___Schneckenrennen_20._03
{
    public class Rennschnecke
    {
        public int Id { get; set; }

        private static readonly Random zufallszahlenGenerator = new Random();

        public string Name { get; set; }
        public int Distanz { get; set; }
        public int MaximalGeschwindigkeit { get; set; }

        public void Krieche()
        {
            Distanz += zufallszahlenGenerator.Next(1, MaximalGeschwindigkeit);
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\t Speed: {1} Zurückgelegte Strecke: {2} cm", Name, MaximalGeschwindigkeit, Distanz);
        }
    }
}
