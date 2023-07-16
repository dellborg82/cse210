public abstract class Activity{
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

    
    public abstract double GetDistance();
   
    public abstract double GetSpeed();
    
    public abstract double GetPace();
    
    public string GetSummary()
    {
        double distanceInMiles = GetDistance();
        double speedInMPH = GetSpeed();
        double paceInMinutesPerMile = GetPace();

        return $"Date of Actvitiy: {GetDate()}, Actvity Name: {GetActivityName()}, Length of Activity: ({Getlength()} min) - Total Distance during Actvity: {distanceInMiles:F2} Miles, With a Speed of: {speedInMPH:F2} MPH, With a Pace of: {paceInMinutesPerMile:F2} min/Mile";
    }
}