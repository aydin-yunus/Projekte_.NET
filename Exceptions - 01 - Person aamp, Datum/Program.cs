using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions___01___Person_aamp__Datum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            try
            {
                p.Name = "Hicham";
                p.Vorname = "Attab";
                p.Alter = 3;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
