using System;

//class Program
//{
//  static void Main(string[] args)
//{

//}

//}


//Testing Goals.cs
class TGoal : Goal
{
    public TGoal(string name, string description, int points)
        : base(name, description, point)
    {
    }
    public override int RecordEvent()
    {
        return_p;
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetUpdate()
    {
        return _n;
    }
    public override string GetDetail()
    {
        return _n + _d + _p;
    }
}

class program
{
    static void Main()
    {
        Goal T = new TGoal("Read Scripture", "Read chapter", 10);
        Console.WriteLine(T.GetDetail())
        Console.WriteLine("Complete: " + T.IsComplete())
        Console.WriteLine("Points:" + T.RecordEvent())
        Console.WriteLine(T.GetUpdate())
    }
}
    