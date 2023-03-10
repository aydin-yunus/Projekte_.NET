using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        var fsw = new FileSystemWatcher("D:\\TestOrdner", "*.txt");

        fsw.Created += Fsw_Created;

        fsw.EnableRaisingEvents = true;
        Console.WriteLine("Starte den FileSystemWatcher");

        Console.WriteLine("Bitte RETURN-Taste zum beenden.");
        Console.ReadLine();
    }

    private static void Fsw_Created(object sender, FileSystemEventArgs e)
    {
        try
        {
            if (e.FullPath.EndsWith("-Statistics.txt")) { return; }

            Console.WriteLine($"Bearbeite die Datei {e.FullPath}");

            string fileContents = File.ReadAllText(e.FullPath).ToLower();
            fileContents = Regex.Replace(fileContents, "[^a-zöäüß -]", "");
            Dictionary<string, int> result = CountWordFrequency(fileContents);

            string name = Path.GetFileNameWithoutExtension(e.FullPath);
            string ext = Path.GetExtension(e.FullPath);
            string? path = Path.GetDirectoryName(e.FullPath);

            string destName = Path.Combine(
                path ??= "D:\\DirectoryToWatch",
                name + "-Statistics" + ext);

            WriteWordFrequency(result, destName);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler! {ex.Message}");
        }
    }

    private static void WriteWordFrequency(Dictionary<string, int> result, string destName)
    {
        using (var sr = new StreamWriter(destName))
        {
            var maxl = result.Keys.Max(x => x.Length);
            foreach (var kvp in result.Keys.OrderBy(x => x))
            {
                sr.WriteLine(String.Format("{0,-" + maxl + "} : {1,14}", kvp, result[kvp]));
            }
        }
    }

    private static Dictionary<string, int> CountWordFrequency(string fileContents)
    {
        var words = fileContents.Split(' ',
                StringSplitOptions.RemoveEmptyEntries |
                StringSplitOptions.TrimEntries);

        Dictionary<string, int> result = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (result.ContainsKey(word))
            {
                result[word] += 1;
            }
            else
            {
                result[word] = 1;
            }
        }
        return result;
    }

}