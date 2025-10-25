public class Comment
{
    private string comName;
    private string comText;
    public Comment(string Name, string Text)
    {
        comName = Name;
        comText = Text;
    }
    public string GComName()
    {
        return comName;
    }
    public string GComText()
    {
        return comText;
    }
}

//Next lines of code were used to test the comment class in program.cs:
// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         Comment TC = new Comment("John", "This is a test!");
//         Console.WriteLine($"Name: {TC.GComName()}");
//         Console.WriteLine($"Text: {TC.GComText()}");
//     }
// }