using System;

public class Customer
{
    string _name;
    Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsInUsa()
    {
      return _address.IsInUsa();
    }

    public string GetDisplayAddress()
    {
        return _address.GetDisplay();
    }
}