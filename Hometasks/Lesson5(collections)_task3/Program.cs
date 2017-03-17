using System;

namespace Lesson5_collections__task3
{
    public class Program
    {
        private static bool isUserLoggedIn;
        private static string currentUser;



        public static void Main(string[] args)
        {
            StoreData store = new StoreData();
            store.PrintAllAvailableMovies();
            store.BuyMovie();
            Console.ReadLine();
            //List<string> listOfUsers = new List<string>();

            // Console.WriteLine("Welcome! For the first time here? - use command 'add user' to register. {0} If you already have an account - use command 'login' to sign in. {0} Enter 'Exit' if you want to quit", Environment.NewLine);
            //while (true)
            //{
            //    string userCommand = Console.ReadLine();
            //    switch (userCommand)
            //    {
            //        case "add user":
            //            AddNewUser();
            //            break;
            //        case "login":
            //            Login(listOfUsers, out isUserLoggedIn, out currentUser);
            //            break;
            //        case "exit":
            //            Exit();
            //            break;
            //        default:
            //            Console.WriteLine("Command not found!");
            //            break;
            //    }
            //    if (isUserLoggedIn)
            //    {
            //        Console.WriteLine("For seeing all movies available this week, enter 'see all'");
            //        Console.WriteLine("If you'd like to buy something, enter 'buy'");
            //        Console.WriteLine("For viewing bought stuff, enter 'cart'");
            //        string userAction = Console.ReadLine();
            //        switch (userAction)
            //        {
            //            case "see all":

            //            break;
            //        case "buy":
            //            BuySomeStuff();
            //            break;
            //        case "cart":
            //            ViewCart();
            //            break;
            //        default:
            //            Console.WriteLine("Command not found!");
            //            break;
            //    }
            //}
            //Dictionary<string, string> usersInfo = new Dictionary<string, string>();
            //Console.ReadLine();
            //    }

            //}

            //private static void ViewCart()
            //{
            //    throw new NotImplementedException();
            //}



            //private static void Exit()
            //{
            //    Environment.Exit(0);
            //}

            //private static void Login(List<string> listOfUsers, out bool isUserLoggedIn, out string currentUser)
            //{
            //    Console.WriteLine("Please, enter username ");
            //    isUserLoggedIn = false;
            //    currentUser = null;
            //    while (isUserLoggedIn != true)
            //    {
            //        string userName = Console.ReadLine();
            //        if (listOfUsers.Contains(userName))
            //        {
            //            Console.WriteLine("Login is successful!");
            //            isUserLoggedIn = true;
            //            currentUser = userName;
            //        }
            //        else
            //        {
            //            Console.WriteLine("User not found! Please, try again" /*or enter 'exit' to quit*/);
            //        }
            //    }
            //}

            //private static void AddNewUser(out List<string> listOfUsers)
            //{
            //    Console.WriteLine("Please, enter new username. Please, use only letters, no symbols or blank spaces are allowed");

            //    bool isCorrectFormat = false;
            //    while (isCorrectFormat != true)
            //    {
            //        string newUser = Console.ReadLine();
            //        if (Regex.IsMatch(newUser, @"^[a-zA-Z]+$"))
            //        {
            //            List<string> listOfUsers = null;
            //            listOfUsers.Add(newUser);
            //            isCorrectFormat = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Incorrect format! Use only letters, no symbols or blank spaces are allowed!");
            //        }
            //    }
            //    Console.WriteLine("User is successfully added, please, use 'login' command to sign in");
            //}

            //private static void BuySomeStuff()
            //{
            //    string userPurchase = Console.ReadLine();
            //}

        }
    }
}

