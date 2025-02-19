public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("*** Breathing Activity ***");
        
        int repeater = _duration / 10;

        while (repeater > 0)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(3);

            Console.Write("\nBreathe out... ");
            ShowCountdown(3);

            Console.Write("\n");
            repeater--;
        }

        DisplayEndingMessage();
    }
}