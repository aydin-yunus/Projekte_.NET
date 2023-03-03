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
        }
    }
    class WarpKern
    {
        public event TemperaturÄnderungEventHandler TemperaturÄnderung;
        double maxTemp = 500;
        public double temperatur;
        public double Temperatur 
        { 
            get=>temperatur;
            set 
            { 

            }
        }

    }
    class WarpKernEventArgs : EventArgs
    {

    }
}
