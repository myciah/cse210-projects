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