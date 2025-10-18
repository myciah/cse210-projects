using System;

//class Program
//{
//  static void Main(string[] args)
//{

//}

//}


//Folowing code used to test if SimpleGoal.cs works
class program
{
    static void Main()
    {
        SimpleGoal SGoal = new SimpleGoal("Read Scriptures", "Read chapter today", 10);
        Console.WriteLine("Goal Detail: ");
        Console.WriteLine(SGoal.GetDetail());
        Console.WriteLine($"Goal Complete? {SGoal.IsComplete()}");
        int PE = SGoal.RecordEvent();
        Console.WriteLine($"Points: {PE}");
        Console.WriteLine($"Is goal complete? {SGoal.IsComplete()}");
        Console.WriteLine($"Goal Update: {SGoal.GetUpdate()}");
    }
}