using System;
using System.Collections.Generic;
using System.Text;

namespace Date
{
   public class Date
    {

        private int year;
        public int Year
        {
            get { return year; }
            set { if (value > 0 && value < 3000) { year = value; }
                  else { Console.WriteLine("YEAR OUT OF RANGE, PLEASE GIVE YEAR BETWEEN 0 AND 3000."); }
            }
        }


        private int month;
        public int Month
        {
            get { return month; }
            set { if (value < 12 && value > 0) { month = value; }
                else { Console.WriteLine("INVALID MONTH..."); }
            }
        }


        private int day;
        public int Day
        {
            get { return day; }
            set { if (value < 31 && value > 0) { day = value; }
                else { Console.WriteLine("INVALID DAY..."); }
            }
        }




        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }


        public void DisplayDate()
        {
            Console.WriteLine($"{day:D2}/{month:D2}/{year:D4}");
       
        }



    }
}
