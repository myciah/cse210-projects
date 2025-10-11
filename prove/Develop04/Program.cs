using System;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        while (run)
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Please choose an activity to do: ");
            string option = Console.ReadLine();

            if (option == 1)
            {
                BreathingActivity BTest = new BreathingActivity();
                BTest.Running();
            }
            else if (option == 2)
            {
                ReflectingActivity RTest = new ReflectingActivity();
                RTest.Running();
            }
            else if (option == 3)
            {
                ListingActivity LTest = new ListingActivity();
                LTest.Running();
            }
            else if (option == 4)
            {
                Console.WriteLine("Have a good day! See you next time!");
                break;
            }
            else
            {
                Console.WriteLine("Please select an option (1-4).");
            }

        }



        //Testing MindfulnessActivity.cs
        //MindfulnessActivity testA = new MindfulnessActivity("Testing", "Testing pt 2");
        //testA.Start();
        //Console.WriteLine("Working or not..");
        //testA.ShowCount(5);
        //testA.End();

            //Testing BreathingActivity.cs
            //BreathingActivity BTest = new BreathingActivity();
            //BTest.Running();

            //Testing ReflectinActivity.cs
            //ReflectingActivity RTest = new ReflectingActivity();
            //RTest.Running();

            //Testing ListingActivity.cs
            //ListingActivity LTest = new ListingActivity();
            //LTest.Running();
    }
}