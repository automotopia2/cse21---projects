using System;

class Order
{
    // Variables
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Methods
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
        return _products; 
    }
    public void SetProducts(List<Product> products) 
    { 
        _products = products; 
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double FinalPrice()
    {
        double finalPrice = 0;
        foreach (Product product in _products)
        {
            finalPrice += product.TotalPrice();
        }
        if (_customer.IsUSA())
        {
            finalPrice += 5;
        }
        else
        {
            finalPrice += 35;
        }
        return finalPrice;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetProductName()} - ID: {product.GetProductID()}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}