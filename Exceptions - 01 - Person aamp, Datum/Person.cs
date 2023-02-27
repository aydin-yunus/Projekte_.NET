using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions___01___Person_aamp__Datum
{
    public class Person
    {
        public string Name { set; get; }
        public string Vorname { get; set; }
        public int Alter
        {
            get => Alter; set
            {
                if (value <= 0)
                {
                    throw new Exception("Kein negatives Alter erlaubt!");
                }
            }
        }
    }


}
