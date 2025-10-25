Public class Product
{
    Private string name
    private string productId
    Private double priceUnit
    private int quantity
    public Product(string Name, string productID, double PriceUnit, int Quantity)
    {
        name = Name;
        productID = ProductID;
        priceUnit = PriceUnit;
        quantitiy = Quantity;
    }
    public string GName()
    {
        return Name;
    }
    public string GProductId()
    {
        return ProductId;
    }
    public double GPrice()
    {
        return priceUnit;
    }
    public int GQuantity()
    {
        return Quantity;
    }
    public double GTotCost()
    {
        return PriceUnit * Quantity;
    }
}