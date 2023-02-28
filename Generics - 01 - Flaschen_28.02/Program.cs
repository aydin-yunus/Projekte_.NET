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
            Bier miller=new Bier("dortmund","Miller");
            //Flasche<bier> bier_fla=new Flasche<bie>();
            
            Flasche<Weißwein> weiß_fla=new Flasche<Weißwein>();
            weiß_fla.Füllen();
            Console.WriteLine(weiß_fla.IstLeer());
            weiß_fla.Leeren();
            Console.WriteLine(weiß_fla.IstLeer());
            //TODO


        }
    }
    
   
}
