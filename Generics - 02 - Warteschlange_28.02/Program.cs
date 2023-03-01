using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___02___Warteschlange_28._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericLinkedQueue queue = new GenericLinkedQueue();

            queue.Enqueue("1. Eintrag");
            queue.Enqueue("2. Eintrag");
            queue.Enqueue("3. Eintrag");
            queue.Enqueue("4. Eintrag");
            queue.Enqueue("5. Eintrag");

            queue.Print();

            queue.Enqueue("6. Eintrag");
            queue.Enqueue("7. Eintrag");

            queue.Print();

            Console.WriteLine("Entferntes Element: {0}", queue.Dequeue());
            Console.WriteLine("Entferntes Element: {0}", queue.Dequeue());
            Console.WriteLine("Entferntes Element: {0}", queue.Dequeue());

            queue.Print();
        }
    }
}
