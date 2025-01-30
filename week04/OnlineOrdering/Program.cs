using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // First order
        Product product1 = new Product("Monitor", 121, 400, 1);
        Product product2 = new Product("Keyboard", 122, 38, 2);
        Address address1 = new Address("Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Miles Metro", address1);

        List<Product> products1 = new List<Product>{product1,product2};
        Order order1 = new Order(products1, customer1);

        // Display results for Order1
        Console.WriteLine(order1.GetPackLabel());
        Console.WriteLine(order1.GetShipLabel());
        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice():0.00}\n"); // Format to two decimal!!

        // Second order
        Product product3 = new Product("Mouse", 123, 25, 3);
        Product product4 = new Product("Headphones", 124, 150, 1);
        Address address2 = new Address("Baker St", "London", "Greater London", "UK");
        Customer customer2 = new Customer("Sarah Lee", address2);

        List<Product> products2 = new List<Product>{product3,product4};
        Order order2 = new Order(products2, customer2);

        // Display results for Order1
        Console.WriteLine(order2.GetPackLabel());
        Console.WriteLine(order2.GetShipLabel());
        Console.WriteLine($"\nTotal Price: ${order2.GetTotalPrice():0.00}"); // Format to two decimal!!
    }
}