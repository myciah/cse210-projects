using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("John", 3, 16);
        Console.WriteLine(ref1.GetDisplayText());

        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        Console.WriteLine(ref2.GetDisplayText());

        //testint word class
        word word = new word("Hope");
        Console.WriteLine(word.GetDisplayText());
        word.Hide();
        Console.WriteLine(word.GetDisplayText());
    }
}