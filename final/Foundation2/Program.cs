using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation2 World!");
//     }
// }

//Testing Customer.cs
class Program
{
     static void Main(string[] args)
    {
        Address A = new Address("123 XYZ st", "Arlington", "VA", "USA");
        Customer C = new Customer("Corrin Magath", A);
        Console.WriteLine($"Customer Name: {C.GName()}");
        Console.WriteLine($"Customer Address: {C.GAddress().GFullAddress()}");
        if (C.LivesUSA())
        {
            Console.WriteLine("C lives in USA");
        }
        else
        {
            Console.WriteLine("C does not live in USA");
        }
    }
}