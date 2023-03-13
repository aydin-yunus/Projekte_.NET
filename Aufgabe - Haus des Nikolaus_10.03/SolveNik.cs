using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe___Haus_des_Nikolaus_13._03
{
    internal class SolveNik
    {
        private const int Min = 111111111;
        private const int Max = 155555552;

        private List<String> solutions;

        public int NumberOfSolutions { get { return solutions.Count; } }

        public SolveNik()
        {
            solutions = new List<String>();
        }

        public void Solve()
        {
            var liste = Solve(Min, Max);
            solutions.AddRange(liste);
            PrintSolutions();

        }

        private void PrintSolutions()
        {
            foreach (var item in solutions)
            {
                Console.WriteLine(item);
            }
        }

        public List<String> Solve(int von, int bis)
        {
            List<string> result = new List<string>();
            var resultF = Parallel.For(von, bis + 1, (i) =>
            {
                {
                    if (IsSolution(i))
                    {
                        result.Add(String.Join("->", numbersToDigits(i)));
                    }
                }
            });
            return result;
        }

        private bool IsSolution(int number)
        {
            int[] digits = numbersToDigits(number);
            Edge[] edges = numbersToEdges(digits); ;


            if (!CheckValidRangeOfNumbers(digits)) { return false; }

            if (CheckForSelfLoops(edges)) { return false; }

            if (!CheckForValidEdges(edges)) { return false; }

            if (CheckForDuplicateEdges(edges)) { return false; }

            return true;
        }

        private bool CheckForDuplicateEdges(Edge[] edges)
        {
            return edges.Count() > edges.Distinct().Count();
        }

        private bool CheckForValidEdges(Edge[] edges)
        {
            return !edges.Any(
                x => (x.From == 1 && x.To == 5) ||
                (x.From == 5 && x.To == 1) ||
                (x.From == 2 && x.To == 5) ||
                (x.From == 5 && x.To == 2)
            );
        }

        private bool CheckForSelfLoops(Edge[] edges)
        {
            return edges.Any(x => x.From == x.To);
        }

        private bool CheckValidRangeOfNumbers(int[] digits)
        {
            return !digits.Any(x => x < 1 || x > 5);
        }

        private Edge[] numbersToEdges(int[] digits)
        {
            return digits.Skip(1).Zip(digits, (from, to) => new Edge(from, to)).ToArray();

        }

        private int[] numbersToDigits(int number)
        {
            int[] digits = new int[9];
            for (int i = 0; i < digits.Length; i++, number /= 10)
            {
                digits[i] = number % 10;
            }

            return digits;
        }
    }
}
