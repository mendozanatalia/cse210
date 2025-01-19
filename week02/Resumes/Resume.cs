// Responsibilities: Keeps track of the person's name and a list of their jobs.
// Behaviors: Displays the resume, which shows the name first, followed by displaying each one of the jobs.

public  class Resume
{
    // Attributtes
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Methods  
    public void Display()
    {
        // Output
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate trough jobs list
        foreach (Job job in _jobs)
        {
            // Call the Display() method from Job class
            job.Display();
        }
    }
}