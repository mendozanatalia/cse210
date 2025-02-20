public class Running : Activity
{
    private double _distance;

    public Running(string name, int length, double distance) : base(name, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // Speed (mph) = (distance / minutes) * 60
        return (_distance / GetLength()) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per km)= minutes / distance
        return GetLength() / _distance;
    }
}