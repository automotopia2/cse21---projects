using System;

class Address
{
    // Variables
    private string _streetAddress;
    private string _city;
    private string _state;
    // Constructor
    public Address(string streetAddress, string city, string state)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
    }
    // Methods
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}\n{_state}";
    }
}