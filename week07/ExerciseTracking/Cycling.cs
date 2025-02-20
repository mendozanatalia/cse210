public class Cycling : Activity
{
    private double _speed;

    public Cycling(string name, int length, double speed) : base(name, length)
    {
        _speed = speed;
    }
    
    public override double GetDistance()
    {
        // Distance (km) = (speed * minutes) / 60
        return (_speed * GetLength()) / 60;
    }

    public override double GetSpeed()
    {
        // Speed = 60 / pace
        return _speed;
    }

    public override double GetPace()
    {
        // Pace = 60 / speed
        return 60 / _speed;
    }
}