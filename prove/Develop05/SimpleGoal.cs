class SimpleGoal : Goal
{
    private bool _c;
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _c = false;
    }
    public override int RecordEvent()
    {
        _c = true;
        Console.WriteLine($"Goal Complete!! {_p} points");
        return _p;
    }
    public override bool IsComplete()
    {
        return _c;
    }
    public override string GetUpdate()
    {
        if (_c == true)
        {
            return ($"[X] {_n}");
        }
        else
        {
            return ($"[] {_n}");
        }
    }
    public override string GetDetail()
    {
        return ($"{_n} - {_d} {_p} pts");
    }
}




//The Following code was used to test if SimpleGoal.cs in program.cs functioned as it was supposed to.
// class program
// {
//     static void Main()
//     {
//         SimpleGoal SGoal = new SimpleGoal("Read Scriptures", "Read chapter today", 10);
//         Console.WriteLine("Goal Detail: ");
//         Console.WriteLine(SGoal.GetDetail());
//         Console.WriteLine($"Goal Complete? {SGoal.IsComplete()}");
//         int PE = SGoal.RecordEvent();
//         Console.WriteLine($"Points: {PE}");
//         Console.WriteLine($"Is goal complete? {SGoal.IsComplete()}");
//         Console.WriteLine($"Goal Update: {SGoal.GetUpdate()}");
//     }
// }