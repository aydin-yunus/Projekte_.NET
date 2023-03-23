using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace LINQ___05___Bestellung_23._03.Models
{
    public class Bestellung
    {
        public Allepositionen[] AllePositionen { get; set; }
    }

    public class Allepositionen
    {
        public int Id { get; set; }
        public int Artikelnummer { get; set; }
        public int Anzahl { get; set; }
    }
}
