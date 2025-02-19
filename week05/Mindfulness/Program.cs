using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();

        // Menu
        while (running)
        {
            Console.Clear();
            Console.WriteLine("*** Welcome to the Mindfulness App ***\nPlease select an activity: \n   1. Breathing \n   2. Reflecting \n   3. Listing \n   4. Quit");
            Console.Write("--> Your choice: ");
            int r = int.Parse(Console.ReadLine());

            switch (r)
            {
                case 1:
                    breathing.Run();
                    break;
                case 2:
                    reflecting.Run();
                    break;
                case 3:
                    listing.Run();
                    break;
                case 4:
                    running = false;
                    Console.WriteLine("OK! See you next time!");
                    break;
            }
        }
    }
}