//Code that is meant to save me from writing extra code (code that is to be reused)
public class MindfulnessActivity
{
    public string name;
    public string description;
    public int duration;
    public void Start
    {
        Console.WriteLine($"Welcome to {name} activity.")
        Console.WriteLine(description);
        Console.WriteLine($"In seconds, how long would you like to do this activity for: ");
        duration = int Console.ReadLine();
    Console.WriteLine("The activity will start soon. Get Ready!!!");
    }
    public void End
    {
        Console.WriteLine("Great Job!");
        Console.WriteLine($"You did {name} activity for {duration} seconds. Well done!")
    }
}