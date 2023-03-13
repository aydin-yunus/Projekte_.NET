using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe___Haus_des_Nikolaus_13._03
{
    public struct Edge : IEquatable<Edge>
    {
        public int From { get; set; }
        public int To { get; set; }


        public Edge(int from, int to) { From = from; To = to; }

        public bool Equals(Edge other)
        {
            return
                (From == other.From && To == other.To)
                ||
                (From == other.To && To == other.From);
        }
    }
}
