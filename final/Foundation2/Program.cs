using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation2 World!");
//     }
// }

class Program
{
     static void Main(string[] args)
    {
        Address A1 = new Address("123 XYZ St", "Arlington", "VA", "USA");
        Console.WriteLine($"Address: {A1.GFullAddress()}");
        if (A1.USA())
        {
            Console.WriteLine("This address is in the USA.");
        }
        else
        {
            Console.WriteLine("Not USA Address");
        }
        Address A2 = new Address("456 ZYX st", "Tokyo", "Shinjuku", "Japan");
        Console.WriteLine($"Address: {A2.GFullAddress()}");
        if (A2.USA())
        {
            Console.WriteLine("This address is in the USA.");
        }
        else
        {
            Console.WriteLine("Not USA Address");
        }
    }

}