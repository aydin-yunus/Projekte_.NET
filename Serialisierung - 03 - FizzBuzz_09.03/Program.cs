
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
internal class Program
{
    private static void Main(string[] args)
    {
        Factor zahlen = new Factor();
        var data = JsonSerializer.Serialize<Factor>(zahlen, new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        });
        FileStream fs = File.WriteAllText(@"D:\TestOrdner\FizzBuzz.json",data);


    }
    public class Factor
    {
        public int Value { get; set; }
        public string Output { get; set; }
        public Factor()
        {
            Value = 0;
            Output = string.Empty;
        }
        public void FizzBuzz()
        {
            for (Value = 1; Value < 100; Value++)
            {

                if (Value % 3 == 0 && Value % 5 == 0)
                {
                    Output = "FizzBuzz";
                    Console.WriteLine(Output);
                }
                else if (Value % 5 == 0)
                {
                    Output = "Buzz";
                    Console.WriteLine(Output);
                }
                else if (Value % 3 == 0)
                {
                    Output = "Fizz";
                    Console.WriteLine(Output);
                }
                else
                {
                    Console.WriteLine(Value);
                }

            }
        }

    }

}