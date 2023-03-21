using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First___03___Kontaktverwaltung_21._03.Models
{
    public class Kontakt
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Geschlecht { get; set; }
        public string Telefonnummer { get; set; }
        public string Email { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }
        public int ID { get; set; }

    }
}
