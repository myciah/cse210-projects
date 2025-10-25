public class Address
{
    private string _street;
    private string _city;
    private string _stateProv;
    private string _country;
    public Address(string street, string city, string StateProv, string country)
    {
        _street = street;
        _city = city;
        _stateProv = StateProv;
        _country = country;
    }
    public bool USA()
    {
        return _country == "USA";
    }
    public string GFullAddress()
    {
        return ($"{_street} - {_city} - {_stateProv} - {_country}");
    }
}

//The following code was used to test Address.cs in Program.cs
// class Program
// {
//      static void Main(string[] args)
//     {
//         Address A1 = new Address("123 XYZ St", "Arlington", "VA", "USA");
//         Console.WriteLine($"Address: {A1.GFullAddress()}");
//         if (A1.USA())
//         {
//             Console.WriteLine("This address is in the USA.");
//         }
//         else
//         {
//             Console.WriteLine("Not USA Address");
//         }
//         Address A2 = new Address("456 ZYX st", "Tokyo", "Shinjuku", "Japan");
//         Console.WriteLine($"Address: {A2.GFullAddress()}");
//         if (A2.USA())
//         {
//             Console.WriteLine("This address is in the USA.");
//         }
//         else
//         {
//             Console.WriteLine("Not USA Address");
//         }
//     }

// }