public class Video
{
    private string title;
    private string author;
    private int TimeSeconds;
    private List<Comment> comments;
    public Video(string Title, string Author, int Time)
    {
        title = Title;
        author = Author;
        TimeSeconds = Time;
        comments = new List<Comment>();

    }
    public void ACom(Comment comment)
    {
        comments.Add(comment);
    }
    public int GComCount()
    {
        return comments.Count;
    }
    public string GTitle()
    {
        return title;
    }
    public string GAuthor()
    {
        return author;
    }
    public List<Comment> GComments()
    {
        return comments;
    }
    public int GLength()
    {
        return TimeSeconds;
    }
}