using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events___02___Beobachter_am_Fluss_03._03
{
    class WasserStandEventArgs:EventArgs
    {
        public int AlterWasserStand { get;  }
        public int NeueWasserStand { get; }
        public WasserStandEventArgs(int alteWasserStand, int neueWasserStand)
        {
            AlterWasserStand = alteWasserStand;
            NeueWasserStand = neueWasserStand;
        }

    }
}
