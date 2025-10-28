public abstract class Activity
{
    private string _date;
    private int _minutes;
    protected string _activityType;
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public string GDate()
    {
       return _date; 
    }
    public int GMinutes()
    {
        return _minutes;
    }
    public abstract double GDist();
    public virtual double GSpeed()
    {
        return (GDist() / _minutes) * 60;
    }
    public virtual double GPace()
    {
        return _minutes / GDist();
    }
    public virtual string GSummary()
    {
        return ($"{_date} {_activityType} ({_minutes} min)- Distance {GDist():0.0} miles, Speed {GSpeed():0.0} mph, Pace: {GPace():0.0} min per mile");
    }

}