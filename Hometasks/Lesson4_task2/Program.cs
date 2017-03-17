using System;

namespace Lesson4_task2
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

            int totalSum = 0;
            for (int i = 1; i <= convertedNumber; i++)
            {
                totalSum = +i + totalSum;
            }

            Console.WriteLine("Total sum of 1 + 2 + 3 + ... + n, is {0}, where 'n' - number your have entered", totalSum);
            Console.ReadKey();
        }
    }
}
