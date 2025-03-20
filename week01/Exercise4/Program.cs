using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine ("Enter a list of numbers, type 0 when finished");
        int addedNumbers = (-1);
        List<int> numbers = new List<int>();

        while (addedNumbers != 0)
        {
            Console.Write ("Enter number:  "); 
            addedNumbers = int.Parse (Console.ReadLine());
            numbers.Add(addedNumbers);
        }
      //  Console.WriteLine (numbers.Count);

        int sum = 0;
        foreach (int number in numbers)
        {
           sum += number;
        }

        Console.WriteLine ($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine ($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        
        Console.WriteLine ($"The largest number is: {max}");
    }
}