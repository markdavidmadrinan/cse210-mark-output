using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Add products to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Getters and Setters
    public Customer GetCustomer()
    {
        return _customer;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public List<Product> GetProducts()
    {
        return new List<Product>(_products);
    }

    // Calculate shipping cost
    private double GetShippingCost()
    {
        if (_customer.IsInUSA())
        {
            return 5.00;
        }
        else
        {
            return 35.00;
        }
    }

    // Calculate total order price
    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total = total + product.GetTotalCost();
        }

        total = total + GetShippingCost();

        return total;
    }

    // Create packing label
    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";

        foreach (Product product in _products)
        {
            label = label + "Product Name: " + product.GetName() + "\n";
            label = label + "Product ID: " + product.GetProductId() + "\n";
        }

        return label;
    }

    // Create shipping label
    public string GetShippingLabel()
    {
        string label = "SHIPPING LABEL\n";

        label = label + _customer.GetName() + "\n";
        label = label + _customer.GetAddress().GetAddressString();

        return label;
    }
}