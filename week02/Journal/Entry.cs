public class Entry
{
    // Atributtes
    public string _date;
    public string _prompText;
    public string _entryText;

    // Methods
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompText}");
        Console.WriteLine($"'{_entryText}'");
        Console.WriteLine("------------------------------");
    }
}