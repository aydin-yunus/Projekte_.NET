
using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    private static void Main(string[] args)
    {
        Book myBook = new Book()
        {
            NumberOfPages = 10,
            ISBN = "1000000",
            Titel = "Reading for Presidents"
        };
        ////Dosya olusturma ve yazma
        //File.WriteAllText(@"D:\TestOrdner\Books.json", JsonSerializer.Serialize(book));//burda verilen konumda dosyamizi olusturduk

        //Dosya acma ve okuma
        StreamReader inFile = File.OpenText(@"D:\TestOrdner\Books.json");
        Book myBooks = JsonSerializer.Deserialize<Book>(inFile.ReadToEnd());
        Console.WriteLine(myBooks);



        Console.ReadKey();
    }
}
public class Book
{
    public string ISBN { get; set; }
    public string Titel { get; set; }
    public int NumberOfPages { get; set; }
    public Book()
    {
        ISBN = string.Empty;
        Titel = string.Empty;
        NumberOfPages = 0;
    }
    public override string ToString()
    {
        return string.Format($"{Titel} ({ISBN}), {NumberOfPages} Seiten");
    }
}