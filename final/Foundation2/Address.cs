public class Address
{
    private string _street;
    private string _city;
    private string _stateProv;
    private string country;
    public Address(string street, string city, string StateProv, string country)
    {
        _street = street;
        _city = city;
        _stateProv = StateProv;
        _country = country;
    }
    public bool USA()
    {
        return _country;
    }
    public string GFullAddress()
    {
        return ($"{_street} - {_city} - {_stateProv} - {_country}");
    }
}