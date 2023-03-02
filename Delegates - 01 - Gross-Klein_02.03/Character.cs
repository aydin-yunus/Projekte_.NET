using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates___01___Gross_Klein_02._03
{
    internal class Character
    {
        public void UpperCase(string wert)
        {
            Console.WriteLine(wert.ToUpper());
        }
        public void LowerCase(string wert)
        {
            Console.WriteLine(wert.ToLower());
        }
        public void UpperLower(string wert)
        {
            Console.WriteLine(wert);
        }
    }
}
