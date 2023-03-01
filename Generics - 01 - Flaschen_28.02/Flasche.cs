using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___01___Flaschen_28._02
{
    internal class Flasche<T> where T : Getränk
    {
        private T inhalt;

        public bool IstLeer { get; set; }

        public Flasche()
        {
            this.IstLeer = true;
        }

        public void Füllen(T getränk)
        {
            if (this.IstLeer)
            {
                this.inhalt = getränk;
                this.IstLeer = false;
            }
            else
            {
                Console.WriteLine("Flasche ist voll. Gefüllt mit " + getränk.GetType().Name);
            }
        }

        public T Leeren()
        {
            if (this.IstLeer == false)
            {
                T flaschenInhalt = inhalt;      // Inhalt zwischenspeichern
                this.inhalt = default(T);       // Inhalt zurücksetzen
                this.IstLeer = true;
                return flaschenInhalt;          // Inhalt zurückliefern
            }
            else
            {
                return default(T);              // Flasche ist bereits leer, dann Standard-Wert des Datentypen zurückliefern
            }
        }

    }

}
