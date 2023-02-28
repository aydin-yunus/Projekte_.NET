using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___01___Flaschen_28._02
{
    internal class Wein:Getränk
    {
        protected string herkunft;
        
        public Wein(string herkunft, string name):base(name)
        {
            this.herkunft = herkunft;
            
        }
    }
}
