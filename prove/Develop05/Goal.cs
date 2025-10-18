abstract class Goal
{
    protected string _n;
    protected string _d;
    protected int _p;
    public Goal(string name, string description, int points)
    {
        _n = name;
        _d = description;
        _p = points;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetUpdate();
    public abstract string GetDetail();
}


//The following lines of code are the ones that I used to test in program.cs to see if the goals.cs code functions as supposed to.
// class TGoal : Goal
// {
//     public TGoal(string name, string description, int points)
//         : base(name, description, points)
//     {
//     }
//     public override int RecordEvent()
//     {
//         return _p;
//     }
//     public override bool IsComplete()
//     {
//         return true;
//     }
//     public override string GetUpdate()
//     {
//         return _n;
//     }
//     public override string GetDetail()
//     {
//         return _n + _d + _p;
//     }
// }

// class program
// {
//     static void Main()
//     {
//         Goal T = new TGoal("Read Scripture", "Read chapter", 10);
//         Console.WriteLine(T.GetDetail());
//         Console.WriteLine("Complete: " + T.IsComplete());
//         Console.WriteLine("Points:" + T.RecordEvent());
//         Console.WriteLine(T.GetUpdate());
//     }
// }
    