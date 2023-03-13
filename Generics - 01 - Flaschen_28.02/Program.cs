using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Generics___01___Flaschen_28._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Getränke anlegen
            Bier hövels = new Bier("Hövels", "Hövels Brauerei");
            Rotwein merlot = new Rotwein("Merlot", "Frankreich");
            Weißwein riesling = new Weißwein("Riesling", "Deutschland");

            // Flaschen anlegen
            Flasche<Bier> bierflasche = new Flasche<Bier>();
            Flasche<Rotwein> rotweinFlasche = new Flasche<Rotwein>();
            Flasche<Weißwein> weißweinFlasche = new Flasche<Weißwein>();

            // Flaschen mit Getränken füllen
            bierflasche.Füllen(hövels);
            bierflasche.Füllen(hövels);
            rotweinFlasche.Füllen(merlot);
            weißweinFlasche.Füllen(riesling);
            Console.WriteLine();

            // Flaschen leeren
            Console.WriteLine(bierflasche.Leeren());
            Console.WriteLine(rotweinFlasche.Leeren());
            Console.WriteLine(rotweinFlasche.Leeren());
            Console.WriteLine(weißweinFlasche.Leeren());

            Console.ReadKey();


        }
    }
    
   
}
