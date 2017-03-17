using System;

namespace Lesson4_task5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please, enter password");
            string correctPassword = "root";
            string userPassword = Console.ReadLine();
            while (userPassword != correctPassword)
            {
                Console.WriteLine("Incorrect password! Please, try again!");
                userPassword = Console.ReadLine();
            }
            Console.WriteLine("Password is correct, press any key to exit");
            Console.ReadKey();
        }
    }
}
