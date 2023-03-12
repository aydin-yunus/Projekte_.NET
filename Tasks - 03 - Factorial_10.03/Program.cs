using System.Numerics;
using System.Drawing;



namespace Tasks___03___Factorial_10._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pfad =@"D:\TestOrdner\Zahlen.txt";

            TaskLesen(pfad);           
            Console.ReadKey();
        }
        public static void TaskLesen(string pfad)
        {
            foreach (string zahlAngabe in File.ReadLines(pfad))
            {
                int faqZahl = Convert.ToInt32(zahlAngabe);
                Task<BigInteger> tasks = Task<BigInteger>.Factory.StartNew(() =>
                {
                    return Factorial(faqZahl);
                });
                Console.WriteLine($"{faqZahl}! = {tasks.Result}");
            }
            
        } 

        public static BigInteger Factorial(BigInteger x)
        {
            if (x < 2)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

    }
}