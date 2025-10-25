public class ideo
{
    private string title;
    private string author;
    private int TimeSeconds;
    private List<Comment> comments;
    public Video(string Tilte, string Authot, int Time)
    {
        title = Title
        author = Author;
        TimeSeconds = Time;
        comments = new List<Comment>();

    }
    public void ACom(Comment comment)
    {
        comment.Add(comment);
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
}