public abstract class Activity
{
    private string _name;
    private DateTime _date;
    private int _length;

    public Activity(string name, int length)
    {
        _name = name;
        _date = DateTime.Now;
        _length = length;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name} ({_length} min): Distance {GetDistance(): 0.0} km, Speed: {GetSpeed(): 0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}