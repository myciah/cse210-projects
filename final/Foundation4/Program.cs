using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation4 World!");
//     }
// }

//Following code to test run.cs
class Program
{
    static void Main(string[] args)
    {
        Cycle TS = new Cycle("27 Oct 2025", 60, 2);
        List<Activity> act = new List<Activity>();
        act.Add(TS);
        foreach (Activity a in act)
        {
            Console.WriteLine(a.GSummary());
        }
    }
}