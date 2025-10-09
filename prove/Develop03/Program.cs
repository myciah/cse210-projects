using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Test 
        // Reference ref1 = new Reference("John", 3, 16);
        // Console.WriteLine(ref1.GetDisplayText());

        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        //Console.WriteLine(ref2.GetDisplayText()); (was part of testing at first)
        string verseT = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";

        Scripture scripture = new Scripture(ref2, verseT);
        while (!scripture.AllWordHid())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit: ");
            string inp = Console.ReadLine();
            if (inp == "quit")
            {
                break;
            }
            scripture.HideRanWord(3);
        }
        Console.Clear();
        Console.WriteLine("All the words have been hidden, hope you were able to learn the scripture!");

        //testing word class
        //Word word = new Word("Hope");
        //Console.WriteLine(word.GetDisplayText());
        //word.Hide();
        //Console.WriteLine(word.GetDisplayText());
    }
}