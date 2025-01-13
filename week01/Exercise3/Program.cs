using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----- MAGIC NUMBER GAME -----");

        // User specified number
        // Console.Write("What's the magic number?: ");
        // int magicNumber = int.Parse(Console.ReadLine());

        int guess = -1;

        // Track how many guesses
        int attempts = 0;

        // Loop: Play again (Not working yet)
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            // Random Number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            
            while (guess != magicNumber)
            {
                Console.Write("What's your guess?: ");
                guess = int.Parse(Console.ReadLine());

                attempts += 1;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higuer");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Attempts = {attempts}");
                    Console.WriteLine("----------------------------------");
                }
            }
            
            Console.Write("Do you wanna play again? Yes/No: ");
            string answer = Console.ReadLine();
            playAgain = playAgain.ToLower();
            Console.WriteLine("----------------------------------");
        }
    }
}