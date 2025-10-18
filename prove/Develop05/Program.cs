using System;

//class Program
//{
//  static void Main(string[] args)
//{

//}

//}


class program
{
    static void Main()
    {
        GoalManager man = new GoalManager();
        SimpleGoal g1 SimpleGoal("Reading", "Read Chapter", 10);
        EternalGoal g2 EternalGoal("Eat Healthy", "Drink Water", 5);
        CheckListGoal g3 CheckListGoal("Exercise", "Leg Day", 15);
        man.AddGoal(g1);
        man.AddGoal(g2);
        man.AddGoal(g3);
        Console.WriteLine("Goals");
        man.DisplayGo();
        man.DisplaySc();
        Console.WriteLine("Recording events");
        man.RecordEvent(1);
        man.RecordEvent(2);
        man.RecordEvent(3);
        man.RecordEvent(3);
        man.RecordEvent(3);
        Console.WriteLine("After Recording");
        man.DisplayGo();
        man.DisplaySc();
        Console.WriteLine("Saving to file");
        man.SaveGo("go.txt");
        Console.WriteLine("Loading goals");
        man.LoadGo("go.txt");
    }
}