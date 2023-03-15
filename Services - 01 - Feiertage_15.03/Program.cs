using System.Text.Json;
using System.Text.Json.Serialization;

namespace Services___01___Feiertage_15._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();

            int jahr;
            do
            {
                Console.Write("Jahr: ");
            } while (int.TryParse(Console.ReadLine(), out jahr) == false);

            List<(int Nummer, string kürzel, string name)> bundesländer = new List<(int nummer, string kürzel, string name)>()
            {
                (1, "BW", "Baden - Württemberg"),
                (2, "BY", "Bayern"),
                (3, "BE", "Berlin"),
                (4, "BB", "Brandenburg"),
                (5, "HB", "Bremen"),
                (6, "HH", "Hamburg"),
                (7, "HE", "Hessen"),
                (8, "MV", "Mecklenburg - Vorpommern"),
                (9, "NI", "Niedersachsen"),
                (10, "NW", "Nordrhein - Westfalen"),
                (11, "RP", "Rheinland - Pfalz"),
                (12, "SL", "Saarland"),
                (13, "SN", "Sachsen"),
                (14, "ST", "Sachsen - Anhalt"),
                (15, "SH", "Schleswig - Holstein"),
                (16, "TH", "Thüringen")
            };

            Console.WriteLine(string.Join(Environment.NewLine, bundesländer));

            int auswahl;
            do
            {
                Console.Write("Auswahl: ");
            } while (int.TryParse(Console.ReadLine(), out auswahl) == false
                     && auswahl < 1 || auswahl > 16);

            string kürzel = bundesländer.Single(b => b.Nummer == auswahl).kürzel.ToLower();

            // Beispiel https://get.api-feiertage.de/?years=2021&states=nw
            string url = string.Format("https://get.api-feiertage.de/?years={0}&states={1}", jahr, kürzel);

            Console.WriteLine("Feiertage aus {0} für das Jahr {1}", bundesländer.SingleOrDefault(b => b.Nummer == auswahl).name, jahr);

            string message = client.GetStringAsync(url).Result;

            ServiceAntwort feiertage = null;

            try
            {
                feiertage = JsonSerializer.Deserialize<ServiceAntwort>(message);

                Console.WriteLine(string.Join<Feiertage>(Environment.NewLine, feiertage.Feiertage));
            }
            catch
            {
                Console.WriteLine(feiertage.Additional_note);
            }
        }   
    }
    public class ServiceAntwort
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("feiertage")]
        public Feiertage[] Feiertage { get; set; }

        [JsonPropertyName("additional_note")]
        public string Additional_note { get; set; }
    }

    public class Feiertage
    {
        public string date { get; set; }
        public string fname { get; set; }
        public string all_states { get; set; }
        public string bw { get; set; }
        public string by { get; set; }
        public string be { get; set; }
        public string bb { get; set; }
        public string hb { get; set; }
        public string hh { get; set; }
        public string he { get; set; }
        public string mv { get; set; }
        public string ni { get; set; }
        public string nw { get; set; }
        public string rp { get; set; }
        public string sl { get; set; }
        public string sn { get; set; }
        public string st { get; set; }
        public string sh { get; set; }
        public string th { get; set; }
        public string comment { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0,-25} Datum: {1} ", fname, Convert.ToDateTime(date).ToShortDateString());
        }
    }

}