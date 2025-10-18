class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"Eternal Goal is recorded!! {_p} points");
        return points;
    }
    public override bool IsComplete()
    {
        return isComplete;
    }
    public override string GetUpdate();
    {
        return ($"[X] {_n}");
    }
    public override string GetDetail()
    {
        return ($"{name} - {description} {points} pts");
    }
}}