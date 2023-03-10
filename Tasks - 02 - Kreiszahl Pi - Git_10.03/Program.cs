using System.Diagnostics;

namespace Tasks___02___Kreiszahl_Pi___Git_10._03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Math.PI);

            double pi = 0;
            const int anzahlAufrufe = 4;
            Stopwatch sw = new Stopwatch();
            Task<double>[] tasks = new Task<double>[anzahlAufrufe];
           
            sw.Start();
            ////benim cözümüm
            for (int i = 1; i < anzahlAufrufe + 1; i++)
            {
                tasks[i-1] = Task.Factory.StartNew(() => { return PI_Berechnung(i, anzahlAufrufe); });
            }
            Task.WaitAll(tasks);
            pi = tasks.Sum(t => t.Result);//bunu hoca ekledi, ben düsünemedim
            ////Osmanin cözüm
            //Task<double> task1 = Task.Run(() => PI_Berechnung(1, anzahlAufrufe));
            //Task<double> task2 = Task.Run(() => PI_Berechnung(2, anzahlAufrufe));
            //Task<double> task3 = Task.Run(() => PI_Berechnung(3, anzahlAufrufe));
            //Task<double> task4 = Task.Run(() => PI_Berechnung(4, anzahlAufrufe));
            //pi += task1.Result;
            //pi += task2.Result;
            //pi += task3.Result;
            //pi += task4.Result;


            //for (int i = 1; i < anzahlAufrufe + 1; i++)
            //{
            //    pi += PI_Berechnung(i, anzahlAufrufe);
            //}

            sw.Stop();

            Console.WriteLine(pi);

            Console.WriteLine("Dauer {0:N0} Millisekunden", sw.ElapsedMilliseconds);
        }

        // Nach John Machin (http://de.wikipedia.org/wiki/John_Machin)
        private static double PI_Berechnung(int startwert, int schrittweite)
        {
            const double durchlaeufe = 1_000_000_000;
            double x, y = 1 / durchlaeufe;
            double summe = 0;
            double pi;

            for (double i = startwert; i <= durchlaeufe; i += schrittweite)
            {
                x = y * (i - 0.5);
                summe += 4.0 / (1 + x * x);
            }

            pi = y * summe;

            return pi;
        }
    }
}