using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation1 World!");
//     }
// }

class Program
{
    static void Main(string[] args)
    {
        Video MV = new Video("Let's do this", "Charlie");
        Console.WriteLine($"Title: {MV.GTitle()}");
        Console.WriteLine($"Author: {MV.GAuthor()}");
        Console.WriteLine($"#Comments: {MV.GComCount()}");
    }
}