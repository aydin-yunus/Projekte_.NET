namespace Tupel___01___Grundlagen_15._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paarbildung();
            Console.WriteLine("--------");
            Reißverschluss();
            Console.ReadKey();

        }
        static public void Paarbildung()
        {

            List<int> zahlen = new List<int> { 9, 42, 60, 33, 38, 7, 7, 11, 18 };
            for (int i = 0; i < zahlen.Count; i++)
            {
                if (zahlen.Count % 2 == 0)
                {
                    var pair = (zahlen[i], zahlen[i + 1]);
                    Console.WriteLine(pair);
                    i++;
                }
                else
                {
                    zahlen.Remove(zahlen.Last());
                    var pair = (zahlen[i], zahlen[i + 1]);
                    Console.WriteLine(pair);
                    i++;
                }
            }
        }
        public static void Reißverschluss()
        {
            List<int> list1 = new List<int> {21,65,6,1,14,58,56,38,18,2 };
            List<int> list2 = new List<int> { 95,1,86,32,66,27,67,10,54,55,80 };
            if (list1.Count<list2.Count)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    if (list1.Count % 2 == 0)
                    {
                        var pair = (list1[i], list2[i ]);
                        Console.WriteLine(pair);
                    }
                    else
                    {
                        list1.Remove(list1.Last());
                        var pair = (list1[i], list2[i ]);
                        Console.WriteLine(pair);
                    }
                }
            }
            else
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    if (list2.Count % 2 == 0)
                    {
                        var pair = (list2[i], list1[i ]);
                        Console.WriteLine(pair);
                    }
                    else
                    {
                        list2.Remove(list2.Last());
                        var pair = (list2[i], list1[i]);
                        Console.WriteLine(pair);
                    }
                }
            }

        }
    }
}