//Code that is meant to save me from writing extra code (code that is to be reused)
public class MindfulnessActivity
{
    public string name;
    public string description;
    public int duration;
    public MindfulnessActivity(string title, string desc)
    {
        name = title;
        description = desc;
    }
    public void ShowSpin(int seconds)
    {
        for (int i = 0; i =< seconds; i++)
        {
            Console.Write('');
            Thread.Sleep(2000);
        }
    }
    public void ShowCount(int seconds)
    {
        for (int i = seconds; i > 0; i++)
        {
            Console.Write(i);
            Thread.Sleep(2000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
        }
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
    public int GetDura()
    {
        return duration;
    }
    public void End()
    {
        Console.WriteLine("Great Job!");
        Console.WriteLine($"You did {name} activity for {duration} seconds. Well done!");
    }
}