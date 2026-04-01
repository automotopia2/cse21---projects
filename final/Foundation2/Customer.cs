using System;

class Customer
{
    // Variables
    private string _name;
    // private Address address = new Address("2645 South Quenzer Way", "Middleton", "Idaho", "USA");
    private Address _address;
    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    // Methods
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name; 
    }
    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public bool IsUSA()
    {
        return _address.IsUSA();
    }
}