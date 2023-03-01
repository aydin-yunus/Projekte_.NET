using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___01___Flaschen_28._02
{
    internal class Wein:Getränk
    {
        public string Herkunft { get; set; }

        public Wein(string name, string herkunft)
            : base(name)
        {
            this.Herkunft = herkunft;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", name, Herkunft);
        }
    }
}
