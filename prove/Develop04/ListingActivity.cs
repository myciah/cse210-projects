public class ListingActivity : MindfulnessActivity
{
    public ListingActivity()
        : base("Listing", "This activity is meant to help you list postive things in your life by creating a list.")
    {
    }
    private List<string> QuestionToBe = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are some spiritual gifts you have?"
    };
    public void Running()
    {
        Start();
        Random Quest = new Random();
        Console.WriteLine(QuestionToBe[Quest.Next(QuestionToBe.Count)]);
        Console.WriteLine("Begin typing in: ");
        ShowCount(5);
        List<string> total = new List<string>();
        DateTime ETime = DateTime.Now.AddSeconds(GetDura());
        while (DateTime.Now < ETime)
        {
            Console.Write(">");
            string totals = Console.ReadLine();
            total.Add(totals);
        }
        Console.WriteLine($"You have {total.Count} items listed.");
        End();
    }
}