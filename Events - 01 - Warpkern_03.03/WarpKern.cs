using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events___01___Warpkern_03._03
{
    // Delegate für den Event
    delegate void TemperaturEventHandler(object sender, WarpKernEventArgs e);
    internal class WarpKern
    {
        // Die öffentlichen Events
        public event TemperaturEventHandler TemperaturÄnderung;

        public event TemperaturEventHandler TemperaturKritisch;

        private const double KritischeTemperatur = 500;

        private double temperatur;

        public double Temperatur
        {
            get { return temperatur; }
            set
            {
                // Temperatur wurde nicht verändert
                if (temperatur == value)
                {
                    return;
                }

                // Min. ein Subscriber vorhanden?
                if (TemperaturÄnderung != null)
                {
                    // Änderungsevent auslösen
                    TemperaturÄnderung(this, new WarpKernEventArgs(value, temperatur));
                }

                if (value > KritischeTemperatur    // Temperatur größer 500 und
                    && TemperaturKritisch != null) // min. ein Subscriber vorhanden?
                {
                    // Kritischen Event auslösen
                    TemperaturKritisch(this, new WarpKernEventArgs(value, temperatur));
                }

                // Temperatur speichern
                temperatur = value;
            }
        }
    }
}
