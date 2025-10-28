public abstract class Activity
{
    private string _date;
    private int _minutes;
    protected string _activityType;
    public Activity(string date, string _minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public string GDate()
    {
       return date; 
    }
    public int GMinutes()
    return minutes;
    public abstract double GDist();
    public virtual double GSpee()
    {
        return (GDist() / _minutes) * 60;
    }
    public virtual double GPace()
    {
        return _minutes / GDist();
    }
    public virtual string GSummary()
    {
        
    }

}