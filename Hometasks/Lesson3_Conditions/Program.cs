using System;

namespace Lesson3_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int convertedInput = 0;
            bool isCorrectInput = false;

            while (!isCorrectInput)
            {
                Console.WriteLine("Please, enter a digit from 0 to 100...");
                string userInput = Console.ReadLine();
                if (Int32.TryParse(userInput, out convertedInput) &&
                    !(convertedInput > 100 || convertedInput < 0))
                {

                    isCorrectInput = true;
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }

            }

            if (convertedInput >= 0 && convertedInput <= 100)
            {
                Console.WriteLine("Congratulation, you entered correct number " + convertedInput);
            }
            if (convertedInput == 13 || convertedInput == 22 || convertedInput == 67)
            {
                Console.WriteLine("You're lucky! You entered special number " + convertedInput);
            }
            if ((convertedInput % 2) == 0)
            {
                Console.WriteLine("You entered even number " + convertedInput);
            }
            Console.WriteLine("Please, press any key to exit the program");
            Console.ReadKey();
        }
    }
}
