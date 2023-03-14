using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenderizeIOForm_14._03
{
    public class GIOResponse
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Probability { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return String.Format($"'{Name}' hat eine Wahrscheinlichkeit vom {Probability} '{Gender}' zu sein. Basierend auf {Count} Einträgen.");
        }
    }
}
