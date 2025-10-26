using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation2 World!");
//     }
// }

//Code used to test Order.cs
class Program
{
     static void Main(string[] args)
    {
        Address A = new Address("123 XXX st", "Arlington", "VA", "USA");
        Customer C = new Customer("Breanna Russ", A);
        Order O = new Order(C);
        Product P1 = new Product("Book", "XYZ", 4.50, 2);
        Product P2 = new Product("Pen", "QWZ123", 1.05, 7);
        O.AProduct(P1);
        O.AProduct(P2);
        Console.WriteLine(O.GPackLabel());
        Console.WriteLine(O.GShippLabel());
        Console.WriteLine($"Total Cost: $ {O.GTotCost}");
    }

}