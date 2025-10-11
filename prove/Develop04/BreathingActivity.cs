//Breathing Activity (Breath in.... , Breath out.....)
public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by helping you breath in and out for certain periods of time.")
    {
    }
    public void Running()
    {
        Start();
        int time = 0;
        while (time < GetDura())
        {
            Console.WriteLine("Breath in...");
            ShowCount(5);
            Console.WriteLine("Breathe out...");
            ShowCount(5);
            time += 10;
        }
        End();
    }
    
}

