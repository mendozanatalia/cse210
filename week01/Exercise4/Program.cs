using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("------------- LIST -------------");
        Console.WriteLine("--> INSTRUCTION: Enter a list of numbers, type 0 when finished.");

        // Make the list
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Sum
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        // Average
        float average = ((float)sum) / numbers.Count;

        // Largest number
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        // Smallest positive number
        int smallest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (number < smallest)
                {
                    smallest = number;
                }
            }
        }

        // Output
        Console.WriteLine("----------------------");
        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Average = {average}");
        Console.WriteLine($"Largest number = {largest}");
        Console.WriteLine($"Smallest positive number = {smallest}");
        Console.WriteLine("----------------------");
    }
}