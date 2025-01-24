public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // Methods
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            // Use the Display method from "Entry.cs"
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("Journal SAVED.");
    }
    
    public void LoadFromFile()
    {
        Console.WriteLine("Journal LOADED");
    }
}