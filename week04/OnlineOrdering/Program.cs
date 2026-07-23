using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer customer = new Customer("John Doe", address1);

        Product product1 = new Product("Laptop", "P001", 503.9, 1);
        Product product2 = new Product("Mouse", "P002", 25.3, 2);
        List<Product> products = new List<Product>();
        products.Add(product1);
        products.Add(product2);

        Order order = new Order(customer, products);

        Console.WriteLine("---- ORDER 1 ----");
        Console.WriteLine("--- Packing Label ---");
        Console.WriteLine(order.GetDisplayLabel());
        Console.WriteLine("--- Shipping Label ---");
        Console.WriteLine(order.GetDisplayShipping());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost()}\n");

        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product3 = new Product("Keyboard", "P003", 45.0, 1);
        Product product4 = new Product("Monitor", "P004", 150.0, 1);
        
        List<Product> products2 = new List<Product>();
        products2.Add(product3);
        products2.Add(product4);

        Order order2 = new Order(customer2, products2);

        Console.WriteLine("---- ORDER 2 ----");
        Console.WriteLine("--- Packing Label ---");
        Console.WriteLine(order2.GetDisplayLabel());
        Console.WriteLine("--- Shipping Label ---");
        Console.WriteLine(order2.GetDisplayShipping());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}