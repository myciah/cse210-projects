using System;

class Program
{
    static void Main(string[] args)
    {
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
        ListingActivity LTest = new ListingActivity();
        LTest.Running();
    }
}