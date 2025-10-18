class CheckListGoal : Goal
{
    private int _TargetC;
    private int _CurrentC;
    private int _b;
    public CheckListGoal(string name, string description, int points, int TC, int bounus)
        : base(name, description, points)
    {
        _TargetC = TC;
        _CurrentC = 1;
        _b = bounus;
    }
    public override int RecordEvent()
    {
        if (_CurrentC > _TargetC)
        {
            Console.WriteLine("Finished");
            return 0;
        }
        _CurrentC++;
        if (_CurrentC == _TargetC)
        {
            Console.WriteLine($"Checklist goal complete. Bonus: {_b} pts");
            return _p + _b;
        }
        Console.WriteLine($"Progress recorded! {_p}");
        return _p
    }
    public override bool IsComplete()
    {
        return _CurrentC == _TargetC;
    }
    public override string GetUpdate()
    {
        return ($"{_CurrentC} / {_TargetC} {_n}");
    }
    public override string GetDetail()
    {
        return ($"{_n} - {_d} {_p} pts");
    }
}