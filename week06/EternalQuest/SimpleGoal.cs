public class SimpleGoal : Goal
{
    public bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congrats, you have earned {_points} points!");

    }

    public override bool isComplete() 
    { 
        return _isComplete; 
    }
    
    public override string GetStringRepresentation() 
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}"; 
    }
}
