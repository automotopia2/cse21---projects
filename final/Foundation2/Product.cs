using System;

class Product
{
    // Variables
    private string _productName;
    private int _productID;
    private double _pricePer;
    private int _quantity;
    // Constructor
    public Product(string name, int ID, double pricePer, int quantity)
    {
        _productName = name;
        _productID = ID;
        _pricePer = pricePer;
        _quantity = quantity;
    }
    // Methods
    public string GetProductName() 
    { 
        return _productName; 
    }

    public void SetProductName(string productName) 
    { 
        _productName = productName; 
    }

    public int GetProductID() 
    { 
        return _productID; 
    }

    public void SetProductID(int productID) 
    { 
        _productID = productID; 
    }

    public double GetPricePer() 
    { 
        return _pricePer; 
    }

    public void SetPricePer(double pricePer) 
    { 
        _pricePer = pricePer; 
    }

    public int GetQuantity() 
    { 
        return _quantity; 
    }

    public void SetQuantity(int quantity) 
    { 
        _quantity = quantity; 
    }

    public double TotalPrice()
    {
        return _pricePer * _quantity;
    }

}