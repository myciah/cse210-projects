public class Scripture
{
    private Reference reference;
    private List<Word> words = new List<Word>();
    private Random random = new Random();
    public Scripture(Reference refO, string verseT)
    {
        reference = refO;
        string[] splitW = verseT.Split(" ");
        for (int i = 0; i < splitW.Length; i++)
        {
            Word TWord;
            TWord = new Word(splitW[i]);
            words.Add(splitW[i]);
        }
    }
    public void HideRanWord(int count)
    {
        for (int i = 0; i <= count; i++)
        {
            int ind = random.Next(words.Count);
            words[ind].Hide();
        }
    }
    public bool AllWordHid()
    {
        for (int i = 0;< words.Count; i++)
        {
            if (words[i].IsHidden == false)
            {
                return false;
            }
        }
        return true:
    }
    public void Display()
    {
        Console.WriteLine(reference.GetDisplayText());
        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i].GetDisplayText());
        }
    }
}