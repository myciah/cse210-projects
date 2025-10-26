public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AProduct(Product product)
    {
        _products.Add(product);
    }
    public double GTotCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GTotCost();
        }
        if (_customer.LivesUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string GPackLabel()
    {
        string label = "Packing Label:\n ";
        foreach (Product product in _products)
        {
            label += $"{product.GName()} ({product.GProductId()})\n";
        }
        return label;
    }
    public string GShippLabel()
    {
        return $"Shipping Label: \n{_customer.GName()} \n{_customer.GAddress().GFullAddress()}";
    }
}

//The following code was used to test Order.cs in Program.cs
// class Program
// {
//      static void Main(string[] args)
//     {
//         Address A = new Address("123 XXX st", "Arlington", "VA", "USA");
//         Customer C = new Customer("Breanna Russ", A);
//         Order O = new Order(C);
//         Product P1 = new Product("Book", "XYZ", 4.50, 2);
//         Product P2 = new Product("Pen", "QWZ123", 1.05, 7);
//         O.AProduct(P1);
//         O.AProduct(P2);
//         Console.WriteLine(O.GPackLabel());
//         Console.WriteLine(O.GShippLabel());
//         Console.WriteLine($"Total Cost: $ {O.GTotCost()}");
//     }

// }