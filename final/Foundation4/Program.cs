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
        Run TR = new Run("27 Oct 2025", 45, 5.0);
        List<Activity> act = new List<Activity>();
        act.Add(TR);
        foreach (Activity a in act)
        {
            Console.WriteLine(a.GSummary());
        }
    }
}