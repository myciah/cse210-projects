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