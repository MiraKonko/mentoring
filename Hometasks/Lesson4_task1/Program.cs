using System;

namespace Lesson4_task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] fruits = { "Apple", "avocado", "Banana", "aPricot", "jackfruit", "cherimoya",
                        "papaya", "pineapple", "lime", "lemon", "grape", "orange", "grapefruit", "strawberry" };

            Console.WriteLine("Fruits, which not contain 'ap':");
            foreach (var fruit in fruits)
            {
                if (!(fruit.ToLower().Contains("ap")))
                {
                    Console.WriteLine(fruit);
                }
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
