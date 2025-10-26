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
        string label = "Packing Label: ";
        foreach (Product product in _products)
        {
            label += $"{product.GName()} {product.GProductId()}";
        }
        return label;
    }
    public string GShippLabel()
    {
        return $"Shipping Label: {_customer.GName()}  {_customer.GAddress().GFullAddress()}";
    }
}