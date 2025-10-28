using System;

 class Program
 {
     static void Main(string[] args)
     {
        List<Activity> act = new List<Activity>();
        act.Add(new Run("01 Jan 2023", 45, 3.5));
        act.Add(new Cycle("02 Feb 2024", 60, 14));
        act.Add(new Swim("03 Mar 2025", 75, 5));

        foreach (Activity ac in act)
        {
            Console.WriteLine();
            Console.WriteLine(ac.GSummary());
            Console.WriteLine();
        }
     }
 }

