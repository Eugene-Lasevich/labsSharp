using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Lab3_Prog
{
    class DateService
    {
        public void day(string date)
        {
            int day;
            int month;
            int year;
            day = Convert.ToInt32(date[0] - '0') * 10 + Convert.ToInt32(date[1] - '0');
            month = Convert.ToInt32(date[3] - '0') * 10 + Convert.ToInt32(date[4] - '0');
            year = Convert.ToInt32(date[6] - '0') * 1000 + Convert.ToInt32(date[7] - '0') * 100 + Convert.ToInt32(date[8] - '0') * 10 + Convert.ToInt32(date[9] - '0');
            DateTime dayname = new DateTime(year, month, day);
            if (dayname.DayOfWeek == DayOfWeek.Sunday)
                Console.WriteLine("Sunday");
            if (dayname.DayOfWeek == DayOfWeek.Monday)
                Console.WriteLine("Monday");
            if (dayname.DayOfWeek == DayOfWeek.Tuesday)
                Console.WriteLine("Tuesday");
            if (dayname.DayOfWeek == DayOfWeek.Wednesday)
                Console.WriteLine("Wednesday");
            if (dayname.DayOfWeek == DayOfWeek.Thursday)
                Console.WriteLine("Thursday");
            if (dayname.DayOfWeek == DayOfWeek.Friday)
                Console.WriteLine("Friday");
            if (dayname.DayOfWeek == DayOfWeek.Saturday)
                Console.WriteLine("Saturday");
        }
        public void span(string date)
        {
            int day;
            int month;
            int year;
            day = Convert.ToInt32(date[0] - '0') * 10 + Convert.ToInt32(date[1] - '0');
            month = Convert.ToInt32(date[3] - '0') * 10 + Convert.ToInt32(date[4] - '0');
            year = Convert.ToInt32(date[6] - '0') * 1000 + Convert.ToInt32(date[7] - '0') * 100 + Convert.ToInt32(date[8] - '0') * 10 + Convert.ToInt32(date[9] - '0');

            var currentTime = DateTime.Now;

            DateTime dateTime = new DateTime(year, month, day);

            int span = Math.Abs((currentTime.Date - dateTime.Date).Days);

            Console.WriteLine($"Number of days between this date and current time is {span}");
        }
    }
}
