using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions___01___Person_aamp__Datum_27_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person jemand=new Person();
                jemand.Alter = -5;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }





            //Aufgabe-2
            try
            {
                SimpleDate einDatum = new SimpleDate();
                einDatum.Year = 2000;
                einDatum.Month = 2;
                einDatum.Day = 29;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                SimpleDate nochEinDatum = new SimpleDate();
                nochEinDatum.Year = 2001;
                nochEinDatum.Month = 13;
                nochEinDatum.Day = 25;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
