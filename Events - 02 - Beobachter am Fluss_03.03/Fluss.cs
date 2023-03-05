using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Events___02___Beobachter_am_Fluss_03._03
{
    delegate void WasserStandEventHandler(object sender, WasserStandEventArgs e);
    class Fluss
    {
        public event WasserStandEventHandler WasserStandÄnderung;
        public event WasserStandEventHandler WasserStandKritisch;
        public string Name { get; }
        private int wasserStand;
        public int WasserStand 
        {   
            get
            {
                return wasserStand;
            }
            set
            {
                if (wasserStand == value)
                {
                    return;
                }
                if(WasserStandÄnderung != null)
                {
                    WasserStandÄnderung(this, new WasserStandEventArgs(value,wasserStand));
                }
                if (WasserStandKritisch != null) 
                { 
                    WasserStandKritisch(this, new WasserStandEventArgs(value,wasserStand));
                }
                wasserStand = value;
            }
        }
        public Fluss(string _name, int _wasserStand)
        {
            Name = _name;
            WasserStand = _wasserStand;
        }

    }
}
