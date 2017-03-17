using System;
using System.Text.RegularExpressions;

namespace Hometasks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectFormat = false;

            while (isCorrectFormat == false)
            {
                Console.WriteLine("Please enter username...");
                var userName = Console.ReadLine();
                if (Regex.IsMatch(userName, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("Hello, " + userName);
                    isCorrectFormat = true;
                }
                else
                {
                    Console.WriteLine("Please, use only letters");

                }
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
