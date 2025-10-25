public class Product
{
    private string _name;
    private string _productId;
    private double _priceUnit;
    private int _quantity;
    public Product(string name, string productId, double priceUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _priceUnit = priceUnit;
        _quantity = quantity;
    }

    public string GName()
    {
        return _name;
    }
    public string GProductId()
    {
        return _productId;
    }
    public double GPrice()
    {
        return _priceUnit;
    }
    public int GQuantity()
    {
        return _quantity;
    }
    public double GTotCost()
    {
        return _priceUnit * _quantity;
    }
}