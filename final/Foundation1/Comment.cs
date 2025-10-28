public class Comment
{
    private string _comName;
    private string _comText;
    public Comment(string Name, string Text)
    {
        _comName = Name;
        _comText = Text;
    }
    public string GComName()
    {
        return _comName;
    }
    public string GComText()
    {
        return _comText;
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