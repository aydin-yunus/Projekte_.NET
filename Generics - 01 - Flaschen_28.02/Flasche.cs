using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___01___Flaschen_28._02
{
    internal class Flasche<T>
    {
        public bool inhalt;
        public bool IstLeer()
        {
            if (inhalt==true)
            {
                return true;
                
            }
            else { return false; }
        }
        public void Füllen()
        {
            inhalt = true;
            Console.WriteLine("Flasche ist voll");
        }
        public void Leeren()
        {
            inhalt= false;
            Console.WriteLine("Flasche ist leer");
        }
        
    }

}
