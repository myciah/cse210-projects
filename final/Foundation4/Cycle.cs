public class Cycle : Activity
{
    private double _Speed;
    public Cycle(string date, int minutes, double speed)
        : base(date.minutes)
    {
        _speed = speed;
        _activityType = "Cycling";
    }
    public override double GSpeed()
    {
        return _Speed;
    }
    public override double GPace()
    {
        return 60 / _Speed;
    }
    public override double GDist()
    {
        return (_Speed * GMinutes()) \ 60;
    }
}