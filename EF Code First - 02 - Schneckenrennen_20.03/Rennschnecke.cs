using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First___02___Schneckenrennen_20._03
{
    public class Rennschnecke
    {
        public int id { get; set; }
        public string name { get; set; }
        public int MaxSpeed { get; set; }
        public int Distance { get; set; }
        public void Krieche()
        {
            Random rnd = new Random();
            Distance += rnd.Next(1, MaxSpeed);
        }
        public override string ToString()
        {
            return string.Format($"Name: {name}\tSpeed: {MaxSpeed}\t Strecke:{Distance}");
        }
    }
}
