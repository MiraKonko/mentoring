using System;

namespace Lesson2_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 'Enter' to find out how many days left till weekend...");
            Console.ReadLine();
            DayOfWeek dateToday = DateTime.Today.DayOfWeek;
            DaysTillWeekEnd(dateToday);
            Console.ReadLine();
        }

        static void DaysTillWeekEnd(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("5 days left, may the force be with you!");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("4 days left, hold on!");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Today is The Little Friday! 3 days left :)");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("2 more days..");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Are you ready? Tomorrow is weekend!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Weekend is now, enjoy!");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Weekend is now, enjoy! But don't forget, tomorrow Monday");
                    break;

            }
            // alternative more primitive solution
            //Console.WriteLine("Press any key to find out how many days left till weekend...");
            //Console.ReadLine();
            //var dateToday = DateTime.Today;
            //int daysTillWeekend = 6 - (int)dateToday.DayOfWeek;
            //if (daysTillWeekend > 0 && daysTillWeekend < 6)
            //{
            //    Console.WriteLine(daysTillWeekend + " days left");
            //}
            //else
            //{
            //    Console.WriteLine("Weekend is now! Enjoy!");
            //}
            //Console.ReadLine();
        }
    }
}

