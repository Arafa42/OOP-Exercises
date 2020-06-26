using System;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        { 
            Date dt = new Date(01,01,2000);
            dt.DisplayDate();
            dt.Month = 100;
            dt.Year = 200; 
            dt.DisplayDate();
        }
    }
}
