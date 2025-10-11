using System;

class Program
{
    static void Main(string[] args)
    {
        //Testing MindfulnessActivity.cs
        MindfulnessActivity testA = new MindfulnessActivity("Testing");
        testA.Start();
        Console.WriteLine("Working or not..");
        testA.End(); 
    }
}