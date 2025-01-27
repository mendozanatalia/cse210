using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the Journal
        Journal journal = new Journal();
        // Call the Prompt Generator
        PromptGenerator promptGenerator = new PromptGenerator();


        // ACTION MENU
        // Using while to restart the menu until the user select QUIT
        while (true)
        {
            Console.WriteLine("--------- JOURNAL MENU ---------");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What do you want to do? (1-5): ");

            string choice = Console.ReadLine();

            Console.WriteLine("------------------------------");

            switch (choice)
            {
                // 1. Write
                case "1":                    
                    // Random Prompt
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    // User Entry
                    Console.Write("--> ");
                    string entry = Console.ReadLine();
                    
                    Entry userEntry = new Entry()
                    {
                        _date = DateTime.Now.ToString("mm/dd/yyyy"),
                        _prompText = prompt,
                        _entryText = entry
                    };
                    // Add the entry to the journal
                    journal.AddEntry(userEntry);
                    break;

                // 2. Display
                case "2":                
                    journal.DisplayAll();
                    break;

                // 3. Load
                case "3":
                    Console.WriteLine("What is the filename?: ");
                    Console.Write("--> ");
                    string fileSaved = Console.ReadLine();
                    journal.LoadFromFile(fileSaved);

                    break;

                // 4. Save
                case "4":
                    Console.WriteLine("What is the filename?: ");
                    Console.Write("--> ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);

                    break;

                // 5. Quit
                case "5":
                    Console.WriteLine("OK! Bye bye :D");
                    return;

                // Handle invalid choice
                default:
                    Console.WriteLine("Invalid. Choose a number from 1 to 5.");

                    break;
            }
        }

    }
}