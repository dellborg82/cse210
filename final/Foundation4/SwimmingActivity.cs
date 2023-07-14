public class Swimming : Activity
{
    private int _laps;

    public Swimming(string activityName, string date, double length, int laps) : base(activityName, date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Getlength()) * 60.0;
    }

    public override double GetPace()
    {
        return Getlength() / GetDistance();
    }
}