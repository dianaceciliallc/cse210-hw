using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer customer = new Customer("John Doe", address1);

        Product product1 = new Product("Laptop", "P001", 15.9, 1);
        Product product2 = new Product("Mouse", "P002", 25.3, 2);
        List<Product> products = new List<Product>();
        products.Add(product1);
        products.Add(product2);

        Order order = new Order(customer, products);

        Console.WriteLine("--- ORDER ---");
        Console.WriteLine(order.GetDisplayLabel());
        Console.WriteLine(order.GetDisplayShipping());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost()}");
    }
}