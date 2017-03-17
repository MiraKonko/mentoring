using System;

namespace Lesson4_task6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 35; i <= 87; i++)
            {
                if (i == 71)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
