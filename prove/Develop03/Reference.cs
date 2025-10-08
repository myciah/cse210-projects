public class Reference
{
    string book;
    int chapter;
    int VStart
    int VEnd
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