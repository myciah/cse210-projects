using System;

//class Program
//{
//  static void Main(string[] args)
//{

//}

//}


//Following lines to test EternalGoal.cs
class program
{
    static void Main()
    {
        EternalGoal RS = new EternalGoal("Read Script", "Read every day", 10);
        Console.WriteLine($"Goal Details: {RS.GetDetail()}");
        Console.WriteLine($"Goal Update: {RS.GetUpdate()}");
        Console.WriteLine($"Complete? {RS.IsComplete()}");
        Console.WriteLine("Recording....");
        int EP = RS.RecordEvent();
        Console.WriteLine($"Earned: {EP}")
        Console.WriteLine("After Event: ")
        Console.WriteLine("Update {RS.getUpdate()}");
        Console.WriteLine($"Complete? {RS.IsComplete()}");
        Console.WriteLine("Test again...");
        RS.RecordEvent();
        Console.WriteLine($"Complete x2? (RS.IsComplete())");
    }
}