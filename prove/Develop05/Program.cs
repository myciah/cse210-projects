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
        SimpleGoal SGoal = new SimpleGoal("Read Scriptures", "Read chapter today", 10)
        Console.Write("Goal Detail: ");
        Console.Write(SGoal.GetDetail());
        Console.Write($"Goal Complete? {SGoal.IsComplete()}");
        int PE = SGoal.RecordEvent();
        Console.Write($"Points: {PE}");
        Console.Write($"Is goal complete? {SGoal.IsComplete()}");
        Console.Write($"Goal Update: {SGoal.GetUpdate()}");
    }
}