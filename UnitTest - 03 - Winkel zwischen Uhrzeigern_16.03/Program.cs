using System;
using System.Text.RegularExpressions;

namespace UnitTest___03___Winkel_zwischen_Uhrzeigern_16._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public static class Clock
    {
        private static int GetClockHandAngles(int hours, int minutes)
        {
            int GetHoursAngle(int hours, int minutes)
            {
                double angle = Math.Round((60 * hours + minutes) * 0.5);
                return (int)(angle % 360);
            }

            int GetMinutesAngle(int minutes)
            {
                return 6 * minutes % 360;
            }

            int deltaHours = GetHoursAngle(hours, minutes);
            int deltaMinutes = GetMinutesAngle(minutes);

            int angle = Math.Abs(deltaHours - deltaMinutes);

            return (angle > 180) ? (360 - angle) : angle;
        }

        public static int GetAngle(string time)
        {
            Regex pattern = new Regex("^([01]?[0-9]|2[0-3]):([0-5][0-9])$");
            if (pattern.IsMatch(time))
            {
                int hours = int.Parse(time.Split(':')[0]);
                int minutes = int.Parse(time.Split(':')[1]);
                return GetClockHandAngles(hours, minutes);
            }

            throw new ArgumentException();
        }
    }
}