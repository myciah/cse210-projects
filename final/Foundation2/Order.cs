public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _cutsomer;
    public Order(Customer customer)
    {
        _cutsomer = customer;
    }
    public void AProduct(Product product)
    {
        _products.Add(product);
    }
    public double GTotCost()
    {
        foreach (Product product in _products)
        {
            total += product.GTotCost();
        }
        if (_cutsomer.LivesUSA())
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
        string label = "Packing Label";
        for (Product product in _products)
        {
            label += ($"{product.GName()} {product.GProductId}");
        }
        return label;
    }
    public string GShippLabel()
    {
        return ($"Shipping Label: {customer.GName()} - {customer.GAddress().GFullAddress()}");
    }
}