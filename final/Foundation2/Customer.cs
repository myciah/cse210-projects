public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GName()
    {
        return _name;
    }
    public Address GAddress()
    {
        return _address;
    }
    public bool LivesUSA()
    {
        return _address.USA();
    }
}

//The following code was used to test Customer.cs in Program.cs
// class Program
// {
//      static void Main(string[] args)
//     {
//         Address A = new Address("123 XYZ st", "Arlington", "VA", "USA");
//         Customer C = new Customer("Corrin Magath", A);
//         Console.WriteLine($"Customer Name: {C.GName()}");
//         Console.WriteLine($"Customer Address: {C.GAddress().GFullAddress()}");
//         if (C.LivesUSA())
//         {
//             Console.WriteLine("C lives in USA");
//         }
//         else
//         {
//             Console.WriteLine("C does not live in USA");
//         }
//     }
// }