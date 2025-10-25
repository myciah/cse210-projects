public class Comment
{
    private string comName;
    private string comText;
    public Comment(string Name, string Text)
    {
        comName = Name;
        comText = Text;
    }
    public string GComName()
    {
        return comName;
    }
    public string GComText()
    {
        return comText;
    }
}