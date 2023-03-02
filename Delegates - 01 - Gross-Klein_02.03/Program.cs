using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates___01___Gross_Klein_02._03
{
    delegate void CharacterHandler(string wert);
    internal class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character();
            CharacterHandler Upper = new CharacterHandler(c.UpperCase);
            CharacterHandler Lower = c.LowerCase;
            CharacterHandler UpperLower = c.UpperLower;

            Upper("yunus");
            Lower("IBRAHIM");
            UpperLower("BiRiSi");

            //Multicast using with Delegates
            CharacterHandler Multicast = new CharacterHandler(Upper + Lower + UpperLower);

            Multicast("MultiCastTest");

            //Anonyme Methode
            CharacterHandler Anonym = delegate (string wert)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(wert);
                Console.ResetColor();
            };
            Anonym("saka gibi");
            Multicast = Upper + Lower + UpperLower + Anonym;
            Multicast("Vay anasini sayin seyirciler");

        }
    }
}
