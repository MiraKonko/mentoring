using System;
using System.Collections.Generic;

namespace Lesson5_collections__task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //V 1
            //string[] testArray = { "Frodo", "Sam", "Gandalf", "Legolas", "Gimli", "Aragorn", "Boromir", "Merry", "Pippin" };
            //int arrayLength = testArray.Length;
            //bool endLoop = false;
            //int userNumber = 0;

            //Console.WriteLine("Please, enter number of last array values to display");
            //while (!endLoop)
            //{
            //    var userInput = Console.ReadLine();

            //    if (int.TryParse(userInput, out userNumber) && userNumber <= arrayLength
            //                                                  && userNumber > 0)
            //    {
            //        OutputArrayByIndex(testArray, userNumber);
            //        endLoop = true;
            //    }
            //    else if (int.TryParse(userInput, out userNumber) && (userNumber > arrayLength
            //                                                      || userNumber <= 0))
            //    {
            //        Console.WriteLine("Number is out of array's length range! Please, use number from 1 to 9 , or press 'q' to quite...");
            //        if (userInput == "q")
            //        {
            //            Environment.Exit(0);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong input! Please, try again, or press 'q' to quite...");
            //        if (userInput == "q")
            //        {
            //            Environment.Exit(0);
            //        }
            //    }
            //}
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();

            //V 2
            Console.WriteLine("Please, enter values to array. {0} Press 'Enter' to submit value. {0} Submit empty value to finish", Environment.NewLine);
            string userInput;
            string[] userArray = GetUserArray();
            Console.WriteLine("Please, enter number of last array values to display");

            bool endLoop = false;
            while (!endLoop)
            {
                int userNumber = 0;
                userInput = Console.ReadLine();

                if (Int32.TryParse(userInput, out userNumber) && userNumber <= userArray.Length
                                                              && userNumber > 0)
                {
                    OutputArrayByIndex(userArray, userNumber);
                    endLoop = true;
                }
                else if (Int32.TryParse(userInput, out userNumber) && (userNumber > userArray.Length
                                                                   || userNumber <= 0))
                {
                    Console.WriteLine("Number is out of array range! Please, try again, or press 'q' to quite...");
                    if (userInput == "q")
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input! Please, try again, or press 'q' to quite...");
                    if (userInput == "q")
                    {
                        Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void OutputArrayByIndex(string[] testArray, int userNumber)
        {
            var index = testArray.Length - userNumber;
            for (int i = index; i < testArray.Length; i++)
            {
                Console.WriteLine(testArray.GetValue(i));
            }
        }

        private static string[] GetUserArray()
        {
            string userInput = Console.ReadLine();
            List<string> userList = new List<string> { userInput };
            bool isInputEmpty = false;

            while (!isInputEmpty)
            {
                userInput = Console.ReadLine();
                if (userInput != "")
                {
                    userList.Add(userInput);
                }
                else
                {
                    isInputEmpty = true;
                }
            }

            string[] userArray = userList.ToArray();
            return userArray;
        }
    }
}

