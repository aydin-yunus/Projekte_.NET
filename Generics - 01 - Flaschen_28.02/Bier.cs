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

        public string brauerei { get=>brauerei; set=>value=brauerei; }
        public Bier(string brauerei, string name):base(name)
        {
            this.Brauerei = brauerei;
            
        }

    }
}
