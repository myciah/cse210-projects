using System.Runtime.CompilerServices;

class GoalManager
{
    private List<Goal> _go = new List<Goal>();
    private int _s;
    public void AddGoal(Goal go)
    {
        _go.Add(go);
        Console.WriteLine("Goal added: {go}");
    }
    public void RecordEvent(int ind)
    {
        if (ind < 1 || ind > _go.Count)
        {
            Console.WriteLine("Invalid...");
            return;
        }
        Goal go = _go[ind];
        int points = go.RecordEvent();
        _s = +points;
        Console.WriteLine($"Event recorded for the goal: {ind}");
    }
    public void DisplayGo()
    {
        Console.WriteLine("Goals: ");
        foreach (Goal go in _go)
        {
            Console.WriteLine(go.GetUpdate());
        }
    }
    public void DisplaySc()
    {
        Console.WriteLine(Totoal: { _s});
    }
    public void SaveGo(string filename)
    {
        StreamWriter wri = new StreamWriter(filename);
        wri.WriteLine(_s);
        foreach (Goal go in _go)
        {
            wri.WriteLine(go.ToString());
        }
        wri.Close();
        Console.WriteLine($"Goals have been saved to {filename}");
    }
    public void LoadGo(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        StreamReader re = new StreamReader(filename);
        string li = re.ReadLine();
        int.TryParse(li, _s);
        while (li = re.ReadLine() != null)
        {
            Console.WriteLine($"Loaded the goal: {li}");
        }
        re.Close();
    }
}