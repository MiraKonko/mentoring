using System;
using System.Collections.Generic;

namespace Lesson5_collections__task3
{
    public class StoreData
    {
        public Dictionary<int, string> listOfAvailableMovies = new Dictionary<int, string>
            {
                {1, "Alien" },{2,"Aliens" }, {3, "Back To The Future 1-3" }, {4, "Dark Knight" },
                {5, "La La Lend" }, {6, "Lethal Weapon" }, {7, "Lord Of The Rings 1-3" }, {8, "Psycho" },
                {9, "Star Wars 1-6" }, {10,  "Terminator 1-2" }, {11, "You'll Meet Tall Dark Stranger"}
            };

        List<string> userMovies = new List<string>();

        public void PrintAllAvailableMovies()
        {
            foreach (var movie in listOfAvailableMovies)
            {
                Console.WriteLine(movie);
            }
        }

        public List<string> BuyMovie()
        {
            string userInput = null;
            Console.WriteLine("For buying enter number of movie and press 'enter'. For exiting from buying mode, enter 'q'");
            while (userInput != "q")
            {
                userInput = Console.ReadLine();

                //int userMovie = int.Parse(userInput);
                //if (userMovie == movieNumber)
                //{
                //    foreach (var movieNumber in listOfAvailableMovies.Keys)
                //    {
                //        userMovies = listOfAvailableMovies.Where(m => m.Key == movieNumber).Select(m => m.Value).ToList();
                //    }

                //}

                //else
                //{
                //    Console.WriteLine("Movie with such number not found");
                //}
            }
            return userMovies;
        }


    }
}

