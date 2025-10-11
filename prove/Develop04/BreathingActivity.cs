//Breathing Activity (Breath in.... , Breath out.....)
public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
        : base("Breathing", "his activity will help you relax by helping you breath")
    {
    public void Running()
    {
        Start;
        int time = 0;
        while (time < GetDura())
        {
            Console.WriteLine("Breath in...");
            ShowCount();
            Console.WriteLine("Breathe out...");
            ShowCount();
        }
        End;
    }
    }
}

