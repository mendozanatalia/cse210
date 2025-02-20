public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congrats, you have earned {_points} points!");
    }

    public override bool isComplete() 
    {
        return false; 
    }
    
    public override string GetStringRepresentation() 
    {
        return $"EternalGoal:{_shortName},{_description},{_points}"; 
    }
}
