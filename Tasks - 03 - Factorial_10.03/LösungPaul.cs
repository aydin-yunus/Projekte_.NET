using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
//// Hepsi icinde, burdan cikarip namespace altina kopyalarsak calisir. evde incelemek icin aldim
namespace Tasks___03___Factorial_10._03
{
    internal class LösungPaul
    {
        static BigInteger factorial(BigInteger x)
        {
            if (x < 2) return 1;
            {
                return x * factorial(x - 1);
            }
        }

        static void Main(string[] args)
        {

            int[] starvalues = ReadValuesFromFile(@"D:\UserData\factorial.txt");

            Task<BigInteger>[] tasks = new Task<BigInteger>[starvalues.Length];

            for (int i = 0; i < starvalues.Length; i++)
            {
                int start = starvalues[i];

                tasks[i] = Task<BigInteger>.Factory.StartNew(()
                    =>
                { return factorial(new BigInteger(start)); });
            }


            var results = starvalues.Zip(tasks,
                (first, second) => first.ToString() + " - " + second.Result.ToString());

            WriteValuesToFile(@"D:\UserData\factorial-results.txt", results.ToArray());

            Console.WriteLine("Hauptprogramm Ende");

        }

        private static void WriteValuesToFile(string path, string[] strings)
        {
            File.WriteAllLines(path, strings);
        }

        private static int[] ReadValuesFromFile(string path)
        {
            if (File.Exists(path))
            {
                String[] numerStrings = File.ReadAllLines(path);
                List<int> values = new List<int>(numerStrings.Length);
                foreach (String numerString in numerStrings)
                {
                    try
                    {
                        int x = int.Parse(numerString);
                        values.Add(x);
                    }
                    catch
                    {
                        continue;
                    }
                }

                return values.ToArray();
            }

            return new int[] { 1 };
        }

    }
}
