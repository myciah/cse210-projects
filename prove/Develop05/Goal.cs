abstract class Goal
{
    protected string _n;
    protected string _d;
    protected int _p;
    public Goal(string name, string description int points)
    {
        _n = name;
        _d = description;
        _P = points;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete()
    public abstract string GetUpdate();
    public abstract string GetDetail();
}