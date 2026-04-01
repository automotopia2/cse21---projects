using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Apple", 101, 1.50, 3));
        order1.AddProduct(new Product("Bread", 102, 2.99, 2));
        order1.AddProduct(new Product("Milk", 103, 3.49, 1));

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Order 1 Total Price: ${order1.FinalPrice():F2}");

        Console.WriteLine("--------------------");

        Address address2 = new Address("456 Elm St", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Shoes", 201, 49.99, 1));
        order2.AddProduct(new Product("Socks", 202, 5.99, 3));

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Order 2 Total Price: ${order2.FinalPrice():F2}");
    }
}