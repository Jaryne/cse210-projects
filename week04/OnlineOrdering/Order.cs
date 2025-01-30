using System.Net.Http.Headers;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(List<Product> products, Customer customer)
    {
        _customer = customer;
        _products = products;
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;
        foreach(Product product in _products)
        {
            total += product.GetTotalCost();
        }

        decimal shipCost = _customer.LivesInUSA() ? 5 :35; // Syntax is called Ternary Operator. It's a Shorthand way to write if-else statement. So basically IF lives in USA ship cost = 5, else = 35.
        return total + shipCost;
    }

    public string GetPackLabel()
    {
        string label = "Packing Label: \n";
        foreach (Product product in _products)
        {
            label += $"Name: {product.GetName()}, Product ID: {product.GetProductId()}\n";
        }

        return label;
    }

    public string GetShipLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}