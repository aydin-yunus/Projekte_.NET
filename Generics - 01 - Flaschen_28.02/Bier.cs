using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Generics___01___Flaschen_28._02
{
    internal class Bier:Getränk
    {
        public string Brauerei { get; set; }

        public Bier(string name, string brauerei)
            : base(name)
        {
            this.Brauerei = brauerei;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", name, Brauerei);
        }

    }
}
