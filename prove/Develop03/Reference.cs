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
        verseS = verseNum;
        verseE = verseNum;
    }
    public Reference(string bookName, int chapterNum, int verseS, int verseE)
    {
        book = bookName;
        chapter = chapterNum;
        verseS = verseS;
        verseE = verseE;
    }
    public string GetDisplayText()
    {
        if (verseS == verseE)
        {
            return book + "" + chapter + ":" + verseS.ToString();
        }
        else
        {
            return book + "" + chapter + ":" + verseS + "-" + verseE;
        }
    }
}