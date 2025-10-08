public class word
{
    private string text;
    private bool hidden;
    public word(string wordT)
    {
        text = wordT
        hidden = false;
    }
    public void Hide()
    {
        hidden = true;
    }
    public bool isHidden
    {
        return hidden;
    }
    public string GetDisplayText()
    {
        if (hidden == true)
        {
            return (text.Length);
        }
        else
        {
            return text;
        }
    }
}