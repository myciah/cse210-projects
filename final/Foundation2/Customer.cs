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