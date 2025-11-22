public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product newProduct)
    {
        _products.Add(newProduct);
    }
    public double CalculateTotalCost()
    {
        double orderCost = 0;
        foreach (Product product in _products)
        {
            orderCost += product.CalculateTotalCost();
        }
        if (_customer.IsLivingInUSA() == true)
        {
            return orderCost + 5;
        }
        else
        {
            return orderCost + 35;
        }
    }
    public string GetPackingLabel()
    {
        List<string> productsNames = new List<string>();
        foreach (Product product in _products)
        {
           productsNames.Add(product.GetDisplayText());
        }
        return $"{string.Join("\n", productsNames)}";
    }
    public string GetShippingLabel()
    {
        return _customer.GetDisplayText();
    }
}