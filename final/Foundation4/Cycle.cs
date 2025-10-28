public class Cycle : Activity
{
    private double _speed;
    public Cycle(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
        _activityType = "Cycling";
    }
    public override double GSpeed()
    {
        return _speed;
    }
    public override double GPace()
    {
        return 60 / _speed;
    }
    public override double GDist()
    {
        return (_speed * GMinutes()) / 60;
    }
}