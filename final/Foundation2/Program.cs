using System;

class Program
 {
     static void Main(string[] args)
     {
        Address A1 = new Address("123 AAA st", "Rexburg", "ID", "USA");
        Customer C1 = new Customer("Allie Shepherd", A1);
        Order O1 = new Order(C1);
        O1.AProduct(new Product("Dress", "11AAA", 45.85, 1));
        O1.AProduct(new Product("Shoes", "AAA22", 22.55, 2));
        Console.WriteLine(O1.GPackLabel());
        Console.WriteLine(O1.GShippLabel());
        Console.WriteLine($"Total Cost: $ {O1.GTotCost()}");
        Console.WriteLine();
        
        Address A2 = new Address("456 BBB st", "Zhengzhou", "Henan", "China");
        Customer C2 = new Customer("Shi-wei Zhu", A2);
        Order O2 = new Order(C2);
        O2.AProduct(new Product("Ring", "70v3R", 2510.99, 2));
        O2.AProduct(new Product("Suit", "2u17t", 55.65, 4));
        O2.AProduct(new Product("Plane Ticket", "Fly189", 505.00, 1));
        Console.WriteLine(O2.GPackLabel());
        Console.WriteLine(O2.GShippLabel());
        Console.WriteLine($"Total Cost: $ {O2.GTotCost()}");
        Console.WriteLine();
     }
 }

