using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RevertString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter some string");
            var userInput = Console.ReadLine();
            var reversedString = ReverseString(userInput);
            Console.WriteLine("Reversed string: " + reversedString);
            Console.ReadLine();
        }

        public static string ReverseString(string userInput)
        {
            var splitString = userInput.ToCharArray().ToList();
            List<char> reversedList = new List<char>();

            for (int i = splitString.Count - 1; i >= 0; i--)
            {
                reversedList.Add(splitString.ElementAt(i));
            }
            StringBuilder reversedString = new StringBuilder();
            foreach (var st in reversedList)
            {
                reversedString.Append(st);
            }
            return reversedString.ToString();
        }
    }
}
