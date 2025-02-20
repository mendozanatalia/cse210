public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;

        while (running)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit");
            Console.Write("--> Your selection: ");
            int r = int.Parse(Console.ReadLine());

            switch (r)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("OK, bye bye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Choose one from the menu.");
                    break;
            }
        }
    }
    
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Your current score is: {_score}");
        Console.WriteLine(new string('-', 30));
    }
    
    public void ListGoalNames()
    {
        int i = 1;

        foreach (Goal g in _goals)
        {
            Console.WriteLine($"\t{i}. {g._shortName}");
            i++;
        }
    }
    
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        int i = 1;

        foreach (Goal g in _goals)
        {
            Console.WriteLine($"\t{i}. [{(g.isComplete() ? "X" : " ")}] {g.GetDetailsString()}");
            i++;
        }
    }
    
    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of goals are: \n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. CheckList Goal");
        Console.Write("--> Which type of goal would you like to create?: ");
        int r = int.Parse(Console.ReadLine());

        Console.Write("--> What is the name of your goal?: ");
        string name = Console.ReadLine();

        Console.Write("--> What is a short description of it?: ");
        string description = Console.ReadLine();

        Console.Write("--> What is the amount of points associated with this goal?: ");
        string points = Console.ReadLine();

        switch (r)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("--> How many times does this goal need to be acomplished for a bonus?: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("--> What is the bonus for acomplishing in that many times?: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new CheckListGoal(name, description, points, target, bonus));
                break;
        }
    }
    
    public void RecordEvent()
    {
        Console.WriteLine("Goals List:");
        ListGoalNames();

        Console.Write("--> Which goal have you completed?: ");
        int r = int.Parse(Console.ReadLine());

        if (_goals[r - 1].isComplete())
        {
            Console.WriteLine("This goal has already been completed");
            return;
        }
        _goals[r - 1].RecordEvent();
        _score += int.Parse(_goals[r - 1]._points);
    }

    public void SaveGoals()
    {
        Console.Write("--> What will be the name of the file?: ");
        string path = Console.ReadLine();
        
        StreamWriter sw = new StreamWriter(path);
        sw.WriteLine(_score);
        
        foreach (Goal g in _goals)
        {
            sw.WriteLine(g.GetStringRepresentation());
        }
        sw.Close();
    }
    
    public void LoadGoals()
    {
        Console.Write("--> What is the filename?: ");
        string path = Console.ReadLine();
        StreamReader sr = new StreamReader(path);
        _score = int.Parse(sr.ReadLine());

        _goals.Clear();
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            string[] parts = line.Split(':');
            string[] goalParts = parts[1].Split(',');
            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(goalParts[0], goalParts[1], goalParts[2], bool.Parse(goalParts[3])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(goalParts[0], goalParts[1], goalParts[2]));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new CheckListGoal(goalParts[0], goalParts[1], goalParts[2], int.Parse(goalParts[3]), int.Parse(goalParts[4]), int.Parse(goalParts[5])));
                    break;
            }
        }
        sr.Close();
    }
}