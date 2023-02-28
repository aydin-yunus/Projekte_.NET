using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions___01___Person_aamp__Datum_27_02
{
    internal class DayOfMonthException : Exception
    {
        public DayOfMonthException(string message)
           : base(message)
        {
        }
    }
}
