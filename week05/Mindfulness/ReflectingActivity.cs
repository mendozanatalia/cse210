public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting", "This  activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("*** Reflecting Activity ***");

        int repeater = _duration / 5;

        Console.WriteLine("Consider the following prompt: ");
        DisplayPrompt();
        Console.Write("--> When you have something in mind, press enter to continue: ");
        Console.ReadLine();
        Console.WriteLine("--> Now ponder on each of the following questions as they related to the experience: ");
        Console.Write("You may begin in... ");
        ShowCountdown(5);
        Console.Clear();

        while (repeater > 0)
        {
            DisplayQuestions();
            ShowSpinner(5);
            repeater--;
        }
        
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random r = new Random();

        int index = r.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random r = new Random();

        int index = r.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n\t --- '{prompt}' --- \n");
    }

    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.Write($"\n> {question} ");
    }
}