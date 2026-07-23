using System;

public class Address
{
    string _address;
    string _city;
    string _state;
    string _country;

    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUsa()
    {
        if (_country.ToUpper() == "USA")
        {
            return true;
        }
        return false;
    }

    public string GetDisplay()
    {
        return $"Address: {_address}\nCity: {_city}\nState: {_state}\nCountry: {_country}";
    }
}