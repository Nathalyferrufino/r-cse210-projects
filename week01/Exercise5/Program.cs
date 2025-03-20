using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMesage ();
        
        string UserName = AskUsersName ();
        int usersNumber = AsUsersNumber ();

        int squaredNumber = SquaredNumber(usersNumber);

        Result(UserName, squaredNumber);

        static void WelcomeMesage ()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string AskUsersName ()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine ();

            return name;
        }

        static int AsUsersNumber ()
        {
            Console.Write ("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine ());

            return number;
        }

        static int SquaredNumber (int number)
        {
            int squared = number * number;

            return squared;
        }

        static void Result (string name, int squared)
        {
            Console.WriteLine ($"{name}, the square of your number is {squared}");
        }

    }
}