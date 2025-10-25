using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation2 World!");
//     }
// }

//Testing Product.cs code
class Program
{
     static void Main(string[] args)
    {
        Product P = new Product("Roller Blades", "XXX123", 122.99, 1);
        Console.WriteLine($"Product Name: {P.GName()}");
        Console.WriteLine($"Product ID: {P.GProductId()}");
        Console.WriteLine($"Product Price: {P.GPrice()}");
        Console.WriteLine($"Product Quantity: {P.GQuantity()}");
        Console.WriteLine($"Total: {P.GTotCost()}");

    }

}