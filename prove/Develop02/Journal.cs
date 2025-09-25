using System;
using System.IO;
public class Journal
{
    private List<Entry> item = new List<Entry>();
    public void AddQuest(Entry quest)
    {
        item.Add(quest);
    }
    public void showEntry()
    {
        foreach (Entry quest in item)
        {
            quest.show();
        }
    }
    public void save(string filename)
    {
        using (StreamWriter author = new StreamWriter(filename))
        {
            foreach (Entry quest in item)
            {
                author.WriteLine(quest.entryFormat());
            }
        }
        Console.WriteLine($"Successfully save the journal entry!!");
    }
    public void load(string filename)
    {
        item.Clear();
        string[] number = File.ReadAllLines(filename);
        foreach (string numbers in number)
        {
            string[] section = numbers.Split("~|~");
            if (section.Length == 3)
            {
                Entry quest = new Entry(section[1], section[2]);
                quest.date = section[0];
                item.Add(quest);
            }
        }
        Console.WriteLine($"The journal has been loaded successfully!!!");
    }
    public void Search(string kw)
    {
        bool located = false;
        foreach (Entry quest in item)
        {
            if (quest.questions.Contains(kw, StringComparison.OrdinalIgnoreCase) ||
            quest.replies.Contains(kw, StringComparison.OrdinalIgnoreCase))
            {
                quest.show();
                located = true;
            }
        }
        if (!located)
        {
            Console.WriteLine("No entries were found using that word.");
        }
    }
}