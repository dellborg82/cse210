public class BikeActivity : Activity
{

    private double _speed;

    public BikeActivity(string activityName, string date, double length, double Speed) : base(activityName, date, length)
    {
        _speed = Speed;        
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return GetSpeed() * (Getlength() / 60);
    }
    public override double GetPace()
    {
        return Getlength() / GetDistance();
    }
}