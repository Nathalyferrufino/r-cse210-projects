using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        // Console.Write ("What is the magic number? ");
        // int magicNumber = int.Parse (Console.ReadLine());

        Random randomNumber = new Random ();
        int number = randomNumber.Next (1, 100);

        int guess = -1;
        int attempts = 0;

        while (guess != number)
        {

            Console.Write ("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine ("Higher");
                attempts++;
            }

            else if (number < guess)
            {
                Console.WriteLine ("Lower");
                attempts++;
            }

            else
            {
                Console.WriteLine ("You guessed it!");
            }

        }

        Console.WriteLine ($"You did {attempts}!");
    }
}