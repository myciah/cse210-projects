using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation1 World!");
//     }
// }

//Next lines of code are to test the comment class:
using System;
class Program
{
    static void Main(string[] args)
    {
        Comment TC = new Comment("John", "This is a test!");
        Console.WriteLine($"Name: {TC.GComName()}");
        Console.WriteLine($"Text: {TC.GComText()}");
    }
}