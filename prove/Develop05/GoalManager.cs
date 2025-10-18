class GoalManager
{
    private List<Goal> _go = new List<Goal>();
    private int _s;
    public void AddGoal(Goal go)
    {
        _go.Add(go);
        //Console.WriteLine("Goal added: {go}");
    }
    public void RecordEvent(int ind)
    {
        if (ind < 1 || ind > _go.Count)
        {
            Console.WriteLine("Invalid...");
            return;
        }
        int poi = _go[ind - 1].RecordEvent();
        _s = _s + poi;
        // Goal go = _go[ind];
        // int points = go.RecordEvent();
        // _s = +points;
        // Console.WriteLine($"Event recorded for the goal: {ind}");
    }
    public void DisplayGo()
    {
        Console.WriteLine("Goals: ");
        for (int i = 0; i < _go.Count; i++)
        {
            Console.WriteLine($"{i + 1} . {_go[i].GetUpdate()}");
        }
        // foreach (Goal go in _go)
        // {
        //     Console.WriteLine(go.GetUpdate());
        // }
    }
    public void DisplaySc()
    {
        Console.WriteLine($"Totoal: {_s}");
    }
    public void SaveGo(string filename)
    {
        StreamWriter wri = new StreamWriter(filename);
        wri.WriteLine(_s);
        for (int i = 0; i < _go.Count; i++)
        {
            wri.WriteLine(_go[i].GetDetail());
        }
        // foreach (Goal go in _go)
        // {
        //     wri.WriteLine(go.ToString());
        // }
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
        int.TryParse(li, out _s);
        while ((li = re.ReadLine()) != null)
        {
            Console.WriteLine($"Loaded the goal: {li}");
        }
        re.Close();
    }
}


//The following lines of code are the ones that I used to test in program.cs to see if the GoalManager.cs code functions as supposed to.
// class program
// {
//     static void Main()
//     {
//         GoalManager man = new GoalManager();
//         SimpleGoal g1 = new SimpleGoal("Reading", "Read Chapter", 10);
//         EternalGoal g2 = new EternalGoal("Eat Healthy", "Drink Water", 5);
//         CheckListGoal g3 = new CheckListGoal("Exercise", "Leg Day", 15, 3, 40);
//         man.AddGoal(g1);
//         man.AddGoal(g2);
//         man.AddGoal(g3);
//         Console.WriteLine("Goals");
//         man.DisplayGo();
//         man.DisplaySc();
//         Console.WriteLine("Recording events");
//         man.RecordEvent(1);
//         man.RecordEvent(2);
//         man.RecordEvent(3);
//         man.RecordEvent(3);
//         man.RecordEvent(3);
//         Console.WriteLine("After Recording");
//         man.DisplayGo();
//         man.DisplaySc();
//         Console.WriteLine("Saving to file");
//         man.SaveGo("go.txt");
//         Console.WriteLine("Loading goals");
//         man.LoadGo("go.txt");
//     }
// }