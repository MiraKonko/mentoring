using System;

namespace Lesson4_task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int convertedNumber = 0;
            bool isCorrectInput = false;

            while (!isCorrectInput)
            {
                Console.WriteLine("Please, enter number of iterations...");
                string userNumber = Console.ReadLine();
                if (Int32.TryParse(userNumber, out convertedNumber))
                {
                    isCorrectInput = true;
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
            }

            int sum = 0;
            for (int i = 0; i <= convertedNumber; i++)
            {
                sum = +i + sum;
                Console.WriteLine("Incremented number: " + i);
                Console.WriteLine("Sum of all previous numbers: " + sum);

            }
            Console.ReadKey();
        }
    }
}
