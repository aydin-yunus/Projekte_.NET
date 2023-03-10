using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        string pfad1 = @"D:\Texte\Hardware.txt";
        string pfad2 = @"D:\Texte\Personen.txt";
        string pfad3 = @"D:\Texte\Projekte.txt";
        Task task1 = new Task(Arbeit, pfad1);
        Task task2 = new Task(Arbeit, pfad2);
        Task task3 = new Task(Arbeit, pfad3); 
        task1.Start();
        task2.Start(); 
        task3.Start();
        Console.ReadLine();
    } 
    public static void Arbeit(object param)
    {
        string pfad = (string)param; 
        Dictionary<string, int> häufigkeit = new Dictionary<string, int>();
        try
        {
            using (StreamReader sr = new StreamReader(pfad))
            {
                while (sr.EndOfStream == false)
                {
                    string zeile = sr.ReadLine().ToLower();
                    zeile = Regex.Replace(zeile, "[^\\w ]", string.Empty); 
                    string[] wörterDerZeile = zeile.Split(' ', StringSplitOptions.RemoveEmptyEntries); 

                    for (int i = 0; i < wörterDerZeile.Length; i++)
                    {
                        if (häufigkeit.ContainsKey(wörterDerZeile[i]))
                        {
                            häufigkeit[wörterDerZeile[i]]++;
                        }
                        else
                        {
                            häufigkeit.Add(wörterDerZeile[i], 1);
                        }
                    }
                }
            }  
           
            using (StreamWriter sw = new StreamWriter(pfad + ".json"))
            {
                foreach (var item in häufigkeit)
                {
                    sw.WriteLine(item.Key + " " + item.Value);
                    Console.WriteLine(item);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}