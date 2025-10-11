//Code that is meant to save me from writing extra code (code that is to be reused)
public class MindfulnessActivity
{
    public string name;
    public string description;
    public int duration;
    public MindfulnessActivity(string activityName)
    {
        name = activityName;
        description = "Testing";
    }
    public void Start()
    {
        Console.WriteLine($"Welcome to {name} activity.");
        Console.WriteLine(description);
        Console.WriteLine($"In seconds, how long would you like to do this activity for: ");
        duration = Convert.ToInt32(Console.ReadLine());
        //duration = int Console.ReadLine();
        Console.WriteLine("The activity will start soon. Get Ready!!!");
        Thread.Sleep(2000);
    }
    public void End()
    {
        Console.WriteLine("Great Job!");
        Console.WriteLine($"You did {name} activity for {duration} seconds. Well done!");
    }
}