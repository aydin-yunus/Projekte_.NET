using System.Reflection;
using System.Text.Json;

namespace EF_Code_First___03___Kontaktverwaltung_21._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menüAuswahl = 0;
            DataContext dataContext = new DataContext();

            Console.WriteLine("---------- Menü ----------");
            Console.WriteLine("1)   Neuer Eintrag");
            Console.WriteLine("2)   Daten anzeigen");
            Console.WriteLine("3)   Daten bearbeiten");
            Console.Write("Bitte Auswahl eingeben: ");
            menüAuswahl = Convert.ToInt32(Console.ReadLine());

            switch (menüAuswahl)
            {
                case 1:
                    NeuerEintrag(dataContext);
                    break;
                case 2:
                    DatenAnzeigen(dataContext);
                    break;
                case 3:
                    DatenBearbeiten(dataContext);
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe");
                    break;
            }

            static void DatenBearbeiten(DataContext dataContext)
            {
                int auswahlMenü;

                foreach (Kontakt item in dataContext.Kontakte)
                {
                    Console.WriteLine("{0}) {1}", item.ID, item.Vorname);
                }

                Console.WriteLine("Bitte Auswählen:");
                auswahlMenü = Convert.ToInt32(Console.ReadLine());

                var meinKontakt = dataContext.Kontakte.Find(auswahlMenü);

                Console.WriteLine("1) {0}", meinKontakt.Vorname);
                Console.WriteLine("2) {0}", meinKontakt.Nachname);
                Console.WriteLine("3) {0}", meinKontakt.Telefonnummer);
                Console.WriteLine("4) {0}", meinKontakt.Email);
                Console.WriteLine("5) {0}", meinKontakt.PLZ);
                Console.WriteLine("Auswahl: ");
                auswahlMenü = Convert.ToInt32(Console.ReadLine());

                switch (auswahlMenü)
                {
                    case 1:
                        meinKontakt.Vorname = Console.ReadLine();
                        break;
                    case 2:
                        meinKontakt.Nachname = Console.ReadLine();
                        break;
                    case 3:
                        meinKontakt.Telefonnummer = Console.ReadLine();
                        break;
                    case 4:
                        meinKontakt.Email = Console.ReadLine();
                        break;
                    case 5:
                        meinKontakt.PLZ = Console.ReadLine();
                        break;
                }


                dataContext.SaveChanges();

            }

            static async void NeuerEintrag(DataContext dataContext)
            {
                Kontakt kontakt = new Kontakt();

                Console.WriteLine("Bitte Vornamen eingeben:");
                kontakt.Vorname = Console.ReadLine();

                Console.WriteLine("Bitte Nachnamen eingeben:");
                kontakt.Nachname = Console.ReadLine();

                Console.WriteLine("Bitte Telefonnummer eingeben:");
                kontakt.Telefonnummer = Console.ReadLine();

                Console.WriteLine("Bitte E-Mail eingeben:");
                kontakt.Email = Console.ReadLine();

                Console.WriteLine("Bitte PLZ eingeben:");
                kontakt.PLZ = Console.ReadLine();

                HttpClient client = new HttpClient();

                string temp = client.GetStringAsync(@"https://api.genderize.io/?name=" + kontakt.Vorname).Result;
                Gender gender = JsonSerializer.Deserialize<Gender>(temp);

                kontakt.Geschlecht = gender.gender;

                temp = client.GetStringAsync(@"https://api.zippopotam.us/de/" + kontakt.PLZ).Result;
                Ort ort = JsonSerializer.Deserialize<Ort>(temp);

                kontakt.Ort = ort.places[0].placename;

                dataContext.Kontakte.Add(kontakt);
                dataContext.SaveChanges();
            }

            static void DatenAnzeigen(DataContext dataContext)
            {
                var sortedList = dataContext.Kontakte.OrderBy(x => x.Nachname).ToList();

                foreach (Kontakt item in sortedList)
                {
                    Console.WriteLine(item.Vorname + " " + item.Geschlecht + " " + item.Ort);
                }
            }
        }
    }
}