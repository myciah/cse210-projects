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
        return _laps * 50 / 1000.0 * .62;
    }
}

//The following code was used to test Swim.cs in program.cs
// class Program
// {
//     static void Main(string[] args)
//     {
//         Cycle TS = new Cycle("27 Oct 2025", 60, 2);
//         List<Activity> act = new List<Activity>();
//         act.Add(TS);
//         foreach (Activity a in act)
//         {
//             Console.WriteLine(a.GSummary());
//         }
//     }
// }