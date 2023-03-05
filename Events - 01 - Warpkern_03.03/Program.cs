using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events___01___Warpkern_03._03
{
    delegate void TemperaturÄnderungEventHandler(object sender, WarpKernEventArgs e);
    internal class Program
    {
        static void Main(string[] args)
        {
            WarpKern warpkern = new WarpKern();

            WarpKernKonsole konsoleAufderBrücke = new WarpKernKonsole("Brücke");

            WarpKernKonsole konsoleImMaschinenraum = new WarpKernKonsole("Maschinenraum");

            // Warpkern Events mit der Konsole verknüpfen
            warpkern.TemperaturÄnderung += konsoleImMaschinenraum.AusgabeTemperaturÄnderung;
            warpkern.TemperaturKritisch += konsoleImMaschinenraum.AusgabeTemperaturKritisch;

            warpkern.TemperaturKritisch += konsoleAufderBrücke.AusgabeTemperaturKritisch;

            warpkern.Temperatur = 100;
            warpkern.Temperatur = 150;
            warpkern.Temperatur = 200;
            warpkern.Temperatur = 400;
            warpkern.Temperatur = 550;
            warpkern.Temperatur = 400;

            // Methode für krititschen Event entfernen
            warpkern.TemperaturKritisch -= konsoleAufderBrücke.AusgabeTemperaturKritisch;

            warpkern.Temperatur = 550;
            Console.ReadKey();
        }    
    }    
}
