using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions___01___Person_aamp__Datum_27_02
{
    internal class MonthOutOfRangeException:Exception
    {
        public MonthOutOfRangeException(string message)
           : base(message)
        {
        }
    }
}
