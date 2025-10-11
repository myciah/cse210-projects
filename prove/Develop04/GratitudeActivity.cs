public class GratitudeActivity : MindfulnessActivity
{
    public GratitudeActivity()
        : base("Gratitude", "This activity is here to help you realize things you are grateful for!")
    {
    }
    public void Running()
    {
        Start();
        Console.WriteLine("What is something you are grateful for?");
        ShowSpin(5);
        Console.WriteLine("Picture it in your head.");
        ShowSpin(5);
        Console.Write("What is it you are grateful for? ");
        string reply = Console.ReadLine();
        Console.WriteLine($"{reply} is an amazing thing to be grateful for!");
    }
}