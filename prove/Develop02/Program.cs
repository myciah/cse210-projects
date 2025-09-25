using System;

class Program
{
    static void Main(string[] args)
    {
        Journal adventure = new Journal();
        Generator prompt = new Generator();
        bool working = true;
        while (working)
        {
            Console.WriteLine("\nJournal Main Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Search entry for keyword");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    string question = prompt.GetRandomQuestion();
                    Console.WriteLine($"\nPrompt: {question}");
                    Console.Write("Your reply: ");
                    string answer = Console.ReadLine();
                    Entry entry = new Entry(question, answer);
                    adventure.AddQuest(entry);
                    break;
                case "2":
                    Console.WriteLine("\nYour journal entries: ");
                    adventure.showEntry();
                    break;
                case "3":
                    Console.Write("Enter the filename you wish to save to: ");
                    string fileSave = Console.ReadLine();
                    adventure.save(fileSave);
                    break;
                case "4":
                    Console.Write("Enter the name of the file you wish to load: ");
                    string fileLoad = Console.ReadLine();
                    adventure.load(fileLoad);
                    break;
                case "5":
                    Console.Write("Enter keyword to search for: ");
                    string kWord = Console.ReadLine();
                    Console.WriteLine($"Searching for {kWord}");
                    adventure.Search(kWord);
                    break;
                case "6":
                    Console.WriteLine("Leaving the journal program. Hope to see more of the wonderful days you'll write about in the future!!!!");
                    working = false;
                    break;
                default:
                    Console.WriteLine("Please choose a number between 1 and 6 to start the journal program.");
                    break;
            }
        }
    }
}