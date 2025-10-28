public class Run : Activity
{
    private double _dist;

    public Run(string date, int minutes, double dist)
        : base(date, minutes)
    {
        _dist = dist;
        _activityType = "Running";
    }
    public override double GDist()
    {
        return _dist;
    }
}