using System.Diagnostics;

namespace Aufgabe___Haus_des_Nikolaus_13._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var solver = new SolveNik();

            Stopwatch watch = new Stopwatch();
            watch.Start();
            solver.Solve();
            watch.Stop();

            Console.WriteLine("Millilsekunden = " + watch.ElapsedMilliseconds);

            Console.WriteLine(solver.NumberOfSolutions);

            Console.ReadLine();
        }
    }
}