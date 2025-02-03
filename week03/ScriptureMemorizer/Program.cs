using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------ Welcome to the SCRIPTURE MEMORIZER ------");

        //SHOWING CREATIVITY: Create a Scriptures list to choose randomly
        List<Scripture> scriptures = new List<Scripture>{
            new Scripture(new Reference("Genesis", 1, 27), "So God created man in his own image, in the image of God created he him; male and female created he them."),
            new Scripture(new Reference("Psalm", 24, 3, 4), "Who shall ascend into the hill of the Lord? or who shall stand in his holy place? He that hath clean hands, and a pure heart; who hath not lifted up his soul unto vanity, nor sworn deceitfully."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Matthew", 5, 14, 16), "Ye are the light of the world. A city that is set on an hill cannot be hid... Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."),
            new Scripture(new Reference("John", 3, 5), "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God."),
            new Scripture(new Reference("Acts", 3, 19), "Repent ye therefore, and be converted, that your sins may be blotted out, when the times of refreshing shall come from the presence of the Lord."),
            new Scripture(new Reference("James", 1, 15), "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him."),
        };

        // Choose a random scripture from the list
        Random r = new Random();
        Scripture scp = scriptures[r.Next(scriptures.Count)];

        Console.WriteLine("-------------------------------------------------");

        // Start hidding the words
        while (!scp.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scp.GetDisplayText());
            Console.Write("--> Press ENTER key to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            scp.HideRandomWords(1);
        }

        // Once all words are hidden:
        Console.Clear();
        Console.WriteLine(scp.GetDisplayText());
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Congratulations! You have completed the scripture.");
    }
}