using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events___01___Warpkern_03._03
{
    internal class WarpKernEventArgs:EventArgs
    {
        public double AlteTemperatur { get; }

        public double NeueTemperatur { get; }

        public DateTime Zeitstempel { get; }

        public WarpKernEventArgs(double neueTemperatur, double alteTemperatur)
        {
            AlteTemperatur = alteTemperatur;
            NeueTemperatur = neueTemperatur;
            Zeitstempel = DateTime.Now;
        }
    }
}
