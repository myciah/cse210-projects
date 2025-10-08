public class Word
{
    private string text;
    private bool hidden;
    public Word(string wordT)
    {
        text = wordT;
        hidden = false;
    }
    public void Hide()
    {
        hidden = true;
    }
    public bool IsHidden()
    {
        return hidden;
    }
    public string GetDisplayText()
    {
        if (hidden == true)
        {
            return new string('_', text.Length);
        }
        else
        {
            return text;
        }
    }
}