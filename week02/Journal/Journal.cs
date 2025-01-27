using System.IO;
using Microsoft.VisualBasic;

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
            // From "Entry.cs"
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompText}|{entry._entryText}");
            }
        }
        Console.WriteLine($"'{filename}' saved!");
    }
    
    public void LoadFromFile(string fileSaved)
    {
        string[] lines = System.IO.File.ReadAllLines(fileSaved);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                Entry entryLoaded = new Entry
                {
                    _date = parts[0],
                    _prompText = parts[1],
                    _entryText = parts[2],
                };
                _entries.Add(entryLoaded);
            }
    }
}