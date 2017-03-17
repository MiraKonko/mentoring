using System;
using System.Linq;

namespace Lesson5_collections__task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //V 1
            Console.WriteLine("Please, add values to array, use ',' as separator. Press 'Enter' to submit values");
            var userInput = Console.ReadLine();
            var userArray = userInput.Split(',').ToArray();

            Console.WriteLine("Press Enter to display array");
            Console.ReadLine();

            DisplayArray(userArray);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            // V 2
            //Console.WriteLine("Please, enter values to array. {0} Press 'Enter' to submit value. {0} Submit empty value to finish", Environment.NewLine);
            //string userInput = null;
            //List<string> userList = new List<string>();

            //while (userInput != "")
            //{
            //    userInput = Console.ReadLine();
            //    userList.Add(userInput);
            //}

            //var userArray = userList.ToArray();
            //Console.WriteLine("Press Enter to display array");
            //Console.ReadLine();

            //DisplayArray(userArray);
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();

        }
        public static void DisplayArray(string[] userArray)
        {
            foreach (var item in userArray)
            {
                Console.WriteLine(item.Trim());
            }
        }
    }
}
