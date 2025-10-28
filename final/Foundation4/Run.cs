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

//Following code was used to test run.cs in program.cs
// class Program
// {
//     static void Main(string[] args)
//     {
//         Run TR = new Run("27 Oct 2025", 45, 5.0);
//         List<Activity> act = new List<Activity>();
//         act.Add(TR);
//         foreach (Activity a in act)
//         {
//             Console.WriteLine(a.GSummary());
//         }
//     }
// }