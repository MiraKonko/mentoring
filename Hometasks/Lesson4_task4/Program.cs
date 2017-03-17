using System;

namespace Lesson4_task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool correctAnswer = false;
            while (!correctAnswer)
            {
                Console.WriteLine("Please, choose correct answer: What is the color of Banana?{0} a.Red{0} b.Green{0} c.Yellow{0} d.Blue{0} e.Purple",
                    Environment.NewLine);
                var userAnswer = Console.ReadLine();

                if (userAnswer == "c")
                {
                    correctAnswer = true;
                    Console.WriteLine("Correct! Press Enter to exit...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrongs answer! Please, try again, or press 'q' to quite...");
                    if (userAnswer == "q")
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
