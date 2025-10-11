using System;

class Program
{
    static void Main(string[] args)
    {
        //Testing MindfulnessActivity.cs
        MindfulnessActivity testA = new MindfulnessActivity("Testing", "Testing pt 2");
        testA.Start();
        Console.WriteLine("Working or not..");
        testA.End();
        testA.ShowCount(10);
    }
}