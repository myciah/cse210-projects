//Reflecting Activity (Show questions, let user reflect)
public class ReflectingActivity : MindfulnessActivity
{
    public ReflectingActivity()
        : base("Reflecting", "This activity is meant to help you reflect on the strengths the Lord has given you!")
    {
    }
    private List<string> question = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> DeepQues = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experince in mind in the future?"
    };
    public void Running()
    {
        Start();
        Random choice = new Random();
        Console.WriteLine(question(choice.Next(question)));
        ShowSpin(5);
        int time = 0
        while (time < GetDura())
        {
            Console.WriteLine(DeepQues(choice.Next(DeepQues)));
            ShowSpin(5);
            time += 5
        }
        End();
    }
}