public class Video
{
    private string _title;
    private string _author;
    private int _timeSeconds;
    private List<Comment> _comments;
    public Video(string Title, string Author, int Time)
    {
        _title = Title;
        _author = Author;
        _timeSeconds = Time;
        _comments = new List<Comment>();

    }
    public void ACom(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GComCount()
    {
        return _comments.Count;
    }
    public string GTitle()
    {
        return _title;
    }
    public string GAuthor()
    {
        return _author;
    }
    public List<Comment> GComments()
    {
        return _comments;
    }
    public int GLength()
    {
        return _timeSeconds;
    }
}

//The following code was used to test Video.cs in program.cs
// class Program
// {
//     static void Main(string[] args)
//     {
//         Video MV = new Video("Let's do this", "Charlie", 180);
//         MV.ACom(new Comment("Heidi", "Great vid"));
//         MV.ACom(new Comment("McKayla", "Moose are great!"));
//         MV.ACom(new Comment("Breanna", "Video Game is well played."));

//         Console.WriteLine($"Title: {MV.GTitle()}");
//         Console.WriteLine($"Author: {MV.GAuthor()}");
//         Console.WriteLine($"Length: {MV.GLength()} seconds");
//         Console.WriteLine($"#Comments: {MV.GComCount()}");
//         Console.WriteLine("Comments: ");
//         foreach (Comment comment in MV.GComments())
//         {
//             Console.WriteLine($"{comment.GComName()}: {comment.GComText()}");
//         }
//     }
// }