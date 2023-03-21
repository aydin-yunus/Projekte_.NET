using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EF_Code_First___03___Kontaktverwaltung_21._03.Models
{
    internal class Ort
    {

        public string postcode { get; set; }
        public string country { get; set; }
        public string countryabbreviation { get; set; }
        public Place[] places { get; set; }
    }

    public class Place
    {
        [JsonPropertyName("place name")]
        public string placename { get; set; }
        public string longitude { get; set; }
        public string state { get; set; }
        public string stateabbreviation { get; set; }
        public string latitude { get; set; }
    }
}
