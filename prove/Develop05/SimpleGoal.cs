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
        Console.WriteLine($"Goal Complete!! {points} points");
        return points;
    }
    public override bool IsComplete()
    {
        return c;
    }
    public override string GetUpdate()
    {
        if (_c = true)
        {
            return ($"[X] {name}")
        }
        else
        {
            return ($"[] {name}")
        }
    }
    public override string GetDetail()
    {
        ($"{name} - {description} {points} pts");
    }
}