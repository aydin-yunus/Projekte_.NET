using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events___01___Warpkern_03._03
{
    internal class WarpKernKonsole
    {
        private string name;

        public WarpKernKonsole(string name)
        {
            this.name = name;
        }

        public void AusgabeTemperaturÄnderung(object sender, WarpKernEventArgs e)
        {
            Console.WriteLine("{0} - {1}: Temperatur Änderung von {2,3}° auf {3,3}°", name, e.Zeitstempel, e.AlteTemperatur, e.NeueTemperatur);
        }

        public void AusgabeTemperaturKritisch(object sender, WarpKernEventArgs e)
        {
            // Schriftfarbe rot
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("{0} - {1}: Kritische Temperatur!! ({2,3}° auf {3,3}°)", name, e.Zeitstempel, e.AlteTemperatur, e.NeueTemperatur);

            // Farbe zurücksetzen
            Console.ResetColor();
        }
    }
}
