public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public CheckListGoal(string name, string description, string points, int bonus, int target, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congrats, you have earned {_points} points and a bonus of {_bonus} points!");
        }
        else
        {
            Console.WriteLine($"Congrats, you have earned {_points} points!");
        }
    }
    
    public override bool isComplete()
    {
       return _amountCompleted >= _target;
    }

    public override string GetDetailsString() 
    { 
        return $"{_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation() 
    { 
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}