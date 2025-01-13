using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What's your grade percentage?: ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        // Core Requirements
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge: Sign

        int remainder = percent % 10;
        string sign = "";

        if (letter != "F")
        {
            if (remainder >= 7)
            {
                sign = "+";
            }
            else if (remainder < 3)
            {
                sign = "-";
            }
            else
            {
                sign = null;
            }
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("Congrats... You passed!");
        }
        else
        {
            Console.WriteLine("Try hard the next time...");
        }
    }
}