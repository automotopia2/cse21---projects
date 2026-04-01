using System;

class Address
{
    // Variables
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    // Constructor
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    // Methods
    public bool IsUSA()
    {
        return _country.ToUpper() == "USA";
    }
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}\n{_state}\n{_country}";
    }
}