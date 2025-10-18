using System;

//class Program
//{
//  static void Main(string[] args)
//{

//}

//}


//Testing CheckListGoal.cs
class program
{
    static void Main()
    {
        CheckListGoal g = new CheckListGoal("Physical", "20 min", 10, 3, 50);
        Console.WriteLine("Created!");
        Console.WriteLine(g.GetDetail());
        Console.WriteLine("Record 1st: ");
        g.RecordEvent();
        Console.WriteLine(g.GetUpdate());
        Console.WriteLine("Recording 2nd: ");
        g.RecordEvent();
        Console.WriteLine(g.GetUpdate());
        Console.WriteLine("Recording 3rd: ");
        g.RecordEvent();
        Console.WriteLine(g.GetUpdate());
        Console.WriteLine("Record 4th (b): ");
        g.RecordEvent();
        Console.WriteLine(g.GetUpdate());
    }
}