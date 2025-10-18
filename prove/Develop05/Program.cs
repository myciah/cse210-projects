using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager man = new GoalManager();
        bool running = true;
        while (running)
        {
            Console.WriteLine("Eternal Quest Menu");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Goal Ideas")
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                CreGo(man);
            }
            else if (option == "2")
            {
                RecordEvent(man);
            }
            else if (option == "3")
            {
                man.DisplayGo();
            }
            else if (option == "4")
            {
                man.DisplaySc();
            }
            else if (option == "5")
            {
                SaveGo(man);
            }
            else if (option == "6")
            {
                LoadGo(man);
            }
            else if (option == "7")
            {
                _i.DisplayId();
            }
            else if (option == "8")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Please choose a valid option.");
            }
        }
        Console.WriteLine("See you next time!!");
    }
    static void CreGo(GoalManager man)
    {
        Console.Write("What is the type of goal? (simple / eternal / checklist): ");
        string ty = Console.ReadLine();
        Console.Write("Name: ");
        string na = Console.ReadLine();
        Console.Write("Description: ");
        string des = Console.ReadLine();
        int points = HowMany("How many points does this goal get? ");

        if (ty == "simple")
        {
            SimpleGoal SG =  new SimpleGoal(na, des, points);
            man.AddGoal(SG);
            Console.WriteLine("A simple goal was created.");
        }
        else if (ty == "eternal")
        {
            EternalGoal EG = new EternalGoal(na, des, points);
            man.AddGoal(EG);
            Console.WriteLine("An eternal goal was created.");
        }
        else if(ty == "checklist")
        {
            int Tar = HowMany("How many times do you need to complete? ");
            int Bon = HowMany("Bonus points??? ");
            CheckListGoal CG = new CheckListGoal(na, des, points, Tar, Bon);
            man.AddGoal(CG);
            Console.WriteLine("Checklist goal has been created.");
        }
        else
        {
            Console.WriteLine("Unkown");
        }
    }
    static void RecordEvent(GoalManager man)
    {
        man.DisplayGo();
        int ind = HowMany("Enter the goal number to record: ");
        man.RecordEvent(ind);
    }
    static void SaveGo(GoalManager man)
    {
        Console.Write("Enter the filename to save: ");
        string filename = Console.ReadLine();
        man.SaveGo(filename);
    }
    static void LoadGo(GoalManager man)
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        man.LoadGo(filename);
    }
    static int HowMany(string quest)
    {
        while (true)
        {
            Console.Write(quest);
            string inp = Console.ReadLine();
            int value;
            if (int.TryParse(inp, out value))
            {
                return value;
            }
            Console.WriteLine("Please enter a number that is valid.");
        }
    }
}


