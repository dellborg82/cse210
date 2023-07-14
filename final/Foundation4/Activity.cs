public class Activity{
    protected string _activityName;
    protected string _date;
    protected double _length;

    public Activity(string activityName, string date, double length)
    {
            _date = date;
            _length = length;
            _activityName = activityName;
    }

    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetDate()
    {
        return _date;
    }
    
    public double Getlength()
    {
        return _length;
    }

    
    public virtual double GetDistance()
    {
        return 1;
    }
    public virtual double GetSpeed()
    {
        return 1;
    }
    public virtual double GetPace()
    {
        return 1;
    }
    public string GetSummary()
    {
        double distanceInKm = GetDistance();
        double speedInKph = GetSpeed();
        double paceInMinutesPerKm = GetPace();

        return $"{GetDate()} {GetActivityName()} ({Getlength()} min) - Distance: {distanceInKm:F2} km, Speed: {speedInKph:F2} kph, Pace: {paceInMinutesPerKm:F2} min/km";
    }


    






}