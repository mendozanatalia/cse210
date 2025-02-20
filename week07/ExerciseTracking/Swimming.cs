public class Swimming : Activity
{
    private int _laps;

    public Swimming(string name, int length, int laps) : base(name, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps;
    }

    public override double GetSpeed()
    {
        // Distance (km) = swimming laps * 50 / 1000
        double d = _laps * 50 / 1000.0;
        // Speed (kph) = (distance / minutes) * 60
        return (d / GetLength()) * 60;
    }

    public override double GetPace()
    {
        // Distance (km) = swimming laps * 50 / 1000
        double d = (_laps * 50) / 1000.0;
        // Pace (min per km)= minutes / distance
        return GetLength() / d;
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} {this.GetType().Name} ({GetLength()} min): Distance {GetDistance()} laps, Speed: {GetSpeed(): 0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}