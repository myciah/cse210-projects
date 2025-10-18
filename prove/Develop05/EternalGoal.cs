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