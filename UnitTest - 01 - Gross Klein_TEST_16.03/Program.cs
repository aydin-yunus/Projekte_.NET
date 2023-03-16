using System.Text;

namespace UnitTest___01___Gross_Klein_TEST_16._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
       
    }
    public class MyClass
    {
        public static string Title(string satz)
        {
            if (string.IsNullOrWhiteSpace(satz))
            {
                return satz;
            }
            StringBuilder sb = new StringBuilder(satz);
            sb[0] = char.ToUpper(sb[0]);
            for (int i = 1; i < sb.Length; i++)
            {
                //if (char.IsWhiteSpace(sb[i-1]))
                //{
                //    sb[i] = char.ToUpper(sb[i]);
                //}
                //else
                //{
                //    sb[i] = char.ToLower(sb[i]);
                //}
                sb[i] = char.IsWhiteSpace(sb[i - 1]) ? char.ToUpper(sb[i]) : char.ToLower(sb[i]);
            }
            return sb.ToString();
        }
    }
}