using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation1 World!");
//     }
// }

//Testing Video.cs
class Program
{
    static void Main(string[] args)
    {
        Video MV = new Video("Let's do this", "Charlie", 180);
        MV.ACom(new Comment("Heidi", "Great vid"));
        MV.ACom(new Comment("McKayla", "Moose are great!"));
        MV.ACom(new Comment("Breanna", "Video Game is well played."));

        Console.WriteLine($"Title: {MV.GTitle()}");
        Console.WriteLine($"Author: {MV.GAuthor()}");
        Console.WriteLine($"Length: {MV.GLength()} seconds");
        Console.WriteLine($"#Comments: {MV.GComCount()}");
        Console.WriteLine("Comments: ");
        foreach (Comment comment in MV.GComments())
        {
            Console.WriteLine($"{comment.GComName()}: {comment.GComText()}");
        }
    }
}