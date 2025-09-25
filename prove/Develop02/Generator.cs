using System;
public class Generator
{
    private List<string> query = new List<string>
    {
        "What was the most stressful par of today?",
        "What can I do better?",
        "Who did I interact with today?",
        "What was the best part of the day?",
        "What Gosple principle did I see in my life today?",
        "What did I do today to grow my relationship with Heavenly Father?",
        "What memories did I make today?",
        "What was my favorite song that I listened to today, and why?",
        "What emotion was most powerful in my life today, and why?"
    };
    private Random chance = new Random();
    public string GetRandomQuestion()
    {
        int index = chance.Next(query.Count);
        return query[index];
    }
}