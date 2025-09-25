using System;
public class Entry
{
    public string questions { get; set; }
    public string replies { get; set; }
    public string date { get; set; }

    public Entry(string question, string reply)
    {
        questions = question;
        replies = reply;
        date = DateTime.Now.ToString("yyyy-MM-dd");
    }
    public string entryFormat()
    {
        return ($"{date}~|~{questions}~|~{replies}");
    }
    public void show()
    {
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Prompt: {questions}");
        Console.WriteLine($"Response: {replies}");
    }
}