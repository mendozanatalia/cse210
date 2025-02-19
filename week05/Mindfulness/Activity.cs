public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to '{_name} Activity'.");
        Console.WriteLine($"{_description}");

        Console.Write("--> How long in seconds would you like to do this activity?: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGreat! It will be " + _duration + " seconds.");
        ShowSpinner(3);

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood Job!");
        Console.WriteLine($"You have completed another {_duration} seconds of the '{_name} Activity.'");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");

            seconds--;
        }
        Console.Write("\n");
    }

    public void ShowCountdown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1200);
            Console.Write("\b \b");

            seconds--;
        }
    }
}