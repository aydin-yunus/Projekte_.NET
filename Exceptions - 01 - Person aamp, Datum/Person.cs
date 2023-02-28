using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions___01___Person_aamp__Datum_27_02
{
    public class Person
    {
        public string Name { set; get; }
        public string Vorname { get; set; }
        public int alter;
        //public Person(int alter)
        //{
        //    this.Alter = alter;
        //}
        public int Alter
        {
            get => Alter; set
            {
                if (value <= 0)
                {
                    throw new Exception("Kein negatives Alter erlaubt!");
                }
                alter = value;

            }
        }
    }


}
