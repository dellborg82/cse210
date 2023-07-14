public class Running : Activity
{

    private double _distance;

    public Running(string activityName, string date, double length, double distance) : base(activityName, date, length)
    {
        _distance = distance;
        
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return GetDistance() / Getlength() * 60;

    }
    public override double GetPace()
    {
        return Getlength() / GetDistance();
    }
}