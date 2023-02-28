using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions___01___Person_aamp__Datum_27_02
{
    internal class SimpleDate
    {
        private int year;

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1 || value > 9999)
                {
                    throw new YearOutOfRangeException("Jahr muss zwischen 1 und 9999 liegen!");
                }
                year = value;
            }
        }

        private int month;

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new MonthOutOfRangeException("Monat muss zwischen 1 und 12 liegen!");
                }
                month = value;
            }
        }

        private int day;

        public int Day
        {
            get { return day; }
            set
            {
                if (value > 0 && TageImMonat(value))
                {
                    day = value;
                }
                else
                {
                    throw new DayOfMonthException("Tagesangabe für diesen Monat ungültig!");
                }
            }
        }

        private bool TageImMonat(int tag)
        {
            switch (Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (tag <= 31)
                    {
                        return true;
                    }
                    break;

                case 2:
                    if (IstSchaltjahr())
                    {
                        if (tag <= 29)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (tag <= 28)
                        {
                            return true;
                        }
                    }
                    break;

                default:
                    if (tag <= 30)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }

        private bool IstSchaltjahr()
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
