namespace EF_Code_First___02___Schneckenrennen_20._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rennschnecke r1 = new Rennschnecke() { Name = "Rudi", MaximalGeschwindigkeit = 30 };
            Rennschnecke r2 = new Rennschnecke() { Name = "Hansi", MaximalGeschwindigkeit = 30 };
            Rennschnecke r3 = new Rennschnecke() { Name = "Klausi", MaximalGeschwindigkeit = 30 };

            Rennen einRennen = new Rennen() { Name = "Rennen am Weinberg", MaxAnzahlTeilnehmer = 3, StreckenLänge = 1000 };

            einRennen.AddRennschnecke(r1);
            einRennen.AddRennschnecke(r2);
            einRennen.AddRennschnecke(r3);

            Console.WriteLine(einRennen);

            Wettbüro wettbüro = new Wettbüro() { Faktor = 10, DasRennen = einRennen };

            wettbüro.WetteAnnehmen("Klausi", 100, "Frank Müller");
            wettbüro.WetteAnnehmen("Rudi", 50, "Lisa Meyer");
            wettbüro.WetteAnnehmen("Hansi", 200, "Karl Schulz");

            wettbüro.RennenDurchführen();

            //Console.WriteLine(wettbüro);

            using (WettContext ctx = new WettContext())
            {
                ctx.Database.EnsureDeleted();
                ctx.Database.EnsureCreated();

                ctx.Wettbüros.Add(wettbüro);

                ctx.SaveChanges();

                Wettbüro wettbüro1 = ctx.Wettbüros.First();
                Console.WriteLine(wettbüro1);
            }
        }
    }
}