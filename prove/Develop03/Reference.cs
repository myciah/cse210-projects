public class Reference
{
    private string book;
    private int chapter;
    private int VStart;
    private int VEnd;
    public Reference(string bookName, int chapterNum, int verseNum)
    {
        book = bookName;
        chapter = chapterNum;
        VStart = verseNum;
        VEnd = verseNum;
    }
    public Reference(string bookName, int chapterNum, int SVerse, int EVerse)
    {
        book = bookName;
        chapter = chapterNum;
        VStart = SVerse;
        VEnd = EVerse;
    }
    public string GetDisplayText()
    {
        if (VStart == VEnd)
        {
            return book + "" + chapter + ":" + VStart.ToString();
        }
        else
        {
            return book + "" + chapter + ":" + VStart + "-" + VEnd;
        }
    }
}