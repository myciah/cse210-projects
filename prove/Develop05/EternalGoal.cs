class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"Eternal Goal is recorded!! {_p} points");
        return _p;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetUpdate()
    {
        return ($"[X] {_n}");
    }
    public override string GetDetail()
    {
        return ($"{_n} - {_d} {_p} pts");
    }
}


//The following lines of code are the ones that I used to test in program.cs to see if the EternalGoal.cs code functions as supposed to.
// class program
// {
//     static void Main()
//     {
//         EternalGoal RS = new EternalGoal("Read Script", "Read every day", 10);
//         Console.WriteLine($"Goal Details: {RS.GetDetail()}");
//         Console.WriteLine($"Goal Update: {RS.GetUpdate()}");
//         Console.WriteLine($"Complete? {RS.IsComplete()}");
//         Console.WriteLine("Recording....");
//         int EP = RS.RecordEvent();
//         Console.WriteLine($"Earned: {EP}");
//         Console.WriteLine("After Event: ");
//         Console.WriteLine($"Update {RS.GetUpdate()}");
//         Console.WriteLine($"Complete? {RS.IsComplete()}");
//         Console.WriteLine("Test again...");
//         RS.RecordEvent();
//         Console.WriteLine($"Complete x2? {RS.IsComplete()}");
//     }
// }