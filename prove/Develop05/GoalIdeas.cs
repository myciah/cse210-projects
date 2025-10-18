class GoalIdeas
{
    private List<string> _i = new List<string>()
    {
        "Exercise for 30 Minutes",
        "Drink 8 cups of water daily",
        "Do the dishes/clean kitchen",
        "Write in journal",
        "Read General Conference Talk (x5)",
        "Read scriptures Daily",
        "Reach out to a friend",
        "Complement others (x15)",
        "Have two meaningful prayers everyday",
        "Help at a service project each week"
    };
    public void DisplayId()
    {
        Console.WriteLine("Hera are some goal ideads you could use: ");
        for (int i = 0; i < _i.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_i[i]}");
        }
    }
}