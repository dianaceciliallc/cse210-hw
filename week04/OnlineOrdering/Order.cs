using System;

public class Order
{
    Customer _customer;
    List<Product> _products;
    double _totalCost;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public double ShippingCost()
    {
        if(_customer.IsInUsa())
        {
            return 5.0;
        }
        return 35.0;
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product item in _products)
        {
            total += item.GetTotal();
        }
        _totalCost = total + ShippingCost();
        return _totalCost;
    }

    public string GetDisplayLabel()
    {
        string label = "";
        foreach (Product item in _products)
        {
            label += $"\n{item.GetDisplay()}";
        }
        return label;
    }

    public string GetDisplayShipping()
    {
        return $"Customer name: {_customer.GetName()}\n{_customer.GetDisplayAddress()}";
    }
}