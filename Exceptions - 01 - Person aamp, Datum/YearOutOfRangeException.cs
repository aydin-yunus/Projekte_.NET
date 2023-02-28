using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions___01___Person_aamp__Datum_27_02
{
    internal class YearOutOfRangeException : Exception
    {
        private string message;

        public YearOutOfRangeException(string message)
        {
            this.message = message;
        }

        public override string Message
        {
            get
            {
                return message;
            }
        }
    }
}
