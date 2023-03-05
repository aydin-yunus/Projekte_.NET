using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events___02___Beobachter_am_Fluss_03._03
{
    internal class Schiff //: IBeobachter
    {
        public void WasserStandÄnderung(int wasserstand)
        {
            if (wasserstand < 250&&wasserstand>800)
            {
                Console.WriteLine($"{this.GetType().Name} : Schiff muss gesperrt werden");
            }
        }
    }
}
