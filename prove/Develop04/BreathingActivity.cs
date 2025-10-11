//Breathing Activity (Breath in.... , Breath out.....)
public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by helping you breath")
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
        }
        End();
    }
    
}

