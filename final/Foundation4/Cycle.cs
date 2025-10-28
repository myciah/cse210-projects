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

//The following code was usded to test Cycle.cs in program.cs
// class Program
// {
//     static void Main(string[] args)
//     {
//         Cycle TC = new Cycle("27 Oct 2025", 45, 13.0);
//         List<Activity> act = new List<Activity>();
//         act.Add(TC);
//         foreach (Activity a in act)
//         {
//             Console.WriteLine(a.GSummary());
//         }
//     }
// }