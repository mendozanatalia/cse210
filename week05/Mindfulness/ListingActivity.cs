public class ListingActivity : Activity
{
    public int _count;
    public List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("*** Listing Activity ***");

        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();

        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random r = new Random();

        int index = r.Next(_prompts.Count);
        Console.WriteLine($"\n\t --- {_prompts[index]} --- \n");
    }
}