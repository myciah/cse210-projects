public class Swim : Activity
{
    private int _laps;
    public Swim(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
        _activityType = "Swimming";
    }
    public override double GDist()
    {
        return _laps * 50 / 1000 * .62;
    }
}