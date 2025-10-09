public class Scripture
{
    private Reference reference;
    private List<Word> words = new List<Word>();
    private Random random = new Random();
    private List<string> scriptureFunFacts = new List<string>
    {
        "Proverbs has 31 wonderful chapters.",
        "The Bible and Book of Mormon both teach of Christ!",
        "The Bible contains many prophets teachings that can help one grow their testimony!"
    };
    public Scripture(Reference refO, string verseT)
    {
        reference = refO;
        string[] splitW = verseT.Split(' ');
        for (int i = 0; i < splitW.Length; i++)
        {
            Word TWord;
            TWord = new Word(splitW[i]);
            words.Add(TWord);
        }
    }
    public void HideRanWord(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int ind = random.Next(words.Count);
            words[ind].Hide();
        }
    }
    public bool AllWordHid()
    {
        for (int i = 0; i < words.Count; i++)
        {
            if (!words[i].IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    public void Display()
    {
        Console.Write(reference.GetDisplayText() + "\n");
        for (int i = 0; i < words.Count; i++)
        {
            Console.Write(words[i].GetDisplayText() + " ");
        }
        Console.WriteLine("\n");
    }
    public void ranFact()
    {
        int ind = random.Next(scriptureFunFacts.Count);
        Console.WriteLine($"This is a fun fact about the bible: {scriptureFunFacts[ind]}");
    }
}