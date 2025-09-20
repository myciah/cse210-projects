using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int magic = randomNumber.Next(1, 101);
        int number = -1;

        while (magic != number)
        {
            Console.Write("What is your guess? ");
            number = int.Parse(Console.ReadLine());
            if (magic == number)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (magic > number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }

        }

    }
}
